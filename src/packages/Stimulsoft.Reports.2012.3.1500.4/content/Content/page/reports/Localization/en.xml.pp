﻿<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<Localization language="English" description="English" cultureName="en">
  <SystemVariables>
	<Column>Returns the current column number (starts from 1).</Column>
	<GroupLine>Returns the current group line number (starts from 1).</GroupLine>
	<Line>Returns the current line number (starts from 1).</Line>
	<LineThrough>Returns the current line number (starts from 1). When calculating the number, all groupings are ignored and numbering starts from the beginning of printing.</LineThrough>
	<LineABC>Returns the alphabetical analogue of the current line number.</LineABC>
	<LineRoman>Returns the current line number in Roman numerals.</LineRoman>
	<PageNumber>Returns the current page number (starts from 1).</PageNumber>
	<PageNumberThrough>Returns the current page number (starts from 1). When calculating the PageNumberThrough, all properties ResetPageNumber are ignored and numbering starts from the beginning of a report.</PageNumberThrough>
	<PageNofM>Returns a localized string, showing "Page N of M" where N is the current page number and M is the TotalPageCount of a report.</PageNofM>
	<PageNofMThrough>Returns a localized string, showing "Page N of M" where N is the current page number and M is the TotalPageCount of a report. When calculating the PageNofMThrough, all properties ResetPageNumber are ignored and numbering starts from the beginning of a report.</PageNofMThrough>
	<TotalPageCount>Returns the number of pages in a report.</TotalPageCount>
	<TotalPageCountThrough>Returns the number of pages in a report. When calculating the TotalPageCountThrough, all properties ResetPageNumber are ignored and numbering starts from the beginning of report.</TotalPageCountThrough>
	<IsFirstPage>Returns true, if, in the current moment, the first page of a report is printed.</IsFirstPage>
	<IsFirstPageThrough>Returns true, if, in the current moment, the first page of a report is printed. When calculating the IsFirstPageThrough, all ResetPageNumber properties are ignored and numbering starts from the beginning of report. For correct calculation of a variable it is required to execute two passes.</IsFirstPageThrough>
	<IsLastPage>Returns true, if, in the current moment, the last page of a report is printed. For correct calculation of a variable it is required to execute two passes.</IsLastPage>
	<IsLastPageThrough>Returns true, if, in the current moment, the last page of a report is printed. When calculating the IsLastPageThrough, all properties ResetPageNumber are ignored and numbering starts from the beginning of report. For correct calculation of a variable it is required to execute two passes.</IsLastPageThrough>
	<ReportAlias>Returns the alias of a report. You can change the ReportAlias with help of the ReportAlias property of a report.</ReportAlias>
	<ReportAuthor>Returns the author of a report. You can change ReportAuthor with help of the ReportAuthor property of a report.</ReportAuthor>
	<ReportChanged>The Date when a report was changed.</ReportChanged>
	<ReportCreated>The Date when a report was created.</ReportCreated>
	<ReportDescription>Returns the description of a report. You can change the ReportName with help of the ReportDescription property of a report.</ReportDescription>
	<ReportName>Returns the name of a report. You can change the ReportName with help of the ReportName property of a report.</ReportName>
	<Time>Returns the current time.</Time>
	<Today>Returns the current date.</Today>
  </SystemVariables>
  <A_WebViewer>
    <DayFriday>Friday</DayFriday>
    <DayMonday>Monday</DayMonday>
    <DaySaturday>Saturday</DaySaturday>
    <DaySunday>Sunday</DaySunday>
    <DayThursday>Thursday</DayThursday>
    <DayTuesday>Tuesday</DayTuesday>
    <DayWednesday>Wednesday</DayWednesday>
    <FirstPage>First Page</FirstPage>
    <LastPage>Last Page</LastPage>
    <Loading>Loading...</Loading>
    <MonthApril>April</MonthApril>
    <MonthAugust>August</MonthAugust>
    <MonthDecember>December</MonthDecember>
    <MonthFebruary>February</MonthFebruary>
    <MonthJanuary>January</MonthJanuary>
    <MonthJuly>July</MonthJuly>
    <MonthJune>June</MonthJune>
    <MonthMarch>March</MonthMarch>
    <MonthMay>May</MonthMay>
    <MonthNovember>November</MonthNovember>
    <MonthOctober>October</MonthOctober>
    <MonthSeptember>September</MonthSeptember>
    <NextPage>Next Page</NextPage>
    <OnePage>One Page</OnePage>
    <Page>Page</Page>
    <PageOf>of</PageOf>
    <PreviousPage>Previous Page</PreviousPage>
    <PrintContinue>Click Print to continue</PrintContinue>
    <PrintReport>Print</PrintReport>
    <PrintToPdf>Print to PDF</PrintToPdf>
    <PrintToXps>Print to XPS</PrintToXps>
    <PrintWithoutPreview>Print without Preview</PrintWithoutPreview>
    <PrintWithPreview>Print with Preview</PrintWithPreview>
    <SaveReport>Save</SaveReport>
    <TodayDate>Today</TodayDate>
    <WholeReport>Whole Report</WholeReport>
  </A_WebViewer>
  <Adapters>
    <AdapterBusinessObjects>Data from Business Objects</AdapterBusinessObjects>
    <AdapterConnection>Data from {0}</AdapterConnection>
    <AdapterCrossTabDataSource>Data from CrossTab</AdapterCrossTabDataSource>
    <AdapterCsvFiles>Data from Csv Files</AdapterCsvFiles>
    <AdapterDataTables>Data from DataSet, DataTables</AdapterDataTables>
    <AdapterDataViews>Data from DataViews</AdapterDataViews>
    <AdapterDB2Connection>Data from IBM DB2 Connection</AdapterDB2Connection>
    <AdapterDBaseFiles>Data from dBase Files</AdapterDBaseFiles>
    <AdapterFirebirdConnection>Data from Firebird Connection</AdapterFirebirdConnection>
    <AdapterInformixConnection>Data from Informix Connection</AdapterInformixConnection>
    <AdapterMySQLConnection>Data from MySQL Connection</AdapterMySQLConnection>
    <AdapterTeradataConnection>Data from Teradata Connection</AdapterTeradataConnection>
    <AdapterOdbcConnection>Data from Odbc Connection</AdapterOdbcConnection>
    <AdapterOleDbConnection>Data from OleDb Connection</AdapterOleDbConnection>
    <AdapterOracleConnection>Data from Oracle Connection</AdapterOracleConnection>
    <AdapterOracleODPConnection>Data from Oracle ODP.NET Connection</AdapterOracleODPConnection>
    <AdapterPostgreSQLConnection>Data from PostgreSQL Connection</AdapterPostgreSQLConnection>
    <AdapterSqlCeConnection>Data from SqlCe Connection</AdapterSqlCeConnection>
    <AdapterSqlConnection>Data from Sql Connection</AdapterSqlConnection>
    <AdapterSQLiteConnection>Data from SQLite Connection</AdapterSQLiteConnection>
    <AdapterUniDirectConnection>Data from Uni Direct Connection</AdapterUniDirectConnection>
    <AdapterUserSources>Data from User Sources</AdapterUserSources>
    <AdapterVirtualSource>Data from other Data Source</AdapterVirtualSource>
    <AdapterVistaDBConnection>Data from VistaDB Connection</AdapterVistaDBConnection>
  </Adapters>
  <Buttons>
    <Add>Add</Add>
    <AddAllColumns>Add All Columns</AddAllColumns>
    <Build>Build...</Build>
    <Cancel>&amp;Cancel</Cancel>
    <Close>Close</Close>
    <Delete>Delete</Delete>
    <Design>Design</Design>
    <Down>Down</Down>
    <Duplicate>Duplicate</Duplicate>
    <Export>Export</Export>
    <Help>Help</Help>
    <MoveLeft>Move Left</MoveLeft>
    <MoveRight>Move Right</MoveRight>
    <No>&amp;No</No>
    <Ok>&amp;OK</Ok>
    <Open>Open</Open>
    <Print>Print</Print>
    <QuickPrint>Quick Print</QuickPrint>
    <Remove>Remove</Remove>
    <RemoveAll>Remove All</RemoveAll>
    <Rename>Rename</Rename>
    <RestoreDefaults>Restore Defaults</RestoreDefaults>
    <Reverse>Reverse</Reverse>
    <Save>Save</Save>
    <SaveCopy>Save a Copy</SaveCopy>
    <SetAll>Set All</SetAll>
    <Submit>Submit</Submit>
    <Test>Test</Test>
    <Up>Up</Up>
    <Yes>&amp;Yes</Yes>
  </Buttons>
  <Chart>
    <AddCondition>&amp;Add Condition</AddCondition>
    <AddConstantLine>Add Constant Line</AddConstantLine>
    <AddFilter>&amp;Add Filter</AddFilter>
    <AddSeries>&amp;Add Series</AddSeries>
    <AddStrip>Add Strip</AddStrip>
    <Area>Area</Area>
    <Axes>Axes</Axes>
    <AxisReverse>Reverse</AxisReverse>
    <AxisX>Axis X</AxisX>
    <AxisY>Axis Y</AxisY>
    <Bubble>Bubble</Bubble>
    <Candlestick>Candlestick</Candlestick>
    <ChartConditionsCollectionForm>Conditions</ChartConditionsCollectionForm>
    <ChartFiltersCollectionForm>Filters</ChartFiltersCollectionForm>
    <ChartType>Chart Type</ChartType>
    <CheckBoxAutoRotation>Auto Rotation</CheckBoxAutoRotation>
    <ClusteredBar>Clustered Bar</ClusteredBar>
    <ClusteredColumn>Clustered Column</ClusteredColumn>
    <ConstantLine>Constant Line</ConstantLine>
    <ConstantLinesEditorForm>Constant Lines Editor</ConstantLinesEditorForm>
    <DataColumns>Data Columns</DataColumns>
    <Doughnut>Doughnut</Doughnut>
    <Financial>Financial</Financial>
    <FullStackedArea>Full-Stacked Area</FullStackedArea>
    <FullStackedBar>Full-Stacked Bar</FullStackedBar>
    <FullStackedColumn>Full-Stacked Column</FullStackedColumn>
    <FullStackedLine>Full-Stacked Line</FullStackedLine>
    <FullStackedSpline>Full-Stacked Spline</FullStackedSpline>
    <FullStackedSplineArea>Full-Stacked Spline Area</FullStackedSplineArea>
    <Funnel>Funnel</Funnel>
    <Gantt>Gantt</Gantt>
    <GridInterlaced>Interlaced</GridInterlaced>
    <GridLines>Grid Lines</GridLines>
    <LabelAlignment>Alignment:</LabelAlignment>
    <LabelAlignmentHorizontal>Horizontal:</LabelAlignmentHorizontal>
    <LabelAlignmentVertical>Vertical:</LabelAlignmentVertical>
    <LabelAngle>Angle:</LabelAngle>
    <LabelArgumentDataColumn>Argument Data Column:</LabelArgumentDataColumn>
    <LabelAutoRotation>Auto Rotation:</LabelAutoRotation>
    <LabelHorizontal>Horizontal:</LabelHorizontal>
    <LabelMinorCount>Minor Count:</LabelMinorCount>
    <Labels>Labels</Labels>
    <LabelsCenter>Center</LabelsCenter>
    <LabelSeriesName>Series Name:</LabelSeriesName>
    <LabelsInside>Inside</LabelsInside>
    <LabelsInsideBase>Inside Base</LabelsInsideBase>
    <LabelsInsideEnd>Inside End</LabelsInsideEnd>
    <LabelsNone>None</LabelsNone>
    <LabelsOutside>Outside</LabelsOutside>
    <LabelsOutsideBase>Outside Base</LabelsOutsideBase>
    <LabelsOutsideEnd>Outside End</LabelsOutsideEnd>
    <LabelsTwoColumns>Two Columns</LabelsTwoColumns>
    <LabelTextAfter>Text After:</LabelTextAfter>
    <LabelTextBefore>Text Before:</LabelTextBefore>
    <LabelTitleAlignment>Alignment:</LabelTitleAlignment>
    <LabelValueDataColumn>Value Data Column:</LabelValueDataColumn>
    <LabelEndValueDataColumn>End Value Data Column:</LabelEndValueDataColumn>
    <LabelOpenValueDataColumn>Open Value Data Column:</LabelOpenValueDataColumn>
    <LabelCloseValueDataColumn>Close Value Data Column:</LabelCloseValueDataColumn>
    <LabelHighValueDataColumn>High Value Data Column:</LabelHighValueDataColumn>
    <LabelLowValueDataColumn>Low Value Data Column:</LabelLowValueDataColumn>

    <LabelValueType>Value Type:</LabelValueType>
    <LabelVertical>Vertical:</LabelVertical>
    <LabelVisible>Visible:</LabelVisible>
    <Legend>Legend</Legend>
    <LegendSpacing>Spacing</LegendSpacing>
    <Line>Line</Line>
    <ListOfValues>List of Columns</ListOfValues>
    <Marker>Marker</Marker>
    <MoveConstantLineDown>Move Constant Line Down</MoveConstantLineDown>
    <MoveConstantLineUp>Move Constant Line Up</MoveConstantLineUp>
    <MoveSeriesDown>Move Series Down</MoveSeriesDown>
    <MoveSeriesUp>Move Series Up</MoveSeriesUp>
    <MoveStripDown>Move Strip Down</MoveStripDown>
    <MoveStripUp>Move Strip Up</MoveStripUp>
    <NoConditions>No Conditions</NoConditions>
    <NoFilters>No Filters</NoFilters>
    <Pie>Pie</Pie>
    <Radar>Radar</Radar>
    <RadarArea>Radar Area</RadarArea>
    <RadarLine>Radar Line</RadarLine>
    <RadarPoint>Radar Point</RadarPoint>
    <Range>Range</Range>
    <RangeBar>Range Bar</RangeBar>
    <RemoveCondition>&amp;Remove Condition</RemoveCondition>
    <RemoveConstantLine>Remove Constant Line</RemoveConstantLine>
    <RemoveFilter>&amp;Remove Filter</RemoveFilter>
    <RemoveSeries>&amp;Remove Series</RemoveSeries>
    <RemoveStrip>Remove Strip</RemoveStrip>
    <RunChartWizard>Run Chart &amp;Wizard</RunChartWizard>
    <Scatter>Scatter</Scatter>
    <ScatterLine>Scatter Line</ScatterLine>
    <ScatterSpline>Scatter Spline</ScatterSpline>
    <Series>Series</Series>
    <SeriesColorsCollectionForm>Series Colors</SeriesColorsCollectionForm>
    <SeriesEditorForm>Series Editor</SeriesEditorForm>
    <Serieses>Series</Serieses>
    <Spline>Spline</Spline>
    <SplineRange>Spline Range</SplineRange>
    <SplineArea>Spline Area</SplineArea>
    <StackedArea>Stacked Area</StackedArea>
    <StackedBar>Stacked Bar</StackedBar>
    <StackedColumn>Stacked Column</StackedColumn>
    <StackedLine>Stacked Line</StackedLine>
    <StackedSpline>Stacked Spline</StackedSpline>
    <StackedSplineArea>Stacked Spline Area</StackedSplineArea>
    <SteppedArea>Stepped Area</SteppedArea>
    <SteppedLine>Stepped Line</SteppedLine>
    <SteppedRange>Stepped Range</SteppedRange>
    <Stock>Stock</Stock>
    <Strip>Strip</Strip>
    <StripsEditorForm>Strips Editor Form</StripsEditorForm>
    <Style>Style</Style>
  </Chart>
  <ChartRibbon>
    <Axes>Axes</Axes>
    <AxesArrowStyle>Arrow Style</AxesArrowStyle>
    <AxesArrowStyleLines>Lines</AxesArrowStyleLines>
    <AxesArrowStyleNone>None</AxesArrowStyleNone>
    <AxesArrowStyleTriangle>Triangle</AxesArrowStyleTriangle>
    <AxesLabel>Label Placement</AxesLabel>
    <AxesLabelsNone>None</AxesLabelsNone>
    <AxesLabelsOneLine>One Line</AxesLabelsOneLine>
    <AxesLabelsTwoLines>Two Lines</AxesLabelsTwoLines>
    <AxesReverseHorizontal>Reverse Horizontal</AxesReverseHorizontal>
    <AxesReverseVertical>Reverse Vertical</AxesReverseVertical>
    <AxesTicks>Ticks</AxesTicks>
    <AxesTicksMajor>Major</AxesTicksMajor>
    <AxesTicksMinor>Minor</AxesTicksMinor>
    <AxesTicksNone>None</AxesTicksNone>
    <AxesVisible>Visible</AxesVisible>
    <AxesXAxis>X Axis</AxesXAxis>
    <AxesXTopAxis>X Top Axis</AxesXTopAxis>
    <AxesYAxis>Y Axis</AxesYAxis>
    <AxesYRightAxis>Y Right Axis</AxesYRightAxis>
    <CenterLabels>Center</CenterLabels>
    <ChangeType>Change Type</ChangeType>
    <GridLines>Grid Lines</GridLines>
    <GridLinesHorizontal>Grid Lines Horizontal</GridLinesHorizontal>
    <GridLinesVertical>Grid Lines Vertical</GridLinesVertical>
    <HorAlCenter>&lt;b&gt;Overlay Legend at Center&lt;/b&gt;&lt;br&gt;Show Legend at center of the chart&lt;/br&gt;&lt;br&gt;without resizing&lt;/br&gt;</HorAlCenter>
    <HorAlLeft>&lt;b&gt;Overlay Legend at Left&lt;/b&gt;&lt;br&gt;Show Legend at left of the chart&lt;/br&gt;&lt;br&gt;without resizing&lt;/br&gt;</HorAlLeft>
    <HorAlLeftOutside>&lt;b&gt;Show Legend at Left&lt;/b&gt;&lt;br&gt;Show Legend and align left&lt;/br&gt;</HorAlLeftOutside>
    <HorAlRight>&lt;b&gt;Overlay Legend at Right&lt;/b&gt;&lt;br&gt;Show Legend at right of the chart&lt;/br&gt;&lt;br&gt;without resizing&lt;/br&gt;</HorAlRight>
    <HorAlRightOutside>&lt;b&gt;Show Legend at Right&lt;/b&gt;&lt;br&gt;Show Legend and align right&lt;/br&gt;</HorAlRightOutside>
    <HorizontalMajor>&lt;b&gt;Major&lt;/b&gt;&lt;br&gt;Display Horizontal Gridlines for Major units&lt;/br&gt;</HorizontalMajor>
    <HorizontalMajorMinor>&lt;b&gt;Major &amp;&amp; Minor Gridlines&lt;/b&gt;&lt;br&gt;Display Horizontal Gridlines for Major and Minor units&lt;/br&gt;</HorizontalMajorMinor>
    <HorizontalMinor>&lt;b&gt;Minor&lt;/b&gt;&lt;br&gt;Display Horizontal Gridlines for Minor units&lt;/br&gt;</HorizontalMinor>
    <HorizontalNone>&lt;b&gt;None&lt;/b&gt;&lt;br&gt;Do not display Horizontal Grirdlines&lt;/br&gt;</HorizontalNone>
    <InsideBaseLabels>Inside Base</InsideBaseLabels>
    <InsideEndLabels>Inside End</InsideEndLabels>
    <Labels>Series Labels</Labels>
    <Legend>Legend</Legend>
    <LegendHorizontalAlignment>Horizontal Alignment</LegendHorizontalAlignment>
    <LegendMarker>Marker</LegendMarker>
    <LegendMarkerAlignmentLeft>Left</LegendMarkerAlignmentLeft>
    <LegendMarkerAlignmentRight>Right</LegendMarkerAlignmentRight>
    <LegendMarkerVisible>Visible</LegendMarkerVisible>
    <LegendVerticalAlignment>Vertical Alignment</LegendVerticalAlignment>
    <LegendVisible>Visible</LegendVisible>
    <NoneLabels>None</NoneLabels>
    <OutsideBaseLabels>Outside Base</OutsideBaseLabels>
    <OutsideEndLabels>Outside End</OutsideEndLabels>
    <OutsideLabels>Outside</OutsideLabels>
    <ribbonBarAxis>Axes</ribbonBarAxis>
    <ribbonBarChartStyles>Chart Styles</ribbonBarChartStyles>
    <ribbonBarChartType>Chart Type</ribbonBarChartType>
    <ribbonBarLabels>Labels</ribbonBarLabels>
    <ribbonBarLegend>Legend</ribbonBarLegend>
    <Style>Change Style</Style>
    <TwoColumnsPieLabels>Two Columns</TwoColumnsPieLabels>
    <VertAlBottom>&lt;b&gt;Overlay Legend at Bottom&lt;/b&gt;&lt;br&gt;Show Legend at bottom of the chart&lt;/br&gt;&lt;br&gt;without resizing&lt;/br&gt;</VertAlBottom>
    <VertAlBottomOutside>&lt;b&gt;Show Legend at Bottom&lt;/b&gt;&lt;br&gt;Show Legend and align bottom&lt;/br&gt;</VertAlBottomOutside>
    <VertAlCenter>&lt;b&gt;Overlay Legend at Center&lt;/b&gt;&lt;br&gt;Show Legend at center of the chart&lt;/br&gt;&lt;br&gt;without resizing&lt;/br&gt;</VertAlCenter>
    <VertAlTop>&lt;b&gt;Overlay Legend at Top&lt;/b&gt;&lt;br&gt;Show Legend at top of the chart&lt;/br&gt;&lt;br&gt;without resizing&lt;/br&gt;</VertAlTop>
    <VertAlTopOutside>&lt;b&gt;Show Legend at Top&lt;/b&gt;&lt;br&gt;Show Legend and align top&lt;/br&gt;</VertAlTopOutside>
    <VerticalMajor>&lt;b&gt;Major&lt;/b&gt;&lt;br&gt;Display Vertical Gridlines for Major units&lt;/br&gt;</VerticalMajor>
    <VerticalMajorMinor>&lt;b&gt;Major &amp;&amp; Minor Gridlines&lt;/b&gt;&lt;br&gt;Display Vertical Gridlines for Major and Minor units&lt;/br&gt;</VerticalMajorMinor>
    <VerticalMinor>&lt;b&gt;Minor&lt;/b&gt;&lt;br&gt;Display Vertical Gridlines for Minor units&lt;/br&gt;</VerticalMinor>
    <VerticalNone>&lt;b&gt;None&lt;/b&gt;&lt;br&gt;Do not display Vertical Gridlines&lt;/br&gt;</VerticalNone>
  </ChartRibbon>
  <Cloud>
    <AccountSettings>Account Settings</AccountSettings>
    <Cancel>Cancel</Cancel>
    <Collection>Collection</Collection>
    <Create>Create</Create>
    <CreateNewCollection>Create New Collection</CreateNewCollection>
    <DeleteFile>Delete File</DeleteFile>
    <labelCollectionName>Collection Name:</labelCollectionName>
    <labelFileName>File Name:</labelFileName>
    <labelPassword>Password:</labelPassword>
    <labelUserName>User Name:</labelUserName>
    <Login>Login</Login>
    <Open>Open</Open>
    <OpenFile>Open File</OpenFile>
    <OperationCreate>Create '{0}'</OperationCreate>
    <OperationDelete>Delete '{0}' from Server</OperationDelete>
    <OperationDownload>Download from Server</OperationDownload>
    <OperationGetList>Get List of Files from Server</OperationGetList>
    <OperationLogin>Login to Server</OperationLogin>
    <OperationRename>Rename '{0}' to '{1}'</OperationRename>
    <OperationUpload>Upload '{0}' to Server</OperationUpload>
    <page>page</page>
    <questionOpenThisFile>Are you sure want to open '{0}' item?</questionOpenThisFile>
    <questionOverrideItem>Do you really want override '{0}' item?</questionOverrideItem>
    <questionRemoveItem>Do you really want remove '{0}' item?</questionRemoveItem>
    <RefreshList>Refresh List</RefreshList>
    <ReportDocumentFormatNotRecognized>Format of '{0}' item is not recognized as rendered report format!</ReportDocumentFormatNotRecognized>
    <ReportTemplateFormatNotRecognized>Format of '{0}' item is not recognized as report template format!</ReportTemplateFormatNotRecognized>
    <Root>Root</Root>
    <Save>Save</Save>
    <SaveAccountSettings>Save Account Settings</SaveAccountSettings>
    <SaveFile>Save File</SaveFile>
    <ShowAllFiles>Show All Files</ShowAllFiles>
  </Cloud>
  <Components>
    <StiBarCode>Bar Code</StiBarCode>
    <StiChart>Chart</StiChart>
    <StiCheckBox>Check Box</StiCheckBox>
    <StiChildBand>Child</StiChildBand>
    <StiClone>Clone</StiClone>
    <StiColumnFooterBand>Column Footer</StiColumnFooterBand>
    <StiColumnHeaderBand>Column Header</StiColumnHeaderBand>
    <StiComponent>Component</StiComponent>
    <StiContainer>Container</StiContainer>
    <StiContourText>Contour Text</StiContourText>
    <StiCrossColumn>Cross-Column</StiCrossColumn>
    <StiCrossColumnTotal>Cross-Column Total</StiCrossColumnTotal>
    <StiCrossDataBand>Cross-Data</StiCrossDataBand>
    <StiCrossFooterBand>Cross-Footer</StiCrossFooterBand>
    <StiCrossGroupFooterBand>Cross-Group Footer</StiCrossGroupFooterBand>
    <StiCrossGroupHeaderBand>Cross-Group Header</StiCrossGroupHeaderBand>
    <StiCrossHeaderBand>Cross-Header</StiCrossHeaderBand>
    <StiCrossRow>Cross-Row</StiCrossRow>
    <StiCrossRowTotal>Cross-Row Total</StiCrossRowTotal>
    <StiCrossSummary>Cross-Summary</StiCrossSummary>
    <StiCrossSummaryHeader>Cross-Summary Header</StiCrossSummaryHeader>
    <StiCrossTab>Cross-Tab</StiCrossTab>
    <StiDataBand>Data</StiDataBand>
    <StiEmptyBand>Empty Data</StiEmptyBand>
    <StiFooterBand>Footer</StiFooterBand>
    <StiGauge>Gauge</StiGauge>
    <StiGroupFooterBand>Group Footer</StiGroupFooterBand>
    <StiGroupHeaderBand>Group Header</StiGroupHeaderBand>
    <StiHeaderBand>Header</StiHeaderBand>
    <StiHierarchicalBand>Hierarchical Data</StiHierarchicalBand>
    <StiHorizontalLinePrimitive>Horizontal Line</StiHorizontalLinePrimitive>
    <StiImage>Image</StiImage>
    <StiOverlayBand>Overlay</StiOverlayBand>
    <StiPage>Page</StiPage>
    <StiPageFooterBand>Page Footer</StiPageFooterBand>
    <StiPageHeaderBand>Page Header</StiPageHeaderBand>
    <StiPanel>Panel</StiPanel>
    <StiRectanglePrimitive>Rectangle</StiRectanglePrimitive>
    <StiReport>Report</StiReport>
    <StiReportSummaryBand>Report Summary</StiReportSummaryBand>
    <StiReportTitleBand>Report Title</StiReportTitleBand>
    <StiRichText>Rich Text</StiRichText>
    <StiRoundedRectanglePrimitive>Rounded Rectangle</StiRoundedRectanglePrimitive>
    <StiShape>Shape</StiShape>
    <StiSubReport>Sub-Report</StiSubReport>
    <StiSystemText>System Text</StiSystemText>
    <StiTable>Table</StiTable>
    <StiText>Text</StiText>
    <StiTextInCells>Text in Cells</StiTextInCells>
    <StiVerticalLinePrimitive>Vertical Line</StiVerticalLinePrimitive>
    <StiWinControl>Win Control</StiWinControl>
    <StiZipCode>Zip Code</StiZipCode>
  </Components>
  <Database>
    <Connection>Connection</Connection>
    <Database>{0} Connection</Database>
    <DatabaseDB2>IBM DB2 Connection</DatabaseDB2>
    <DatabaseFirebird>Firebird Connection</DatabaseFirebird>
    <DatabaseInformix>Informix Connection</DatabaseInformix>
    <DatabaseMySQL>MySQL Connection</DatabaseMySQL>
    <DatabaseTeradata>Teradata Connection</DatabaseTeradata>
    <DatabaseOdbc>Odbc Connection</DatabaseOdbc>
    <DatabaseOleDb>OleDB Connection</DatabaseOleDb>
    <DatabaseOracle>Oracle Connection</DatabaseOracle>
    <DatabaseOracleODP>Oracle ODP.NET Connection</DatabaseOracleODP>
    <DatabasePostgreSQL>PostgreSQL Connection</DatabasePostgreSQL>
    <DatabaseSql>Sql Connection</DatabaseSql>
    <DatabaseSqlCe>SQLServerCE Connection</DatabaseSqlCe>
    <DatabaseSQLite>SQLite Connection</DatabaseSQLite>
    <DatabaseUniDirect>Uni Direct Connection</DatabaseUniDirect>
    <DatabaseVistaDB>VistaDB Connection</DatabaseVistaDB>
    <DatabaseXml>Xml Data</DatabaseXml>
  </Database>
  <DesignerFx>
    <TextNotFound>The specified text was not found. Text : {0}</TextNotFound>
    <CanNotLoadThisReportTemplate>Can't load this report template.</CanNotLoadThisReportTemplate>
    <CloseDataSourceEditor>You want to close data source editor?</CloseDataSourceEditor>
    <CloseEditor>You want to close editor?</CloseEditor>
    <CompilingReport>Compiling Report</CompilingReport>
    <Connecting>Connecting to Server</Connecting>
    <ConnectionError>Connection error</ConnectionError>
    <ConnectionSuccessfull>Connection was successful</ConnectionSuccessfull>
    <Continue>Continue</Continue>
    <DecryptionError>Decryption error: Wrong password or corrupted file.</DecryptionError>
    <ErrorCode>Error at saving. Error code: {0}</ErrorCode>
    <ErrorServer>Error at saving. Server doesn't respond.</ErrorServer>
    <ExportingReport>Exporting Report</ExportingReport>
    <LoadingCode>Loading Code</LoadingCode>
    <LoadingConfiguration>Loading Configuration</LoadingConfiguration>
    <LoadingData>Loading Data</LoadingData>
    <LoadingDocument>Loading Document</LoadingDocument>
    <LoadingImages>Loading Images</LoadingImages>
    <LoadingLanguage>Loading Language</LoadingLanguage>
    <LoadingReport>Loading Report</LoadingReport>
    <PreviewAs>Preview as {0}</PreviewAs>
    <RetrieveError>Retrieve columns error</RetrieveError>
    <RetrievingColumns>Retrieving Columns</RetrievingColumns>
    <SavingConfiguration>Saving Configuration</SavingConfiguration>
    <SavingReport>Saving Report</SavingReport>
    <TestConnection>Test Connection</TestConnection>
  </DesignerFx>
  <Dialogs>
    <StiButtonControl>Button</StiButtonControl>
    <StiCheckBoxControl>Check Box</StiCheckBoxControl>
    <StiCheckedListBoxControl>Checked List Box</StiCheckedListBoxControl>
    <StiComboBoxControl>Combo Box</StiComboBoxControl>
    <StiDateTimePickerControl>Date Time Picker</StiDateTimePickerControl>
    <StiForm>Form</StiForm>
    <StiGridControl>Grid</StiGridControl>
    <StiGroupBoxControl>Group Box</StiGroupBoxControl>
    <StiLabelControl>Label</StiLabelControl>
    <StiListBoxControl>List Box</StiListBoxControl>
    <StiListViewControl>List View</StiListViewControl>
    <StiLookUpBoxControl>LookUp Box</StiLookUpBoxControl>
    <StiNumericUpDownControl>Numeric Up Down</StiNumericUpDownControl>
    <StiPanelControl>Panel</StiPanelControl>
    <StiPictureBoxControl>Picture Box</StiPictureBoxControl>
    <StiRadioButtonControl>Radio Button</StiRadioButtonControl>
    <StiReportControl>Report Control</StiReportControl>
    <StiRichTextBoxControl>Rich Text Box</StiRichTextBoxControl>
    <StiTextBoxControl>Text Box</StiTextBoxControl>
    <StiTreeViewControl>Tree View</StiTreeViewControl>
  </Dialogs>
  <Editor>
    <CantFind>Cannot find the data you're searching for.</CantFind>
    <CollapseToDefinitions>C&amp;ollapse to Definitions</CollapseToDefinitions>
    <Column>Column: {0}</Column>
    <EntireScope>&amp;Entire Scope</EntireScope>
    <Find>&amp;Find</Find>
    <FindNext>&amp;Find Next</FindNext>
    <FindWhat>Find What:</FindWhat>
    <FromCursor>From Cursor</FromCursor>
    <GotoLine>Go To &amp;Line</GotoLine>
    <Line>Line: {0}</Line>
    <LineNumber>Line Number:</LineNumber>
    <LineNumberIndex>Line Number ({0} - {1})</LineNumberIndex>
    <MarkAll>&amp;Mark All</MarkAll>
    <MatchCase>Match &amp;Case</MatchCase>
    <MatchWholeWord>Match &amp;Whole Word</MatchWholeWord>
    <Outlining>Out&amp;lining</Outlining>
    <PromptOnReplace>Prompt on Replace</PromptOnReplace>
    <Replace>&amp;Replace</Replace>
    <ReplaceAll>Replace &amp;All</ReplaceAll>
    <ReplaceWith>Replace With:</ReplaceWith>
    <Search>Search</Search>
    <SearchHiddenText>Hidden Text</SearchHiddenText>
    <SearchUp>Search &amp;Up</SearchUp>
    <SelectionOnly>Selection &amp;Only</SelectionOnly>
    <ShowAutoGeneratedCode>Show Auto Generated Code</ShowAutoGeneratedCode>
    <ShowLineNumbers>Show Line Numbers</ShowLineNumbers>
    <StopOutlining>Sto&amp;p Outlining</StopOutlining>
    <titleFind>Find</titleFind>
    <titleGotoLine>Go To Line</titleGotoLine>
    <titleReplace>Replace</titleReplace>
    <ToggleAllOutlining>Toggle A&amp;ll Outlining</ToggleAllOutlining>
    <ToggleOutliningExpansion>&amp;Toggle Outlining Expansion</ToggleOutliningExpansion>
    <UseRegularExpressions>Use &amp;Regular Expressions</UseRegularExpressions>
  </Editor>
  <Errors>
    <ComponentIsNotRelease>Component is not release "{0}".</ComponentIsNotRelease>
    <ContainerIsNotValidForComponent>Container {0} is not valid for component {1}.</ContainerIsNotValidForComponent>
    <DataNotFound>Data not found.</DataNotFound>
    <Error>Error!</Error>
    <ErrorsList>Errors List</ErrorsList>
    <FieldRequire>Field "{0}" required filling.</FieldRequire>
    <FileNotFound>File "{0}" not found.</FileNotFound>
    <IdentifierIsNotValid>Identifier '{0}' is not valid.</IdentifierIsNotValid>
    <ImpossibleFindDataSource>Impossible to Find Data Source.</ImpossibleFindDataSource>
    <NameExists>There is already an object named '{0}'. Objects must have unique names, and names must be case-insensitive.</NameExists>
    <NoServices>Services are not found in '{0}'</NoServices>
    <NotAssign>Data Source is not specified.</NotAssign>
    <NotCorrectFormat>Input string was not in a correct format.</NotCorrectFormat>
    <RelationsNotFound>Relations not found.</RelationsNotFound>
    <ReportCannotBeSaveDueToErrors>Report cannot be saved due to errors!</ReportCannotBeSaveDueToErrors>
    <ServiceNotFound>'{0}' Service not found.</ServiceNotFound>
  </Errors>
  <Export>
    <AddPageBreaks>Add Page Breaks</AddPageBreaks>
    <AllowAddOrModifyTextAnnotations>Allow Add or Modify Text Annotations</AllowAddOrModifyTextAnnotations>
    <AllowCopyTextAndGraphics>Allow Copy Text and Graphics</AllowCopyTextAndGraphics>
    <AllowModifyContents>Allow Modify Contents</AllowModifyContents>
    <AllowPrintDocument>Allow Print Document</AllowPrintDocument>
    <Color>Color</Color>
    <Compressed>Compressed</Compressed>
    <ContinuousPages>Continuous Pages</ContinuousPages>
    <DigitalSignature>Digital Signature</DigitalSignature>
    <DocumentSecurity>Document Security</DocumentSecurity>
    <DotMatrixMode>Dot-Matrix Mode</DotMatrixMode>
    <EmbeddedFonts>Embedded Fonts</EmbeddedFonts>
    <Encoding>Encoding:</Encoding>
    <EscapeCodes>Escape Codes</EscapeCodes>
    <ExportDataOnly>Export Data Only</ExportDataOnly>
    <ExportEachPageToSheet>Export Each Page to Sheet</ExportEachPageToSheet>
    <ExportingCalculatingCoordinates>Calculating Coordinates</ExportingCalculatingCoordinates>
    <ExportingCreatingDocument>Creating Document</ExportingCreatingDocument>
    <ExportingFormatingObjects>Formatting Objects</ExportingFormatingObjects>
    <ExportingReport>Exporting Report</ExportingReport>
    <ExportMode>Export Mode:</ExportMode>
    <ExportModeFrame>Frame</ExportModeFrame>
    <ExportModeTable>Table</ExportModeTable>
    <ExportObjectFormatting>Export Object Formatting</ExportObjectFormatting>
    <ExportPageBreaks>Export Page Breaks</ExportPageBreaks>
    <ExportRtfTextAsImage>Export Rich Text as Image</ExportRtfTextAsImage>
    <ExportTypeBmpFile>BMP Image...</ExportTypeBmpFile>
    <ExportTypeCalcFile>OpenDocument Calc File...</ExportTypeCalcFile>
    <ExportTypeCsvFile>CSV File...</ExportTypeCsvFile>
    <ExportTypeDbfFile>dBase DBF File...</ExportTypeDbfFile>
    <ExportTypeDifFile>Data Interchange Format (DIF) File...</ExportTypeDifFile>
    <ExportTypeExcel2007File>Microsoft Excel 2007/2013 File...</ExportTypeExcel2007File>
    <ExportTypeExcelFile>Microsoft Excel File...</ExportTypeExcelFile>
    <ExportTypeExcelXmlFile>Microsoft Excel Xml File...</ExportTypeExcelXmlFile>
    <ExportTypeGifFile>GIF Image...</ExportTypeGifFile>
    <ExportTypeHtml5File>HTML5 File...</ExportTypeHtml5File>
    <ExportTypeHtmlFile>HTML File...</ExportTypeHtmlFile>
    <ExportTypeJpegFile>JPEG Image...</ExportTypeJpegFile>
    <ExportTypeMetafile>Windows Metafile...</ExportTypeMetafile>
    <ExportTypeMhtFile>MHT Web Archive...</ExportTypeMhtFile>
    <ExportTypePcxFile>PCX Image...</ExportTypePcxFile>
    <ExportTypePdfFile>Adobe PDF File...</ExportTypePdfFile>
    <ExportTypePngFile>PNG Image...</ExportTypePngFile>
    <ExportTypePpt2007File>Microsoft PowerPoint 2007/2013 File...</ExportTypePpt2007File>
    <ExportTypeRtfFile>Rich Text File...</ExportTypeRtfFile>
    <ExportTypeSvgFile>Scalable Vector Graphics (SVG) File...</ExportTypeSvgFile>
    <ExportTypeSvgzFile>Compressed SVG (SVGZ) File...</ExportTypeSvgzFile>
    <ExportTypeSylkFile>Symbolic Link (SYLK) File...</ExportTypeSylkFile>
    <ExportTypeTiffFile>TIFF Image...</ExportTypeTiffFile>
    <ExportTypeTxtFile>Text File...</ExportTypeTxtFile>
    <ExportTypeWord2007File>Microsoft Word 2007/2013 File...</ExportTypeWord2007File>
    <ExportTypeWriterFile>OpenDocument Writer File...</ExportTypeWriterFile>
    <ExportTypeXmlFile>XML File...</ExportTypeXmlFile>
    <ExportTypeXpsFile>Microsoft XPS File...</ExportTypeXpsFile>
    <GetCertificateFromCryptoUI>Get Certificate from Crypto UI</GetCertificateFromCryptoUI>
    <ImageCompressionMethod>Image Compression Method:</ImageCompressionMethod>
    <ImageCutEdges>Cut Edges</ImageCutEdges>
    <ImageFormat>Image Format:</ImageFormat>
    <ImageGrayscale>Grayscale</ImageGrayscale>
    <ImageMonochrome>Monochrome</ImageMonochrome>
    <ImageQuality>Image Quality</ImageQuality>
    <ImageResolution>Image Resolution:</ImageResolution>
    <ImageType>Image Type</ImageType>
    <labelEncryptionKeyLength>Encryption Key Length:</labelEncryptionKeyLength>
    <labelOwnerPassword>Owner Password:</labelOwnerPassword>
    <labelSubjectNameString>Subject Name String:</labelSubjectNameString>
    <labelUserPassword>User Password:</labelUserPassword>
    <MonochromeDitheringType>Monochrome Dithering Type:</MonochromeDitheringType>
    <MoreSettings>More Settings</MoreSettings>
    <MultipleFiles>Multiple Files</MultipleFiles>
    <OpenAfterExport>Open After Export</OpenAfterExport>
    <PdfACompliance>PDF/A Compliance</PdfACompliance>
    <RemoveEmptySpaceAtBottom>Remove empty space at bottom of the page</RemoveEmptySpaceAtBottom>
    <Separator>Separator:</Separator>
    <Settings>Settings</Settings>
    <SkipColumnHeaders>Skip Column Headers</SkipColumnHeaders>
    <StandardPDFFonts>Standard PDF Fonts</StandardPDFFonts>
    <TiffCompressionScheme>TIFF Compression Scheme:</TiffCompressionScheme>
    <title>Export Settings</title>
    <TxtBorderType>Border Type</TxtBorderType>
    <TxtBorderTypeDouble>Unicode-Double</TxtBorderTypeDouble>
    <TxtBorderTypeSimple>Simple</TxtBorderTypeSimple>
    <TxtBorderTypeSingle>Unicode-Single</TxtBorderTypeSingle>
    <TxtCutLongLines>Cut Long Lines</TxtCutLongLines>
    <TxtDrawBorder>Draw Border</TxtDrawBorder>
    <TxtKillSpaceGraphLines>Kill Space Graph Lines</TxtKillSpaceGraphLines>
    <TxtKillSpaceLines>Kill Space Lines</TxtKillSpaceLines>
    <TxtPutFeedPageCode>Put Feed Page Code</TxtPutFeedPageCode>
    <UseDefaultSystemEncoding>Use Default System Encoding</UseDefaultSystemEncoding>
    <UseDigitalSignature>Use Digital Signature</UseDigitalSignature>
    <UseEscapeCodes>Use Escape Codes</UseEscapeCodes>
    <UseOnePageHeaderAndFooter>Use One Page Header and Footer</UseOnePageHeaderAndFooter>
    <UsePageHeadersAndFooters>Use Page Headers and Footers</UsePageHeadersAndFooters>
    <UseUnicode>Use Unicode</UseUnicode>
    <X>X:</X>
    <Y>Y:</Y>
    <Zoom>Zoom:</Zoom>
    <EncryptionError>Encryption error at step</EncryptionError>
    <DigitalSignatureError>Digital Signature error at step</DigitalSignatureError>
    <DigitalSignatureCertificateNotSelected>Certificate is not selected</DigitalSignatureCertificateNotSelected>
    <BandsFilter>Bands Filter:</BandsFilter>
    <DataOnly>Data only</DataOnly>
    <DataAndHeadersFooters>Data and Headers/Footers</DataAndHeadersFooters>
    <AllBands>All bands</AllBands>
  </Export>
  <FileFilters>
    <AllImageFiles>All Image Files</AllImageFiles>
    <BitmapFiles>Bitmap Files</BitmapFiles>
    <BmpFiles>BMP image (*.bmp)|*.bmp</BmpFiles>
    <CalcFiles>OpenDocument Calc files (*.ods)|*.ods</CalcFiles>
    <CsvFiles>CSV files (*.csv)|*.csv</CsvFiles>
    <DataSetXmlData>DataSet XML data (*.xml)|*.xml</DataSetXmlData>
    <DataSetXmlSchema>DataSet XML schema (*.xsd)|*.xsd</DataSetXmlSchema>
    <DbfFiles>DBF files (*.dbf)|*.dbf</DbfFiles>
    <DictionaryFiles>Files dictionary (*.dct)|*.dct</DictionaryFiles>
    <DifFiles>DIF files (*.dif)|*.dif</DifFiles>
    <DllFiles>DLL files (*.dll)|*.dll</DllFiles>
    <DocumentFiles>Files document (*.mdc)|*.mdc</DocumentFiles>
    <EmfFiles>Metafile (*.emf)|*.emf</EmfFiles>
    <EncryptedDocumentFiles>Files encrypted document (*.mdx)|*.mdx</EncryptedDocumentFiles>
    <EncryptedReportFiles>Files encrypted report (*.mrx)|*.mrx</EncryptedReportFiles>
    <Excel2007Files>Microsoft Excel 2007/2013 files (*.xlsx)|*.xlsx</Excel2007Files>
    <ExcelFiles>Microsoft Excel files (*.xls)|*.xls</ExcelFiles>
    <ExcelXmlFiles>Microsoft Excel XML files (*.xls)|*.xls</ExcelXmlFiles>
    <ExeFiles>EXE files (*.exe)|*.exe</ExeFiles>
    <GifFiles>GIF image (*.gif)|*.gif</GifFiles>
    <HtmlFiles>HTML files (*.html)|*.html</HtmlFiles>
    <InheritedLanguageFiles>{0} files for inherited reports (*.{1})|*.{2}</InheritedLanguageFiles>
    <JpegFiles>JPEG image (*.jpeg)|*.jpeg</JpegFiles>
    <LanguageFiles>{0} files (*.{1})|*.{2}</LanguageFiles>
    <LanguageForSilverlightFiles>{0} files for Silverlight reports (*.{1})|*.{2}</LanguageForSilverlightFiles>
    <MetaFiles>Meta Files</MetaFiles>
    <MhtFiles>MHT Web Archive files (*.mht)|*.mht</MhtFiles>
    <PackedDocumentFiles>Files packed document (*.mdz)|*.mdz</PackedDocumentFiles>
    <PackedReportFiles>Files packed report (*.mrz)|*.mrz</PackedReportFiles>
    <PageFiles>Files page (*.pg)|*.pg</PageFiles>
    <PcxFiles>PCX image (*.pcx)|*.pcx</PcxFiles>
    <PdfFiles>Adobe PDF files (*.pdf)|*.pdf</PdfFiles>
    <PngFiles>PNG image (*.png)|*.png</PngFiles>
    <Ppt2007Files>Microsoft PowerPoint 2007/2013 files (*.pptx)|*.pptx</Ppt2007Files>
    <ReportFiles>Files report (*.mrt)|*.mrt</ReportFiles>
    <RtfFiles>Rich Text (*.rtf)|*.rtf</RtfFiles>
    <StandaloneReportFiles>Standalone report (*.exe)|*.exe</StandaloneReportFiles>
    <StylesFiles>Files style (*.sts)|*.sts</StylesFiles>
    <SvgFiles>SVG image (*.svg)|*.svg</SvgFiles>
    <SvgzFiles>Compressed SVG image (*.svgz)|*.svgz</SvgzFiles>
    <SylkFiles>SYLK files (*.slk)|*.slk</SylkFiles>
    <TiffFiles>TIFF image (*.tiff)|*.tiff</TiffFiles>
    <TxtFiles>Text (*.txt)|*.txt</TxtFiles>
    <Word2007Files>Microsoft Word 2007/2013 files (*.docx)|*.docx</Word2007Files>
    <WriterFiles>OpenDocument Writer files (*.odt)|*.odt</WriterFiles>
    <XmlFiles>XML files (*.xml)|*.xml</XmlFiles>
    <XpsFiles>Microsoft XPS files (*.xps)|*.xps</XpsFiles>
  </FileFilters>
  <Formats>
    <custom01>d</custom01>
    <custom02>D</custom02>
    <custom03>f</custom03>
    <custom04>F</custom04>
    <custom05>yy/MM/dd</custom05>
    <custom06>yyyy/MM/dd</custom06>
    <custom07>G</custom07>
    <custom08>$0.00</custom08>
    <custom09>$0</custom09>
    <custom10>c</custom10>
    <custom11>c1</custom11>
    <custom12>c2</custom12>
    <custom13>#.00</custom13>
    <custom14>#,#</custom14>
    <custom15>n</custom15>
    <custom16>n1</custom16>
    <custom17>n2</custom17>
    <custom18>(###) ### - ####</custom18>
    <date01>*d</date01>
    <date02>*D</date02>
    <date03>M.dd</date03>
    <date04>yy.M.dd</date04>
    <date05>yy.MM.dd</date05>
    <date06>MMM.dd</date06>
    <date07>yy.MMM.dd</date07>
    <date08>yyyy, MMMM</date08>
    <date09>*f</date09>
    <date10>*F</date10>
    <date11>MM.dd.yyyy</date11>
    <date12>dd/MM/yyyy</date12>
    <time01>*t</time01>
    <time02>*T</time02>
    <time03>HH:mm</time03>
    <time04>H:mm</time04>
    <time06>HH:mm:ss</time06>
  </Formats>
  <FormBand>
    <AddFilter>&amp;Add Filter</AddFilter>
    <AddGroup>&amp;Add Group</AddGroup>
    <AddResult>&amp;Add Result</AddResult>
    <AddSort>&amp;Add Sort</AddSort>
    <And>and</And>
    <Ascending>Ascending</Ascending>
    <Descending>Descending</Descending>
    <NoFilters>No Filters</NoFilters>
    <NoSort>No Sorting</NoSort>
    <RemoveFilter>&amp;Remove Filter</RemoveFilter>
    <RemoveGroup>&amp;Remove Group</RemoveGroup>
    <RemoveResult>&amp;Remove Result</RemoveResult>
    <RemoveSort>&amp;Remove Sort</RemoveSort>
    <SortBy>Sort by</SortBy>
    <ThenBy>Then by</ThenBy>
    <title>Data Setup</title>
  </FormBand>
  <FormColorBoxPopup>
    <Color>Color</Color>
    <Custom>Custom</Custom>
    <Others>Others...</Others>
    <System>System</System>
    <Web>Web</Web>
  </FormColorBoxPopup>
  <FormConditions>
    <AaBbCcYyZz>AaBbCcYyZz</AaBbCcYyZz>
    <AddCondition>&amp;Add Condition</AddCondition>
    <AddLevel>Add Level</AddLevel>
    <AssignExpression>Assign Expression</AssignExpression>
    <ChangeFont>Change Font...</ChangeFont>
    <ComponentIsEnabled>Component is Enabled</ComponentIsEnabled>
    <NoConditions>No Conditions</NoConditions>
    <RemoveCondition>&amp;Remove Condition</RemoveCondition>
    <SelectStyle>Select Style</SelectStyle>
    <title>Conditions</title>
  </FormConditions>
  <FormCrossTabDesigner>
    <Columns>Columns:</Columns>
    <DataSource>DataSource:</DataSource>
    <Properties>Properties:</Properties>
    <Rows>Rows:</Rows>
    <Summary>Summary:</Summary>
    <Swap>Swap Rows / Columns</Swap>
    <title>Cross-Tab Designer</title>
  </FormCrossTabDesigner>
  <FormDatabaseEdit>
    <ConnectionString>Connection String:</ConnectionString>
    <DB2Edit>Edit IBM DB2 Connection</DB2Edit>
    <DB2New>New IBM DB2 Connection</DB2New>
    <EditConnection>Edit {0} Connection</EditConnection>
    <FirebirdEdit>Edit Firebird Connection</FirebirdEdit>
    <FirebirdNew>New Firebird Connection</FirebirdNew>
    <InformixEdit>Edit Informix Connection</InformixEdit>
    <InformixNew>New Informix Connection</InformixNew>
    <InitialCatalog>Initial Catalog:</InitialCatalog>
    <MySQLEdit>Edit MySQL Connection</MySQLEdit>
    <MySQLNew>New MySQL Connection</MySQLNew>
    <TeradataEdit>Edit Teradata Connection</TeradataEdit>
    <TeradataNew>New Teradata Connection</TeradataNew>
    <NewConnection>New {0} Connection</NewConnection>
    <OdbcEdit>Edit Odbc Connection</OdbcEdit>
    <OdbcNew>New Odbc Connection</OdbcNew>
    <OleDbEdit>Edit OleDb Connection</OleDbEdit>
    <OleDbNew>New OleDb Connection</OleDbNew>
    <OracleEdit>Edit Oracle Connection</OracleEdit>
    <OracleNew>New Oracle Connection</OracleNew>
    <OracleODPEdit>Edit Oracle ODP.NET Connection</OracleODPEdit>
    <OracleODPNew>New Oracle ODP.NET Connection</OracleODPNew>
    <PathData>Path to XML Data:</PathData>
    <PathSchema>Path to XSD Schema:</PathSchema>
    <PostgreSQLEdit>Edit PostgreSQL Connection</PostgreSQLEdit>
    <PostgreSQLNew>New PostgreSQL Connection</PostgreSQLNew>
    <PromptUserNameAndPassword>Prompt User Name and Password</PromptUserNameAndPassword>
    <SqlCeEdit>Edit SQLServerCE Connection</SqlCeEdit>
    <SqlCeNew>New SQLServerCE Connection</SqlCeNew>
    <SqlEdit>Edit Sql Connection</SqlEdit>
    <SQLiteEdit>Edit SQLite Connection</SQLiteEdit>
    <SQLiteNew>New SQLite Connection</SQLiteNew>
    <SqlNew>New Sql Connection</SqlNew>
    <UniDirectEdit>Edit Uni Direct Connection</UniDirectEdit>
    <UniDirectNew>New Uni Direct Connection</UniDirectNew>
    <VistaDBEdit>Edit VistaDB Connection</VistaDBEdit>
    <VistaDBNew>New VistaDB Connection</VistaDBNew>
    <XmlEdit>Edit Xml Data</XmlEdit>
    <XmlNew>New Xml Data</XmlNew>
  </FormDatabaseEdit>
  <FormDesigner>
    <Code>Code</Code>
    <ColumnsOne>One</ColumnsOne>
    <ColumnsThree>Three</ColumnsThree>
    <ColumnsTwo>Two</ColumnsTwo>
    <CompilingReport>Compiling Report</CompilingReport>
    <DockingPanels>Panels</DockingPanels>
    <HtmlPreview>HTML Preview</HtmlPreview>
    <labelPleaseSelectTypeOfInterface>Please, select type of interface</labelPleaseSelectTypeOfInterface>
    <LoadImage>Load Image...</LoadImage>
    <LocalizePropertyGrid>Localize Property Grid</LocalizePropertyGrid>
    <MarginsNarrow>Narrow</MarginsNarrow>
    <MarginsNormal>Normal</MarginsNormal>
    <MarginsWide>Wide</MarginsWide>
    <OrderToolbars>Order Toolbars</OrderToolbars>
    <Pages>Pages</Pages>
    <Preview>Preview</Preview>
    <PropertyChange>Change of property '{0}'</PropertyChange>
    <SetupToolbox>Setup Toolbox</SetupToolbox>
    <ShowDescription>Show Description</ShowDescription>
    <SLPreview>Silverlight Preview</SLPreview>
    <RTPreview>WinRT Preview</RTPreview>
    <title>Designer</title>
    <WebPreview>Web Preview</WebPreview>
  </FormDesigner>
  <FormDictionaryDesigner>
    <Actions>Actions</Actions>
    <AutoSort>Auto Sort</AutoSort>
    <BusinessObjectEdit>Edit Business Object</BusinessObjectEdit>
    <CalcColumnEdit>Edit Calculated Column</CalcColumnEdit>
    <CalcColumnNew>New Calculated Column</CalcColumnNew>
    <CategoryEdit>Edit Category</CategoryEdit>
    <CategoryNew>New Category</CategoryNew>
    <ChildOfBusinessObject>Child of Business Object</ChildOfBusinessObject>
    <ChildSource>Child Data Source:</ChildSource>
    <ColumnEdit>Edit Column</ColumnEdit>
    <ColumnNew>New Column</ColumnNew>
    <DatabaseEdit>Edit Database</DatabaseEdit>
    <DatabaseNew>New Database</DatabaseNew>
    <DataParameterEdit>Edit Parameter</DataParameterEdit>
    <DataParameterNew>New Parameter</DataParameterNew>
    <DataSourceEdit>Edit Data Source</DataSourceEdit>
    <DataSourceNew>New Data Source</DataSourceNew>
    <DataSourcesNew>New Data Sources</DataSourcesNew>
    <Delete>Delete</Delete>
    <DesignTimeQueryText>Design-Time Query Text</DesignTimeQueryText>
    <DictionaryMerge>Merge Dictionary...</DictionaryMerge>
    <DictionaryNew>New Dictionary...</DictionaryNew>
    <DictionaryOpen>Open Dictionary...</DictionaryOpen>
    <DictionarySaveAs>Save Dictionary As...</DictionarySaveAs>
    <EditQuery>Edit Query</EditQuery>
    <ExecutedSQLStatementSuccessfully>Executed SQL statement successfully</ExecutedSQLStatementSuccessfully>
    <ExpressionNew>New Expression</ExpressionNew>
    <GetColumnsFromAssembly>Get Columns from Assembly</GetColumnsFromAssembly>
    <ImportRelations>Import Relations</ImportRelations>
    <MarkUsedItems>Mark Used Items</MarkUsedItems>
    <NewBusinessObject>New Business Object</NewBusinessObject>
    <NewItem>New Item</NewItem>
    <OpenAssembly>Open Assembly</OpenAssembly>
    <ParentSource>Parent DataSource:</ParentSource>
    <Queries>Queries</Queries>
    <QueryNew>New Query</QueryNew>
    <QueryText>Query Text</QueryText>
    <RelationEdit>Edit Relation</RelationEdit>
    <RelationNew>New Relation</RelationNew>
    <RetrieveColumns>Retrieve Columns</RetrieveColumns>
    <RetrievingDatabaseInformation>Retrieving database information...</RetrievingDatabaseInformation>
    <Run>Run</Run>
    <SelectTypeOfBusinessObject>Select Type of Business Object</SelectTypeOfBusinessObject>
    <SortItems>Sort Items</SortItems>
    <Synchronize>Synchronize</Synchronize>
    <SynchronizeHint>Synchronizes contents of the Data Store and contents of the Dictionary</SynchronizeHint>
    <title>Dictionary Designer</title>
    <ValueNew>New Value</ValueNew>
    <VariableEdit>Edit Variable</VariableEdit>
    <VariableNew>New Variable</VariableNew>
    <ViewData>View Data</ViewData>
    <ViewQuery>View Query</ViewQuery>
  </FormDictionaryDesigner>
  <FormFormatEditor>
    <Boolean>Boolean</Boolean>
    <BooleanDisplay>Display:</BooleanDisplay>
    <BooleanValue>Value:</BooleanValue>
    <Currency>Currency</Currency>
    <CurrencySymbol>Currency Symbol:</CurrencySymbol>
    <Custom>Custom</Custom>
    <Date>Date</Date>
    <DateTimeFormat>Date Time Format</DateTimeFormat>
    <DecimalDigits>Decimal Digits:</DecimalDigits>
    <DecimalSeparator>Decimal Separator:</DecimalSeparator>
    <FormatMask>Format Mask:</FormatMask>
    <Formats>Formats</Formats>
    <General>General</General>
    <GroupSeparator>Group Separator:</GroupSeparator>
    <GroupSize>Group Size:</GroupSize>
    <nameFalse>False</nameFalse>
    <nameNo>No</nameNo>
    <nameOff>Off</nameOff>
    <nameOn>On</nameOn>
    <nameTrue>True</nameTrue>
    <nameYes>Yes</nameYes>
    <NegativePattern>Negative Pattern:</NegativePattern>
    <Number>Number</Number>
    <Percentage>Percentage</Percentage>
    <PercentageSymbol>Percentage Symbol:</PercentageSymbol>
    <PositivePattern>Positive Pattern:</PositivePattern>
    <Properties>Properties</Properties>
    <Sample>Sample</Sample>
    <SampleText>Sample Text</SampleText>
    <TextFormat>Text Format</TextFormat>
    <Time>Time</Time>
    <title>Format</title>
    <UseGroupSeparator>Use Group Separator</UseGroupSeparator>
    <UseLocalSetting>Use Local Setting</UseLocalSetting>
  </FormFormatEditor>
  <FormGlobalizationEditor>
    <AddCulture>&amp;Add Culture</AddCulture>
    <AutoLocalizeReportOnRun>Auto Localize Report on Run</AutoLocalizeReportOnRun>
    <GetCulture>Get Culture Settings from Report</GetCulture>
    <qnGetCulture>Do you really want to get culture settings from report and override current culture settings?</qnGetCulture>
    <qnSetCulture>Do you really want to set culture settings to report components?</qnSetCulture>
    <RemoveCulture>&amp;Remove Culture</RemoveCulture>
    <SetCulture>Set Culture Settings to Report</SetCulture>
    <title>Globalization Editor</title>
  </FormGlobalizationEditor>
  <FormOptions>
    <AutoSave>Auto Save</AutoSave>
    <AutoSaveReportToReportClass>Auto Save Report to C# or Vb.Net File</AutoSaveReportToReportClass>
    <Default>Default</Default>
    <Drawing>Drawing</Drawing>
    <DrawMarkersWhenMoving>Draw Markers When Moving</DrawMarkersWhenMoving>
    <EditAfterInsert>Edit After Insert</EditAfterInsert>
    <EnableAutoSaveMode>Enable Auto Save Mode</EnableAutoSaveMode>
    <FillBands>Fill Bands</FillBands>
    <FillComponents>Fill Components</FillComponents>
    <FillContainers>Fill Containers</FillContainers>
    <FillCrossBands>Fill Cross Bands</FillCrossBands>
    <GenerateLocalizedName>Generate Localized Name</GenerateLocalizedName>
    <Grid>Grid</Grid>
    <GridDots>Dots</GridDots>
    <GridLines>Lines</GridLines>
    <GridMode>Grid Mode</GridMode>
    <GridSize>Grid Size</GridSize>
    <groupAutoSaveOptions>Auto save options</groupAutoSaveOptions>
    <groupColorScheme>Please select color scheme of Gui</groupColorScheme>
    <groupGridDrawingOptions>Grid drawing options</groupGridDrawingOptions>
    <groupGridOptions>Grid options</groupGridOptions>
    <groupGridSize>Grid size</groupGridSize>
    <groupMainOptions>Main options for working with report designer</groupMainOptions>
    <groupMarkersStyle>Marker style</groupMarkersStyle>
    <groupOptionsOfQuickInfo>Options of Quick Info</groupOptionsOfQuickInfo>
    <groupPleaseSelectTypeOfGui>Please, select the type of GUI</groupPleaseSelectTypeOfGui>
    <groupReportDisplayOptions>Report display options</groupReportDisplayOptions>
    <labelColorScheme>Color Scheme:</labelColorScheme>
    <labelInfoAutoSave>Change parameters of reports autosaving</labelInfoAutoSave>
    <labelInfoDrawing>Setting parameters of report drawing</labelInfoDrawing>
    <labelInfoGrid>How Grid is shown and used in a report</labelInfoGrid>
    <labelInfoGui>Select the mode of using GUI in the report designer</labelInfoGui>
    <labelInfoMain>Setting basic parameters of the report designer</labelInfoMain>
    <labelInfoQuickInfo>Components Quick Info on a page</labelInfoQuickInfo>
    <Main>Main</Main>
    <MarkersStyle>Markers Style</MarkersStyle>
    <MarkersStyleCorners>Corners</MarkersStyleCorners>
    <MarkersStyleDashedRectangle>Dashed Rectangle</MarkersStyleDashedRectangle>
    <MarkersStyleNone>None</MarkersStyleNone>
    <Minutes>{0} minutes</Minutes>
    <SaveReportEvery>Save Report Every:</SaveReportEvery>
    <SelectUILanguage>Select UI Language</SelectUILanguage>
    <ShowDimensionLines>Show Dimension Lines</ShowDimensionLines>
    <title>Options</title>
    <UseComponentColor>Use Component Color for Filling</UseComponentColor>
    <UseLastFormat>Use Last Format</UseLastFormat>
  </FormOptions>
  <FormPageSetup>
    <ApplyTo>Apply to</ApplyTo>
    <Bottom>Bottom:</Bottom>
    <Columns>Columns</Columns>
    <groupColumns>Page columns</groupColumns>
    <groupImage>Watermark image</groupImage>
    <groupMargins>Page margins</groupMargins>
    <groupOrientation>Paper orientation</groupOrientation>
    <groupPaper>Paper size</groupPaper>
    <groupPaperSource>Paper source</groupPaperSource>
    <groupText>Watermark text</groupText>
    <Height>Height:</Height>
    <labelAngle>Angle:</labelAngle>
    <labelColumnGaps>Column Gaps:</labelColumnGaps>
    <labelColumnWidth>Column Width:</labelColumnWidth>
    <labelImageAlignment>Image Alignment:</labelImageAlignment>
    <labelImageTransparency>Image Transparency:</labelImageTransparency>
    <labelInfoColumns>Setting page columns</labelInfoColumns>
    <labelInfoPaper>Setting size and orientation for the current page</labelInfoPaper>
    <labelInfoUnit>Page margins are specified in the current units</labelInfoUnit>
    <labelInfoWatermark>Setting parameters for showing watermark</labelInfoWatermark>
    <labelMultipleFactor>Multiple Factor:</labelMultipleFactor>
    <labelPaperSourceOfFirstPage>Paper Source of First Page:</labelPaperSourceOfFirstPage>
    <labelPaperSourceOfOtherPages>Paper Source of Other Pages:</labelPaperSourceOfOtherPages>
    <labelSelectColor>Select Color:</labelSelectColor>
    <labelSelectFont>Select Font:</labelSelectFont>
    <labelSelectImage>Select Image:</labelSelectImage>
    <labelText>Text:</labelText>
    <Left>Left:</Left>
    <Margins>Margins</Margins>
    <NumberOfColumns>Number of Columns:</NumberOfColumns>
    <Orientation>Orientation</Orientation>
    <PageOrientationLandscape>Landscape</PageOrientationLandscape>
    <PageOrientationPortrait>Portrait</PageOrientationPortrait>
    <Paper>Paper:</Paper>
    <RebuildReport>Rebuild Report</RebuildReport>
    <Right>Right:</Right>
    <ScaleContent>Scale Content</ScaleContent>
    <Size>Size:</Size>
    <title>Page Setup</title>
    <Top>Top:</Top>
    <Width>Width:</Width>
  </FormPageSetup>
  <FormReportSetup>
    <groupDates>A date of report creation and a date of the last report change</groupDates>
    <groupDescription>Report description</groupDescription>
    <groupMainParameters>Parameters which effect on report rendering</groupMainParameters>
    <groupNames>Report name, report alias, and report author</groupNames>
    <groupScript>Script language of your report</groupScript>
    <groupUnits>Size and coordinates in a report will be in specified units</groupUnits>
    <labelInfoDescription>Indicate the information of a report</labelInfoDescription>
    <labelInfoMain>Change of basic report parameters</labelInfoMain>
    <labelNumberOfPass>Number of Pass:</labelNumberOfPass>
    <labelReportCacheMode>Report Cache Mode:</labelReportCacheMode>
    <ReportChanged>Report Changed:</ReportChanged>
    <ReportCreated>Report Created:</ReportCreated>
    <title>Report Setup</title>
  </FormReportSetup>
  <FormRichTextEditor>
    <Bullets>Bullets</Bullets>
    <FontName>Font Name</FontName>
    <FontSize>Font Size</FontSize>
    <Insert>Insert Expression</Insert>
    <title>Rich Text Editor</title>
  </FormRichTextEditor>
  <FormStyleDesigner>
    <Add>Add Style</Add>
    <ApplyStyleCollectionToReportComponents>Apply Style Collection to Report Components</ApplyStyleCollectionToReportComponents>
    <ApplyStyles>Apply Styles</ApplyStyles>
    <CreateStyleCollection>Create Style Collection</CreateStyleCollection>
    <Duplicate>Duplicate Style</Duplicate>
    <GetStyle>Get Style from Selected Components</GetStyle>
    <Open>Open Style</Open>
    <qnApplyStyleCollection>Do you want to apply style collection to report components?</qnApplyStyleCollection>
    <Remove>Remove Style</Remove>
    <RemoveExistingStyles>Remove Existing Styles</RemoveExistingStyles>
    <Save>Save Style</Save>
    <Style>Style</Style>
    <StyleCollectionsNotFound>Style Collections Not Found!</StyleCollectionsNotFound>
    <title>Style Designer</title>
  </FormStyleDesigner>
  <FormSystemTextEditor>
    <Condition>Condition</Condition>
    <LabelDataBand>Data Band:</LabelDataBand>
    <LabelDataColumn>Data Column:</LabelDataColumn>
    <LabelShowInsteadNullValues>Show Instead Null Values:</LabelShowInsteadNullValues>
    <LabelSummaryFunction>Summary Function:</LabelSummaryFunction>
    <pageExpression>Expression</pageExpression>
    <pageSummary>Summary</pageSummary>
    <pageSystemVariable>System Variable</pageSystemVariable>
    <RunningTotal>Running Total</RunningTotal>
    <SummaryRunning>Summary Running</SummaryRunning>
    <SummaryRunningByColumn>Column</SummaryRunningByColumn>
    <SummaryRunningByPage>Page</SummaryRunningByPage>
    <SummaryRunningByReport>Report</SummaryRunningByReport>
  </FormSystemTextEditor>
  <FormTitles>
    <ChartWizardForm>Chart Wizard</ChartWizardForm>
    <ConditionEditorForm>Condition</ConditionEditorForm>
    <ConnectionSelectForm>Select Type of Connection</ConnectionSelectForm>
    <ContainerSelectForm>Select Container</ContainerSelectForm>
    <DataAdapterServiceSelectForm>Select Type of Data</DataAdapterServiceSelectForm>
    <DataRelationSelectForm>Select Data Relation</DataRelationSelectForm>
    <DataSetName>Enter DataSet Name</DataSetName>
    <DataSourceSelectForm>Select Data Source</DataSourceSelectForm>
    <DataSourcesNewForm>New DataSources</DataSourcesNewForm>
    <DataStoreViewerForm>Data Store Viewer</DataStoreViewerForm>
    <EventEditorForm>Event Editor</EventEditorForm>
    <ExpressionEditorForm>Expression Editor</ExpressionEditorForm>
    <GroupConditionForm>Group Condition</GroupConditionForm>
    <InteractionDrillDownPageSelectForm>Select Drill-Down Page</InteractionDrillDownPageSelectForm>
    <MasterComponentSelectForm>Select Master Component</MasterComponentSelectForm>
    <PageAddForm>Add Page</PageAddForm>
    <PageSizeForm>Page Size</PageSizeForm>
    <PagesManagerForm>Pages Manager</PagesManagerForm>
    <PromptForm>Enter information to logon on to the database</PromptForm>
    <ServiceSelectForm>Select Service</ServiceSelectForm>
    <SqlExpressionsForm>Sql Expressions</SqlExpressionsForm>
    <SubReportPageSelectForm>Select Sub-Report Page</SubReportPageSelectForm>
    <TextEditorForm>Text Editor</TextEditorForm>
    <ViewDataForm>View Data</ViewDataForm>
    <ViewerApplication>Report Viewer</ViewerApplication>
  </FormTitles>
  <FormViewer>
    <Bookmarks>Bookmarks</Bookmarks>
    <Close>Close</Close>
    <CollapseAll>Collapse All</CollapseAll>
    <CompressedDocumentFile>Compressed Document File</CompressedDocumentFile>
    <ContextMenu>Context Menu</ContextMenu>
    <DocumentFile>Document File...</DocumentFile>
    <Editor>Editor</Editor>
    <EncryptedDocumentFile>Encrypted Document File</EncryptedDocumentFile>
    <ExpandAll>Expand All</ExpandAll>
    <Export>Export...</Export>
    <Find>Find</Find>
    <FirstPage>First Page</FirstPage>
    <FullScreen>Full Screen</FullScreen>
    <GoToPage>Go To Page</GoToPage>
    <HorScrollBar>Horizontal Scroll Bar</HorScrollBar>
    <LabelPageN>Page:</LabelPageN>
    <LastPage>Last Page</LastPage>
    <NextPage>Next Page</NextPage>
    <Open>Open...</Open>
    <PageControl>Page Control</PageControl>
    <PageDelete>Delete Page</PageDelete>
    <PageDesign>Edit Page...</PageDesign>
    <PageNew>New Page</PageNew>
    <PageNofM>Page {0} of {1}</PageNofM>
    <PageofM>of {0}</PageofM>
    <PageSize>Page Size...</PageSize>
    <PageViewModeContinuous>Continuous</PageViewModeContinuous>
    <PageViewModeMultiplePages>Multiple Pages</PageViewModeMultiplePages>
    <PageViewModeSinglePage>Single Page</PageViewModeSinglePage>
    <Parameters>Parameters</Parameters>
    <PrevPage>Previous Page</PrevPage>
    <Print>Print...</Print>
    <qnPageDelete>Do you want to delete page?</qnPageDelete>
    <Save>Save...</Save>
    <SendEMail>Send E-Mail...</SendEMail>
    <StatusBar>Status Bar</StatusBar>
    <Thumbnails>Thumbnails</Thumbnails>
    <title>Viewer</title>
    <titlePageSettings>Page Settings</titlePageSettings>
    <Toolbar>Tool Bar</Toolbar>
    <VerScrollBar>Vertical Scroll Bar</VerScrollBar>
    <ViewMode>View Mode</ViewMode>
    <Zoom>Zoom</Zoom>
    <ZoomMultiplePages>Multiple Pages</ZoomMultiplePages>
    <ZoomOnePage>One Page</ZoomOnePage>
    <ZoomPageWidth>Page Width</ZoomPageWidth>
    <ZoomTwoPages>Two Pages</ZoomTwoPages>
    <ZoomXXPages>{0} X {1} Pages</ZoomXXPages>
    <ZoomXXPagesCancel>Cancel</ZoomXXPagesCancel>
  </FormViewer>
  <FormViewerFind>
    <Close>Close</Close>
    <FindNext>Find Next</FindNext>
    <FindPrevious>Find Previous</FindPrevious>
    <FindWhat>Find What:</FindWhat>
  </FormViewerFind>
  <Gui>
    <barname_cancel>Cancel</barname_cancel>
    <barname_caption>New Toolbar</barname_caption>
    <barname_msginvalidname>Toolbar name cannot be empty.</barname_msginvalidname>
    <barname_name>&amp;Toolbar Name:</barname_name>
    <barname_ok>OK</barname_ok>
    <barrename_caption>Rename Toolbar</barrename_caption>
    <barsys_autohide_tooltip>Auto-Hide</barsys_autohide_tooltip>
    <barsys_close_tooltip>Close</barsys_close_tooltip>
    <barsys_customize_tooltip>Customize</barsys_customize_tooltip>
    <colorpicker_morecolors>&amp;More Colors...</colorpicker_morecolors>
    <colorpicker_nofill>&amp;No Fill</colorpicker_nofill>
    <colorpicker_standardcolorslabel>Standard Colors</colorpicker_standardcolorslabel>
    <colorpicker_themecolorslabel>Theme Colors</colorpicker_themecolorslabel>
    <colorpickerdialog_bluelabel>&amp;Blue:</colorpickerdialog_bluelabel>
    <colorpickerdialog_cancelbutton>Cancel</colorpickerdialog_cancelbutton>
    <colorpickerdialog_caption>Colors</colorpickerdialog_caption>
    <colorpickerdialog_colormodellabel>Color Model:</colorpickerdialog_colormodellabel>
    <colorpickerdialog_currentcolorlabel>Current</colorpickerdialog_currentcolorlabel>
    <colorpickerdialog_customcolorslabel>Colors:</colorpickerdialog_customcolorslabel>
    <colorpickerdialog_greenlabel>&amp;Green:</colorpickerdialog_greenlabel>
    <colorpickerdialog_newcolorlabel>New</colorpickerdialog_newcolorlabel>
    <colorpickerdialog_okbutton>OK</colorpickerdialog_okbutton>
    <colorpickerdialog_redlabel>&amp;Red:</colorpickerdialog_redlabel>
    <colorpickerdialog_rgblabel>RGB</colorpickerdialog_rgblabel>
    <colorpickerdialog_standardcolorslabel>Colors:</colorpickerdialog_standardcolorslabel>
    <colorpickerdialog_tabcustom>Custom</colorpickerdialog_tabcustom>
    <colorpickerdialog_tabstandard>Standard</colorpickerdialog_tabstandard>
    <cust_btn_close>Close</cust_btn_close>
    <cust_btn_delete>Delete</cust_btn_delete>
    <cust_btn_keyboard>&amp;Keyboard...</cust_btn_keyboard>
    <cust_btn_new>&amp;New...</cust_btn_new>
    <cust_btn_rename>&amp;Rename...</cust_btn_rename>
    <cust_btn_reset>&amp;Reset...</cust_btn_reset>
    <cust_btn_resetusage>&amp;Reset my usage data</cust_btn_resetusage>
    <cust_caption>Customize</cust_caption>
    <cust_cbo_fade>Fade</cust_cbo_fade>
    <cust_cbo_none>(None)</cust_cbo_none>
    <cust_cbo_random>Random</cust_cbo_random>
    <cust_cbo_slide>Slide</cust_cbo_slide>
    <cust_cbo_system>System Default</cust_cbo_system>
    <cust_cbo_unfold>Unfold</cust_cbo_unfold>
    <cust_chk_delay>Show full menus after a short delay</cust_chk_delay>
    <cust_chk_fullmenus>Always show full menus</cust_chk_fullmenus>
    <cust_chk_showsk>Show &amp;Shortcut Keys in ScreenTips</cust_chk_showsk>
    <cust_chk_showst>Show Screen&amp;Tips on Toolbars</cust_chk_showst>
    <cust_lbl_cats>Cate&amp;gories:</cust_lbl_cats>
    <cust_lbl_cmds>Comman&amp;ds:</cust_lbl_cmds>
    <cust_lbl_cmdsins>To add a command to Bar select the category and drag the command out of this box to a Bar.</cust_lbl_cmdsins>
    <cust_lbl_menuan>Menu Animation:</cust_lbl_menuan>
    <cust_lbl_other>Other:</cust_lbl_other>
    <cust_lbl_pmt>Personalized Menus and Toolbars</cust_lbl_pmt>
    <cust_lbl_tlbs>Toolb&amp;ars:</cust_lbl_tlbs>
    <cust_mnu_addremove>&amp;Add or Remove Buttons</cust_mnu_addremove>
    <cust_mnu_cust>Customize...</cust_mnu_cust>
    <cust_mnu_reset>Reset Bar</cust_mnu_reset>
    <cust_mnu_tooltip>Bar Options</cust_mnu_tooltip>
    <cust_msg_delete>Are you sure you want to delete the &lt;barname&gt; toolbar?</cust_msg_delete>
    <cust_pm_begingroup>Begin Group</cust_pm_begingroup>
    <cust_pm_delete>Delete</cust_pm_delete>
    <cust_pm_name>Name:</cust_pm_name>
    <cust_pm_reset>Reset</cust_pm_reset>
    <cust_pm_stydef>Default Style</cust_pm_stydef>
    <cust_pm_styimagetext>Image and Text (Always)</cust_pm_styimagetext>
    <cust_pm_stytextonly>Text Only (Always)</cust_pm_stytextonly>
    <cust_tab_commands>Commands</cust_tab_commands>
    <cust_tab_options>Options</cust_tab_options>
    <cust_tab_toolbars>Toolbars</cust_tab_toolbars>
    <mdisysmenu_close>Close</mdisysmenu_close>
    <mdisysmenu_maximize>Maximize</mdisysmenu_maximize>
    <mdisysmenu_minimize>Minimize</mdisysmenu_minimize>
    <mdisysmenu_move>Move</mdisysmenu_move>
    <mdisysmenu_next>Next</mdisysmenu_next>
    <mdisysmenu_restore>Restore</mdisysmenu_restore>
    <mdisysmenu_size>Size</mdisysmenu_size>
    <mdisystt_close>Close</mdisystt_close>
    <mdisystt_minimize>Minimize</mdisystt_minimize>
    <mdisystt_restore>Restore</mdisystt_restore>
    <monthcalendar_clearbutton>Clear</monthcalendar_clearbutton>
    <monthcalendar_todaybutton>Today</monthcalendar_todaybutton>
    <navbar_navpaneoptions>Na&amp;vigation Pane Options...</navbar_navpaneoptions>
    <navbar_showfewerbuttons>Show &amp;Fewer Buttons</navbar_showfewerbuttons>
    <navbar_showmorebuttons>Show &amp;More Buttons</navbar_showmorebuttons>
    <navPaneCollapseTooltip>Collapse the Navigation Pane</navPaneCollapseTooltip>
    <navPaneExpandTooltip>Expand the Navigation Pane</navPaneExpandTooltip>
    <sys_custombar>Custom Bar</sys_custombar>
    <sys_morebuttons>More Buttons</sys_morebuttons>
  </Gui>
  <HelpComponents>
    <StiBarCode>This component allows showing bar-codes in a report. Bar-code data are sent to an object as a string. The string may contain any symbols but only allowed symbols for the selected chart can be displayed.</StiBarCode>
    <StiChart>This component allows showing charts in a report. Different types of charts are available. Among them are bar, line, pie, doughnut, lines, areas, Gantt, scatter charts etc. </StiChart>
    <StiCheckBox>This component allows showing a checkbox in a report. It can display two modes: "enable" or "disable".</StiCheckBox>
    <StiChildBand>The Child band can be used to output two bands on one data row.</StiChildBand>
    <StiClone>This component is used to clone parts of a report into a required part of a report. Cloning can be applied only to the panel contents.</StiClone>
    <StiColumnFooterBand>This band is used to output footers of columns on the Data band. The ColumnFooter band is output once under each column. All components which are placed on this band will also be output under each column.</StiColumnFooterBand>
    <StiColumnHeaderBand>This band is used to column headers. The ColumnHeader band is used to output only once. All components which are placed on the band can be output above each column.</StiColumnHeaderBand>
    <StiContainer>This is the rectangular region where other components, including bands, can be placed. When moving the container the components in it will be moved too. The container can be placed both on a band and on a page.</StiContainer>
    <StiCrossDataBand>This band is connected to the data source. It is output as many times as there are rows in the data source. A Cross band is output from left to right.</StiCrossDataBand>
    <StiCrossFooterBand>This band is used to output footers of a CrossData band. The band is output once after all rows of the Data band. A Cross band is output from left to right.</StiCrossFooterBand>
    <StiCrossGroupFooterBand>This band is used to output footers of a group. It is placed under the CrossData band. Each CrossFooter belongs to the specified CrossHeader band. A Cross band is output from left to right.</StiCrossGroupFooterBand>
    <StiCrossGroupHeaderBand>This band is the basic one for the report rendering with grouping, when CrossData are used. It is impossible to create grouping without this band. The components for showing information by the group are placed on the group header. The information can be group name, date, condition of grouping etc. The band is output in the beginning of each group. A Cross band is output from left to right.</StiCrossGroupHeaderBand>
    <StiCrossHeaderBand>This band is used to output headers. It is used in association with the Cross band. A Cross band is output from left to right.</StiCrossHeaderBand>
    <StiCrossTab>The cross-tab component is used for the structured data representation as a table.</StiCrossTab>
    <StiDataBand>The Data band is connected to the data source and is output as many times as there are rows in the data source.</StiDataBand>
    <StiEmptyBand>This band is used to fill free space on the bottom of a page. This band fills free space on each page of a report.</StiEmptyBand>
    <StiFooterBand>This band is used to output summary by the Data band. It is placed under the Data band and is output once after all data rows which Data band outputs.</StiFooterBand>
    <StiGroupFooterBand>The GroupFooter band is used to output the group footer. This band is placed after the Data band. And this is the Data band with what the GroupHeader band is bound. Each GroupFooter band belongs to the specified GroupHeader band. The GroupFooter band will not be output without the GroupHeader band.</StiGroupFooterBand>
    <StiGroupHeaderBand>This band is the basic band for rendering reports with grouping. The components for showing information by this group are placed on the group header. It can be group name, date, condition of grouping etc. This band is output once in the beginning of each group.</StiGroupHeaderBand>
    <StiHeaderBand>This band is used to output headers. It is used together with the data band.</StiHeaderBand>
    <StiHierarchicalBand>This band is connected to the data source and output as many times as there are rows in the data source. Data are output as a tree.</StiHierarchicalBand>
    <StiHorizontalLinePrimitive>This component is used to output a line.</StiHorizontalLinePrimitive>
    <StiImage>This component is used to output images. It supports the following graphic formats, such as BMP, JPG, JPEG, GIF, TIFF, PNG, ICO, WMF, EMF.</StiImage>
    <StiOverlayBand>This band is used to output watermarks on a page.</StiOverlayBand>
    <StiPageFooterBand>This band is used to output the information on the bottom of each page such as page numbers, dates, and other additional information.</StiPageFooterBand>
    <StiPageHeaderBand>This band is used to output the page header such as page numbers, dates, and other additional information. It is output on the top of each page.</StiPageHeaderBand>
    <StiPanel>A rectangular region that can contain other components, including bands.  When the panel is moved the components in it are moved too.  A panel can be placed either on a band or on a page.</StiPanel>
    <StiRectanglePrimitive>This component is used to output rectangles.</StiRectanglePrimitive>
    <StiReportSummaryBand>This band is used to output summaries through the entire report. It is output once in the end of a report.</StiReportSummaryBand>
    <StiReportTitleBand>This band is used to output the report title. It is output in the beginning of a report.</StiReportTitleBand>
    <StiRichText>This component is used to output and edit the RTF text. It also supports loading and saving files in the RTF format.</StiRichText>
    <StiRoundedRectanglePrimitive>This component is used to output rounded rectangles.</StiRoundedRectanglePrimitive>
    <StiShape>This component is used to insert ready-made shapes, such as arrows, diagonal line down, diagonal line up, horizontal line, left and right lines, oval, rectangle, rounded rectangle, top and bottom lines, triangle, vertical line.</StiShape>
    <StiSubReport>This component is used to output additional data in different places of a report.</StiSubReport>
    <StiTable>This component is a set of data elements that is organized using a model of vertical columns and horizontal rows.</StiTable>
    <StiText>This component is a basic object to output data as a text.</StiText>
    <StiTextInCells>The component is used to output a text in cells. It is frequently used for creating forms.</StiTextInCells>
    <StiVerticalLinePrimitive>This component is used to output vertical lines.</StiVerticalLinePrimitive>
    <StiWinControl>The component allows showing visual controls from .NET Framework.</StiWinControl>
    <StiZipCode>This component is used to output the zip code.</StiZipCode>
  </HelpComponents>
  <HelpDesigner>
    <Align>Change the location of selected components.</Align>
    <AlignBottom>Align the contents of a component to bottom.</AlignBottom>
    <AlignCenter>Align the contents of a component to center.</AlignCenter>
    <AlignComponentBottom>Allows you to align objects horizontally along the bottom edge of selected components.</AlignComponentBottom>
    <AlignComponentCenter>Allows you to align objects horizontally along the center edge of selected components.</AlignComponentCenter>
    <AlignComponentLeft>Allows you to align objects vertically along the left edge of selected components.</AlignComponentLeft>
    <AlignComponentMiddle>Allows you to align objects vertically along the center edge of selected components.</AlignComponentMiddle>
    <AlignComponentRight>Allows you to align objects vertically along the right edge of selected components.</AlignComponentRight>
    <AlignComponentTop>Allows you to align objects horizontally along the top edge of selected components.</AlignComponentTop>
    <AlignLeft>Align the contents of a component to left.</AlignLeft>
    <AlignMiddle>Center the contents by the top and bottom borders of a component.</AlignMiddle>
    <AlignRight>Align contents of a component to right.</AlignRight>
    <AlignToGrid>Align the selected components to grid nodes.</AlignToGrid>
    <AlignTop>Align the contents of a component to top.</AlignTop>
    <AlignWidth>Justify the contents of a component.</AlignWidth>
    <Angle>Rotate the contents of the component.</Angle>
    <AngleWatermark>The watermark text rotation angle.</AngleWatermark>
    <Background>Change the background of the selected components.</Background>
    <biConditions>Control list of conditions of the selected components.</biConditions>
    <BorderColor>Select the border color of the selected component.</BorderColor>
    <BorderSidesAll>Switch on all borders sides of the selected components.</BorderSidesAll>
    <BorderSidesBottom>Switch on bottom border side of the selected components.</BorderSidesBottom>
    <BorderSidesLeft>Switch on left border side of the selected components.</BorderSidesLeft>
    <BorderSidesNone>Switch off all borders sides of the selected components.</BorderSidesNone>
    <BorderSidesRight>Switch on right border side of the selected components.</BorderSidesRight>
    <BorderSidesTop>Switch on top border side of the selected components.</BorderSidesTop>
    <BorderStyle>Select the border style of the selected components.</BorderStyle>
    <BringToFront>Bring the selected component to front.</BringToFront>
    <CenterHorizontally>Allows you to align a component horizontally relative to container edges in what it is placed.</CenterHorizontally>
    <CenterVertically>Allows you to align a component vertically relative to container edges in what it is placed.</CenterVertically>
    <Close>Close the Report Designer.</Close>
    <Columns>Split a page into columns.</Columns>
    <ComponentSize>Change the size of the selected components.</ComponentSize>
    <CopyToClipboard>Copy to Clipboard</CopyToClipboard>
    <CurrencySymbol>Select the currency symbol.</CurrencySymbol>
    <DataStore>Show data, registered in a report.</DataStore>
    <DateTimeFormat>Select the date and time format for the selected components.</DateTimeFormat>
    <DockingPanels>Panel settings.</DockingPanels>
    <DockStyleBottom>Dock selected components to bottom side.</DockStyleBottom>
    <DockStyleFill>Dock selected components to all sides.</DockStyleFill>
    <DockStyleLeft>Dock selected components to the left side.</DockStyleLeft>
    <DockStyleNone>Undock selected components.</DockStyleNone>
    <DockStyleRight>Dock selected components to the right side.</DockStyleRight>
    <DockStyleTop>Dock selected components to the top side.</DockStyleTop>
    <FontGrow>Make the text size larger.</FontGrow>
    <FontName>The text font.</FontName>
    <FontNameWatermark>The watermark text font.</FontNameWatermark>
    <FontShrink>Make the text size smaller.</FontShrink>
    <FontSize>Font size.</FontSize>
    <FontSizeWatermark>Change the font size.</FontSizeWatermark>
    <FontStyleBold>Make the text bold.</FontStyleBold>
    <FontStyleBoldWatermark>Make the text of the watermark bold.</FontStyleBoldWatermark>
    <FontStyleItalic>Make the text Italic.</FontStyleItalic>
    <FontStyleItalicWatermark>Make the watermark text Italic.</FontStyleItalicWatermark>
    <FontStyleUnderline>Make the text underlined.</FontStyleUnderline>
    <FontStyleUnderlineWatermark>Make the watermark text underlined.</FontStyleUnderlineWatermark>
    <FormatBoolean>This format is used to format values of the boolean type.</FormatBoolean>
    <FormatCurrency>Display a value as currency. It allows you to display a number with the default currency symbol.</FormatCurrency>
    <FormatCustom>This type is used to show values according to custom requirements. This type allows data formatting in the Format Mask.</FormatCustom>
    <FormatDate>Display a value as date. The date format is based on the regional date settings.</FormatDate>
    <FormatGeneral>Display a value without specific format.</FormatGeneral>
    <FormatNumber>It is used for general display of numbers.</FormatNumber>
    <FormatPercentage>Display a value as percentage. Numbers are multiplied by 100 to convert them to percentages.</FormatPercentage>
    <FormatTime>Display a value as time. The time format is based on the regional time settings.</FormatTime>
    <FormNew>Create a new dialog form.</FormNew>
    <GridMode>Show grid in lines or dots.</GridMode>
    <ImageAlignment>Put a watermark image on a page.</ImageAlignment>
    <ImageTransparency>Change the transparency of the watermark image.</ImageTransparency>
    <Link>Link the component to the current container.</Link>
    <LoadImage>Load watermark images from the file.</LoadImage>
    <Lock>Lock the component. The component cannot be moved and resized.</Lock>
    <MainMenu>Click here to see the list of possible operations with a report, including opening, closing, and previewing.</MainMenu>
    <MakeHorizontalSpacingEqual>Allows you to set equal horizontal spacing between selected components.</MakeHorizontalSpacingEqual>
    <MakeVerticalSpacingEqual>Allows you to set equal vertical spacing between selected components.</MakeVerticalSpacingEqual>
    <Margins>Select the margins of the current page.</Margins>
    <menuCheckIssues>Check through a report to find errors, warnings and get recommendations.</menuCheckIssues>
    <menuDesignerOptions>Setup report designer options.</menuDesignerOptions>
    <menuEditClearContents>Clear the contents.</menuEditClearContents>
    <menuEditCopy>Copy the selected components and put them on the Clipboard.</menuEditCopy>
    <menuEditCut>Cut the selected components from a report and put them on the Clipboard.</menuEditCut>
    <menuEditDelete>Delete selected components.</menuEditDelete>
    <menuEditPaste>Paste the contents of the Clipboard into report.</menuEditPaste>
    <menuFAQPage>Go to the web page with frequently asked questions.</menuFAQPage>
    <menuGlobalizationStrings>Call the Globalization Strings editor of the current report.</menuGlobalizationStrings>
    <menuHelpAboutProgramm>Get information about the version of report generator and the version of .Net Framework.</menuHelpAboutProgramm>
    <menuHomePage>Go the Home page of the product.</menuHomePage>
    <menuPageOptions>Setup the basic parameters of the current page. All page options can be changed using the Property panel.</menuPageOptions>
    <menuPagesManager>Run the Pages Manager. It allow moving pages, deleting pages, and creating new pages.</menuPagesManager>
    <menuPreviewSettings>Call the Preview Settings editor of the current report. Settings will be applied only when viewing the current report.</menuPreviewSettings>
    <menuPrint>Select a printer, number of copies, and other printing options before printing.</menuPrint>
    <menuPrintPreview>Preview a report before printing.</menuPrintPreview>
    <menuPrintQuick>Print a report directly to the default printer. Printing dialog is not displayed.</menuPrintQuick>
    <menuReportOptions>Setup the basic report options. All options can be changed using the Property panel.</menuReportOptions>
    <menuStyleDesigner>Call the Style Designer of the current report.</menuStyleDesigner>
    <menuSupport>Go to the support page to ask a question.</menuSupport>
    <menuViewAlignToGrid>Align components to grid.</menuViewAlignToGrid>
    <menuViewNormal>Normal view of a page.</menuViewNormal>
    <menuViewPageBreakPreview>The mode of showing a page with borders of segments.</menuViewPageBreakPreview>
    <menuViewQuickInfo>Show quick information of components: component name, alias, contents, events etc.</menuViewQuickInfo>
    <menuViewShowGrid>Turn on grid lines to which you can align objects in a report.</menuViewShowGrid>
    <menuViewShowHeaders>Show headers of bands.</menuViewShowHeaders>
    <menuViewShowOrder>Show order of components on a page.</menuViewShowOrder>
    <menuViewShowRulers>View the rulers, used to measure and line up objects on a page.</menuViewShowRulers>
    <MoveBackward>Move a component to one level higher in order of placing components on a page.</MoveBackward>
    <MoveForward>Move a component to one level lower in order of placing components on a page.</MoveForward>
    <Orientation>Switch the pages between portrait and landscape layouts.</Orientation>
    <PageDelete>Delete current page from a report.</PageDelete>
    <PageNew>Create a new page.</PageNew>
    <PageSetup>Show the Page Setup dialog box.</PageSetup>
    <PageSize>Choose the paper size for the current page of a report.</PageSize>
    <PagesManager>Run the Pages Manager.</PagesManager>
    <Redo>Redo the previously canceled change in a report.</Redo>
    <ReportNew>Create a new report.</ReportNew>
    <ReportOpen>Open a report in designer.</ReportOpen>
    <ReportPreview>Preview an edited report in viewer.</ReportPreview>
    <ReportSave>Save currently edited report.</ReportSave>
    <SelectAll>Select all components on the current page.</SelectAll>
    <SelectUILanguage>Select the UI language.</SelectUILanguage>
    <SendToBack>Move the selected component to back relative to other components.</SendToBack>
    <ServicesConfigurator>Run the Services Configurator.</ServicesConfigurator>
    <Shadow>Show the shadow of a component.</Shadow>
    <ShowBehind>Show the watermark text behind the components.</ShowBehind>
    <ShowImageBehind>Put the watermark image behind all components on a page.</ShowImageBehind>
    <ShowToolbox>Show the toolbox.</ShowToolbox>
    <StyleDesigner>Run Style Designer.</StyleDesigner>
    <Text>Watermark text.</Text>
    <TextBrush>Change the text color.</TextBrush>
    <TextBrushWatermark>Change the text color of the watermark.</TextBrushWatermark>
    <TextColor>Change the text color.</TextColor>
    <TextFormat>Select the format of values.</TextFormat>
    <ToolbarStyle>Set selected style to all selected components.</ToolbarStyle>
    <Undo>Undo the latest change in a report.</Undo>
    <WordWrap>Wrap the text of a component.</WordWrap>
    <Zoom>Specify the zoom level of the report.</Zoom>
  </HelpDesigner>
  <HelpDialogs>
    <StiButtonControl>Represents the Button control.</StiButtonControl>
    <StiCheckBoxControl>Represents the Flag control.</StiCheckBoxControl>
    <StiCheckedListBoxControl>Shows the List object, in what a flag on the left is shown for each elements.</StiCheckedListBoxControl>
    <StiComboBoxControl>Represents the ComboBox that is used to either type a value directly into the control or choose from the list of existing options.</StiComboBoxControl>
    <StiDateTimePickerControl>Represents the control that allows selecting the date and time. It also allows you to output the date and time in specified format.</StiDateTimePickerControl>
    <StiGridControl>Represents the Grid control that consist of rows and columns.</StiGridControl>
    <StiGroupBoxControl>Represents the control that creates a container with borders and a header for the UI content.</StiGroupBoxControl>
    <StiLabelControl>A label is a user interface control which displays text on a form. It is usually a static control having no interactivity.</StiLabelControl>
    <StiListBoxControl>Contains the list of elements for selection.</StiListBoxControl>
    <StiListViewControl>Represents the ListView control that shows the list of data elements.</StiListViewControl>
    <StiLookUpBoxControl>Contains the list of elements for selection.</StiLookUpBoxControl>
    <StiNumericUpDownControl>Represents the control that shows numeric values.</StiNumericUpDownControl>
    <StiPanelControl>The Panel elements are used for placing and arrangement objects.</StiPanelControl>
    <StiPictureBoxControl>Represents the control for showing an image.</StiPictureBoxControl>
    <StiRadioButtonControl>Represents the Radio button control that allows the user to choose only one of a predefined set of options. </StiRadioButtonControl>
    <StiRichTextBoxControl>Represents the RichText control with widen editing.</StiRichTextBoxControl>
    <StiTextBoxControl>Represents the Text control that is used for showing or editing a text.</StiTextBoxControl>
    <StiTreeViewControl>Represents the control that is used to show the hierachical data as a tree.</StiTreeViewControl>
  </HelpDialogs>
  <HelpViewer>
    <Bookmarks>Show the bookmark panel that is used for quick navigation to jump directly to a bookmarked location.</Bookmarks>
    <Close>Close Preview of report.</Close>
    <CloseDotMatrix>Close Dot Matrix Viewer of report.</CloseDotMatrix>
    <DotMatrixMode>This mode allows you to see how will a report look like if to print it on a dot matrix printer.</DotMatrixMode>
    <Edit>Edit components.</Edit>
    <Find>Search a text through a report.</Find>
    <FullScreen>Full screen reading.</FullScreen>
    <Open>Open the previously saved report in the window of preview.</Open>
    <PageDelete>Delete the selected page of a report.</PageDelete>
    <PageDesign>Edit the selected page in the report designer.</PageDesign>
    <PageFirst>Go to the first page of a report.</PageFirst>
    <PageGoTo>Go to the specified report page.</PageGoTo>
    <PageLast>Go to the last page of a report.</PageLast>
    <PageNew>Add a new page to a report.</PageNew>
    <PageNext>Go to the next page of a report.</PageNext>
    <PagePrevious>Go to the previous page of a report.</PagePrevious>
    <PageSize>Change the page parameters in a report.</PageSize>
    <Parameters>Showing parameters panel which is used when report rendering.</Parameters>
    <Print>Print a report.</Print>
    <Save>Save a report for further using.</Save>
    <SendEMail>Send a report via e-mail.</SendEMail>
    <Thumbnails>Show the thumbnails that can be used for quick navigation to find the section of the report that you want to jump to.</Thumbnails>
    <ToolEditor>This tool allows you edit contents of text components directly in report viewer.</ToolEditor>
    <ViewModeContinuous>Show all report pages as a vertical ribbon.</ViewModeContinuous>
    <ViewModeMultiplePages>Zoom the report so that as many pages as can be fit in window are displayed.</ViewModeMultiplePages>
    <ViewModeSinglePage>Show a single page in the window of preview.</ViewModeSinglePage>
    <ZoomMultiplePages>Zoom the report so that the selected pages fit in the window.</ZoomMultiplePages>
    <ZoomOnePage>Zoom the report so that an entire page fits in the window.</ZoomOnePage>
    <ZoomPageWidth>Zoom the report so that the width of the page matches the width of the window.</ZoomPageWidth>
    <ZoomTwoPages>Zoom the report so that two pages fit in the window.</ZoomTwoPages>
  </HelpViewer>
  <MainMenu>
    <menuCheckIssues>Check for Issues</menuCheckIssues>
    <menuContextClone>Clone...</menuContextClone>
    <menuContextDesign>Design...</menuContextDesign>
    <menuContextTextFormat>Text Format...</menuContextTextFormat>
    <menuDeleteColumn>Delete Column</menuDeleteColumn>
    <menuDeleteRow>Delete Row</menuDeleteRow>
    <menuEdit>&amp;Edit</menuEdit>
    <menuEditBusinessObjectNew>New Business Object...</menuEditBusinessObjectNew>
    <menuEditBusinessObjectFromDataSetNew>New Business Object From DataSet...</menuEditBusinessObjectFromDataSetNew>
    <menuEditCalcColumnNew>New Calculated Column...</menuEditCalcColumnNew>
    <menuEditCantRedo>Can't Redo</menuEditCantRedo>
    <menuEditCantUndo>Can't Undo</menuEditCantUndo>
    <menuEditCategoryNew>New Category...</menuEditCategoryNew>
    <menuEditClearContents>Clear Contents</menuEditClearContents>
    <menuEditColumnNew>New Column...</menuEditColumnNew>
    <menuEditConnectionNew>New Connection...</menuEditConnectionNew>
    <menuEditCopy>&amp;Copy</menuEditCopy>
    <menuEditCut>Cu&amp;t</menuEditCut>
    <menuEditDataParameterNew>New Parameter...</menuEditDataParameterNew>
    <menuEditDataSourceNew>New Data Source...</menuEditDataSourceNew>
    <menuEditDataSourcesNew>New Data Sources...</menuEditDataSourcesNew>
    <menuEditDelete>&amp;Delete</menuEditDelete>
    <menuEditEdit>Edit</menuEditEdit>
    <menuEditImportRelations>Import Relations...</menuEditImportRelations>
    <menuEditPaste>&amp;Paste</menuEditPaste>
    <menuEditRedo>&amp;Redo</menuEditRedo>
    <menuEditRedoText>&amp;Redo {0}</menuEditRedoText>
    <menuEditRelationNew>New Relation...</menuEditRelationNew>
    <menuEditRemoveUnused>Remove Unused Items</menuEditRemoveUnused>
    <menuEditSelectAll>Select &amp;All</menuEditSelectAll>
    <menuEditSynchronize>Synchronize</menuEditSynchronize>
    <menuEditUndo>&amp;Undo</menuEditUndo>
    <menuEditUndoText>&amp;Undo {0}</menuEditUndoText>
    <menuEditVariableNew>New Variable...</menuEditVariableNew>
    <menuEditViewData>View Data...</menuEditViewData>
    <menuFile>&amp;File</menuFile>
    <menuFileClose>&amp;Close</menuFileClose>
    <menuFileExit>E&amp;xit</menuFileExit>
    <menuFileExportXMLSchema>Export XML Schema...</menuFileExportXMLSchema>
    <menuFileFormNew>New Form</menuFileFormNew>
    <menuFileImportXMLSchema>Import XML Schema...</menuFileImportXMLSchema>
    <menuFileMerge>Merge...</menuFileMerge>
    <menuFileMergeXMLSchema>Merge XML Schema...</menuFileMergeXMLSchema>
    <menuFileNew>&amp;New</menuFileNew>
    <menuFileOpen>&amp;Open...</menuFileOpen>
    <menuFilePageDelete>Delete Page</menuFilePageDelete>
    <menuFilePageNew>New Page</menuFilePageNew>
    <menuFilePageOpen>Open Page...</menuFilePageOpen>
    <menuFilePageSaveAs>Save Page As...</menuFilePageSaveAs>
    <menuFilePageSetup>Page Setup...</menuFilePageSetup>
    <menuFileRecentDocuments>Recent Documents</menuFileRecentDocuments>
    <menuFileRecentLocations>Recent Locations</menuFileRecentLocations>
    <menuFileReportNew>&amp;New Report...</menuFileReportNew>
    <menuFileReportOpen>&amp;Open Report...</menuFileReportOpen>
    <menuFileReportOpenFromGoogleDocs>Open Report from Google Docs...</menuFileReportOpenFromGoogleDocs>
    <menuFileReportPreview>&amp;Preview</menuFileReportPreview>
    <menuFileReportSave>&amp;Save Report</menuFileReportSave>
    <menuFileReportSaveAs>Save Report &amp;As...</menuFileReportSaveAs>
    <menuFileReportSaveAsToGoogleDocs>Save Report As to Google Docs...</menuFileReportSaveAsToGoogleDocs>
    <menuFileReportSetup>Report &amp;Setup...</menuFileReportSetup>
    <menuFileReportWizardNew>New Report with &amp;Wizard...</menuFileReportWizardNew>
    <menuFileSaveAs>Save As...</menuFileSaveAs>
    <menuHelp>&amp;Help</menuHelp>
    <menuHelpAboutProgramm>&amp;About...</menuHelpAboutProgramm>
    <menuHelpContents>&amp;Contents...</menuHelpContents>
    <menuHelpFAQPage>FAQ Page</menuHelpFAQPage>
    <menuHelpHowToRegister>How to Register</menuHelpHowToRegister>
    <menuHelpProductHomePage>Product Home Page</menuHelpProductHomePage>
    <menuHelpSupport>&amp;Support</menuHelpSupport>
    <menuInsertColumnToLeft>Insert Column To Left</menuInsertColumnToLeft>
    <menuInsertColumnToRight>Insert Column To Right</menuInsertColumnToRight>
    <menuInsertRowAbove>Insert Row Above</menuInsertRowAbove>
    <menuInsertRowBelow>Insert Row Below</menuInsertRowBelow>
    <menuJoinCells>Join Cells</menuJoinCells>
    <menuSelectColumn>Select Column</menuSelectColumn>
    <menuSelectRow>Select Row</menuSelectRow>
    <menuTable>Table</menuTable>
    <menuTools>&amp;Tools</menuTools>
    <menuToolsDataStore>Data &amp;Store...</menuToolsDataStore>
    <menuToolsDictionary>&amp;Dictionary...</menuToolsDictionary>
    <menuToolsOptions>&amp;Options...</menuToolsOptions>
    <menuToolsPagesManager>&amp;Pages Manager...</menuToolsPagesManager>
    <menuToolsServicesConfigurator>Services &amp;Configurator...</menuToolsServicesConfigurator>
    <menuToolsStyleDesigner>Style &amp;Designer...</menuToolsStyleDesigner>
    <menuView>&amp;View</menuView>
    <menuViewAlignToGrid>Align to Grid</menuViewAlignToGrid>
    <menuViewNormal>&amp;Normal</menuViewNormal>
    <menuViewOptions>Options</menuViewOptions>
    <menuViewPageBreakPreview>Page &amp;Break Preview</menuViewPageBreakPreview>
    <menuViewQuickInfo>Quick Info</menuViewQuickInfo>
    <menuViewQuickInfoNone>None</menuViewQuickInfoNone>
    <menuViewQuickInfoOverlay>Display Over Components</menuViewQuickInfoOverlay>
    <menuViewQuickInfoShowAliases>Show Aliases</menuViewQuickInfoShowAliases>
    <menuViewQuickInfoShowComponentsNames>Show Components Names</menuViewQuickInfoShowComponentsNames>
    <menuViewQuickInfoShowContent>Show Content</menuViewQuickInfoShowContent>
    <menuViewQuickInfoShowEvents>Show Events</menuViewQuickInfoShowEvents>
    <menuViewQuickInfoShowFields>Show Fields</menuViewQuickInfoShowFields>
    <menuViewQuickInfoShowFieldsOnly>Show Fields Only</menuViewQuickInfoShowFieldsOnly>
    <menuViewShowGrid>Show Grid</menuViewShowGrid>
    <menuViewShowHeaders>Show Headers</menuViewShowHeaders>
    <menuViewShowOrder>Show Order</menuViewShowOrder>
    <menuViewShowRulers>Show Rulers</menuViewShowRulers>
    <menuViewToolbars>Toolbars</menuViewToolbars>
  </MainMenu>
  <Panels>
    <Dictionary>Dictionary</Dictionary>
    <Messages>Messages</Messages>
    <Properties>Properties</Properties>
    <ReportTree>Report Tree</ReportTree>
  </Panels>
  <Password>
    <gbPassword>Encrypting of file</gbPassword>
    <lbPasswordLoad>Enter the password to open a file</lbPasswordLoad>
    <lbPasswordSave>Password:</lbPasswordSave>
    <PasswordNotEntered>The password is not entered</PasswordNotEntered>
    <StiLoadPasswordForm>Document encrypting</StiLoadPasswordForm>
    <StiSavePasswordForm>Password</StiSavePasswordForm>
  </Password>
  <PlacementComponent>
    <MoveLeftFreeSpace>Moves a component to the left side of a free space, increasing the height of the component to the height of free space.</MoveLeftFreeSpace>
    <MoveRightFreeSpace>Moves a component to the right side of a free space, increasing the height of the component to the height of free space.</MoveRightFreeSpace>
  </PlacementComponent>
  <PropertyCategory>
    <AppearanceCategory>Appearance</AppearanceCategory>
    <ArgumentCategory>Argument</ArgumentCategory>
    <BarCodeAdditionalCategory>Bar Code Additional</BarCodeAdditionalCategory>
    <BarCodeCategory>Bar Code</BarCodeCategory>
    <BehaviorCategory>Behavior</BehaviorCategory>
    <CellCategory>Cell</CellCategory>
    <ChartAdditionalCategory>Chart Additional</ChartAdditionalCategory>
    <ChartCategory>Chart</ChartCategory>
    <CheckCategory>Check</CheckCategory>
    <ColorsCategory>Colors</ColorsCategory>
    <ColumnsCategory>Columns</ColumnsCategory>
    <ControlCategory>Control</ControlCategory>
    <ControlsEventsCategory>Controls Events</ControlsEventsCategory>
    <CrossTabCategory>Cross-Tab</CrossTabCategory>
    <DataCategory>Data</DataCategory>
    <DescriptionCategory>Description</DescriptionCategory>
    <DesignCategory>Design</DesignCategory>
    <DisplayCategory>Display</DisplayCategory>
    <ExportCategory>Export</ExportCategory>
    <ExportEventsCategory>Export Events</ExportEventsCategory>
    <HierarchicalCategory>Hierarchical</HierarchicalCategory>
    <ImageAdditionalCategory>Image Additional</ImageAdditionalCategory>
    <ImageCategory>Image</ImageCategory>
    <MainCategory>Main</MainCategory>
    <MarkerCategory>Marker</MarkerCategory>
    <MiscCategory>Misc</MiscCategory>
    <MouseEventsCategory>Mouse Events</MouseEventsCategory>
    <NavigationCategory>Navigation</NavigationCategory>
    <NavigationEventsCategory>Navigation Events</NavigationEventsCategory>
    <OptionsCategory>Options</OptionsCategory>
    <PageAdditionalCategory>Page Additional</PageAdditionalCategory>
    <PageCategory>Page</PageCategory>
    <PageColumnBreakCategory>Page and Column Break</PageColumnBreakCategory>
    <ParametersCategory>Parameters</ParametersCategory>
    <PositionCategory>Position</PositionCategory>
    <PrimitiveCategory>Primitive</PrimitiveCategory>
    <PrintEventsCategory>Print Events</PrintEventsCategory>
    <RenderEventsCategory>Render Events</RenderEventsCategory>
    <ShapeCategory>Shape</ShapeCategory>
    <SubReportCategory>Sub-Report</SubReportCategory>
    <TextAdditionalCategory>Text Additional</TextAdditionalCategory>
    <TextCategory>Text</TextCategory>
    <TitleCategory>Title</TitleCategory>
    <ValueCategory>Value</ValueCategory>
    <ValueCloseCategory>Value Close</ValueCloseCategory>
    <ValueEndCategory>Value End</ValueEndCategory>
    <ValueEventsCategory>Value Events</ValueEventsCategory>
    <ValueOpenCategory>Value Open</ValueOpenCategory>
    <ValueHighCategory>Value High</ValueHighCategory>
    <ValueLowCategory>Value Low</ValueLowCategory>
    <WeightCategory>Weight</WeightCategory>
    <WinControlCategory>Win Control</WinControlCategory>
    <ZipCodeCategory>Zip Code</ZipCodeCategory>
  </PropertyCategory>
  <PropertyColor>
    <AliceBlue>Alice Blue</AliceBlue>
    <AntiqueWhite>Antique White</AntiqueWhite>
    <Aqua>Aqua</Aqua>
    <Aquamarine>Aquamarine</Aquamarine>
    <Azure>Azure</Azure>
    <Beige>Beige</Beige>
    <Bisque>Bisque</Bisque>
    <Black>Black</Black>
    <BlanchedAlmond>Blanched Almond</BlanchedAlmond>
    <Blue>Blue</Blue>
    <BlueViolet>Blue Violet</BlueViolet>
    <Brown>Brown</Brown>
    <BurlyWood>Burly Wood</BurlyWood>
    <CadetBlue>Cadet Blue</CadetBlue>
    <Chartreuse>Chartreuse</Chartreuse>
    <Chocolate>Chocolate</Chocolate>
    <Coral>Coral</Coral>
    <CornflowerBlue>Cornflower Blue</CornflowerBlue>
    <Cornsilk>Cornsilk</Cornsilk>
    <Crimson>Crimson</Crimson>
    <Cyan>Cyan</Cyan>
    <DarkBlue>Dark Blue</DarkBlue>
    <DarkCyan>Dark Cyan</DarkCyan>
    <DarkGoldenrod>Dark Goldenrod</DarkGoldenrod>
    <DarkGray>Dark Gray</DarkGray>
    <DarkGreen>Dark Green</DarkGreen>
    <DarkKhaki>Dark Khaki</DarkKhaki>
    <DarkMagenta>Dark Magenta</DarkMagenta>
    <DarkOliveGreen>Dark Olive Green</DarkOliveGreen>
    <DarkOrange>Dark Orange</DarkOrange>
    <DarkOrchid>Dark Orchid</DarkOrchid>
    <DarkRed>Dark Red</DarkRed>
    <DarkSalmon>Dark Salmon</DarkSalmon>
    <DarkSeaGreen>Dark Sea Green</DarkSeaGreen>
    <DarkSlateBlue>Dark Slate Blue</DarkSlateBlue>
    <DarkSlateGray>Dark Slate Gray</DarkSlateGray>
    <DarkTurquoise>Dark Turquoise</DarkTurquoise>
    <DarkViolet>Dark Violet</DarkViolet>
    <DeepPink>Deep Pink</DeepPink>
    <DeepSkyBlue>Deep Sky Blue</DeepSkyBlue>
    <DimGray>Dim Gray</DimGray>
    <DodgerBlue>Dodger Blue</DodgerBlue>
    <Firebrick>Firebrick</Firebrick>
    <FloralWhite>Floral White</FloralWhite>
    <ForestGreen>Forest Green</ForestGreen>
    <Fuchsia>Fuchsia</Fuchsia>
    <Gainsboro>Gainsboro</Gainsboro>
    <GhostWhite>Ghost White</GhostWhite>
    <Gold>Gold</Gold>
    <Goldenrod>Goldenrod</Goldenrod>
    <Gray>Gray</Gray>
    <Green>Green</Green>
    <GreenYellow>Green Yellow</GreenYellow>
    <Honeydew>Honeydew</Honeydew>
    <HotPink>Hot Pink</HotPink>
    <IndianRed>Indian Red</IndianRed>
    <Indigo>Indigo</Indigo>
    <Ivory>Ivory</Ivory>
    <Khaki>Khaki</Khaki>
    <Lavender>Lavender</Lavender>
    <LavenderBlush>Lavender Blush</LavenderBlush>
    <LawnGreen>Lawn Green</LawnGreen>
    <LemonChiffon>Lemon Chiffon</LemonChiffon>
    <LightBlue>Light Blue</LightBlue>
    <LightCoral>Light Coral</LightCoral>
    <LightCyan>Light Cyan</LightCyan>
    <LightGoldenrodYellow>Light Goldenrod Yellow</LightGoldenrodYellow>
    <LightGray>Light Gray</LightGray>
    <LightGreen>Light Green</LightGreen>
    <LightPink>Light Pink</LightPink>
    <LightSalmon>Light Salmon</LightSalmon>
    <LightSeaGreen>Light Sea Green</LightSeaGreen>
    <LightSkyBlue>Light Sky Blue</LightSkyBlue>
    <LightSlateGray>Light Slate Gray</LightSlateGray>
    <LightSteelBlue>Light Steel Blue</LightSteelBlue>
    <LightYellow>Light Yellow</LightYellow>
    <Lime>Lime</Lime>
    <LimeGreen>Lime Green</LimeGreen>
    <Linen>Linen</Linen>
    <Magenta>Magenta</Magenta>
    <Maroon>Maroon</Maroon>
    <MediumAquamarine>Medium Aquamarine</MediumAquamarine>
    <MediumBlue>Medium Blue</MediumBlue>
    <MediumOrchid>Medium Orchid</MediumOrchid>
    <MediumPurple>Medium Purple</MediumPurple>
    <MediumSeaGreen>Medium Sea Green</MediumSeaGreen>
    <MediumSlateBlue>Medium Slate Blue</MediumSlateBlue>
    <MediumSpringGreen>Medium Spring Green</MediumSpringGreen>
    <MediumTurquoise>Medium Turquoise</MediumTurquoise>
    <MediumVioletRed>Medium Violet Red</MediumVioletRed>
    <MidnightBlue>Midnight Blue</MidnightBlue>
    <MintCream>Mint Cream</MintCream>
    <MistyRose>Misty Rose</MistyRose>
    <Moccasin>Moccasin</Moccasin>
    <NavajoWhite>Navajo White</NavajoWhite>
    <Navy>Navy</Navy>
    <OldLace>Old Lace</OldLace>
    <Olive>Olive</Olive>
    <OliveDrab>Olive Drab</OliveDrab>
    <Orange>Orange</Orange>
    <OrangeRed>Orange Red</OrangeRed>
    <Orchid>Orchid</Orchid>
    <PaleGoldenrod>Pale Goldenrod</PaleGoldenrod>
    <PaleGreen>Pale Green</PaleGreen>
    <PaleTurquoise>Pale Turquoise</PaleTurquoise>
    <PaleVioletRed>Pale Violet Red</PaleVioletRed>
    <PapayaWhip>Papaya Whip</PapayaWhip>
    <PeachPuff>Peach Puff</PeachPuff>
    <Peru>Peru</Peru>
    <Pink>Pink</Pink>
    <Plum>Plum</Plum>
    <PowderBlue>Powder Blue</PowderBlue>
    <Purple>Purple</Purple>
    <Red>Red</Red>
    <RosyBrown>Rosy Brown</RosyBrown>
    <RoyalBlue>Royal Blue</RoyalBlue>
    <SaddleBrown>Saddle Brown</SaddleBrown>
    <Salmon>Salmon</Salmon>
    <SandyBrown>Sandy Brown</SandyBrown>
    <SeaGreen>Sea Green</SeaGreen>
    <SeaShell>Sea Shell</SeaShell>
    <Sienna>Sienna</Sienna>
    <Silver>Silver</Silver>
    <SkyBlue>Sky Blue</SkyBlue>
    <SlateBlue>Slate Blue</SlateBlue>
    <SlateGray>Slate Gray</SlateGray>
    <Snow>Snow</Snow>
    <SpringGreen>Spring Green</SpringGreen>
    <SteelBlue>Steel Blue</SteelBlue>
    <Tan>Tan</Tan>
    <Teal>Teal</Teal>
    <Thistle>Thistle</Thistle>
    <Tomato>Tomato</Tomato>
    <Transparent>Transparent</Transparent>
    <Turquoise>Turquoise</Turquoise>
    <Violet>Violet</Violet>
    <Wheat>Wheat</Wheat>
    <White>White</White>
    <WhiteSmoke>White Smoke</WhiteSmoke>
    <Yellow>Yellow</Yellow>
    <YellowGreen>Yellow Green</YellowGreen>
  </PropertyColor>
  <PropertyEnum>
    <boolFalse>False</boolFalse>
    <boolTrue>True</boolTrue>
    <BorderStyleFixed3D>Fixed 3D</BorderStyleFixed3D>
    <BorderStyleFixedSingle>Fixed Single</BorderStyleFixedSingle>
    <BorderStyleNone>None</BorderStyleNone>
    <ChartAxesTicksAll>All</ChartAxesTicksAll>
    <ChartAxesTicksMajor>Major</ChartAxesTicksMajor>
    <ChartAxesTicksNone>None</ChartAxesTicksNone>
    <ChartGridLinesAll>All</ChartGridLinesAll>
    <ChartGridLinesMajor>Major</ChartGridLinesMajor>
    <ChartGridLinesNone>None</ChartGridLinesNone>
    <ComboBoxStyleDropDown>Drop Down</ComboBoxStyleDropDown>
    <ComboBoxStyleDropDownList>Drop Down List</ComboBoxStyleDropDownList>
    <ComboBoxStyleSimple>Simple</ComboBoxStyleSimple>
    <ContentAlignmentBottomCenter>Bottom Center</ContentAlignmentBottomCenter>
    <ContentAlignmentBottomLeft>Bottom Left</ContentAlignmentBottomLeft>
    <ContentAlignmentBottomRight>Bottom Right</ContentAlignmentBottomRight>
    <ContentAlignmentMiddleCenter>Middle Center</ContentAlignmentMiddleCenter>
    <ContentAlignmentMiddleLeft>Middle Left</ContentAlignmentMiddleLeft>
    <ContentAlignmentMiddleRight>Middle Right</ContentAlignmentMiddleRight>
    <ContentAlignmentTopCenter>Top Center</ContentAlignmentTopCenter>
    <ContentAlignmentTopLeft>Top Left</ContentAlignmentTopLeft>
    <ContentAlignmentTopRight>Top Right</ContentAlignmentTopRight>
    <DataGridLineStyleNone>None</DataGridLineStyleNone>
    <DataGridLineStyleSolid>Solid</DataGridLineStyleSolid>
    <DateTimePickerFormatCustom>Custom</DateTimePickerFormatCustom>
    <DateTimePickerFormatLong>Long</DateTimePickerFormatLong>
    <DateTimePickerFormatShort>Short</DateTimePickerFormatShort>
    <DateTimePickerFormatTime>Time</DateTimePickerFormatTime>
    <DialogResultAbort>Abort</DialogResultAbort>
    <DialogResultCancel>Cancel</DialogResultCancel>
    <DialogResultIgnore>Ignore</DialogResultIgnore>
    <DialogResultNo>No</DialogResultNo>
    <DialogResultNone>None</DialogResultNone>
    <DialogResultOK>OK</DialogResultOK>
    <DialogResultRetry>Retry</DialogResultRetry>
    <DialogResultYes>Yes</DialogResultYes>
    <DuplexDefault>Default</DuplexDefault>
    <DuplexHorizontal>Horizontal</DuplexHorizontal>
    <DuplexSimplex>Simplex</DuplexSimplex>
    <DuplexVertical>Vertical</DuplexVertical>
    <FormStartPositionCenterParent>Center Parent</FormStartPositionCenterParent>
    <FormStartPositionCenterScreen>Center Screen</FormStartPositionCenterScreen>
    <FormStartPositionManual>Manual</FormStartPositionManual>
    <FormStartPositionWindowsDefaultBounds>Windows Default Bounds</FormStartPositionWindowsDefaultBounds>
    <FormStartPositionWindowsDefaultLocation>Windows Default Location</FormStartPositionWindowsDefaultLocation>
    <FormWindowStateMaximized>Maximized</FormWindowStateMaximized>
    <FormWindowStateMinimized>Minimized</FormWindowStateMinimized>
    <FormWindowStateNormal>Normal</FormWindowStateNormal>
    <HorizontalAlignmentCenter>Center</HorizontalAlignmentCenter>
    <HorizontalAlignmentLeft>Left</HorizontalAlignmentLeft>
    <HorizontalAlignmentRight>Right</HorizontalAlignmentRight>
    <HotkeyPrefixHide>Hide</HotkeyPrefixHide>
    <HotkeyPrefixNone>None</HotkeyPrefixNone>
    <HotkeyPrefixShow>Show</HotkeyPrefixShow>
    <LeftRightAlignmentLeft>Left</LeftRightAlignmentLeft>
    <LeftRightAlignmentRight>Right</LeftRightAlignmentRight>
    <PictureBoxSizeModeAutoSize>Auto Size</PictureBoxSizeModeAutoSize>
    <PictureBoxSizeModeCenterImage>Center Image</PictureBoxSizeModeCenterImage>
    <PictureBoxSizeModeNormal>Normal</PictureBoxSizeModeNormal>
    <PictureBoxSizeModeStretchImage>Stretch Image</PictureBoxSizeModeStretchImage>
    <RightToLeftInherit>Inherit</RightToLeftInherit>
    <RightToLeftNo>No</RightToLeftNo>
    <RightToLeftYes>Yes</RightToLeftYes>
    <SelectionModeMultiExtended>Multi Extended</SelectionModeMultiExtended>
    <SelectionModeMultiSimple>Multi Simple</SelectionModeMultiSimple>
    <SelectionModeNone>None</SelectionModeNone>
    <SelectionModeOne>One</SelectionModeOne>
    <StiAngleAngle0>0 Degrees</StiAngleAngle0>
    <StiAngleAngle180>180 Degrees</StiAngleAngle180>
    <StiAngleAngle270>270 Degrees</StiAngleAngle270>
    <StiAngleAngle45>45 Degrees</StiAngleAngle45>
    <StiAngleAngle90>90 Degrees</StiAngleAngle90>
    <StiArrowStyleArc>Arc</StiArrowStyleArc>
    <StiArrowStyleArcAndCircle>Arc and Circle</StiArrowStyleArcAndCircle>
    <StiArrowStyleCircle>Circle</StiArrowStyleCircle>
    <StiArrowStyleLines>Lines</StiArrowStyleLines>
    <StiArrowStyleNone>None</StiArrowStyleNone>
    <StiArrowStyleTriangle>Triangle</StiArrowStyleTriangle>
    <StiBorderSidesAll>All</StiBorderSidesAll>
    <StiBorderSidesBottom>Bottom</StiBorderSidesBottom>
    <StiBorderSidesLeft>Left</StiBorderSidesLeft>
    <StiBorderSidesNone>None</StiBorderSidesNone>
    <StiBorderSidesRight>Right</StiBorderSidesRight>
    <StiBorderSidesTop>Top</StiBorderSidesTop>
    <StiBorderStyleBump>Bump</StiBorderStyleBump>
    <StiBorderStyleEtched>Etched</StiBorderStyleEtched>
    <StiBorderStyleFlat>Flat</StiBorderStyleFlat>
    <StiBorderStyleNone>None</StiBorderStyleNone>
    <StiBorderStyleRaised>Raised</StiBorderStyleRaised>
    <StiBorderStyleRaisedInner>Raised Inner</StiBorderStyleRaisedInner>
    <StiBorderStyleRaisedOuter>Raised Outer</StiBorderStyleRaisedOuter>
    <StiBorderStyleSunken>Sunken</StiBorderStyleSunken>
    <StiBorderStyleSunkenInner>Sunken Inner</StiBorderStyleSunkenInner>
    <StiBorderStyleSunkenOuter>Sunken Outer</StiBorderStyleSunkenOuter>
    <StiBrushTypeGlare>Glare Brush</StiBrushTypeGlare>
    <StiBrushTypeGradient0>Gradient Brush, Angle 0</StiBrushTypeGradient0>
    <StiBrushTypeGradient180>Gradient Brush, Angle 180</StiBrushTypeGradient180>
    <StiBrushTypeGradient270>Gradient Brush, Angle 270</StiBrushTypeGradient270>
    <StiBrushTypeGradient45>Gradient Brush, Angle 45</StiBrushTypeGradient45>
    <StiBrushTypeGradient90>Gradient Brush, Angle 90</StiBrushTypeGradient90>
    <StiBrushTypeSolid>Solid Brush</StiBrushTypeSolid>
    <StiCalculationModeCompilation>Compilation</StiCalculationModeCompilation>
    <StiCalculationModeInterpretation>Interpretation</StiCalculationModeInterpretation>
    <StiCapStyleArrow>Arrow</StiCapStyleArrow>
    <StiCapStyleDiamond>Diamond</StiCapStyleDiamond>
    <StiCapStyleNone>None</StiCapStyleNone>
    <StiCapStyleOpen>Open</StiCapStyleOpen>
    <StiCapStyleOval>Oval</StiCapStyleOval>
    <StiCapStyleSquare>Square</StiCapStyleSquare>
    <StiCapStyleStealth>Stealth</StiCapStyleStealth>
    <StiChartTitleDockBottom>Bottom</StiChartTitleDockBottom>
    <StiChartTitleDockLeft>Left</StiChartTitleDockLeft>
    <StiChartTitleDockRight>Right</StiChartTitleDockRight>
    <StiChartTitleDockTop>Top</StiChartTitleDockTop>
    <StiCheckStyleCheck>Check</StiCheckStyleCheck>
    <StiCheckStyleCheckRectangle>Check Rectangle</StiCheckStyleCheckRectangle>
    <StiCheckStyleCross>Cross</StiCheckStyleCross>
    <StiCheckStyleCrossCircle>Cross Circle</StiCheckStyleCrossCircle>
    <StiCheckStyleCrossRectangle>Cross Rectangle</StiCheckStyleCrossRectangle>
    <StiCheckStyleDotCircle>Dot Circle</StiCheckStyleDotCircle>
    <StiCheckStyleDotRectangle>Dot Rectangle</StiCheckStyleDotRectangle>
    <StiCheckStyleNone>None</StiCheckStyleNone>
    <StiCheckStyleNoneCircle>None Circle</StiCheckStyleNoneCircle>
    <StiCheckStyleNoneRectangle>None Rectangle</StiCheckStyleNoneRectangle>
    <StiCheckSumNo>No</StiCheckSumNo>
    <StiCheckSumYes>Yes</StiCheckSumYes>
    <StiCode11CheckSumAuto>Auto</StiCode11CheckSumAuto>
    <StiCode11CheckSumNone>None</StiCode11CheckSumNone>
    <StiCode11CheckSumOneDigit>One Digit</StiCode11CheckSumOneDigit>
    <StiCode11CheckSumTwoDigits>Two Digits</StiCode11CheckSumTwoDigits>
    <StiColorScaleTypeColor2>2-Color Scale</StiColorScaleTypeColor2>
    <StiColorScaleTypeColor3>3-Color Scale</StiColorScaleTypeColor3>
    <StiColumnDirectionAcrossThenDown>Across Then Down</StiColumnDirectionAcrossThenDown>
    <StiColumnDirectionDownThenAcross>Down Then Across</StiColumnDirectionDownThenAcross>
    <StiCrossHorAlignmentCenter>Center</StiCrossHorAlignmentCenter>
    <StiCrossHorAlignmentLeft>Left</StiCrossHorAlignmentLeft>
    <StiCrossHorAlignmentNone>None</StiCrossHorAlignmentNone>
    <StiCrossHorAlignmentRight>Right</StiCrossHorAlignmentRight>
    <StiDateTimeTypeDate>Date</StiDateTimeTypeDate>
    <StiDateTimeTypeDateAndTime>Date and Time</StiDateTimeTypeDateAndTime>
    <StiDateTimeTypeTime>Time</StiDateTimeTypeTime>
    <StiDockStyleBottom>Bottom</StiDockStyleBottom>
    <StiDockStyleFill>Fill</StiDockStyleFill>
    <StiDockStyleLeft>Left</StiDockStyleLeft>
    <StiDockStyleNone>None</StiDockStyleNone>
    <StiDockStyleRight>Right</StiDockStyleRight>
    <StiDockStyleTop>Top</StiDockStyleTop>
    <StiEanSupplementTypeFiveDigit>FiveDigit</StiEanSupplementTypeFiveDigit>
    <StiEanSupplementTypeNone>None</StiEanSupplementTypeNone>
    <StiEanSupplementTypeTwoDigit>TwoDigit</StiEanSupplementTypeTwoDigit>
    <StiEmptySizeModeAlignFooterToBottom>Align Footer to Bottom</StiEmptySizeModeAlignFooterToBottom>
    <StiEmptySizeModeAlignFooterToTop>Align Footer to Top</StiEmptySizeModeAlignFooterToTop>
    <StiEmptySizeModeDecreaseLastRow>Decrease Last Row</StiEmptySizeModeDecreaseLastRow>
    <StiEmptySizeModeIncreaseLastRow>Increase Last Row</StiEmptySizeModeIncreaseLastRow>
    <StiEnumeratorTypeABC>ABC</StiEnumeratorTypeABC>
    <StiEnumeratorTypeArabic>Arabic</StiEnumeratorTypeArabic>
    <StiEnumeratorTypeNone>None</StiEnumeratorTypeNone>
    <StiEnumeratorTypeRoman>Roman</StiEnumeratorTypeRoman>
    <StiFilterConditionBeginningWith>beginning with</StiFilterConditionBeginningWith>
    <StiFilterConditionBetween>between</StiFilterConditionBetween>
    <StiFilterConditionContaining>containing</StiFilterConditionContaining>
    <StiFilterConditionEndingWith>ending with</StiFilterConditionEndingWith>
    <StiFilterConditionEqualTo>equal to</StiFilterConditionEqualTo>
    <StiFilterConditionGreaterThan>greater than</StiFilterConditionGreaterThan>
    <StiFilterConditionGreaterThanOrEqualTo>greater than or equal to</StiFilterConditionGreaterThanOrEqualTo>
    <StiFilterConditionLessThan>less than</StiFilterConditionLessThan>
    <StiFilterConditionLessThanOrEqualTo>less than or equal to</StiFilterConditionLessThanOrEqualTo>
    <StiFilterConditionNotBetween>not between</StiFilterConditionNotBetween>
    <StiFilterConditionNotContaining>not containing</StiFilterConditionNotContaining>
    <StiFilterConditionNotEqualTo>not equal to</StiFilterConditionNotEqualTo>
    <StiFilterDataTypeBoolean>Boolean</StiFilterDataTypeBoolean>
    <StiFilterDataTypeDateTime>DateTime</StiFilterDataTypeDateTime>
    <StiFilterDataTypeExpression>Expression</StiFilterDataTypeExpression>
    <StiFilterDataTypeNumeric>Numeric</StiFilterDataTypeNumeric>
    <StiFilterDataTypeString>String</StiFilterDataTypeString>
    <StiFilterEngineReportEngine>Report Engine</StiFilterEngineReportEngine>
    <StiFilterEngineSQLQuery>SQL Query</StiFilterEngineSQLQuery>
    <StiFilterItemArgument>Argument</StiFilterItemArgument>
    <StiFilterItemExpression>Expression</StiFilterItemExpression>
    <StiFilterItemValue>Value</StiFilterItemValue>
    <StiFilterModeAnd>And</StiFilterModeAnd>
    <StiFilterModeOr>Or</StiFilterModeOr>
    <StiFormStartModeOnEnd>On End</StiFormStartModeOnEnd>
    <StiFormStartModeOnPreview>On Preview</StiFormStartModeOnPreview>
    <StiFormStartModeOnStart>On Start</StiFormStartModeOnStart>
    <StiGroupSortDirectionAscending>Ascending</StiGroupSortDirectionAscending>
    <StiGroupSortDirectionDescending>Descending</StiGroupSortDirectionDescending>
    <StiGroupSortDirectionNone>None</StiGroupSortDirectionNone>
    <StiHorAlignmentCenter>Center</StiHorAlignmentCenter>
    <StiHorAlignmentLeft>Left</StiHorAlignmentLeft>
    <StiHorAlignmentRight>Right</StiHorAlignmentRight>
    <StiImageProcessingDuplicatesTypeGlobalHide>Global Hide</StiImageProcessingDuplicatesTypeGlobalHide>
    <StiImageProcessingDuplicatesTypeGlobalMerge>Global Merge</StiImageProcessingDuplicatesTypeGlobalMerge>
    <StiImageProcessingDuplicatesTypeGlobalRemoveImage>Global Remove Image</StiImageProcessingDuplicatesTypeGlobalRemoveImage>
    <StiImageProcessingDuplicatesTypeHide>Hide</StiImageProcessingDuplicatesTypeHide>
    <StiImageProcessingDuplicatesTypeMerge>Merge</StiImageProcessingDuplicatesTypeMerge>
    <StiImageProcessingDuplicatesTypeNone>None</StiImageProcessingDuplicatesTypeNone>
    <StiImageProcessingDuplicatesTypeRemoveImage>Remove Image</StiImageProcessingDuplicatesTypeRemoveImage>
    <StiImageRotationFlipHorizontal>Flip Horizontal</StiImageRotationFlipHorizontal>
    <StiImageRotationFlipVertical>Flip Vertical</StiImageRotationFlipVertical>
    <StiImageRotationNone>None</StiImageRotationNone>
    <StiImageRotationRotate180>Rotate 180°</StiImageRotationRotate180>
    <StiImageRotationRotate90CCW>Rotate 90° CCW</StiImageRotationRotate90CCW>
    <StiImageRotationRotate90CW>Rotate 90° CW</StiImageRotationRotate90CW>
    <StiKeepDetailsNone>None</StiKeepDetailsNone>
    <StiKeepDetailsKeepFirstRowTogether>Keep First Row Together</StiKeepDetailsKeepFirstRowTogether>
    <StiKeepDetailsKeepFirstDetailTogether>Keep First Detail Together</StiKeepDetailsKeepFirstDetailTogether>
    <StiKeepDetailsKeepDetailsTogether>Keep Details Together</StiKeepDetailsKeepDetailsTogether>
    <StiLabelsPlacementNone>None</StiLabelsPlacementNone>
    <StiLabelsPlacementOneLine>One Line</StiLabelsPlacementOneLine>
    <StiLabelsPlacementTwoLines>Two Lines</StiLabelsPlacementTwoLines>
    <StiLegendDirectionBottomToTop>Bottom to Top</StiLegendDirectionBottomToTop>
    <StiLegendDirectionLeftToRight>Left to Right</StiLegendDirectionLeftToRight>
    <StiLegendDirectionRightToLeft>Right to Left</StiLegendDirectionRightToLeft>
    <StiLegendDirectionTopToBottom>Top to Bottom</StiLegendDirectionTopToBottom>
    <StiLegendHorAlignmentCenter>Center</StiLegendHorAlignmentCenter>
    <StiLegendHorAlignmentLeft>Left</StiLegendHorAlignmentLeft>
    <StiLegendHorAlignmentLeftOutside>Left Outside</StiLegendHorAlignmentLeftOutside>
    <StiLegendHorAlignmentRight>Right</StiLegendHorAlignmentRight>
    <StiLegendHorAlignmentRightOutside>Right Outside</StiLegendHorAlignmentRightOutside>
    <StiLegendVertAlignmentBottom>Bottom</StiLegendVertAlignmentBottom>
    <StiLegendVertAlignmentBottomOutside>Bottom Outside</StiLegendVertAlignmentBottomOutside>
    <StiLegendVertAlignmentCenter>Center</StiLegendVertAlignmentCenter>
    <StiLegendVertAlignmentTop>Top</StiLegendVertAlignmentTop>
    <StiLegendVertAlignmentTopOutside>Top Outside</StiLegendVertAlignmentTopOutside>
    <StiMarkerAlignmentLeft>Left</StiMarkerAlignmentLeft>
    <StiMarkerAlignmentRight>Right</StiMarkerAlignmentRight>
    <StiMarkerTypeCircle>Circle</StiMarkerTypeCircle>
    <StiMarkerTypeHexagon>Hexagon</StiMarkerTypeHexagon>
    <StiMarkerTypeRectangle>Rectangle</StiMarkerTypeRectangle>
    <StiMarkerTypeStar5>Star 5</StiMarkerTypeStar5>
    <StiMarkerTypeStar6>Star 6</StiMarkerTypeStar6>
    <StiMarkerTypeStar7>Star 7</StiMarkerTypeStar7>
    <StiMarkerTypeStar8>Star 8</StiMarkerTypeStar8>
    <StiMarkerTypeTriangle>Triangle</StiMarkerTypeTriangle>
    <StiNestedFactorHigh>High</StiNestedFactorHigh>
    <StiNestedFactorLow>Low</StiNestedFactorLow>
    <StiNestedFactorNormal>Normal</StiNestedFactorNormal>
    <StiNumberOfPassDoublePass>Double Pass</StiNumberOfPassDoublePass>
    <StiNumberOfPassSinglePass>Single Pass</StiNumberOfPassSinglePass>
    <StiOrientationHorizontal>Horizontal</StiOrientationHorizontal>
    <StiOrientationVertical>Vertical</StiOrientationVertical>
    <StiPageOrientationLandscape>Landscape</StiPageOrientationLandscape>
    <StiPageOrientationPortrait>Portrait</StiPageOrientationPortrait>
    <StiPenStyleDash>Dash</StiPenStyleDash>
    <StiPenStyleDashDot>Dash Dot</StiPenStyleDashDot>
    <StiPenStyleDashDotDot>Dash Dot Dot</StiPenStyleDashDotDot>
    <StiPenStyleDot>Dot</StiPenStyleDot>
    <StiPenStyleDouble>Double</StiPenStyleDouble>
    <StiPenStyleNone>None</StiPenStyleNone>
    <StiPenStyleSolid>Solid</StiPenStyleSolid>
    <StiPlesseyCheckSumModulo10>Modulo10</StiPlesseyCheckSumModulo10>
    <StiPlesseyCheckSumModulo11>Modulo11</StiPlesseyCheckSumModulo11>
    <StiPlesseyCheckSumNone>None</StiPlesseyCheckSumNone>
    <StiPreviewModeDotMatrix>Dot-Matrix</StiPreviewModeDotMatrix>
    <StiPreviewModeStandard>Standard</StiPreviewModeStandard>
    <StiPreviewModeStandardAndDotMatrix>Standard and Dot-Matrix</StiPreviewModeStandardAndDotMatrix>
    <StiPrintOnEvenOddPagesTypeIgnore>Ignore</StiPrintOnEvenOddPagesTypeIgnore>
    <StiPrintOnEvenOddPagesTypePrintOnEvenPages>Print on Even Pages</StiPrintOnEvenOddPagesTypePrintOnEvenPages>
    <StiPrintOnEvenOddPagesTypePrintOnOddPages>Print on Odd Pages</StiPrintOnEvenOddPagesTypePrintOnOddPages>
    <StiPrintOnTypeAllPages>All Pages</StiPrintOnTypeAllPages>
    <StiPrintOnTypeExceptFirstAndLastPage>Except First and Last Page</StiPrintOnTypeExceptFirstAndLastPage>
    <StiPrintOnTypeExceptFirstPage>Except First Page</StiPrintOnTypeExceptFirstPage>
    <StiPrintOnTypeExceptLastPage>Except Last Page</StiPrintOnTypeExceptLastPage>
    <StiPrintOnTypeOnlyFirstAndLastPage>Only First and Last Page</StiPrintOnTypeOnlyFirstAndLastPage>
    <StiPrintOnTypeOnlyFirstPage>Only First Page</StiPrintOnTypeOnlyFirstPage>
    <StiPrintOnTypeOnlyLastPage>Only Last Page</StiPrintOnTypeOnlyLastPage>
    <StiProcessAtEndOfPage>EndOfPage</StiProcessAtEndOfPage>
    <StiProcessAtEndOfReport>EndOfReport</StiProcessAtEndOfReport>
    <StiProcessAtNone>None</StiProcessAtNone>
    <StiProcessingDuplicatesTypeBasedOnTagHide>Hide based on Tag</StiProcessingDuplicatesTypeBasedOnTagHide>
    <StiProcessingDuplicatesTypeBasedOnTagMerge>Merge based on Tag</StiProcessingDuplicatesTypeBasedOnTagMerge>
    <StiProcessingDuplicatesTypeBasedOnTagRemoveText>Remove Text based on Tag</StiProcessingDuplicatesTypeBasedOnTagRemoveText>
    <StiProcessingDuplicatesTypeBasedOnValueAndTagHide>Hide based on Value and Tag</StiProcessingDuplicatesTypeBasedOnValueAndTagHide>
    <StiProcessingDuplicatesTypeBasedOnValueAndTagMerge>Merge based on Value and Tag</StiProcessingDuplicatesTypeBasedOnValueAndTagMerge>
    <StiProcessingDuplicatesTypeBasedOnValueRemoveText>Remove based on Value Text</StiProcessingDuplicatesTypeBasedOnValueRemoveText>
    <StiProcessingDuplicatesTypeGlobalBasedOnValueAndTagHide>Global Hide based on Value and Tag</StiProcessingDuplicatesTypeGlobalBasedOnValueAndTagHide>
    <StiProcessingDuplicatesTypeGlobalBasedOnValueAndTagMerge>Global Merge based on Value and Tag</StiProcessingDuplicatesTypeGlobalBasedOnValueAndTagMerge>
    <StiProcessingDuplicatesTypeGlobalBasedOnValueRemoveText>Global Remove based on Value Text</StiProcessingDuplicatesTypeGlobalBasedOnValueRemoveText>
    <StiProcessingDuplicatesTypeGlobalHide>Global Hide</StiProcessingDuplicatesTypeGlobalHide>
    <StiProcessingDuplicatesTypeGlobalMerge>Global Merge</StiProcessingDuplicatesTypeGlobalMerge>
    <StiProcessingDuplicatesTypeGlobalRemoveText>Global Remove Text</StiProcessingDuplicatesTypeGlobalRemoveText>
    <StiProcessingDuplicatesTypeHide>Hide</StiProcessingDuplicatesTypeHide>
    <StiProcessingDuplicatesTypeMerge>Merge</StiProcessingDuplicatesTypeMerge>
    <StiProcessingDuplicatesTypeNone>None</StiProcessingDuplicatesTypeNone>
    <StiProcessingDuplicatesTypeRemoveText>Remove Text</StiProcessingDuplicatesTypeRemoveText>
    <StiRadarStyleXFCircle>Circle</StiRadarStyleXFCircle>
    <StiRadarStyleXFPolygon>Polygon</StiRadarStyleXFPolygon>
    <StiReportCacheModeAuto>Auto</StiReportCacheModeAuto>
    <StiReportCacheModeOff>Off</StiReportCacheModeOff>
    <StiReportCacheModeOn>On</StiReportCacheModeOn>
    <StiReportUnitTypeCentimeters>Centimeters</StiReportUnitTypeCentimeters>
    <StiReportUnitTypeHundredthsOfInch>Hundredths of Inch</StiReportUnitTypeHundredthsOfInch>
    <StiReportUnitTypeInches>Inches</StiReportUnitTypeInches>
    <StiReportUnitTypeMillimeters>Millimeters</StiReportUnitTypeMillimeters>
    <StiReportUnitTypePixels>Pixels</StiReportUnitTypePixels>
    <StiRestrictionsAll>All</StiRestrictionsAll>
    <StiRestrictionsAllowChange>Allow Change</StiRestrictionsAllowChange>
    <StiRestrictionsAllowDelete>Allow Delete</StiRestrictionsAllowDelete>
    <StiRestrictionsAllowMove>Allow Move</StiRestrictionsAllowMove>
    <StiRestrictionsAllowResize>Allow Resize</StiRestrictionsAllowResize>
    <StiRestrictionsAllowSelect>Allow Select</StiRestrictionsAllowSelect>
    <StiRestrictionsNone>None</StiRestrictionsNone>
    <StiSeriesLabelsValueTypeArgument>Argument</StiSeriesLabelsValueTypeArgument>
    <StiSeriesLabelsValueTypeArgumentValue>Argument - Value</StiSeriesLabelsValueTypeArgumentValue>
    <StiSeriesLabelsValueTypeSeriesTitle>Series Title</StiSeriesLabelsValueTypeSeriesTitle>
    <StiSeriesLabelsValueTypeSeriesTitleArgument>Series Title - Argument</StiSeriesLabelsValueTypeSeriesTitleArgument>
    <StiSeriesLabelsValueTypeSeriesTitleValue>Series Title - Value</StiSeriesLabelsValueTypeSeriesTitleValue>
    <StiSeriesLabelsValueTypeTag>Tag</StiSeriesLabelsValueTypeTag>
    <StiSeriesLabelsValueTypeWeight>Weight</StiSeriesLabelsValueTypeWeight>
    <StiSeriesLabelsValueTypeValue>Value</StiSeriesLabelsValueTypeValue>
    <StiSeriesLabelsValueTypeValueArgument>Value - Argument</StiSeriesLabelsValueTypeValueArgument>
    <StiSeriesSortDirectionAscending>Ascending</StiSeriesSortDirectionAscending>
    <StiSeriesSortDirectionDescending>Descending</StiSeriesSortDirectionDescending>
    <StiSeriesSortTypeArgument>Argument</StiSeriesSortTypeArgument>
    <StiSeriesSortTypeNone>None</StiSeriesSortTypeNone>
    <StiSeriesSortTypeValue>Value</StiSeriesSortTypeValue>
    <StiSeriesYAxisLeftYAxis>Left Y Axis</StiSeriesYAxisLeftYAxis>
    <StiSeriesYAxisRightYAxis>Right Y Axis</StiSeriesYAxisRightYAxis>
    <StiShapeDirectionDown>Down</StiShapeDirectionDown>
    <StiShapeDirectionLeft>Left</StiShapeDirectionLeft>
    <StiShapeDirectionRight>Right</StiShapeDirectionRight>
    <StiShapeDirectionUp>Up</StiShapeDirectionUp>
    <StiShiftModeDecreasingSize>Decreasing Size</StiShiftModeDecreasingSize>
    <StiShiftModeIncreasingSize>Increasing Size</StiShiftModeIncreasingSize>
    <StiShiftModeNone>None</StiShiftModeNone>
    <StiShiftModeOnlyInWidthOfComponent>Only in Width of Component</StiShiftModeOnlyInWidthOfComponent>
    <StiShowSeriesLabelsFromChart>FromChart</StiShowSeriesLabelsFromChart>
    <StiShowSeriesLabelsFromSeries>FromSeries</StiShowSeriesLabelsFromSeries>
    <StiShowSeriesLabelsNone>None</StiShowSeriesLabelsNone>
    <StiShowXAxisBoth>Both</StiShowXAxisBoth>
    <StiShowXAxisBottom>Bottom</StiShowXAxisBottom>
    <StiShowXAxisCenter>Center</StiShowXAxisCenter>
    <StiShowYAxisBoth>Both</StiShowYAxisBoth>
    <StiShowYAxisCenter>Center</StiShowYAxisCenter>
    <StiShowYAxisLeft>Left</StiShowYAxisLeft>
    <StiSortDirectionAsc>Ascending</StiSortDirectionAsc>
    <StiSortDirectionDesc>Descending</StiSortDirectionDesc>
    <StiSortDirectionNone>None</StiSortDirectionNone>
    <StiSortTypeByDisplayValue>by Display Value</StiSortTypeByDisplayValue>
    <StiSortTypeByValue>by Value</StiSortTypeByValue>
    <StiSqlSourceTypeStoredProcedure>Stored Procedure</StiSqlSourceTypeStoredProcedure>
    <StiSqlSourceTypeTable>Table</StiSqlSourceTypeTable>
    <StiStyleComponentTypeChart>Chart</StiStyleComponentTypeChart>
    <StiStyleComponentTypeCheckBox>Check Box</StiStyleComponentTypeCheckBox>
    <StiStyleComponentTypeCrossTab>Cross-Tab</StiStyleComponentTypeCrossTab>
    <StiStyleComponentTypeImage>Image</StiStyleComponentTypeImage>
    <StiStyleComponentTypePrimitive>Primitive</StiStyleComponentTypePrimitive>
    <StiStyleComponentTypeText>Text</StiStyleComponentTypeText>
    <StiStyleConditionTypeComponentName>Component Name</StiStyleConditionTypeComponentName>
    <StiStyleConditionTypeComponentType>Component Type</StiStyleConditionTypeComponentType>
    <StiStyleConditionTypeLocation>Location</StiStyleConditionTypeLocation>
    <StiStyleConditionTypePlacement>Placement</StiStyleConditionTypePlacement>
    <StiSummaryValuesAllValues>All Values</StiSummaryValuesAllValues>
    <StiSummaryValuesSkipNulls>Skip Nulls</StiSummaryValuesSkipNulls>
    <StiSummaryValuesSkipZerosAndNulls>Skip Zeros and Nulls</StiSummaryValuesSkipZerosAndNulls>
    <StiTablceCellTypeCheckBox>CheckBox</StiTablceCellTypeCheckBox>
    <StiTablceCellTypeImage>Image</StiTablceCellTypeImage>
    <StiTablceCellTypeRichText>RichText</StiTablceCellTypeRichText>
    <StiTablceCellTypeText>Text</StiTablceCellTypeText>
    <StiTableAutoWidthNone>None</StiTableAutoWidthNone>
    <StiTableAutoWidthPage>Page</StiTableAutoWidthPage>
    <StiTableAutoWidthTable>Table</StiTableAutoWidthTable>
    <StiTableAutoWidthTypeFullTable>Full Table</StiTableAutoWidthTypeFullTable>
    <StiTableAutoWidthTypeLastColumns>Last Columns</StiTableAutoWidthTypeLastColumns>
    <StiTableAutoWidthTypeNone>None</StiTableAutoWidthTypeNone>
    <StiTextHorAlignmentCenter>Center</StiTextHorAlignmentCenter>
    <StiTextHorAlignmentLeft>Left</StiTextHorAlignmentLeft>
    <StiTextHorAlignmentRight>Right</StiTextHorAlignmentRight>
    <StiTextHorAlignmentWidth>Width</StiTextHorAlignmentWidth>
    <StiTextPositionCenterBottom>Center Bottom</StiTextPositionCenterBottom>
    <StiTextPositionCenterTop>Center Top</StiTextPositionCenterTop>
    <StiTextPositionLeftBottom>Left Bottom</StiTextPositionLeftBottom>
    <StiTextPositionLeftTop>Left Top</StiTextPositionLeftTop>
    <StiTextPositionRightBottom>Right Bottom</StiTextPositionRightBottom>
    <StiTextPositionRightTop>Right Top</StiTextPositionRightTop>
    <StiTextQualityStandard>Standard</StiTextQualityStandard>
    <StiTextQualityTypographic>Typographic</StiTextQualityTypographic>
    <StiTextQualityWysiwyg>Wysiwyg</StiTextQualityWysiwyg>
    <StiTypeModeList>List</StiTypeModeList>
    <StiTypeModeNullableValue>Nullable Value</StiTypeModeNullableValue>
    <StiTypeModeRange>Range</StiTypeModeRange>
    <StiTypeModeValue>Value</StiTypeModeValue>
    <StiVertAlignmentBottom>Bottom</StiVertAlignmentBottom>
    <StiVertAlignmentCenter>Center</StiVertAlignmentCenter>
    <StiVertAlignmentTop>Top</StiVertAlignmentTop>
    <StiViewModeNormal>Normal</StiViewModeNormal>
    <StiViewModePageBreakPreview>Page Break Preview</StiViewModePageBreakPreview>
    <StringAlignmentCenter>Center</StringAlignmentCenter>
    <StringAlignmentFar>Far</StringAlignmentFar>
    <StringAlignmentNear>Near</StringAlignmentNear>
    <StringTrimmingCharacter>Character</StringTrimmingCharacter>
    <StringTrimmingEllipsisCharacter>Ellipsis Character</StringTrimmingEllipsisCharacter>
    <StringTrimmingEllipsisPath>Ellipsis Path</StringTrimmingEllipsisPath>
    <StringTrimmingEllipsisWord>Ellipsis Word</StringTrimmingEllipsisWord>
    <StringTrimmingNone>None</StringTrimmingNone>
    <StringTrimmingWord>Word</StringTrimmingWord>
  </PropertyEnum>
  <PropertyEvents>
    <AfterPrintEvent>After Print</AfterPrintEvent>
    <AfterSelectEvent>After Select</AfterSelectEvent>
    <BeforePrintEvent>Before Print</BeforePrintEvent>
    <BeginRenderEvent>Begin Render</BeginRenderEvent>
    <CheckedChangedEvent>Checked Changed</CheckedChangedEvent>
    <ClickEvent>Click</ClickEvent>
    <ClosedFormEvent>Closed Form</ClosedFormEvent>
    <ClosingFormEvent>Closing Form</ClosingFormEvent>
    <ColumnBeginRenderEvent>Column Begin Render</ColumnBeginRenderEvent>
    <ColumnEndRenderEvent>Column End Render</ColumnEndRenderEvent>
    <ConnectedEvent>ConnectedEvent</ConnectedEvent>
    <ConnectingEvent>ConnectingEvent</ConnectingEvent>
    <DisconnectedEvent>Disconnected</DisconnectedEvent>
    <DisconnectingEvent>Disconnecting</DisconnectingEvent>
    <DoubleClickEvent>Double Click</DoubleClickEvent>
    <EndRenderEvent>End Render</EndRenderEvent>
    <EnterEvent>Enter</EnterEvent>
    <ExportedEvent>Exported</ExportedEvent>
    <ExportingEvent>Exporting</ExportingEvent>
    <GetArgumentEvent>Get Argument</GetArgumentEvent>
    <GetBookmarkEvent>Get Bookmark</GetBookmarkEvent>
    <GetCollapsedEvent>Get Collapsed</GetCollapsedEvent>
    <GetCrossValueEvent>Get Cross Value</GetCrossValueEvent>
    <GetCutPieListEvent>Get Cut Pie List</GetCutPieListEvent>
    <GetDisplayCrossValueEvent>Get Display Cross Value</GetDisplayCrossValueEvent>
    <GetDrillDownReportEvent>Get Drill-Down Report</GetDrillDownReportEvent>
    <GetExcelSheetEvent>Get Excel Sheet</GetExcelSheetEvent>
    <GetExcelValueEvent>Get Excel Value</GetExcelValueEvent>
    <GetHyperlinkEvent>Get Hyperlink</GetHyperlinkEvent>
    <GetImageDataEvent>Get Image Data</GetImageDataEvent>
    <GetImageURLEvent>Get Image URL</GetImageURLEvent>
    <GetListOfArgumentsEvent>Get List of Arguments</GetListOfArgumentsEvent>
    <GetListOfHyperlinksEvent>Get List of Hyperlinks</GetListOfHyperlinksEvent>
    <GetListOfTagsEvent>Get List of Tags</GetListOfTagsEvent>
    <GetListOfToolTipsEvent>Get List of Tool Tips</GetListOfToolTipsEvent>
    <GetListOfValuesEndEvent>Get List of Values End</GetListOfValuesEndEvent>
    <GetListOfValuesEvent>Get List of Values</GetListOfValuesEvent>
    <GetListOfWeights>Get List of Weights</GetListOfWeights>
    <GetListOfWeightsEvent>Get List of Weights</GetListOfWeightsEvent>
    <GetSummaryExpressionEvent>Get Summary Expression</GetSummaryExpressionEvent>
    <GetTagEvent>Get Tag</GetTagEvent>
    <GetTitleEvent>Get Title</GetTitleEvent>
    <GetToolTipEvent>Get Tool Tip</GetToolTipEvent>
    <GetValueEndEvent>Get Value End</GetValueEndEvent>
    <GetValueEvent>Get Value</GetValueEvent>
    <GetWeightEvent>Get Weight</GetWeightEvent>
    <LeaveEvent>Leave</LeaveEvent>
    <LoadFormEvent>Load Form</LoadFormEvent>
    <MouseDownEvent>Mouse Down</MouseDownEvent>
    <MouseEnterEvent>Mouse Enter</MouseEnterEvent>
    <MouseLeaveEvent>Mouse Leave</MouseLeaveEvent>
    <MouseMoveEvent>Mouse Move</MouseMoveEvent>
    <MouseUpEvent>Mouse Up</MouseUpEvent>
    <NewAutoSeriesEvent>New Auto Series</NewAutoSeriesEvent>
    <PositionChangedEvent>Position Changed</PositionChangedEvent>
    <PrintedEvent>Printed</PrintedEvent>
    <PrintingEvent>Printing</PrintingEvent>
    <ProcessCellEvent>Process Cell</ProcessCellEvent>
    <ProcessChartEvent>Process Chart</ProcessChartEvent>
    <RenderingEvent>Rendering</RenderingEvent>
    <SelectedIndexChangedEvent>Selected Index Changed</SelectedIndexChangedEvent>
    <StateRestoreEvent>State Restore</StateRestoreEvent>
    <StateSaveEvent>State Save</StateSaveEvent>
    <ValueChangedEvent>Value Changed</ValueChangedEvent>
  </PropertyEvents>
  <PropertyHatchStyle>
    <BackwardDiagonal>Backward Diagonal</BackwardDiagonal>
    <Cross>Cross</Cross>
    <DarkDownwardDiagonal>Dark Downward Diagonal</DarkDownwardDiagonal>
    <DarkHorizontal>Dark Horizontal</DarkHorizontal>
    <DarkUpwardDiagonal>Dark Upward Diagonal</DarkUpwardDiagonal>
    <DarkVertical>Dark Vertical</DarkVertical>
    <DashedDownwardDiagonal>Dashed Downward Diagonal</DashedDownwardDiagonal>
    <DashedHorizontal>Dashed Horizontal</DashedHorizontal>
    <DashedUpwardDiagonal>Dashed Upward Diagonal</DashedUpwardDiagonal>
    <DashedVertical>Dashed Vertical</DashedVertical>
    <DiagonalBrick>Diagonal Brick</DiagonalBrick>
    <DiagonalCross>Diagonal Cross</DiagonalCross>
    <Divot>Divot</Divot>
    <DottedDiamond>Dotted Diamond</DottedDiamond>
    <DottedGrid>Dotted Grid</DottedGrid>
    <ForwardDiagonal>Forward Diagonal</ForwardDiagonal>
    <Horizontal>Horizontal</Horizontal>
    <HorizontalBrick>Horizontal Brick</HorizontalBrick>
    <LargeCheckerBoard>Large Checker Board</LargeCheckerBoard>
    <LargeConfetti>Large Confetti</LargeConfetti>
    <LargeGrid>Large Grid</LargeGrid>
    <LightDownwardDiagonal>Light Downward Diagonal</LightDownwardDiagonal>
    <LightHorizontal>Light Horizontal</LightHorizontal>
    <LightUpwardDiagonal>Light Upward Diagonal</LightUpwardDiagonal>
    <LightVertical>Light Vertical</LightVertical>
    <NarrowHorizontal>Narrow Horizontal</NarrowHorizontal>
    <NarrowVertical>Narrow Vertical</NarrowVertical>
    <OutlinedDiamond>Outlined Diamond</OutlinedDiamond>
    <Percent05>Percent05</Percent05>
    <Percent10>Percent10</Percent10>
    <Percent20>Percent20</Percent20>
    <Percent25>Percent25</Percent25>
    <Percent30>Percent30</Percent30>
    <Percent40>Percent40</Percent40>
    <Percent50>Percent50</Percent50>
    <Percent60>Percent60</Percent60>
    <Percent70>Percent70</Percent70>
    <Percent75>Percent75</Percent75>
    <Percent80>Percent80</Percent80>
    <Percent90>Percent90</Percent90>
    <Plaid>Plaid</Plaid>
    <Shingle>Shingle</Shingle>
    <SmallCheckerBoard>Small Checker Board</SmallCheckerBoard>
    <SmallConfetti>Small Confetti</SmallConfetti>
    <SmallGrid>Small Grid</SmallGrid>
    <SolidDiamond>Solid Diamond</SolidDiamond>
    <Sphere>Sphere</Sphere>
    <Trellis>Trellis</Trellis>
    <Vertical>Vertical</Vertical>
    <Weave>Weave</Weave>
    <WideDownwardDiagonal>Wide Downward Diagonal</WideDownwardDiagonal>
    <WideUpwardDiagonal>Wide Upward Diagonal</WideUpwardDiagonal>
    <ZigZag>Zig Zag</ZigZag>
  </PropertyHatchStyle>
  <PropertyMain>
    <AcceptsReturn>Accepts Return</AcceptsReturn>
    <AcceptsTab>Accepts Tab</AcceptsTab>
    <AddClearZone>Add Clear Zone</AddClearZone>
    <Advanced>Advanced</Advanced>
    <AggregateFunction>Aggregate Function</AggregateFunction>
    <AggregateFunctions>Aggregate Functions</AggregateFunctions>
    <Alias>Alias</Alias>
    <Alignment>Alignment</Alignment>
    <AllowApplyBorderColor>Allow Apply Border Color</AllowApplyBorderColor>
    <AllowApplyBrush>Allow Apply Brush</AllowApplyBrush>
    <AllowApplyBrushNegative>Allow Apply Brush Negative</AllowApplyBrushNegative>
    <AllowApplyColorNegative>Allow Apply Color Negative</AllowApplyColorNegative>
    <AllowApplyStyle>Allow Apply Style</AllowApplyStyle>
    <AllowExpressions>Allow Expressions</AllowExpressions>
    <AllowHtmlTags>Allow Html Tags</AllowHtmlTags>
    <AllowSeries>Allow Series</AllowSeries>    
    <AllowSeriesElements>Allow Series Elements</AllowSeriesElements>
    <AllowSorting>Allow Sorting</AllowSorting>
    <AllowUseBackColor>Allow Use Back Color</AllowUseBackColor>
    <AllowUseBorder>Allow Use Border</AllowUseBorder>
    <AllowUseBorderFormatting>Allow Use Border Formatting</AllowUseBorderFormatting>
    <AllowUseBorderSides>Allow Use Border Sides</AllowUseBorderSides>
    <AllowUseBorderSidesFromLocation>Allow Use Border Sides from Location</AllowUseBorderSidesFromLocation>
    <AllowUseBrush>Allow Use Brush</AllowUseBrush>
    <AllowUseFont>Allow Use Font</AllowUseFont>
    <AllowUseForeColor>Allow Use Fore Color</AllowUseForeColor>
    <AllowUseHorAlignment>Allow Use Hor Alignment</AllowUseHorAlignment>
    <AllowUseImage>Allow Use Image</AllowUseImage>
    <AllowUserValues>Allow User Values</AllowUserValues>
    <AllowUseTextBrush>Allow Use Text Brush</AllowUseTextBrush>
    <AllowUseTextOptions>Allow Use Text Options</AllowUseTextOptions>
    <AllowUseVertAlignment>Allow Use Vert Alignment</AllowUseVertAlignment>
    <AlternatingBackColor>Alternating Back Color</AlternatingBackColor>
    <Angle>Angle</Angle>
    <Antialiasing>Antialiasing</Antialiasing>
    <Area>Area</Area>
    <Argument>Argument</Argument>
    <ArgumentDataColumn>Argument Data Column</ArgumentDataColumn>
    <ArrowHeight>Arrow Height</ArrowHeight>
    <ArrowStyle>Arrow Style</ArrowStyle>
    <ArrowWidth>Arrow Width</ArrowWidth>
    <AspectRatio>Aspect Ratio</AspectRatio>
    <Author>Author</Author>
    <Auto>Auto</Auto>
    <AutoDataColumns>Auto Data Columns</AutoDataColumns>
    <AutoDataRows>Auto Data Rows</AutoDataRows>
    <AutoLocalizeReportOnRun>Auto Localize Report on Run</AutoLocalizeReportOnRun>
    <AutoRefresh>Auto Refresh</AutoRefresh>
    <AutoRotate>Auto Rotate</AutoRotate>
    <AutoScale>Auto Scale</AutoScale>
    <AutoSeriesColorDataColumn>Auto Series Color Data Column</AutoSeriesColorDataColumn>
    <AutoSeriesKeyDataColumn>Auto Series Key Data Column</AutoSeriesKeyDataColumn>
    <AutoSeriesTitleDataColumn>Auto Series Title Data Column</AutoSeriesTitleDataColumn>
    <AutoWidth>Auto Width</AutoWidth>
    <AutoWidthType>Auto Width Type</AutoWidthType>
    <AxisValue>Axis Value</AxisValue>
    <BackColor>Back Color</BackColor>
    <Background>Background</Background>
    <BackgroundColor>Background Color</BackgroundColor>
    <BarCodeType>Bar Code Type</BarCodeType>
    <BasicStyleColor>Basic Style Color</BasicStyleColor>
    <Blend>Blend</Blend>
    <Bold>Bold</Bold>
    <Bookmark>Bookmark</Bookmark>
    <Border>Border</Border>
    <BorderColor>Border Color</BorderColor>
    <Borders>Borders</Borders>
    <BorderStyle>Border Style</BorderStyle>
    <Bottom>Bottom</Bottom>
    <BottomSide>Bottom Side</BottomSide>
    <BreakIfLessThan>Break if Less Than</BreakIfLessThan>
    <Brush>Brush</Brush>
    <BrushNegative>Brush Negative</BrushNegative>
    <BrushType>Brush Type</BrushType>
    <BusinessObject>Business Object</BusinessObject>
    <CacheAllData>Cache All Data</CacheAllData>
    <CalcInvisible>Calc Invisible</CalcInvisible>
    <CalculatedDataColumn>Calculated Data Column</CalculatedDataColumn>
    <CalculationMode>Calculation Mode</CalculationMode>
    <CanBreak>Can Break</CanBreak>
    <Cancel>Cancel</Cancel>
    <CanGrow>Can Grow</CanGrow>
    <CanShrink>Can Shrink</CanShrink>
    <Categories>Categories</Categories>
    <Category>Category</Category>
    <CategoryConnections>Connections</CategoryConnections>
    <CellDockStyle>Cell Dock Style</CellDockStyle>
    <CellHeight>Cell Height</CellHeight>
    <CellType>Cell Type</CellType>
    <CellWidth>Cell Width</CellWidth>
    <ChartType>Chart Type</ChartType>
    <Checked>Checked</Checked>
    <CheckOnClick>Check on Click</CheckOnClick>
    <CheckStyle>Check Style</CheckStyle>
    <CheckStyleForFalse>Check Style for False</CheckStyleForFalse>
    <CheckStyleForTrue>Check Style for True</CheckStyleForTrue>
    <Checksum>Checksum</Checksum>
    <CheckSum>CheckSum</CheckSum>
    <CheckSum1>CheckSum1</CheckSum1>
    <CheckSum2>CheckSum2</CheckSum2>
    <Child>Child</Child>
    <ChildColumns>Child Columns</ChildColumns>
    <ChildSource>Child Data Source</ChildSource>
    <ClearFormat>Clear Format</ClearFormat>
    <CloneContainer>Clone Container</CloneContainer>
    <Code>Code</Code>
    <CodePage>Code Page</CodePage>
    <Collapsed>Collapsed</Collapsed>
    <CollapseGroupFooter>Collapse Group Footer</CollapseGroupFooter>
    <CollapsingEnabled>Collapsing Enabled</CollapsingEnabled>
    <Collate>Collate</Collate>
    <CollectionName>Collection Name</CollectionName>
    <Color>Color</Color>
    <ColorEach>Color Each</ColorEach>
    <ColorScaleCondition>Color Scale Condition</ColorScaleCondition>
    <ColorScaleType>Color Scale Type</ColorScaleType>
    <Column>Column</Column>
    <ColumnCount>Column Count</ColumnCount>
    <ColumnDirection>Column Direction</ColumnDirection>
    <ColumnGaps>Column Gaps</ColumnGaps>
    <ColumnHeadersVisible>Column Headers Visible</ColumnHeadersVisible>
    <Columns>Columns</Columns>
    <ColumnWidth>Column Width</ColumnWidth>
    <CommandTimeout>Command Timeout</CommandTimeout>
    <ComponentStyle>Component Style</ComponentStyle>
    <Condition>Condition</Condition>
    <ConditionOptions>Condition Options</ConditionOptions>
    <Conditions>Conditions</Conditions>
    <ConnectionString>Connection String</ConnectionString>
    <ConnectOnStart>Connect on Start</ConnectOnStart>
    <ConstantLines>Constant Lines</ConstantLines>
    <Container>Container</Container>
    <ContinuousText>Continuous Text</ContinuousText>
    <ContourColor>Contour Color</ContourColor>
    <Converting>Converting</Converting>
    <ConvertNulls>Convert Nulls</ConvertNulls>
    <Copies>Copies</Copies>
    <Count>Count</Count>
    <CountData>Count Data</CountData>
    <Create>Create</Create>
    <CreateFieldOnDoubleClick>Create Field on Double Click</CreateFieldOnDoubleClick>
    <CreateLabel>Create Label</CreateLabel>
    <CustomFormat>Custom Format</CustomFormat>
    <CutPieList>Cut Pie List</CutPieList>
    <Data>Data</Data>
    <DataAdapter>Data Adapter</DataAdapter>
    <DataAdapters>Data Adapters</DataAdapters>
    <DataBarCondition>Data Bar Condition</DataBarCondition>
    <DataBindings>Data Bindings</DataBindings>
    <DataColumn>Data Column</DataColumn>
    <DataColumns>Data Columns</DataColumns>
    <DataField>Data Field</DataField>
    <DataRelation>Data Relation</DataRelation>
    <DataRows>Data Rows</DataRows>
    <DataSource>Data Source</DataSource>
    <DataSources>Data Sources</DataSources>
    <DataTextField>Data Text Field</DataTextField>
    <DataType>Data Type</DataType>
    <DateInfo>Date Info</DateInfo>
    <DateTimeStep>Date Time Step</DateTimeStep>
    <Default>Default</Default>
    <DefaultHeightCell>Default Height of Cell</DefaultHeightCell>
    <DefaultNamespace>Default Namespace</DefaultNamespace>
    <Description>Description</Description>
    <DetectUrls>Detect Urls</DetectUrls>
    <DialogResult>Dialog Result</DialogResult>
    <Diameter>Diameter</Diameter>
    <Direction>Direction</Direction>
    <DisplayValue>Display Value</DisplayValue>
    <Distance>Distance</Distance>
    <DistanceBetweenTabs>Distance Between Tabs</DistanceBetweenTabs>
    <Dock>Dock</Dock>
    <DockableTable>Dockable Table</DockableTable>
    <DockStyle>Dock Style</DockStyle>
    <DrawBorder>Draw Border</DrawBorder>
    <DrawHatch>Draw Hatch</DrawHatch>
    <DrawLine>Draw Line</DrawLine>
    <DrillDownEnabled>Drill-Down Enabled</DrillDownEnabled>
    <DrillDownPage>Drill-Down Page</DrillDownPage>
    <DrillDownParameter1>Drill-Down Parameter 1</DrillDownParameter1>
    <DrillDownParameter2>Drill-Down Parameter 2</DrillDownParameter2>
    <DrillDownParameter3>Drill-Down Parameter 3</DrillDownParameter3>
    <DrillDownParameter4>Drill-Down Parameter 4</DrillDownParameter4>
    <DrillDownParameter5>Drill-Down Parameter 5</DrillDownParameter5>
    <DrillDownReport>Drill-Down Report</DrillDownReport>
    <DropDownAlign>Drop Down Align</DropDownAlign>
    <DropDownStyle>Drop Down Style</DropDownStyle>
    <DropDownWidth>Drop Down Width</DropDownWidth>
    <DropShadow>Drop Shadow</DropShadow>
    <Duplex>Duplex</Duplex>
    <Editable>Editable</Editable>
    <EmptyValue>Empty Value</EmptyValue>
    <Enabled>Enabled</Enabled>
    <EnableLog>Enabled Log</EnableLog>
    <EncodingMode>Encoding Mode</EncodingMode>
    <EncodingType>Encoding Type</EncodingType>
    <EndCap>End Cap</EndCap>
    <EndColor>End Color</EndColor>
    <EngineVersion>Engine Version</EngineVersion>
    <EnumeratorSeparator>Enumerator Separator</EnumeratorSeparator>
    <EnumeratorType>Enumerator Type</EnumeratorType>
    <ErrorCorrectionLevel>Error Correction Level</ErrorCorrectionLevel>
    <ErrorsCorrectionLevel>Errors Correction Level</ErrorsCorrectionLevel>
    <EvenStyle>Even Style</EvenStyle>
    <ExcelSheet>Excel Sheet</ExcelSheet>
    <ExcelValue>Excel Value</ExcelValue>
    <Exponential>Exponential</Exponential>
    <ExportAsImage>Export as Image</ExportAsImage>
    <Expression>Expression</Expression>
    <FaqPage>Faq Page</FaqPage>
    <FieldIs>Field Is</FieldIs>
    <File>File</File>
    <Fill>Fill</Fill>
    <Filter>Filter</Filter>
    <FilterEngine>FilterEngine</FilterEngine>
    <FilterOn>Filter On</FilterOn>
    <Filters>Filters</Filters>
    <FirstTabOffset>First Tab Offset</FirstTabOffset>
    <FixedWidth>Fixed Width</FixedWidth>
    <Flat>Flat</Flat>
    <FlatMode>Flat Mode</FlatMode>
    <Focus>Focus</Focus>
    <Font>Font</Font>
    <FontBold>Font Bold</FontBold>
    <FontItalic>Font Italic</FontItalic>
    <FontName>Font Name</FontName>
    <FontSize>Font Size</FontSize>
    <FontStrikeout>Font Strikeout</FontStrikeout>
    <FontSubscript>Subscript</FontSubscript>
    <FontSuperscript>Superscript</FontSuperscript>
    <FontUnderline>Font Underline</FontUnderline>
    <FontUnit>Font Unit</FontUnit>
    <FooterCanBreak>Footer Can Break</FooterCanBreak>
    <FooterCanGrow>Footer Can Grow</FooterCanGrow>
    <FooterCanShrink>Footer Can Shrink</FooterCanShrink>
    <FooterPrintAtBottom>Footer Print At Bottom</FooterPrintAtBottom>
    <FooterPrintIfEmpty>Footer Print If Empty</FooterPrintIfEmpty>
    <FooterPrintOn>Footer Print On</FooterPrintOn>
    <FooterPrintOnAllPages>Footer Print On All Pages</FooterPrintOnAllPages>
    <FooterPrintOnEvenOddPages>Footer Print On Even Odd Pages</FooterPrintOnEvenOddPages>
    <FooterRowsCount>Footer Rows Count</FooterRowsCount>
    <Footers>Footers</Footers>
    <ForeColor>Fore Color</ForeColor>
    <Format>Format</Format>
    <From>From</From>
    <FullConvertExpression>Full Convert Expression</FullConvertExpression>
    <Function>Function</Function>
    <Functions>Functions</Functions>
    <GlobalizationStrings>Globalization Strings</GlobalizationStrings>
    <GlobalizedName>Globalized Name</GlobalizedName>
    <GridLineColor>Grid Line Color</GridLineColor>
    <GridLinesHor>Grid Lines Horizontal</GridLinesHor>
    <GridLinesHorRight>Grid Lines Horizontal Right</GridLinesHorRight>
    <GridLineStyle>Grid Line Style</GridLineStyle>
    <GridLinesVert>Grid Lines Vertical</GridLinesVert>
    <GridOutline>Grid Outline</GridOutline>
    <GrowToHeight>Grow to Height</GrowToHeight>
    <HeaderBackColor>Header Back Color</HeaderBackColor>
    <HeaderCanBreak>Header Can Break</HeaderCanBreak>
    <HeaderCanGrow>Header Can Grow</HeaderCanGrow>
    <HeaderCanShrink>Header Can Shrink</HeaderCanShrink>
    <HeaderFont>Header Font</HeaderFont>
    <HeaderForeColor>Header Fore Color</HeaderForeColor>
    <HeaderPrintAtBottom>Header Print At Bottom</HeaderPrintAtBottom>
    <HeaderPrintIfEmpty>Header Print If Empty</HeaderPrintIfEmpty>
    <HeaderPrintOn>Header Print On</HeaderPrintOn>
    <HeaderPrintOnAllPages>Header Print On All Pages</HeaderPrintOnAllPages>
    <HeaderPrintOnEvenOddPages>Header Print On Even Odd Pages</HeaderPrintOnEvenOddPages>
    <HeaderRowsCount>Header Rows Count</HeaderRowsCount>
    <Headers>Headers</Headers>
    <HeaderText>Header Text</HeaderText>
    <Height>Height</Height>
    <HideSeriesWithEmptyTitle>Hide Series with Empty Title</HideSeriesWithEmptyTitle>
    <HideZeros>Hide Zeros</HideZeros>
    <High>High</High>
    <HighlightCondition>Highlight Condition</HighlightCondition>
    <HorAlignment>Horizontal Alignment</HorAlignment>
    <HorSpacing>Horizontal Spacing</HorSpacing>
    <HotkeyPrefix>Hotkey Prefix</HotkeyPrefix>
    <HtmlTags>Html Tags</HtmlTags>
    <Hyperlink>Hyperlink</Hyperlink>
    <HyperlinkDataColumn>Hyperlink Data Column</HyperlinkDataColumn>
    <Icon>Icon</Icon>
    <IconSet>Icon Set</IconSet>
    <IconSetCondition>Icon Set Condition</IconSetCondition>
    <Idents>Indents</Idents>
    <Image>Image</Image>
    <ImageAlign>Image Align</ImageAlign>
    <ImageAlignment>Image Alignment</ImageAlignment>
    <ImageData>Image Data</ImageData>
    <ImageHorAlignment>Image Horizontal Alignment</ImageHorAlignment>
    <ImageMultipleFactor>Image Multiple Factor</ImageMultipleFactor>
    <ImageRotation>Image Rotation</ImageRotation>
    <ImageStretch>Image Stretch</ImageStretch>
    <ImageTiling>Image Tiling</ImageTiling>
    <ImageTransparency>Image Transparency</ImageTransparency>
    <ImageURL>Image URL</ImageURL>
    <ImageVertAlignment>Image Vertical Alignment</ImageVertAlignment>
    <ImportRelations>Import Relations</ImportRelations>
    <Increment>Increment</Increment>
    <Indent>Indent</Indent>
    <InitBy>Init by</InitBy>
    <Insert>Insert</Insert>
    <Interaction>Interaction</Interaction>
    <InterlacedBrush>Interlaced Brush</InterlacedBrush>
    <InterlacingHor>Interlacing Horizontal</InterlacingHor>
    <InterlacingVert>Interlacing Vertical</InterlacingVert>
    <Italic>Italic</Italic>
    <Item>Item</Item>
    <ItemHeight>Item Height</ItemHeight>
    <Items>Items</Items>
    <KeepChildTogether>Keep Child Together</KeepChildTogether>
    <KeepCrossTabTogether>Keep Cross-Tab Together</KeepCrossTabTogether>
    <KeepDetails>Keep Details</KeepDetails>
    <KeepDetailsTogether>Keep Details Together</KeepDetailsTogether>
    <KeepFooterTogether>Keep Footer Together</KeepFooterTogether>
    <KeepGroupFooterTogether>Keep Group Footer Together</KeepGroupFooterTogether>
    <KeepGroupHeaderTogether>Keep Group Header Together</KeepGroupHeaderTogether>
    <KeepGroupTogether>Keep Group Together</KeepGroupTogether>
    <KeepHeaderTogether>Keep Header Together</KeepHeaderTogether>
    <KeepReportSummaryTogether>Keep Report Summary Together</KeepReportSummaryTogether>
    <KeepSubReportTogether>Keep Sub-Report Together</KeepSubReportTogether>
    <Key>Key</Key>
    <KeyDataColumn>Key Data Column</KeyDataColumn>
    <Keys>Keys</Keys>
    <LabelColor>Label Color</LabelColor>
    <Labels>Labels</Labels>
    <LabelsColor>Labels Color</LabelsColor>
    <LabelsOffset>Labels Offset</LabelsOffset>
    <Language>Language</Language>
    <LargeHeight>Large Height</LargeHeight>
    <LargeHeightFactor>Large Height Factor</LargeHeightFactor>
    <Left>Left</Left>
    <LeftSide>Left Side</LeftSide>
    <Legend>Legend</Legend>
    <LegendValueType>Legend Value Type</LegendValueType>
    <Length>Length</Length>
    <LengthUnderLabels>Length under Labels</LengthUnderLabels>
    <Lighting>Lighting</Lighting>
    <Linear>Linear</Linear>
    <LineColor>Line Color</LineColor>
    <LineColorNegative>Line Color Negative</LineColorNegative>
    <LineLimit>Line Limit</LineLimit>
    <LineMarker>Line Marker</LineMarker>
    <LinesOfUnderline>Lines of Underline</LinesOfUnderline>
    <LineStyle>Line Style</LineStyle>
    <LineWidth>Line Width</LineWidth>
    <Linked>Linked</Linked>
    <ListOfArguments>List of Arguments</ListOfArguments>
    <ListOfHyperlinks>List Of Hyperlinks</ListOfHyperlinks>
    <ListOfTags>List Of Tags</ListOfTags>
    <ListOfToolTips>List Of Tool Tip</ListOfToolTips>
    <ListOfValues>List of Values</ListOfValues>
    <ListOfValuesEnd>List of Values End</ListOfValuesEnd>
    <ListOfValuesClose>List of Values Close</ListOfValuesClose>
    <ListOfValuesHigh>List of Values High</ListOfValuesHigh>
    <ListOfValuesLow>List of Values Low</ListOfValuesLow>
    <ListOfValuesOpen>List of Values Open</ListOfValuesOpen>
    <ListOfWeights>List of Weights</ListOfWeights>
    <Localizable>Localizable</Localizable>
    <Location>Location</Location>
    <Locked>Locked</Locked>
    <Logarithmic>Logarithmic</Logarithmic>
    <LogarithmicScale>Logarithmic Scale</LogarithmicScale>
    <Low>Low</Low>
    <Margins>Margins</Margins>
    <Marker>Marker</Marker>
    <MarkerAlignment>Marker Alignment</MarkerAlignment>
    <MarkerBorder>Marker Border</MarkerBorder>
    <MarkerColor>Marker Color</MarkerColor>
    <MarkerSize>Marker Size</MarkerSize>
    <MarkerType>Marker Type</MarkerType>
    <MarkerVisible>Marker Visible</MarkerVisible>
    <MasterComponent>Master Component</MasterComponent>
    <MasterKeyDataColumn>Master Key Data Column</MasterKeyDataColumn>
    <MatrixSize>Matrix Size</MatrixSize>
    <MaxDate>Max Date</MaxDate>
    <MaxDropDownItems>Max Drop Down Items</MaxDropDownItems>
    <MaxHeight>Max Height</MaxHeight>
    <Maximum>Maximum</Maximum>
    <MaxLength>Max Length</MaxLength>
    <MaxNumberOfLines>Max Number of Lines</MaxNumberOfLines>
    <MaxSize>Max Size</MaxSize>
    <MaxValue>Max Value</MaxValue>
    <MaxWidth>Max Width</MaxWidth>
    <MergeDuplicates>Merge Duplicates</MergeDuplicates>
    <MergeHeaders>Merge Headers</MergeHeaders>
    <Mid>Mid</Mid>
    <MinDate>Min Date</MinDate>
    <MinHeight>Min Height</MinHeight>
    <Minimum>Minimum</Minimum>
    <MinimumFontSize>Minimum Font Size</MinimumFontSize>
    <MinorColor>Minor Color</MinorColor>
    <MinorCount>Minor Count</MinorCount>
    <MinorLength>Minor Length</MinorLength>
    <MinorStyle>Minor Style</MinorStyle>
    <MinorVisible>Minor Visible</MinorVisible>
    <MinRowsInColumn>Min Rows in Column</MinRowsInColumn>
    <MinSize>Min Size</MinSize>
    <MinValue>Min Value</MinValue>
    <MinWidth>Min Width</MinWidth>
    <Mode>Mode</Mode>
    <Module>Module</Module>
    <Move>Move</Move>
    <Multiline>Multiline</Multiline>
    <MultipleFactor>Multiple Factor</MultipleFactor>
    <Name>Name</Name>
    <NameInSource>Name in Source</NameInSource>
    <NameParent>Parent Name</NameParent>
    <Namespaces>Namespaces</Namespaces>
    <Negative>Negative</Negative>
    <NestedLevel>Nested Level</NestedLevel>
    <NewColumnAfter>New Column After</NewColumnAfter>
    <NewColumnBefore>New Column Before</NewColumnBefore>
    <NewPageAfter>New Page After</NewPageAfter>
    <NewPageBefore>New Page Before</NewPageBefore>
    <NextPage>Next Page</NextPage>
    <NoIcon>No Icon</NoIcon>
    <NullText>Null Text</NullText>
    <NumberOfColumns>Number of Columns</NumberOfColumns>
    <NumberOfCopies>Number of Copies</NumberOfCopies>
    <NumberOfPass>Number of Pass</NumberOfPass>
    <NumberOfValues>Number of Values</NumberOfValues>
    <OddStyle>Odd Style</OddStyle>
    <OnlyText>Only Text</OnlyText>
    <Operation>Operation</Operation>
    <Options>Options</Options>
    <Orientation>Orientation</Orientation>
    <OthersText>Others Text</OthersText>
    <PageHeight>Page Height</PageHeight>
    <PageNumbers>Page Numbers</PageNumbers>
    <PageWidth>Page Width</PageWidth>
    <Paper>Paper</Paper>
    <PaperSize>Paper Size</PaperSize>
    <PaperSourceOfFirstPage>Paper Source of First Page</PaperSourceOfFirstPage>
    <PaperSourceOfOtherPages>Paper Source of Other Pages</PaperSourceOfOtherPages>
    <Parameter>Parameter</Parameter>
    <Parameters>Parameters</Parameters>
    <ParametersOrientation>Parameters Orientation</ParametersOrientation>
    <ParentColumns>Parent Columns</ParentColumns>
    <ParentSource>Parent Data Source</ParentSource>
    <ParentValue>Parent Value</ParentValue>
    <PasswordChar>Password Char</PasswordChar>
    <Path>Path</Path>
    <PathData>Path Data</PathData>
    <PathSchema>Path Schema</PathSchema>
    <Placement>Placement</Placement>
    <PlaceOnToolbox>Place on Toolbox</PlaceOnToolbox>
    <PointAtCenter>Point at Center</PointAtCenter>
    <Position>Position</Position>
    <Positive>Positive</Positive>
    <PreferredColumnWidth>Preferred Column Width</PreferredColumnWidth>
    <PreferredRowHeight>Preferred Row Height</PreferredRowHeight>
    <PreventIntersection>Prevent Intersection</PreventIntersection>
    <PreviewMode>Preview Mode</PreviewMode>
    <PreviewSettings>Preview Settings</PreviewSettings>
    <Printable>Printable</Printable>
    <PrintAtBottom>Print at Bottom</PrintAtBottom>
    <PrinterName>Printer Name</PrinterName>
    <PrinterSettings>Printer Settings</PrinterSettings>
    <PrintHeadersFootersFromPreviousPage>Print Headers and Footers from Previous Page</PrintHeadersFootersFromPreviousPage>
    <PrintIfDetailEmpty>Print if Detail Empty</PrintIfDetailEmpty>
    <PrintIfEmpty>Print if Empty</PrintIfEmpty>
    <PrintIfParentDisabled>Print if Parent Disabled</PrintIfParentDisabled>
    <PrintOn>Print on</PrintOn>
    <PrintOnAllPages>Print on All Pages</PrintOnAllPages>
    <PrintOnEvenOddPages>Print on Even Odd Pages</PrintOnEvenOddPages>
    <PrintOnPreviousPage>Print on Previous Page</PrintOnPreviousPage>
    <PrintTitleOnAllPages>Print Title On All Pages</PrintTitleOnAllPages>
    <PrintVerticalBars>Print Vertical Bars</PrintVerticalBars>
    <ProcessAt>Process at</ProcessAt>
    <ProcessAtEnd>Process at End</ProcessAtEnd>
    <ProcessingDuplicates>Processing Duplicates</ProcessingDuplicates>
    <ProductHomePage>Product Home Page</ProductHomePage>
    <RadarStyle>Radar Style</RadarStyle>
    <Range>Range</Range>
    <RangeFrom>From</RangeFrom>
    <RangeScrollEnabled>Range Scroll Enabled</RangeScrollEnabled>
    <RangeTo>To</RangeTo>
    <Ratio>Ratio</Ratio>
    <RatioY>Ratio Y</RatioY>
    <ReadOnly>Read Only</ReadOnly>
    <ReconnectOnEachRow>Reconnect on Each Row</ReconnectOnEachRow>
    <ReferencedAssemblies>Referenced Assemblies</ReferencedAssemblies>
    <Refresh>Refresh</Refresh>
    <Relation>Relation</Relation>
    <RelationName>Relation Name</RelationName>
    <Relations>Relations</Relations>
    <RemoveUnusedDataBeforeStart>Remove Unused Data Before Start</RemoveUnusedDataBeforeStart>
    <RenderTo>Render to</RenderTo>
    <ReportAlias>Report Alias</ReportAlias>
    <ReportAuthor>Report Author</ReportAuthor>
    <ReportCacheMode>Report Cache Mode</ReportCacheMode>
    <ReportDescription>Report Description</ReportDescription>
    <ReportName>Report Name</ReportName>
    <ReportUnit>Report Unit</ReportUnit>
    <RequestFromUser>Request from User</RequestFromUser>
    <RequestParameters>Request Parameters</RequestParameters>
    <ResetDataSource>Reset Data Source</ResetDataSource>
    <ResetPageNumber>Reset Page Number</ResetPageNumber>
    <Resize>Resize</Resize>
    <Restrictions>Restrictions</Restrictions>
    <ReturnValue>Return Value</ReturnValue>
    <ReverseHor>Reverse Horizontal</ReverseHor>
    <ReverseVert>Reverse Vertical</ReverseVert>
    <Right>Right</Right>
    <RightSide>Right Side</RightSide>
    <RightToLeft>Right to Left</RightToLeft>
    <Rotation>Rotation</Rotation>
    <RotationLabels>Rotation Labels</RotationLabels>
    <Round>Round</Round>
    <RowCount>Row Count</RowCount>
    <RowHeadersVisible>Row Headers Visible</RowHeadersVisible>
    <RowHeaderWidth>Row Header Width</RowHeaderWidth>
    <Scale>Scale</Scale>
    <ScaleHor>Scale Hor</ScaleHor>
    <ScriptLanguage>Script Language</ScriptLanguage>
    <SegmentPerHeight>Segment per Height</SegmentPerHeight>
    <SegmentPerWidth>Segment per Width</SegmentPerWidth>
    <SelectedIndex>Selected Index</SelectedIndex>
    <SelectedItem>Selected Item</SelectedItem>
    <SelectedKey>Selected Key</SelectedKey>
    <SelectedValue>Selected Value</SelectedValue>
    <SelectionBackColor>Selection Back Color</SelectionBackColor>
    <SelectionEnabled>Selection Enabled</SelectionEnabled>
    <SelectionForeColor>Selection Fore Color</SelectionForeColor>
    <SelectionMode>Selection Mode</SelectionMode>
    <Series>Series</Series>
    <SeriesLabels>Series Labels</SeriesLabels>
    <Shadow>Shadow</Shadow>
    <ShadowBrush>Shadow Brush</ShadowBrush>
    <ShadowColor>Shadow Color</ShadowColor>
    <ShadowSize>Shadow Size</ShadowSize>
    <ShapeType>Shape Type</ShapeType>
    <Shift>Shift</Shift>
    <ShiftMode>Shift Mode</ShiftMode>
    <ShowBehind>Show Behind</ShowBehind>
    <ShowDialog>Show Dialog</ShowDialog>
    <ShowEdgeValues>Show Edge Values</ShowEdgeValues>
    <ShowImageBehind>Show Image Behind</ShowImageBehind>
    <ShowInLegend>Show in Legend</ShowInLegend>
    <ShowInPercent>Show in Percent</ShowInPercent>
    <ShowLabels>Show Labels</ShowLabels>
    <ShowLabelText>Show Label Text</ShowLabelText>
    <ShowMarker>Show Marker</ShowMarker>
    <ShowNulls>Show Nulls</ShowNulls>
    <ShowOthers>Show Others</ShowOthers>
    <ShowPercents>Show Percents</ShowPercents>
    <ShowQuietZoneIndicator>Show Quiet Zone Indicator</ShowQuietZoneIndicator>
    <ShowQuietZones>Show Quiet Zones</ShowQuietZones>
    <ShowScrollBar>Show Scroll Bar</ShowScrollBar>
    <ShowSeriesLabels>Show Series Labels</ShowSeriesLabels>
    <ShowShadow>Show Shadow</ShowShadow>
    <ShowTotal>Show Total</ShowTotal>
    <ShowUpDown>Show Up Down</ShowUpDown>
    <ShowValue>Show Value</ShowValue>
    <ShowXAxis>Show X Axis</ShowXAxis>
    <ShowYAxis>Show Y Axis</ShowYAxis>
    <ShowZeros>Show Zeros</ShowZeros>
    <ShrinkFontToFit>Shrink Font to Fit</ShrinkFontToFit>
    <ShrinkFontToFitMinimumSize>Shrink Font to Fit Minimum Size</ShrinkFontToFitMinimumSize>
    <Side>Side</Side>
    <Sides>Sides</Sides>
    <Simple>Simple</Simple>
    <Size>Size</Size>
    <SizeMode>Size Mode</SizeMode>
    <SkipFirst>Skip First</SkipFirst>
    <Smoothing>Smoothing</Smoothing>
    <Sort>Sort</Sort>
    <SortBy>Sort by</SortBy>
    <SortDirection>Sort Direction</SortDirection>
    <Sorted>Sorted</Sorted>
    <SortingColumn>Sorting Column</SortingColumn>
    <SortingEnabled>Sorting Enabled</SortingEnabled>
    <SortType>Sort Type</SortType>
    <Space>Space</Space>
    <Spacing>Spacing</Spacing>
    <SqlCommand>Sql Command</SqlCommand>
    <StartAngle>Start Angle</StartAngle>
    <StartCap>Start Cap</StartCap>
    <StartColor>Start Color</StartColor>
    <StartFromZero>Start From Zero</StartFromZero>
    <StartMode>Start Mode</StartMode>
    <StartNewPage>Start New Page</StartNewPage>
    <StartNewPageIfLessThan>Start New Page if Less Than</StartNewPageIfLessThan>
    <StartPosition>Start Position</StartPosition>
    <Step>Step</Step>
    <Stop>Stop</Stop>
    <StopBeforePage>Stop Before Page</StopBeforePage>
    <StopBeforePrint>Stop Before Print</StopBeforePrint>
    <StoreImagesInResources>Store Images in Resources</StoreImagesInResources>
    <Stretch>Stretch</Stretch>
    <StretchToPrintArea>Stretch to Print Area</StretchToPrintArea>
    <StripBrush>Strip Brush</StripBrush>
    <Strips>Strips</Strips>
    <Style>Style</Style>
    <StyleColors>Style Colors</StyleColors>
    <Styles>Styles</Styles>
    <SubReportPage>Sub Report Page</SubReportPage>
    <Summary>Summary</Summary>
    <SummaryExpression>Summary Expression</SummaryExpression>
    <SummarySortDirection>Summary Sort Direction</SummarySortDirection>
    <SummaryType>Summary Type</SummaryType>
    <SummaryValues>Summary Values</SummaryValues>
    <SupplementCode>Supplement Code</SupplementCode>
    <SupplementType>Supplement Type</SupplementType>
    <SystemVariable>System Variable</SystemVariable>
    <SystemVariables>System Variables</SystemVariables>
    <Tag>Tag</Tag>
    <TagDataColumn>Tag Data Column</TagDataColumn>
    <TagValue>Tag Value</TagValue>
    <Tension>Tension</Tension>
    <Text>Text</Text>
    <TextAfter>Text After</TextAfter>
    <TextAlign>Text Align</TextAlign>
    <TextAlignment>Text Alignment</TextAlignment>
    <TextBefore>Text Before</TextBefore>
    <TextBrush>Text Brush</TextBrush>
    <TextColor>Text Color</TextColor>
    <TextFormat>Text Format</TextFormat>
    <TextOnly>Text Only</TextOnly>
    <TextOptions>Text Options</TextOptions>
    <TextQuality>Text Quality</TextQuality>
    <Ticks>Ticks</Ticks>
    <Title>Title</Title>
    <TitleBeforeHeader>Title before Header</TitleBeforeHeader>
    <TitleColor>Title Color</TitleColor>
    <TitleDirection>TitleDirection</TitleDirection>
    <TitleFont>Title Font</TitleFont>
    <TitleVisible>Visible</TitleVisible>
    <To>To</To>
    <Today>Today</Today>
    <ToolTip>Tool Tip</ToolTip>
    <ToolTipDataColumn>Tool Tip Data Column</ToolTipDataColumn>
    <Top>Top</Top>
    <Topmost>Topmost</Topmost>
    <TopmostLine>Topmost Line</TopmostLine>
    <TopN>Top N</TopN>
    <TopSide>Top Side</TopSide>
    <Total>Total</Total>
    <Totals>Totals</Totals>
    <TransparentColor>Transparent Color</TransparentColor>
    <Trimming>Trimming</Trimming>
    <TrendLine>Trend Line</TrendLine>
    <Type>Type</Type>
    <TypeName>Type Name</TypeName>
    <Types>Types</Types>
    <Underline>Underline</Underline>
    <UndoLimit>Undo Limit</UndoLimit>
    <Unit>Unit</Unit>
    <UnlimitedBreakable>Unlimited Breakable</UnlimitedBreakable>
    <UnlimitedHeight>Unlimited Height</UnlimitedHeight>
    <UnlimitedWidth>Unlimited Width</UnlimitedWidth>
    <UseAliases>Use Aliases</UseAliases>
    <UseExternalReport>Use External Report</UseExternalReport>
    <UseParentStyles>Use Parent Styles</UseParentStyles>
    <UseRectangularSymbols>Use Rectangular Symbols</UseRectangularSymbols>
    <UseSeriesColor>Use Series Color</UseSeriesColor>
    <UseStyleOfSummaryInColumnTotal>Use Style of Summary in Column Total</UseStyleOfSummaryInColumnTotal>
    <UseStyleOfSummaryInRowTotal>Use Style of Summary in Row Total</UseStyleOfSummaryInRowTotal>
    <Value>Value</Value>
    <ValueDataColumn>Value Data Column</ValueDataColumn>
    <ValueDataColumnEnd>Value Data Column End</ValueDataColumnEnd>
    <ValueDataColumnClose>Value Data Column Close</ValueDataColumnClose>
    <ValueDataColumnHigh>Value Data Column High</ValueDataColumnHigh>
    <ValueDataColumnLow>Value Data Column Low</ValueDataColumnLow>
    <ValueDataColumnOpen>Value Data Column Open</ValueDataColumnOpen>    
    <ValueEnd>Value End</ValueEnd>
    <ValueClose>Value Close</ValueClose>
    <ValueHigh>Value High</ValueHigh>
    <ValueLow>Value Low</ValueLow>
    <ValueOpen>Value Open</ValueOpen>    
    <Values>Values</Values>
    <ValueType>Value Type</ValueType>
    <ValueTypeSeparator>Value Type Separator</ValueTypeSeparator>
    <Variable>Variable</Variable>
    <Variables>Variables</Variables>
    <Version>Version</Version>
    <VertAlignment>Vertical Alignment</VertAlignment>
    <VertSpacing>Vertical Spacing</VertSpacing>
    <ViewMode>View Mode</ViewMode>
    <Visible>Visible</Visible>
    <Watermark>Watermark</Watermark>
    <Weight>Weight</Weight>
    <WeightDataColumn>Weight Data Column</WeightDataColumn>
    <Width>Width</Width>
    <WindowState>Window State</WindowState>
    <WordWrap>Word Wrap</WordWrap>
    <Wrap>Wrap</Wrap>
    <WrapGap>WrapGap</WrapGap>
    <XAxis>X Axis</XAxis>
    <XTopAxis>X Top Axis</XTopAxis>
    <YAxis>Y Axis</YAxis>
    <YRightAxis>Y Right Axis</YRightAxis>
    <Zoom>Zoom</Zoom>
  </PropertyMain>
  <PropertySystemColors>
    <ActiveBorder>Active Border</ActiveBorder>
    <ActiveCaption>Active Caption</ActiveCaption>
    <ActiveCaptionText>Active Caption Text</ActiveCaptionText>
    <AppWorkspace>App Workspace</AppWorkspace>
    <Control>Control</Control>
    <ControlDark>Control Dark</ControlDark>
    <ControlDarkDark>Control Dark Dark</ControlDarkDark>
    <ControlLight>Control Light</ControlLight>
    <ControlLightLight>Control Light Light</ControlLightLight>
    <ControlText>Control Text</ControlText>
    <Desktop>Desktop</Desktop>
    <GrayText>Gray Text</GrayText>
    <Highlight>Highlight</Highlight>
    <HighlightText>Highlight Text</HighlightText>
    <HotTrack>Hot Track</HotTrack>
    <InactiveBorder>Inactive Border</InactiveBorder>
    <InactiveCaption>Inactive Caption</InactiveCaption>
    <InactiveCaptionText>Inactive Caption Text</InactiveCaptionText>
    <Info>Info</Info>
    <InfoText>Info Text</InfoText>
    <Menu>Menu</Menu>
    <MenuText>Menu Text</MenuText>
    <ScrollBar>Scroll Bar</ScrollBar>
    <Window>Window</Window>
    <WindowFrame>Window Frame</WindowFrame>
    <WindowText>Window Text</WindowText>
  </PropertySystemColors>
  <QueryBuilder>
    <AddObject>Add Object</AddObject>
    <AddSubQuery>Add Derived Table</AddSubQuery>
    <AllObjects>(All objects)</AllObjects>
    <BadFromObjectExpression>Invalid FROM object expression!</BadFromObjectExpression>
    <BadObjectName>Invalid object name!</BadObjectName>
    <BadSelectStatement>Invalid SELECT statement!</BadSelectStatement>
    <CreateLinksFromForeignKeys>Create Links from Foreign Keys</CreateLinksFromForeignKeys>
    <CriteriaAlias>Alias</CriteriaAlias>
    <CriteriaCriteria>Criteria</CriteriaCriteria>
    <CriteriaExpression>Expression</CriteriaExpression>
    <CriteriaGroupBy>Group By</CriteriaGroupBy>
    <CriteriaOr>Or...</CriteriaOr>
    <CriteriaOutput>Output</CriteriaOutput>
    <CriteriaSortOrder>Sort Order</CriteriaSortOrder>
    <CriteriaSortType>Sort Type</CriteriaSortType>
    <Database>Database</Database>
    <DataSourceProperties>Data Source Properties</DataSourceProperties>
    <DialectDontSupportDatabases>The server does not support queries with objects from different databases.</DialectDontSupportDatabases>
    <DialectDontSupportSchemas>The server does not support schemas.</DialectDontSupportSchemas>
    <DialectDontSupportUnions>This server does not support unions.</DialectDontSupportUnions>
    <DialectDontSupportUnionsBrackets>This server does not support brackets in unions.</DialectDontSupportUnionsBrackets>
    <DialectDontSupportUnionsBracketsInSubQuery>This server doesn't support brackets in unions in subqueries.</DialectDontSupportUnionsBracketsInSubQuery>
    <DialectDontSupportUnionsInSubQueries>This server does not support unions in subqueries.</DialectDontSupportUnionsInSubQueries>
    <Edit>Edit</Edit>
    <EncloseWithBrackets>Enclose with brackets</EncloseWithBrackets>
    <Expressions>Expressions</Expressions>
    <InsertEmptyItem>Insert Empty Item</InsertEmptyItem>
    <JoinExpression>Join Expression</JoinExpression>
    <LabelAlias>Alias:</LabelAlias>
    <LabelFilterObjectsBySchemaName>Filter Objects by Schema Name:</LabelFilterObjectsBySchemaName>
    <LabelJoinExpression>Join Expression:</LabelJoinExpression>
    <LabelLeftColumn>Left Column:</LabelLeftColumn>
    <LabelLeftObject>Left Object:</LabelLeftObject>
    <LabelObject>Object:</LabelObject>
    <LabelRightColumn>Right Column:</LabelRightColumn>
    <LabelRightObject>Right Object:</LabelRightObject>
    <LinkProperties>Link Properties</LinkProperties>
    <MetadataProviderCantExecSQL>Used metadata provider cannot execute SQL queries.</MetadataProviderCantExecSQL>
    <MetaProviderCantLoadMetadata>Used metadata provider cannot automatically load metadata.</MetaProviderCantLoadMetadata>
    <MetaProviderCantLoadMetadataForDatabase>Used metadata provider cannot automatically load metadata for database: {0}</MetaProviderCantLoadMetadataForDatabase>
    <MoveDown>Move Down</MoveDown>
    <MoveUp>Move Up</MoveUp>
    <NewUnionSubQuery>New union sub-query</NewUnionSubQuery>
    <NoConnectionObject>No connection object (property {0} not assigned).</NoConnectionObject>
    <NoTransactionObject>No transaction object (property {0} not assigned).</NoTransactionObject>
    <Objects>Objects</Objects>
    <ProcedureParameters>Procedure Parameters</ProcedureParameters>
    <Procedures>Procedures</Procedures>
    <qnSaveChanges>Do you want to save changes of query?</qnSaveChanges>
    <Query>Query</Query>
    <QueryBuilder>Query Builder</QueryBuilder>
    <QueryParameters>Query Parameters</QueryParameters>
    <QueryProperties>Query Properties</QueryProperties>
    <Remove>Remove</Remove>
    <RemoveBrackets>Remove brackets</RemoveBrackets>
    <RunQueryBuilder>Run Query Builder</RunQueryBuilder>
    <SelectAllFromLeft>Select All from Left</SelectAllFromLeft>
    <SelectAllFromRight>Select All from Right</SelectAllFromRight>
    <SwitchToDerivedTable>Switch to Derived Table</SwitchToDerivedTable>
    <Tables>Tables</Tables>
    <UnexpectedTokenAt>Unexpected token \"{0}\" at line {1}, pos {2}!</UnexpectedTokenAt>
    <Unions>Unions</Unions>
    <UnionSubMenu>Union</UnionSubMenu>
    <ViewQuery>View Query</ViewQuery>
    <Views>Views</Views>
  </QueryBuilder>
  <Questions>
    <qnConfiguration>Please choose the type of configuration for the properties panel. The type of the selected configuration depends on the number of visible properties and their complexity for the developer of reports. You can always change the configuration type from the context menu of the properties panel.</qnConfiguration>
    <qnDictionaryNew>Do you want to create new Dictionary?</qnDictionaryNew>
    <qnLanguageNew>You have changed the language of the report. This will lead to the new report code generation. Are you certain you want to save the new language?</qnLanguageNew>
    <qnPageDelete>Do you want to delete page?</qnPageDelete>
    <qnRemove>Do you want to remove?</qnRemove>
    <qnRemoveService>Do you want to remove Service?</qnRemoveService>
    <qnRemoveServiceCategory>Do you want to remove Category?</qnRemoveServiceCategory>
    <qnRemoveUnused>Do you want to remove Unused?</qnRemoveUnused>
    <qnRestoreDefault>Restore defaults?</qnRestoreDefault>
    <qnSaveChanges>Save changes in {0}?</qnSaveChanges>
    <qnSaveChangesToPreviewPage>Do you want to save page changes?</qnSaveChangesToPreviewPage>
    <qnSynchronize>Synchronized contents of the Data Store and contents of the Dictionary?</qnSynchronize>
    <qnSynchronizeServices>Synchronized services?</qnSynchronizeServices>
  </Questions>
  <Report>
    <Alphabetical>Alphabetical</Alphabetical>
    <Bands>Bands</Bands>
    <Basic>Basic</Basic>
    <BasicConfiguration>Minimal number of object properties, which are necessary for rendering the basic report types.</BasicConfiguration>
    <BusinessObjects>Business Objects</BusinessObjects>
    <Categorized>Categorized</Categorized>
    <Charts>Charts</Charts>
    <ClickForMoreDetails>Click for More Details</ClickForMoreDetails>
    <CollapseAll>Collapse All</CollapseAll>
    <Collection>Collection</Collection>
    <CompilingReport>Compiling Report</CompilingReport>
    <Complete>Complete</Complete>
    <Components>Components</Components>
    <ConnectingToData>Connecting to Data</ConnectingToData>
    <CopyOf>Copy</CopyOf>
    <CreateNewReportPageForm>Create a new report, add a page, add a form</CreateNewReportPageForm>
    <CreatingReport>Creating Report</CreatingReport>
    <CrossBands>Cross Bands</CrossBands>
    <Dialogs>Dialogs</Dialogs>
    <EditStyles>[Edit Styles]</EditStyles>
    <Errors>Errors</Errors>
    <EventsTab>Events Tab</EventsTab>
    <ExpandAll>Expand All</ExpandAll>
    <FilterAnd>And</FilterAnd>
    <FilterOr>Or</FilterOr>
    <FinishingReport>Finishing Report</FinishingReport>
    <FirstPass>First Pass</FirstPass>
    <GenerateNewCode>Generate New Code</GenerateNewCode>
    <InfoMessage>{0} - {1} found.</InfoMessage>
    <InformationMessages>Information Messages</InformationMessages>
    <LabelAlias>Alias:</LabelAlias>
    <LabelAuthor>Author:</LabelAuthor>
    <LabelBackground>Background:</LabelBackground>
    <LabelCategory>Category:</LabelCategory>
    <LabelCentimeters>Centimeters:</LabelCentimeters>
    <LabelCollectionName>Collection Name:</LabelCollectionName>
    <LabelColor>Color:</LabelColor>
    <LabelCountData>Count Data:</LabelCountData>
    <LabelDataBand>DataBand:</LabelDataBand>
    <LabelDataColumn>Data Column:</LabelDataColumn>
    <LabelDefaultValue>Default Value:</LabelDefaultValue>
    <LabelExpression>Expression:</LabelExpression>
    <LabelFactorLevel>Nested Factor:</LabelFactorLevel>
    <LabelFontName>Font Name:</LabelFontName>
    <LabelFunction>Function:</LabelFunction>
    <LabelHundredthsOfInch>Hundredths of Inch:</LabelHundredthsOfInch>
    <LabelInches>Inches:</LabelInches>
    <LabelMillimeters>Millimeters:</LabelMillimeters>
    <LabelName>Name:</LabelName>
    <LabelNameInSource>Name in Source:</LabelNameInSource>
    <LabelNestedLevel>Nested Level:</LabelNestedLevel>
    <LabelPassword>Password:</LabelPassword>
    <LabelPixels>Pixels:</LabelPixels>
    <LabelSystemVariable>System Variable:</LabelSystemVariable>
    <LabelTotals>Totals</LabelTotals>
    <LabelType>Type:</LabelType>
    <LabelUserName>User Name:</LabelUserName>
    <LabelValue>Value:</LabelValue>
    <LoadingReport>Loading Report</LoadingReport>
    <nameAssembly>Assembly</nameAssembly>
    <No>No</No>
    <NoIssues>No Issues</NoIssues>
    <NotAssigned>Not Assigned</NotAssigned>
    <Office2010Back>Back</Office2010Back>
    <PageNofM>Page {0} of {1}</PageNofM>
    <PreparingReport>Preparing Report</PreparingReport>
    <Professional>Professional</Professional>
    <ProfessionalConfiguration>All object properties.</ProfessionalConfiguration>
    <PropertiesTab>Properties Tab</PropertiesTab>
    <RangeAll>All</RangeAll>
    <RangeCurrentPage>Current Page</RangeCurrentPage>
    <RangeInfo>Enter page number and/or pages ranges separated by commas. For example: 1, 3, 5-12</RangeInfo>
    <RangePage>Page Range</RangePage>
    <RangePages>Pages:</RangePages>
    <ReportChecker>Report Checker</ReportChecker>
    <ReportRenderingMessages>Report Rendering Messages</ReportRenderingMessages>
    <RestartDesigner>You need to restart the report designer</RestartDesigner>
    <SaveReportPagesOrFormsFromReport>Save the report, pages or forms</SaveReportPagesOrFormsFromReport>
    <SavingReport>Saving Report</SavingReport>
    <SecondPass>Second Pass</SecondPass>
    <Standard>Standard</Standard>
    <StandardConfiguration>Main object properties except rarely used ones.</StandardConfiguration>
    <StiEmptyBrush>Empty</StiEmptyBrush>
    <StiGlareBrush>Glare</StiGlareBrush>
    <StiGlassBrush>Glass</StiGlassBrush>
    <StiGradientBrush>Gradient</StiGradientBrush>
    <StiHatchBrush>Hatch</StiHatchBrush>
    <StiSolidBrush>Solid</StiSolidBrush>
    <StyleBad>Bad</StyleBad>
    <StyleGood>Good</StyleGood>
    <StyleNeutral>Neutral</StyleNeutral>
    <StyleNormal>Normal</StyleNormal>
    <StyleNote>Note</StyleNote>
    <StyleWarning>Warning</StyleWarning>
    <Warnings>Warnings</Warnings>
    <When>when {0} {1}</When>
    <WhenAnd>when {0} {1} and</WhenAnd>
    <WhenValueIs>when value is</WhenValueIs>
  </Report>
  <Services>
    <categoryContextTools>Context Tools</categoryContextTools>
    <categoryDesigner>Designer</categoryDesigner>
    <categoryDictionary>Dictionary</categoryDictionary>
    <categoryExport>Exports</categoryExport>
    <categoryLanguages>Languages</categoryLanguages>
    <categoryPanels>Panels</categoryPanels>
    <categoryRender>Render</categoryRender>
    <categoryShapes>Shapes</categoryShapes>
    <categorySL>Save / Load</categorySL>
    <categorySystem>System</categorySystem>
    <categoryTextFormat>Text Format</categoryTextFormat>
  </Services>
  <Shapes>
    <Arrow>Arrow</Arrow>
    <BasicShapes>Basic Shapes</BasicShapes>
    <BentArrow>Bent Arrow</BentArrow>
    <BlockArrows>Block Arrows</BlockArrows>
    <Chevron>Chevron</Chevron>
    <ComplexArrow>Complex Arrow</ComplexArrow>
    <DiagonalDownLine>Diagonal Line Down</DiagonalDownLine>
    <DiagonalUpLine>Diagonal Line Up</DiagonalUpLine>
    <Division>Division</Division>
    <Equal>Equal</Equal>
    <EquationShapes>Equation Shapes</EquationShapes>
    <FlowchartCard>Flowchart: Card</FlowchartCard>
    <FlowchartCollate>Flowchart: Collate</FlowchartCollate>
    <FlowchartDecision>Flowchart: Decision</FlowchartDecision>
    <FlowchartManualInput>Flowchart: Manual Input</FlowchartManualInput>
    <FlowchartOffPageConnector>Flowchart: Off Page Connector</FlowchartOffPageConnector>
    <FlowchartPreparation>Flowchart: Preparation</FlowchartPreparation>
    <FlowchartSort>Flowchart: Sort</FlowchartSort>
    <Frame>Frame</Frame>
    <HorizontalLine>Horizontal Line</HorizontalLine>
    <InsertShapes>Insert Shapes</InsertShapes>
    <LeftAndRightLine>Left and Right Line</LeftAndRightLine>
    <Lines>Lines</Lines>
    <Minus>Minus</Minus>
    <Multiply>Multiply</Multiply>
    <Oval>Oval</Oval>
    <Parallelogram>Parallelogram</Parallelogram>
    <Plus>Plus</Plus>
    <Rectangle>Rectangle</Rectangle>
    <Rectangles>Rectangles</Rectangles>
    <RegularPentagon>Regular: Pentagon</RegularPentagon>
    <RoundedRectangle>Rounded Rectangle</RoundedRectangle>
    <ServiceCategory>Shapes</ServiceCategory>
    <ShapeStyles>Shape Styles</ShapeStyles>
    <SnipDiagonalSideCornerRectangle>Snip Diagonal Side Corner Rectangle</SnipDiagonalSideCornerRectangle>
    <SnipSameSideCornerRectangle>Snip Same Side Corner Rectangle</SnipSameSideCornerRectangle>
    <TopAndBottomLine>Top and Bottom Line</TopAndBottomLine>
    <Trapezoid>Trapezoid</Trapezoid>
    <Triangle>Triangle</Triangle>
    <VerticalLine>Vertical Line</VerticalLine>
  </Shapes>
  <TableRibbon>
    <BuiltIn>Built-In</BuiltIn>
    <Delete>Delete</Delete>
    <DeleteColumns>Delete Columns</DeleteColumns>
    <DeleteRows>Delete Rows</DeleteRows>
    <DeleteTable>Delete Table</DeleteTable>
    <DistributeColumns>Distribute Columns</DistributeColumns>
    <DistributeRows>Distribute Rows</DistributeRows>
    <InsertAbove>Insert Above</InsertAbove>
    <InsertBelow>Insert Below</InsertBelow>
    <InsertLeft>Insert Left</InsertLeft>
    <InsertRight>Insert Right</InsertRight>
    <PlainTables>Plain Tables</PlainTables>
    <ribbonBarRowsColumns>Rows and Columns</ribbonBarRowsColumns>
    <ribbonBarTable>Table</ribbonBarTable>
    <ribbonBarTableStyles>Table Styles</ribbonBarTableStyles>
    <Select>Select</Select>
    <SelectColumn>Select Column</SelectColumn>
    <SelectRow>Select Row</SelectRow>
    <SelectTable>Select Table</SelectTable>
  </TableRibbon>
  <Toolbars>
    <Align>Align</Align>
    <AlignBottom>Align Bottom</AlignBottom>
    <AlignCenter>Align Center</AlignCenter>
    <AlignLeft>Align Left</AlignLeft>
    <AlignMiddle>Align Middle</AlignMiddle>
    <AlignRight>Align Right</AlignRight>
    <AlignToGrid>Align to Grid</AlignToGrid>
    <AlignTop>Align Top</AlignTop>
    <AlignWidth>Justify</AlignWidth>
    <BringToFront>Bring to Front</BringToFront>
    <CenterHorizontally>Center Horizontally</CenterHorizontally>
    <CenterVertically>Center Vertically</CenterVertically>
    <Conditions>Conditions</Conditions>
    <FontGrow>Grow Font</FontGrow>
    <FontName>Font Name</FontName>
    <FontShrink>Shrink Font</FontShrink>
    <FontSize>Font Size</FontSize>
    <FontStyleBold>Font Style Bold</FontStyleBold>
    <FontStyleItalic>Font Style Italic</FontStyleItalic>
    <FontStyleUnderline>Font Style Underline</FontStyleUnderline>
    <Link>Link</Link>
    <Lock>Lock</Lock>
    <MakeHorizontalSpacingEqual>Make Horizontal Spacing Equal</MakeHorizontalSpacingEqual>
    <MakeSameHeight>Make Same Height as {0}</MakeSameHeight>
    <MakeSameSize>Make Same Size as {0}</MakeSameSize>
    <MakeSameWidth>Make Same Width as {0}</MakeSameWidth>
    <MakeVerticalSpacingEqual>Make Vertical Spacing Equal</MakeVerticalSpacingEqual>
    <MoveBackward>Move Backward</MoveBackward>
    <MoveForward>Move Forward</MoveForward>
    <Order>Order</Order>
    <SendToBack>Send to Back</SendToBack>
    <Size>Size</Size>
    <StyleDesigner>Style Designer</StyleDesigner>
    <Styles>List of the styles</Styles>
    <TabHome>Home</TabHome>
    <TabLayout>Layout</TabLayout>
    <TabPage>Page</TabPage>
    <TabView>View</TabView>
    <TextBrush>Text Brush</TextBrush>
    <ToolbarAlignment>Alignment</ToolbarAlignment>
    <ToolbarArrange>Arrange</ToolbarArrange>
    <ToolbarBorders>Borders</ToolbarBorders>
    <ToolbarClipboard>Clipboard</ToolbarClipboard>
    <ToolbarDockStyle>Dock Style</ToolbarDockStyle>
    <ToolbarFont>Font</ToolbarFont>
    <ToolbarFormatting>Formatting</ToolbarFormatting>
    <ToolbarLayout>Layout</ToolbarLayout>
    <ToolbarPageSetup>Page Setup</ToolbarPageSetup>
    <ToolbarStandard>Standard</ToolbarStandard>
    <ToolbarStyle>Style</ToolbarStyle>
    <ToolbarTextFormat>Text Format</ToolbarTextFormat>
    <ToolbarTools>Tools</ToolbarTools>
    <ToolbarViewOptions>View Options</ToolbarViewOptions>
    <ToolbarWatermarkImage>Watermark Image</ToolbarWatermarkImage>
    <ToolbarWatermarkText>Watermark Text</ToolbarWatermarkText>
  </Toolbars>
  <Toolbox>
    <Create>Creation components</Create>
    <Hand>Hand</Hand>
    <Select>Select</Select>
    <Style>Copy Style</Style>
    <TextEditor>Text Editor</TextEditor>
    <title>Toolbox</title>
  </Toolbox>
  <Wizards>
    <BlankReport>Blank Report</BlankReport>
    <ButtonBack>&lt; &amp;Back</ButtonBack>
    <ButtonCancel>Cancel</ButtonCancel>
    <ButtonFinish>&amp;Finish</ButtonFinish>
    <ButtonNext>&amp;Next &gt;</ButtonNext>
    <ColumnsOrder>Columns Order</ColumnsOrder>
    <Custom>Custom</Custom>
    <DataRelation>Relation</DataRelation>
    <DataSource>Data Source</DataSource>
    <DataSources>Data Sources</DataSources>
    <DefaultThemes>Default Themes</DefaultThemes>
    <Filters>Filters</Filters>
    <FromReportTemplate>From Report Template</FromReportTemplate>
    <groupCreateNewPageOrForm>Create a New Page or Form</groupCreateNewPageOrForm>
    <groupCreateNewReport>Create a New Report</groupCreateNewReport>
    <Groups>Groups</Groups>
    <groupTemplates>Templates</groupTemplates>
    <groupWizards>Wizards</groupWizards>
    <infoColumnsOrder>Arrange columns in the necessary order.</infoColumnsOrder>
    <infoDataSource>Select one Data Source from available.</infoDataSource>
    <infoDataSources>Select Data Sources from available. The first selected one will be the Master datasource.</infoDataSources>
    <infoFilters>Filter Data for your report</infoFilters>
    <infoGroups>Select columns on which necessary to group.</infoGroups>
    <infoLabelSettings>Set the settings of labels.</infoLabelSettings>
    <infoLayout>Specify layout of report.</infoLayout>
    <infoRelation>Select one Data Relation from available.</infoRelation>
    <infoSelectColumns>Select columns from which the information will be displayed.</infoSelectColumns>
    <infoSort>Set the sorting of data. You can sort immediately on multiple columns.</infoSort>
    <infoThemes>Select theme for your report.</infoThemes>
    <infoTotals>Add summary information to your report.</infoTotals>
    <LabelDirection>Direction:</LabelDirection>
    <LabelHeight>Height:</LabelHeight>
    <LabelHorizontalGap>Horizontal Gap:</LabelHorizontalGap>
    <LabelLabelType>Label Type:</LabelLabelType>
    <LabelLeftMargin>Left Margin:</LabelLeftMargin>
    <LabelNumberOfColumns>Number of Columns:</LabelNumberOfColumns>
    <LabelNumberOfRows>Number of Rows:</LabelNumberOfRows>
    <LabelPageHeight>Page Height:</LabelPageHeight>
    <LabelPageWidth>Page Width:</LabelPageWidth>
    <LabelReport>Label Report</LabelReport>
    <LabelSettings>Label Settings</LabelSettings>
    <LabelSize>Size:</LabelSize>
    <LabelTopMargin>Top Margin:</LabelTopMargin>
    <LabelVerticalGap>Vertical Gap:</LabelVerticalGap>
    <LabelWidth>Width:</LabelWidth>
    <Layout>Layout</Layout>
    <MarkAll>Mark &amp;All</MarkAll>
    <MasterDetailReport>Master-Detail Report</MasterDetailReport>
    <NoFunction>[None]</NoFunction>
    <OpenExistingReport>Open Existing Report</OpenExistingReport>
    <Preview>Preview</Preview>
    <Reset>&amp;Reset</Reset>
    <Results>Results</Results>
    <SelectColumns>Select Columns</SelectColumns>
    <Sort>Sort</Sort>
    <StandardReport>Standard Report</StandardReport>
    <Themes>Themes</Themes>
    <title>New Report</title>
    <Totals>Totals</Totals>
    <UsingReportWizard>Using Report Wizard</UsingReportWizard>
  </Wizards>
  <Zoom>
    <EmptyValue>Empty Value</EmptyValue>
    <MultiplePages>Multiple Pages</MultiplePages>
    <OnePage>One Page</OnePage>
    <PageHeight>Page Height</PageHeight>
    <PageWidth>Page Width</PageWidth>
    <TwoPages>Two Pages</TwoPages>
    <ZoomTo100>Zoom to 100%</ZoomTo100>
  </Zoom>
</Localization>