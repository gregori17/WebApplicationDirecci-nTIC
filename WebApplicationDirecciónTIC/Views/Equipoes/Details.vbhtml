@ModelType WebApplicationDirecciónTIC.WebApplicationDirecciónTIC.Equipo
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Equipo</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaCreación)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaCreación)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Estado.Estado1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Estado.Estado1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Persona.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Persona.Nombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
