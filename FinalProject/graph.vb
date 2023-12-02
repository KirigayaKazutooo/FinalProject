Imports MySql.Data.MySqlClient

Public Class graph

    Private Sub graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Call the method to populate the usage chart
        PopulateUsageChart()
    End Sub

    Private Sub PopulateUsageChart()
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim query As String = "SELECT username, access_count FROM usage_statistics"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Dim chartData As New DataTable()
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(chartData)

                ' Configure the chart control
                Chart1.DataSource = chartData

                ' Set the chart type to a bar chart
                Chart1.Series.Clear()
                Chart1.Series.Add("Usage")
                Chart1.Series("Usage").ChartType = DataVisualization.Charting.SeriesChartType.Bar

                ' Specify the data source fields
                Chart1.Series("Usage").XValueMember = "username"
                Chart1.Series("Usage").YValueMembers = "access_count"

                ' Display data labels
                Chart1.Series("Usage").IsValueShownAsLabel = True

                ' Set the axis labels
                Chart1.ChartAreas(0).AxisX.Title = "Students"
                Chart1.ChartAreas(0).AxisY.Title = "Usage Count"

                ' Refresh the chart control
                Chart1.DataBind()
            End Using
        End Using
    End Sub

    

End Class