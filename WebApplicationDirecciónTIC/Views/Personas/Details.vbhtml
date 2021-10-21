@ModelType WebApplicationDirecciónTIC.WebApplicationDirecciónTIC.Persona
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

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

            <img src="@Html.DisplayFor(Function(model) model.Foto)" height="102" width="102" />
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
