@ModelType WebApplicationDirecciónTIC.WebApplicationDirecciónTIC.Persona
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Persona</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Apellido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Apellido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaNacimiento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaNacimiento)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Pasaporte)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Pasaporte)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sexo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sexo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Foto)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Foto)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
