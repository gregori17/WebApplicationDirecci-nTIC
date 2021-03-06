@ModelType IEnumerable(Of WebApplicationDirecciónTIC.WebApplicationDirecciónTIC.Solicitud)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.NombreEstado)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaCreación)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Persona.Nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NombreEstado)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FechaCreación)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Persona.Nombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
