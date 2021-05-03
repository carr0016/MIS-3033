@ModelType MVC_EF_Intro.FootballSchedule
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
