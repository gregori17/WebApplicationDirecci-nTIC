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
    Public Class EstadoesController
        Inherits System.Web.Mvc.Controller

        Private db As New WebApplicationDireccinTICEntities

        ' GET: Estadoes
        Function Index() As ActionResult
            Return View(db.Estados.ToList())
        End Function

        ' GET: Estadoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim estado As Estado = db.Estados.Find(id)
            If IsNothing(estado) Then
                Return HttpNotFound()
            End If
            Return View(estado)
        End Function

        ' GET: Estadoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Estadoes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Estado1")> ByVal estado As Estado) As ActionResult
            If ModelState.IsValid Then
                db.Estados.Add(estado)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(estado)
        End Function

        ' GET: Estadoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim estado As Estado = db.Estados.Find(id)
            If IsNothing(estado) Then
                Return HttpNotFound()
            End If
            Return View(estado)
        End Function

        ' POST: Estadoes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Estado1")> ByVal estado As Estado) As ActionResult
            If ModelState.IsValid Then
                db.Entry(estado).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(estado)
        End Function

        ' GET: Estadoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim estado As Estado = db.Estados.Find(id)
            If IsNothing(estado) Then
                Return HttpNotFound()
            End If
            Return View(estado)
        End Function

        ' POST: Estadoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim estado As Estado = db.Estados.Find(id)
            db.Estados.Remove(estado)
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
