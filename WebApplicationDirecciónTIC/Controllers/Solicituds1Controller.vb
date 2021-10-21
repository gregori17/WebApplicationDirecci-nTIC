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
    Public Class Solicituds1Controller
        Inherits System.Web.Mvc.Controller

        Private db As New WebApplicationDireccinTICEntities

        ' GET: Solicituds1
        Function Index() As ActionResult
            Dim solicituds = db.Solicituds.Include(Function(s) s.Persona)
            Return View(solicituds.ToList())
        End Function

        ' GET: Solicituds1/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim solicitud As Solicitud = db.Solicituds.Find(id)
            If IsNothing(solicitud) Then
                Return HttpNotFound()
            End If
            Return View(solicitud)
        End Function

        ' GET: Solicituds1/Create
        Function Create() As ActionResult
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre")
            Return View()
        End Function

        ' POST: Solicituds1/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,NombreEstado,FechaCreación,PersonaId")> ByVal solicitud As Solicitud) As ActionResult
            If ModelState.IsValid Then
                db.Solicituds.Add(solicitud)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre", solicitud.PersonaId)
            Return View(solicitud)
        End Function

        ' GET: Solicituds1/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim solicitud As Solicitud = db.Solicituds.Find(id)
            If IsNothing(solicitud) Then
                Return HttpNotFound()
            End If
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre", solicitud.PersonaId)
            Return View(solicitud)
        End Function

        ' POST: Solicituds1/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,NombreEstado,FechaCreación,PersonaId")> ByVal solicitud As Solicitud) As ActionResult
            If ModelState.IsValid Then
                db.Entry(solicitud).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PersonaId = New SelectList(db.Personas, "Id", "Nombre", solicitud.PersonaId)
            Return View(solicitud)
        End Function

        ' GET: Solicituds1/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim solicitud As Solicitud = db.Solicituds.Find(id)
            If IsNothing(solicitud) Then
                Return HttpNotFound()
            End If
            Return View(solicitud)
        End Function

        ' POST: Solicituds1/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim solicitud As Solicitud = db.Solicituds.Find(id)
            db.Solicituds.Remove(solicitud)
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
