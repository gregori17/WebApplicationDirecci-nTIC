@ModelType WebApplicationDirecciónTIC.WebApplicationDirecciónTIC.Solicitud
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Solicitud</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NombreEstado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NombreEstado)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaCreación)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaCreación)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Persona.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Persona.Nombre)
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
