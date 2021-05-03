Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports MVC_EF_Intro

Namespace Controllers
    Public Class FootballSchedulesController
        Inherits System.Web.Mvc.Controller

        Private db As New DB_128040_practiceEntities

        ' GET: FootballSchedules
        Function Index() As ActionResult
            Return View(db.FootballSchedules.ToList())
        End Function

        ' GET: FootballSchedules/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim footballSchedule As FootballSchedule = db.FootballSchedules.Find(id)
            If IsNothing(footballSchedule) Then
                Return HttpNotFound()
            End If
            Return View(footballSchedule)
        End Function

        ' GET: FootballSchedules/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: FootballSchedules/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Season,Opponent,Date,IsHomeGame")> ByVal footballSchedule As FootballSchedule) As ActionResult
            If ModelState.IsValid Then
                db.FootballSchedules.Add(footballSchedule)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(footballSchedule)
        End Function

        ' GET: FootballSchedules/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim footballSchedule As FootballSchedule = db.FootballSchedules.Find(id)
            If IsNothing(footballSchedule) Then
                Return HttpNotFound()
            End If
            Return View(footballSchedule)
        End Function

        ' POST: FootballSchedules/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Season,Opponent,Date,IsHomeGame")> ByVal footballSchedule As FootballSchedule) As ActionResult
            If ModelState.IsValid Then
                db.Entry(footballSchedule).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(footballSchedule)
        End Function

        ' GET: FootballSchedules/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim footballSchedule As FootballSchedule = db.FootballSchedules.Find(id)
            If IsNothing(footballSchedule) Then
                Return HttpNotFound()
            End If
            Return View(footballSchedule)
        End Function

        ' POST: FootballSchedules/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim footballSchedule As FootballSchedule = db.FootballSchedules.Find(id)
            db.FootballSchedules.Remove(footballSchedule)
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
