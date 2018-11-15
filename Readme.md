<!-- default file list -->
*Files to look at*:

* **[CustomContainers.xml](./CS/XtraDiagram.CreateCustomContainers/CustomContainers.xml) (VB: [CustomContainers.xml](./VB/XtraDiagram.CreateCustomContainers/CustomContainers.xml))**
* [Form1.cs](./CS/XtraDiagram.CreateCustomContainers/Form1.cs) (VB: [Form1.vb](./VB/XtraDiagram.CreateCustomContainers/Form1.vb))
<!-- default file list end -->
# How to create custom diagram containers and register them in the toolbox and ribbon gallery


In this example, we show how to create containers with custom headers and padding. <br>DiagramControl supports a special language for defining containers. The root element that contains a container description is <em>ContainerShapeTemplate</em>. This element describes a container contour and may contain several segments

* <em>Start</em>. Specifies the start point
* <em>Line</em>. Defines a line with start and end points
* <em>Arc</em>. Defines an arc with start and end points<br><br>To define a container's header editor position, use the EditorBounds property. To specify a padding, set the ActualPadding property.<br>To register custom containers in the ribbon gallery, use the DiagramContainerGalleryRegistrator.RegisterContainerShapes method.

<br/>


