@ModelType MVC_EF_Intro.FootballSchedule
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>FootballSchedule</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Season)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Season)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Opponent)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Opponent)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IsHomeGame)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IsHomeGame)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
