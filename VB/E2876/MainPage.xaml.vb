﻿Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.DocumentServices.ServiceModel.Client
Imports DevExpress.Xpf.Printing
' ...

Namespace E2876
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			preview.Model = New ReportServicePreviewModel() With {.ReportName = "E2876.Web.SampleReport, E2876.Web", .ServiceClientFactory = New ReportServiceClientFactory("endpointConfiguration")}
		End Sub
	End Class
End Namespace
