Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Diagram.Core
Imports System.Reflection

Namespace XtraDiagram.CreateCustomContainers

    Public Partial Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Const MyContainersStencilName As String = "MyContainers"

        Private Shared ReadOnly containerDescriptions As ContainerShapeDescription()

        Shared Sub New()
            Using stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("XtraDiagram.CreateCustomContainers.CustomContainers.xml")
                containerDescriptions = ShapeDescriptions.LoadDescriptionsFromXml(stream).OfType(Of ContainerShapeDescription)().ToArray()
            End Using

            DiagramContainerGalleryRegistrator.RegisterContainerShapes(containerDescriptions)
        End Sub

        Public Sub New()
            InitializeComponent()
            Dim customContainersStencil = DiagramStencil.Create(MyContainersStencilName, "Custom Containers", containerDescriptions)
            diagramControl1.OptionsBehavior.Stencils = New DiagramStencilCollection(DiagramToolboxRegistrator.Stencils.Concat({customContainersStencil}))
            diagramControl1.SelectedStencils = New StencilCollection(MyContainersStencilName, BasicShapes.StencilId)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            diagramControl1.InitializeRibbon(ribbonControl1)
        End Sub
    End Class
End Namespace
