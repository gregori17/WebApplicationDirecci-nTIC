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
    Public Class SolicitudsController
        Inherits System.Web.Mvc.Controller

        Private db As New WebApplicationDireccinTICEntities

        ' GET: Solicituds
        Function Index() As ActionResult
            Return View(db.Solicituds.ToList())
        End Function

        ' GET: Solicituds/Details/5
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

        ' GET: Solicituds/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Solicituds/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,NombreEstado,FechaCreación")> ByVal solicitud As Solicitud) As ActionResult
            If ModelState.IsValid Then
                db.Solicituds.Add(solicitud)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(solicitud)
        End Function

        ' GET: Solicituds/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim solicitud As Solicitud = db.Solicituds.Find(id)
            If IsNothing(solicitud) Then
                Return HttpNotFound()
            End If
            Return View(solicitud)
        End Function

        ' POST: Solicituds/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,NombreEstado,FechaCreación")> ByVal solicitud As Solicitud) As ActionResult
            If ModelState.IsValid Then
                db.Entry(solicitud).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(solicitud)
        End Function

        ' GET: Solicituds/Delete/5
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

        ' POST: Solicituds/Delete/5
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
