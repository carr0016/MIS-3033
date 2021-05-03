@ModelType IEnumerable(Of MVC_EF_Intro.FootballSchedule)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Season)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Opponent)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IsHomeGame)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Season)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Opponent)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IsHomeGame)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
