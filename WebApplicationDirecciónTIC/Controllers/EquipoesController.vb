Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplicationDirecciónTIC.WebApplicationDirecciónTIC

Namespace Controllers
    Public Class EquipoesController
        Inherits System.Web.Mvc.Controller

        Private db As New WebApplicationDireccinTICEntities

        ' GET: Equipoes
        Function Index() As ActionResult
            Dim equipoes = db.Equipoes.Include(Function(e) e.Estado).Include(Function(e) e.Persona)
            Return View(equipoes.ToList())
        End Function

        ' GET: Equipoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim equipo As Equipo = db.Equipoes.Find(id)
            If IsNothing(equipo) Then
                Return HttpNotFound()
            End If
            Return View(equipo)
        End Function

        ' GET: Equipoes/Create
        Function Create() As ActionResult
            ViewBag.EstadoId = New SelectList(db.Estados, "Id", "Estado1")
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre")
            Return View()
        End Function

        ' POST: Equipoes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,PersonaId,EstadoId,FechaCreación")> ByVal equipo As Equipo) As ActionResult
            If ModelState.IsValid Then
                db.Equipoes.Add(equipo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EstadoId = New SelectList(db.Estados, "Id", "Estado1", equipo.EstadoId)
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre", equipo.PersonaId)
            Return View(equipo)
        End Function

        ' GET: Equipoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim equipo As Equipo = db.Equipoes.Find(id)
            If IsNothing(equipo) Then
                Return HttpNotFound()
            End If
            ViewBag.EstadoId = New SelectList(db.Estados, "Id", "Estado1", equipo.EstadoId)
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre", equipo.PersonaId)
            Return View(equipo)
        End Function

        ' POST: Equipoes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,PersonaId,EstadoId,FechaCreación")> ByVal equipo As Equipo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(equipo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EstadoId = New SelectList(db.Estados, "Id", "Estado1", equipo.EstadoId)
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre", equipo.PersonaId)
            Return View(equipo)
        End Function

        ' GET: Equipoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim equipo As Equipo = db.Equipoes.Find(id)
            If IsNothing(equipo) Then
                Return HttpNotFound()
            End If
            Return View(equipo)
        End Function

        ' POST: Equipoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim equipo As Equipo = db.Equipoes.Find(id)
            db.Equipoes.Remove(equipo)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
