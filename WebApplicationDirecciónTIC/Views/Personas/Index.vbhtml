@ModelType IEnumerable(Of WebApplicationDirecciónTIC.WebApplicationDirecciónTIC.Persona)
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
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellido)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaNacimiento)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Pasaporte)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sexo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Foto)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Nombre)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Apellido)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.FechaNacimiento)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Pasaporte)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Direccion)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Sexo)
    </td>
    <td>
        <img src="@Html.DisplayFor(Function(modelItem) item.Foto)" height="52" width="52" />
        
    </td>

    @*<td>
        @Html.DisplayFor(Function(modelItem) item.Foto)
    </td>*@
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
    </td>
</tr>
Next

</table>
