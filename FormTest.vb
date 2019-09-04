Imports System.IO
Imports System.Text.RegularExpressions

Public Class formTest

    'Default location for file input and output
    Private Const DEFAULT_FILEPATH = "E:\Boot Camp\VisualBasic Programming\FormTest"

    'Class constants
    Private Const FORM_X_PADDING = 20
    Private Const FORM_Y_PADDING = 50
    Private Const MIN_TXB_HEIGHT = 100
    Private Const MIN_TXB_WIDTH = 250
    Private Const MIN_LBL_WIDTH = 390
    Private Const MIN_TXB_FILEWIDTH = 450
    Private Const TIMER_MAX = 10
    Private Const TIMER_SPEED = 500
    Private Const TOTAL_BUTTONS = 9
    Private Const ARRAY_SIZE_DEFAULT = 50

    'Class variables
    Private TimersOn As Boolean
    Private ListboxOn As Boolean
    Private Time1Count As Long
    Private Time2Count As Long
    Private Filepath As String
    Private Threads() As System.Threading.Thread
    Private NumThread As Long

    ' Form Load
    '  Initial form settings
    Private Sub FormText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Allow threads to update the output textbox at the same time
        CheckForIllegalCrossThreadCalls = False

        'Set the default filepath
        txbFilepath.Text = DEFAULT_FILEPATH
        Filepath = txbFilepath.Text

        'Initalize class variables
        TimersOn = False
        ListboxOn = False
        lsbOutput.Visible = False
        Threads = New System.Threading.Thread(ARRAY_SIZE_DEFAULT) {}
        NumThread = 0
    End Sub

    ' Filepath Updated
    '  Update file location for reading or writing practice tests
    Private Sub TxbFilepath_TextChanged(sender As Object, e As EventArgs) Handles txbFilepath.TextChanged
        Filepath = txbFilepath.Text
    End Sub

    ' Toggle Buttons
    '  Will enable a primary button and update its text while enabling or disabling the other buttons on the form
    Private Sub ToggleButtons(ByVal btnPrimary As Long, ByVal btnPrimaryText As String, ByVal othersEnabled As Boolean)

        Dim index As Long

        For index = 1 To TOTAL_BUTTONS
            Select Case index
                Case 1
                    btnQuestion1.Enabled = othersEnabled
                Case 2
                    btnQuestion2.Enabled = othersEnabled
                Case 4
                    If index = btnPrimary Then
                        btnQuestion4.Enabled = True
                        btnQuestion4.Text = btnPrimaryText
                    Else
                        btnQuestion4.Enabled = othersEnabled
                    End If
                Case 5
                    btnQuestion5.Enabled = othersEnabled
                Case 6
                    btnQuestion6.Enabled = othersEnabled
                Case 7
                    btnQuestion7.Enabled = othersEnabled
                Case 8
                    If index = btnPrimary Then
                        btnQuestion8.Enabled = True
                        btnQuestion8.Text = btnPrimaryText
                    Else
                        btnQuestion8.Enabled = othersEnabled
                    End If
                Case 9
                    btnQuestion9.Enabled = othersEnabled
            End Select
        Next

    End Sub

    ' Input from File to Textbox
    '  Dispalys contents of a file in the input textbox on the form
    '  Also creates output array with file lines
    Private Sub InputFromFileToTextBox(ByVal filepath As String, ByRef lines() As String)

        Dim fileReader As StreamReader
        Dim lineReader As String
        Dim index As Long
        Dim size As Long

        If Not (File.Exists(filepath)) Then
            MsgBox("ERROR: File could not be found at " & filepath)
            Exit Sub
        End If

        fileReader = My.Computer.FileSystem.OpenTextFileReader(filepath)
        txbInput.ResetText()
        index = 0
        size = 0

        Do
            lineReader = fileReader.ReadLine()

            'Check if end of file
            If String.IsNullOrEmpty(lineReader) Then
                Exit Do
            End If

            'Save file input to output array
            lines(index) = lineReader
            index += 1

            'Resize array if input file is getting too big
            If index = size Then
                size += ARRAY_SIZE_DEFAULT
                ReDim Preserve lines(size)
            End If

            'Display input in textbox
            If Not String.IsNullOrEmpty(txbInput.Text) Then
                'Add new line between rows of data
                txbInput.Text &= vbNewLine
            End If
            txbInput.Text &= lineReader

        Loop

        ReDim Preserve lines(index)
        fileReader.Close()

    End Sub

    ' Output to File and Textbox
    '  Displays contents of output array in the output textbox on the form
    '  Also writes contents of output array to a file
    Private Sub OutputToFileAndTextbox(ByRef output() As String, ByVal filepath As String)

        Dim fileWriter As StreamWriter
        Dim index As Long

        If Not (File.Exists(filepath)) Then
            File.Create(filepath).Dispose()
        End If

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(filepath, False)
        txbOutput.ResetText()
        index = 0
        For index = 0 To (output.Length - 1)

            fileWriter.WriteLine(output(index))

            If Not String.IsNullOrEmpty(txbOutput.Text) Then
                txbOutput.Text &= vbNewLine
            End If
            txbOutput.Text &= output(index)

        Next

        fileWriter.Close()

    End Sub

    ' Question 1:
    '  Reading in lines from a file, display any numbers along with their hexadecimal value.  
    '  Then display the total sum of the numbers to a precision of 2 decimal places.
    Private Sub BtnQuestion1_Click(sender As Object, e As EventArgs) Handles btnQuestion1.Click

        Dim inputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim outputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim sum As Decimal
        Dim index As Long
        Dim outCount As Long

        EnableListboxOutput(False)
        Call InputFromFileToTextBox(Filepath & "\Question1_Input.txt", inputData)

        sum = 0
        For index = 0 To (inputData.Length - 1)
            'For numeric input, show hex value and include in the sum
            If IsNumeric(inputData(index)) Then
                outputData(outCount) = inputData(index) & vbTab & " [0x" & Hex(inputData(index)) & "]"
                sum += Convert.ToDecimal(inputData(index))
                outCount += 1
            End If
        Next

        outputData(outCount) = vbNewLine & "Sum: " & sum.ToString("F2")
        ReDim Preserve outputData(outCount)

        Call OutputToFileAndTextbox(outputData, Filepath & "\Question1_Output.txt")

    End Sub

    ' Question 2:
    '  Reading in a list of potential dates, convert only the valid ones to yyyy-mm-dd formatting.
    Private Sub BtnQuestion2_Click(sender As Object, e As EventArgs) Handles btnQuestion2.Click

        Dim inputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim outputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim index As Long
        Dim outCount As Long
        Dim tempDate As Date

        EnableListboxOutput(False)
        Call InputFromFileToTextBox(Filepath & "\Question2_Input.txt", inputData)

        For index = 0 To (inputData.Length - 1)
            'For valid date input, update the formatting for the output
            If IsDate(inputData(index)) Then
                tempDate = Convert.ToDateTime(inputData(index))
                outputData(outCount) = tempDate.ToString("yyyy-MM-dd")
                'For Practice - Alternative ways to format a date:
                '  outputData(outCount) = tempDate.Year & "-" & tempDate.Month & "-" & tempDate.Day
                '  outputData(outCount) = DateTime.Parse(tempDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)
                outCount += 1
            End If
        Next

        ReDim Preserve outputData(outCount)
        Call OutputToFileAndTextbox(outputData, Filepath & "\Question2_Output.txt")
    End Sub

    'Question 3:
    ' When a form is resized, update the form elements to resize with it.
    Private Sub FormTest_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim txbHeight As Long
        Dim txbWidth As Long
        Dim lblWidth As Long
        Dim txbFileWidth As Long

        txbHeight = Me.Height - txbInput.Location.Y - FORM_Y_PADDING
        txbWidth = (Me.Width / 2) - txbInput.Location.X - FORM_X_PADDING
        lblWidth = Me.Width - lblQText1.Location.X - FORM_X_PADDING
        txbFileWidth = Me.Width - txbFilepath.Location.X - FORM_X_PADDING

        'Adjust textbox/listbox height
        If txbHeight > MIN_TXB_HEIGHT Then
            txbInput.Height = txbHeight
            txbOutput.Height = txbHeight
            lsbOutput.Height = txbHeight
        End If

        'Adjust textbox/listbox width
        ' Move Output left as needed to make space for expanding Input
        If txbWidth > MIN_TXB_WIDTH Then
            txbInput.Width = txbWidth
            lblOutput.Left = txbInput.Location.X + txbInput.Width + FORM_X_PADDING
            txbOutput.Left = lblOutput.Left
            txbOutput.Width = txbWidth
            lsbOutput.Left = lblOutput.Left
            lsbOutput.Width = txbWidth
        End If

        'Update the label widths for the Questions
        If lblWidth > MIN_LBL_WIDTH Then
            lblQText1.Width = lblWidth
            lblQText2.Width = lblWidth
            lblQText3.Width = lblWidth
            lblQText4.Width = lblWidth
            lblQText5.Width = lblWidth
            lblQText6.Width = lblWidth
            lblQText7.Width = lblWidth
            lblQText8.Width = lblWidth
            lblQText9.Width = lblWidth
        End If

        'Update the filepath textbox width
        If txbFileWidth > MIN_TXB_FILEWIDTH Then
            txbFilepath.Width = txbFileWidth
        End If

    End Sub

    ' Question 4:
    '  Display two timers, one twice as fast as the other, that count up to 10 then reset back to 0.
    Private Sub BtnQuestion4_Click(sender As Object, e As EventArgs) Handles btnQuestion4.Click

        TimersOn = Not TimersOn
        EnableListboxOutput(False)

        If TimersOn Then
            'Set the timer speeds
            Timer1.Interval = TIMER_SPEED
            Timer2.Interval = Timer1.Interval * 2

            'Convert the form elements (and disable other form buttons)
            ToggleButtons(4, "Stop Timers", False)
            lblInput.Text = "Timer 1"
            lblOutput.Text = "Timer 2"
            txbInput.Text = "0"
            txbOutput.Text = "0"

            Time1Count = 0
            Time2Count = 0

            Timer1.Start()
            Timer2.Start()
        Else
            Timer1.Stop()
            Timer2.Stop()

            'Reset the form back to its original state
            ToggleButtons(4, "Begin 4", True)
            lblInput.Text = "Input:"
            lblOutput.Text = "Output:"
            txbInput.ResetText()
            txbOutput.ResetText()
        End If

    End Sub

    ' Timer Control
    '  Updates the timer count, resets timer When TIMER_MAX Is reached
    Private Sub TimerControl(ByRef timeCount As Long)
        timeCount += 1
        If timeCount > TIMER_MAX Then
            timeCount = 0
        End If
    End Sub

    ' Timer 1
    '  Displayed in input textbox
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerControl(Time1Count)
        txbInput.Text = Time1Count

    End Sub

    ' Timer 2
    '  Displayed in output textbox
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TimerControl(Time2Count)
        txbOutput.Text = Time2Count

    End Sub

    ' Question 5:
    '  Reading text from a file, count the number of words and lines, 
    '  replace "doctor" with "clinician", count the number of replacements, 
    '  and display the updated text along with each tally.
    Private Sub BtnQuestion5_Click(sender As Object, e As EventArgs) Handles btnQuestion5.Click
        Dim inputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim outputData() As String = New String(4) {}
        Dim index As Long
        Dim lineCount
        Dim wordCount As Long
        Dim replaceCount As Long
        Dim wordSplit() As String
        Dim idxStr As Long

        EnableListboxOutput(False)
        Call InputFromFileToTextBox(Filepath & "\Question5_Input.txt", inputData)

        lineCount = 0
        wordCount = 0
        replaceCount = 0
        For index = 0 To (inputData.Length - 1)
            If Not String.IsNullOrEmpty(inputData(index)) Then
                'Count lines
                lineCount += 1

                'Create array of words
                wordSplit = inputData(index).Split()
                For idxStr = 0 To (wordSplit.Length - 1)
                    If Not String.IsNullOrWhiteSpace(wordSplit(idxStr)) Then
                        'Count words
                        wordCount += 1

                        'Check for replacement
                        If StrComp(wordSplit(idxStr).ToUpper, "DOCTOR") = 0 Then
                            If wordSplit(idxStr)(0) = "D" Then
                                wordSplit(idxStr) = "Clinician"
                            Else
                                wordSplit(idxStr) = "clinician"
                            End If
                            'count replacements
                            replaceCount += 1
                        End If
                    End If
                Next
                'Save text to output, but otherwise clear word array
                outputData(3) &= vbNewLine & String.Join(" ", wordSplit)
                Array.Clear(wordSplit, 0, wordSplit.Length)
            End If
        Next

        'Finalize tallies
        outputData(0) = "Line Count: " & lineCount
        outputData(1) = "Word Count: " & wordCount
        outputData(2) = "Replacements: " & replaceCount

        Call OutputToFileAndTextbox(outputData, Filepath & "\Question5_Output.txt")
    End Sub

    ' Question 6:
    '  Reading in text from question 5, sort each unique word into a 
    '  dynamically-sized array.  Sort the list of words and display in a listbox.
    Private Sub BtnQuestion6_Click(sender As Object, e As EventArgs) Handles btnQuestion6.Click
        Dim inputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim outputData() As String = New String() {}
        Dim index As Long
        Dim wordSplit() As String
        Dim idxStr As Long
        Dim word As String

        EnableListboxOutput(True)
        lsbOutput.Sorted = True 'sets the listbox to alphabetize itself
        Call InputFromFileToTextBox(Filepath & "\Question5_Input.txt", inputData)

        For index = 0 To (inputData.Length - 1)
            If Not String.IsNullOrEmpty(inputData(index)) Then
                'Create array of words
                wordSplit = inputData(index).Split()
                For idxStr = 0 To (wordSplit.Length - 1)
                    'Remove any punctuation marks
                    word = Regex.Replace(wordSplit(idxStr), "[^A-Za-z]+", String.Empty).ToLower
                    'Add new words to list
                    If Not String.IsNullOrWhiteSpace(word) And Not lsbOutput.Items.Contains(word) Then
                        lsbOutput.Items.Add(word)
                    End If
                Next
                Array.Clear(wordSplit, 0, wordSplit.Length)
            End If
        Next

        ReDim outputData(lsbOutput.Items.Count)
        lsbOutput.Items.CopyTo(outputData, 0)
        Call OutputToFileAndTextbox(outputData, Filepath & "\Question6_Output.txt")

    End Sub

    ' Enable Listbox Output
    '  Toggles the output fields between an textbox and a listbox
    '  Updates the textbox/listbox to the current form size while hiding the disabled output element
    Private Sub EnableListboxOutput(ByVal enable As Boolean)
        ListboxOn = enable
        lsbOutput.Visible = ListboxOn
        txbOutput.Visible = Not ListboxOn
    End Sub

    ' Question 7:
    '  Inherit a virtual class, Shape, to create classes Rectangle and Square.  
    '  Create and display Square and Rectangle objects from file input.
    Private Sub BtnQuestion7_Click(sender As Object, e As EventArgs) Handles btnQuestion7.Click
        Dim inputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim outputData() As String = New String(ARRAY_SIZE_DEFAULT) {}
        Dim mySquare As Square
        Dim myRectangle As Rectangle
        Dim outString As String
        Dim index As Long
        Dim outCount As Long

        EnableListboxOutput(False)
        Call InputFromFileToTextBox(Filepath & "\Question7_Input.txt", inputData)
        outString = ""
        index = 0
        Try
            While index < inputData.Length
                If Not String.IsNullOrWhiteSpace(inputData(index)) Then
                    'Determine which object is being read in
                    If inputData(index).ToUpper = "SQUARE" Then
                        'Use next 3 input lines to create a Square object
                        mySquare = New Square(inputData(index + 1), inputData(index + 2), inputData(index + 3))
                        outString = mySquare.PrintData() & vbNewLine & mySquare.Draw()
                        index += 3
                    ElseIf inputData(index).ToUpper = "RECTANGLE" Then
                        'Use next 4 input lines to create a Rectangle object
                        myRectangle = New Rectangle(inputData(index + 1), inputData(index + 2), inputData(index + 3), inputData(index + 4))
                        outString = myRectangle.PrintData() & vbNewLine & myRectangle.Draw()
                        index += 4
                    End If
                    'Add object data to output array
                    outputData(outCount) = outString
                    outCount += 1
                End If
                'Increment index to next line
                index += 1
            End While
            ReDim Preserve outputData(outCount)
            Call OutputToFileAndTextbox(outputData, Filepath & "\Question7_Output.txt")
        Catch ex As Exception
            MsgBox("Error: Invalid file input formatting.")
            txbOutput.Text = "Expected File Formatting: " & vbNewLine &
                "  [""Square""/""Rectangle""]" & vbNewLine &
                "  [Shape Name] (string)" & vbNewLine &
                "  [Shape ID] (numeric)" & vbNewLine &
                "  [Shape Width]" & vbNewLine &
                "  [Shape Height] (rectangle only)" &
                vbNewLine & "Example: " & vbNewLine & "  Square" & vbNewLine & "  MySquare" & vbNewLine & "  123" & vbNewLine & "  5"
        End Try


    End Sub

    ' Question 8:
    '  Every time the button is pressed, begin a new thread.  
    '  Allow the form to be resized while the threads run.
    Private Sub BtnQuestion8_Click(sender As Object, e As EventArgs) Handles btnQuestion8.Click

        EnableListboxOutput(False)

        'Disable all other buttons on the form
        ToggleButtons(8, "Waiting...", False)

        'Begin a new thread
        NumThread += 1
        Threads(NumThread) = New System.Threading.Thread(AddressOf Wait)
        Threads(NumThread).Start()
    End Sub

    ' Wait
    '  Makes the application hang for 3 seconds.  Reactivates the form buttons if there are no active threads.
    Private Sub Wait()
        Dim time As String
        time = Now.TimeOfDay.ToString

        'Reset text fields for first thread 
        If NumThread = 1 Then
            txbInput.ResetText()
            txbOutput.ResetText()
        End If

        'Make each thread wait for 3 seconds
        txbInput.Text &= vbNewLine & "Thread started at " & time
        Threading.Thread.Sleep(3000)
        txbOutput.Text &= vbNewLine & "Thread from " & time & " is ending"
        NumThread -= 1

        'Renable form buttons when all threads finish 
        If NumThread = 0 Then
            ToggleButtons(8, "Begin 8", True)
        End If
    End Sub

    ' Question 9:
    '  Given a randomly generated exception, display an appropriate error message in a message box.
    Private Sub BtnQuestion9_Click(sender As Object, e As EventArgs) Handles btnQuestion9.Click

        Dim rn As New Random
        Dim caseNum As Integer
        Dim testNum As Integer
        Dim zeroNum As Integer
        Dim testSquare As Square = New Square("Ted", 12, 3)
        Dim testRectangle As Rectangle = New Rectangle("Barney", 1, 4, 5)
        Dim testVariant As Object = New Object()
        Dim nullArray() As String
        Dim smallArray() As Integer = New Integer() {5}

        EnableListboxOutput(False)
        txbOutput.ResetText()

        zeroNum = 0
        caseNum = rn.Next(1, 8)
        Try
            'Randomly trigger one of the following code blocks designed to cause a runtime exception
            Select Case caseNum
                Case 1
                    txbInput.Text = "nullArray(0) = ""hello"""
                    nullArray(0) = "hello"
                Case 2
                    txbInput.Text = "smallArray(10) = 5"
                    smallArray(10) = 5
                Case 3
                    txbInput.Text = "Array.Copy(intArray, strArray, index)"
                    nullArray = {"test"}
                    Array.Copy(smallArray, nullArray, 1)
                Case 4
                    txbInput.Text = "testNum = (30 \ 0)"
                    testNum = (30 \ zeroNum)
                Case 5
                    txbInput.Text = "RectangleObject = SquareObject"
                    testVariant = testSquare
                    testRectangle = testVariant
                Case 6
                    txbInput.Text = "Throw (New CustomError)"
                    Throw (New CustomError)
                Case 7
                    txbInput.Text = "Array.Copy(intArray, strArray, outOfRange)"
                    nullArray = New String() {5}
                    Array.Copy(smallArray, nullArray, 5)
            End Select

        Catch ex As System.NullReferenceException
            'Handles Case 1
            MsgBox("Error: Null reference encountered")

        Catch ex As System.IndexOutOfRangeException
            'Handles Case 2
            MsgBox("Error: Index out of bounds encountered")

        Catch ex As System.ArrayTypeMismatchException
            'Handles Case 3
            MsgBox("Error: Array type mismatch encountered")

        Catch ex As System.DivideByZeroException
            'Handles Case 4
            MsgBox("Error: Divide by zero encountered")

        Catch ex As System.InvalidCastException
            'Handles Case 5
            MsgBox("Error: Invalid cast encountered")

        Catch ex As CustomError
            'Handles Case 6
            MsgBox("Error: Custom error encountered")

        Catch ex As Exception
            'Handles Case 7
            MsgBox("Error: Other error encountered" & vbNewLine & ex.Message)

        Finally
            txbOutput.Text = "Error of Case " & caseNum & " handled."
        End Try

    End Sub
