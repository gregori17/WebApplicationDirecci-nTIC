Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mime.MediaTypeNames
Imports System.Web
Imports System.Web.Mvc
Imports WebApplicationDirecciónTIC.WebApplicationDirecciónTIC

Namespace Controllers
    Public Class PersonasController
        Inherits System.Web.Mvc.Controller

        Private db As New WebApplicationDireccinTICEntities

        ' GET: Personas
        Function Index() As ActionResult
            Return View(db.Personas.ToList())
        End Function

        ' GET: Personas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim persona As Persona = db.Personas.Find(id)
            If IsNothing(persona) Then
                Return HttpNotFound()
            End If
            Return View(persona)
        End Function

        ' GET: Personas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Personas/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Nombre,Apellido,FechaNacimiento,Pasaporte,Direccion,Sexo,Foto")> ByVal persona As Persona, ByVal upload As HttpPostedFileBase) As ActionResult
            If ModelState.IsValid Then
                If Not upload Is Nothing Then
                    If upload.ContentLength > 0 Then
                        Dim ruta As String = upload.FileName

                        Dim fs As System.IO.Stream = upload.InputStream
                        Dim br As New System.IO.BinaryReader(fs)
                        Dim bytes As Byte() = br.ReadBytes(CType(fs.Length, Integer))
                        Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                        ruta = "data:image/png;base64," & base64String

                        persona.Foto = ruta
                    End If
                End If
                db.Personas.Add(persona)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(persona)
        End Function



        ' GET: Personas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim persona As Persona = db.Personas.Find(id)
            If IsNothing(persona) Then
                Return HttpNotFound()
            End If
            Return View(persona)
        End Function

        ' POST: Personas/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Nombre,Apellido,FechaNacimiento,Pasaporte,Direccion,Sexo,Foto")> ByVal persona As Persona, ByVal upload As HttpPostedFileBase) As ActionResult
            If ModelState.IsValid Then
                If Not upload Is Nothing Then
                    If upload.ContentLength > 0 Then
                        Dim ruta As String = upload.FileName

                        Dim fs As System.IO.Stream = upload.InputStream
                        Dim br As New System.IO.BinaryReader(fs)
                        Dim bytes As Byte() = br.ReadBytes(CType(fs.Length, Integer))
                        Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                        ruta = "data:image/png;base64," & base64String

                        persona.Foto = ruta
                    End If
                End If
                db.Entry(persona).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(persona)
        End Function

        ' GET: Personas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim persona As Persona = db.Personas.Find(id)
            If IsNothing(persona) Then
                Return HttpNotFound()
            End If
            Return View(persona)
        End Function

        ' POST: Personas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim persona As Persona = db.Personas.Find(id)
            db.Personas.Remove(persona)
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
