Public Class Pie_Chart
    Private SQL As New SQLControl
    Dim selected As String
    Private Sub Pie_Chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData("")
        loadDataU("")
        loadDataP("")
    End Sub

    Private Sub loadData(ByVal jemaat As String)
        Chart1.DataSource = getData(jemaat)
        Chart1.Series("Series1").XValueMember = "NAMA_PKRJN"
        Chart1.Series("Series1").YValueMembers = "Persentase"
    End Sub

    Private Function getData(ByVal jemaat As String)
        Dim dtChartData As New DataTable
        If SQL.HasConnection = True Then
            SQL.AddParam("@jemaat", "%" & jemaat & "%")
            SQL.ExecQuery("SELECT COUNT(ID_JEMAAT) * 1.0 / (SELECT COUNT(*) FROM JEMAAT WHERE ID_GEREJA like @jemaat) as Persentase ,NAMA_PKRJN FROM JEMAAT,PEKERJAAN WHERE PEKERJAAN.ID_PEKERJAAN = JEMAAT.ID_PEKERJAAN and ID_GEREJA like @jemaat GROUP BY NAMA_PKRJN")
            SQL.SQLDA.Fill(dtChartData)
        End If
        Return dtChartData
    End Function

    Private Sub loadDataU(ByVal jemaat As String)
        Chart2.DataSource = getDataU(jemaat)
        Chart2.Series("Series1").XValueMember = "age_range"
        Chart2.Series("Series1").YValueMembers = "count"
    End Sub

    Private Function getDataU(ByVal jemaat As String)
        Dim dtChartData As New DataTable
        If SQL.HasConnection = True Then
            SQL.AddParam("@jemaat", "%" & jemaat & "%")
            SQL.ExecQuery("SELECT CASE " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) < 30 THEN 'Under 30' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 30 AND 35 THEN '30-35' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 36 AND 40 THEN '36-40' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 41 AND 45 THEN '41-45' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 46 AND 50 THEN '46-50' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 51 AND 55 THEN '51-55' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 56 AND 60 THEN '56-60' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) > 60 THEN 'Above 60' " &
                            "end as age_range, " &
                             "Count(*) * 1.0 / (SELECT COUNT(*) FROM JEMAAT where ID_GEREJA like @jemaat) as count " &
                             "from jemaat where ID_GEREJA like @jemaat" &
                            " group by case " &
                             "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) < 30 THEN 'Under 30' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 30 AND 35 THEN '30-35' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 36 AND 40 THEN '36-40' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 41 AND 45 THEN '41-45' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 46 AND 50 THEN '46-50' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 51 AND 55 THEN '51-55' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) BETWEEN 56 AND 60 THEN '56-60' " &
                            "WHEN DATEDIFF(year,tgl_lhr,CONVERT(date,getdate())) > 60 THEN 'Above 60' " &
                            "end " &
                             "order by age_range")
            SQL.SQLDA.Fill(dtChartData)
        End If
        Return dtChartData
    End Function

    Private Sub loadDataP(ByVal jemaat As String)
        Chart3.DataSource = getDataP(jemaat)
        Chart3.Series("Series1").XValueMember = "PDDK_AKHR"
        Chart3.Series("Series1").YValueMembers = "Persentase"
    End Sub

    Private Function getDataP(ByVal jemaat As String)
        Dim dtChartData As New DataTable
        If SQL.HasConnection = True Then
            SQL.AddParam("@jemaat", "%" & jemaat & "%")
            SQL.ExecQuery("SELECT COUNT(ID_JEMAAT) * 1.0 / (SELECT COUNT(*) FROM JEMAAT Where ID_GEREJA like @jemaat) as Persentase ,PDDK_AKHR " &
                            "FROM JEMAAT,PENDIDIKAN " &
                            "WHERE PENDIDIKAN.ID_PDDK = JEMAAT.ID_PDDK and ID_GEREJA like @jemaat " &
                            "GROUP BY PDDK_AKHR")
            SQL.SQLDA.Fill(dtChartData)
        End If
        Return dtChartData
    End Function

    Private Sub rbKanaan_CheckedChanged(sender As Object, e As EventArgs) Handles rbKanaan.CheckedChanged
        clearChart()
        loadData("G04")
        loadDataU("G04")
        loadDataP("G04")
    End Sub

    Private Sub rbBukit_CheckedChanged(sender As Object, e As EventArgs) Handles rbBukit.CheckedChanged
        clearChart()
        loadData("G02")
        loadDataU("G02")
        loadDataP("G02")
    End Sub

    Private Sub rbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAll.CheckedChanged
        clearChart()
        loadData("")
        loadDataU("")
        loadDataP("")
    End Sub

    Private Sub clearChart()
        Chart1.Series("Series1").Points.Clear()
        Chart2.Series("Series1").Points.Clear()
        Chart3.Series("Series1").Points.Clear()
    End Sub

    Private Sub rbEfrata_CheckedChanged(sender As Object, e As EventArgs) Handles rbEfrata.CheckedChanged
        clearChart()
        loadData("G03")
        loadDataU("G03")
        loadDataP("G03")
    End Sub

    Private Sub rbImanuel_CheckedChanged(sender As Object, e As EventArgs) Handles rbImanuel.CheckedChanged
        clearChart()
        loadData("G01")
        loadDataU("G01")
        loadDataP("G01")
    End Sub

    Private Sub rbEben_CheckedChanged(sender As Object, e As EventArgs) Handles rbEben.CheckedChanged
        clearChart()
        loadData("G06")
        loadDataU("G06")
        loadDataP("G06")
    End Sub

    Private Sub rbSion_CheckedChanged(sender As Object, e As EventArgs) Handles rbSion.CheckedChanged
        clearChart()
        loadData("G05")
        loadDataU("G05")
        loadDataP("G05")
    End Sub

    Private Sub rbArarat_CheckedChanged(sender As Object, e As EventArgs) Handles rbArarat.CheckedChanged
        clearChart()
        loadData("G07")
        loadDataU("G07")
        loadDataP("G07")
    End Sub
End Class