End Class

Public MustInherit Class Shape
    Public name As String
    Public id As Long

    Public MustOverride Function PrintData() As String
    Public MustOverride Function Draw() As String

End Class

Public Class Square
    Inherits Shape
    Private ReadOnly side As Long

    Public Sub New(name As String, id As Long, side As Long)
        Me.id = id
        Me.name = name
        Me.side = side
    End Sub

    Public Overrides Function PrintData() As String
        PrintData = "Square " & name & " [ID: " & id & "] has sides of " & side & "."
    End Function

    Public Overrides Function Draw() As String
        Dim width As Long
        Dim height As Long
        Dim shape As String = ""

        For height = 0 To side
            If height = 0 Then
                shape &= " "
            Else
                shape &= "|"
            End If
            For width = 1 To side
                If height = 0 Or height = side Then
                    shape &= "_ "
                Else
                    shape &= "  "
                End If
            Next
            If height <> 0 Then
                shape &= "|"
            End If
            shape &= vbNewLine
        Next

        Draw = shape
    End Function

End Class

Public Class Rectangle
    Inherits Shape
    Private ReadOnly width As Long
    Private ReadOnly height As Long

    Public Sub New(name As String, id As Long, width As Long, height As Long)
        Me.id = id
        Me.name = name
        Me.width = width
        Me.height = height
    End Sub

    Public Overrides Function PrintData() As String
        PrintData = "Rectangle " & name & " [ID: " & id & "] has a width of " & width & " and a height of " & height & "."
    End Function

    Public Overrides Function Draw() As String
        Dim index As Long
        Dim line As String = ""
        Dim space As String = ""
        Dim shape As String = ""

        For index = 1 To width
            line &= "_ "
            space &= "  "
        Next

        For index = 0 To height
            If index = 0 Then
                shape = " " & line & " "
            ElseIf index = height Then
                shape &= "|" & line & "|"
            Else
                shape &= "|" & space & "|"
            End If
            shape &= vbNewLine
        Next

        Draw = shape
    End Function

End Class

Public Class CustomError : Inherits ApplicationException
    Public Sub New()

    End Sub
End Class
