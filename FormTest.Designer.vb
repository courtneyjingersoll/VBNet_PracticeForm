<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblQText1 = New System.Windows.Forms.Label()
        Me.lblQText2 = New System.Windows.Forms.Label()
        Me.btnQuestion1 = New System.Windows.Forms.Button()
        Me.btnQuestion2 = New System.Windows.Forms.Button()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txbInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txbOutput = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.lblQText3 = New System.Windows.Forms.Label()
        Me.lblQuestion4 = New System.Windows.Forms.Label()
        Me.btnQuestion4 = New System.Windows.Forms.Button()
        Me.lblQText4 = New System.Windows.Forms.Label()
        Me.lblQText5 = New System.Windows.Forms.Label()
        Me.btnQuestion5 = New System.Windows.Forms.Button()
        Me.lblQuestion5 = New System.Windows.Forms.Label()
        Me.lblQuestion6 = New System.Windows.Forms.Label()
        Me.btnQuestion6 = New System.Windows.Forms.Button()
        Me.lblQText6 = New System.Windows.Forms.Label()
        Me.lblQuestion7 = New System.Windows.Forms.Label()
        Me.btnQuestion7 = New System.Windows.Forms.Button()
        Me.lblQText7 = New System.Windows.Forms.Label()
        Me.lblQuestion8 = New System.Windows.Forms.Label()
        Me.btnQuestion8 = New System.Windows.Forms.Button()
        Me.lblQText8 = New System.Windows.Forms.Label()
        Me.lblQuestion9 = New System.Windows.Forms.Label()
        Me.btnQuestion9 = New System.Windows.Forms.Button()
        Me.lblQText9 = New System.Windows.Forms.Label()
        Me.lblFilepath = New System.Windows.Forms.Label()
        Me.txbFilepath = New System.Windows.Forms.TextBox()
        Me.lsbOutput = New System.Windows.Forms.ListBox()
        Me.btnQuestion3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(12, 18)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(162, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Practice Problems"
        '
        'lblQText1
        '
        Me.lblQText1.Location = New System.Drawing.Point(167, 75)
        Me.lblQText1.Name = "lblQText1"
        Me.lblQText1.Size = New System.Drawing.Size(463, 43)
        Me.lblQText1.TabIndex = 1
        Me.lblQText1.Text = "Reading in lines from a file, display any numbers along with their hexadecimal va" &
    "lue.  Then display the total sum of the numbers to a precision of 2 decimal plac" &
    "es."
        Me.lblQText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQText2
        '
        Me.lblQText2.Location = New System.Drawing.Point(167, 114)
        Me.lblQText2.Name = "lblQText2"
        Me.lblQText2.Size = New System.Drawing.Size(463, 43)
        Me.lblQText2.TabIndex = 2
        Me.lblQText2.Text = "Reading in a list of potential dates, convert only the valid ones to yyyy-mm-dd f" &
    "ormatting."
        Me.lblQText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuestion1
        '
        Me.btnQuestion1.Location = New System.Drawing.Point(23, 81)
        Me.btnQuestion1.Name = "btnQuestion1"
        Me.btnQuestion1.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion1.TabIndex = 6
        Me.btnQuestion1.Text = "Begin 1"
        Me.btnQuestion1.UseVisualStyleBackColor = True
        '
        'btnQuestion2
        '
        Me.btnQuestion2.Location = New System.Drawing.Point(23, 120)
        Me.btnQuestion2.Name = "btnQuestion2"
        Me.btnQuestion2.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion2.TabIndex = 7
        Me.btnQuestion2.Text = "Begin 2"
        Me.btnQuestion2.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(25, 431)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(37, 15)
        Me.lblInput.TabIndex = 12
        Me.lblInput.Text = "Input:"
        '
        'txbInput
        '
        Me.txbInput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbInput.Location = New System.Drawing.Point(23, 447)
        Me.txbInput.Multiline = True
        Me.txbInput.Name = "txbInput"
        Me.txbInput.ReadOnly = True
        Me.txbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbInput.Size = New System.Drawing.Size(300, 215)
        Me.txbInput.TabIndex = 11
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(340, 431)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(46, 15)
        Me.lblOutput.TabIndex = 14
        Me.lblOutput.Text = "Output:"
        '
        'txbOutput
        '
        Me.txbOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbOutput.Location = New System.Drawing.Point(338, 447)
        Me.txbOutput.Multiline = True
        Me.txbOutput.Name = "txbOutput"
        Me.txbOutput.ReadOnly = True
        Me.txbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbOutput.Size = New System.Drawing.Size(300, 215)
        Me.txbOutput.TabIndex = 13
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'lblQuestion1
        '
        Me.lblQuestion1.Location = New System.Drawing.Point(104, 85)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion1.TabIndex = 23
        Me.lblQuestion1.Text = "Question 1:"
        Me.lblQuestion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion2
        '
        Me.lblQuestion2.Location = New System.Drawing.Point(104, 124)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion2.TabIndex = 24
        Me.lblQuestion2.Text = "Question 2:"
        Me.lblQuestion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion3
        '
        Me.lblQuestion3.Location = New System.Drawing.Point(104, 163)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion3.TabIndex = 30
        Me.lblQuestion3.Text = "Question 3:"
        Me.lblQuestion3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQText3
        '
        Me.lblQText3.Location = New System.Drawing.Point(167, 153)
        Me.lblQText3.Name = "lblQText3"
        Me.lblQText3.Size = New System.Drawing.Size(463, 43)
        Me.lblQText3.TabIndex = 26
        Me.lblQText3.Text = "When a form is resized, update the form elements to resize with it."
        Me.lblQText3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion4
        '
        Me.lblQuestion4.Location = New System.Drawing.Point(104, 202)
        Me.lblQuestion4.Name = "lblQuestion4"
        Me.lblQuestion4.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion4.TabIndex = 36
        Me.lblQuestion4.Text = "Question 4:"
        Me.lblQuestion4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuestion4
        '
        Me.btnQuestion4.Location = New System.Drawing.Point(23, 198)
        Me.btnQuestion4.Name = "btnQuestion4"
        Me.btnQuestion4.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion4.TabIndex = 34
        Me.btnQuestion4.Text = "Begin 4"
        Me.btnQuestion4.UseVisualStyleBackColor = True
        '
        'lblQText4
        '
        Me.lblQText4.Location = New System.Drawing.Point(167, 192)
        Me.lblQText4.Name = "lblQText4"
        Me.lblQText4.Size = New System.Drawing.Size(463, 43)
        Me.lblQText4.TabIndex = 32
        Me.lblQText4.Text = "Display two timers, one twice as fast as the other, that count up to 10 then rese" &
    "t back to 0."
        Me.lblQText4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQText5
        '
        Me.lblQText5.Location = New System.Drawing.Point(167, 231)
        Me.lblQText5.Name = "lblQText5"
        Me.lblQText5.Size = New System.Drawing.Size(463, 43)
        Me.lblQText5.TabIndex = 38
        Me.lblQText5.Text = "Reading text from a file, count the number of words and lines, replace ""doctor"" w" &
    "ith ""clinician"", count the number of replacements, and display the updated text " &
    "along with each tally."
        Me.lblQText5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuestion5
        '
        Me.btnQuestion5.Location = New System.Drawing.Point(23, 237)
        Me.btnQuestion5.Name = "btnQuestion5"
        Me.btnQuestion5.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion5.TabIndex = 40
        Me.btnQuestion5.Text = "Begin 5"
        Me.btnQuestion5.UseVisualStyleBackColor = True
        '
        'lblQuestion5
        '
        Me.lblQuestion5.Location = New System.Drawing.Point(104, 241)
        Me.lblQuestion5.Name = "lblQuestion5"
        Me.lblQuestion5.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion5.TabIndex = 42
        Me.lblQuestion5.Text = "Question 5:"
        Me.lblQuestion5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion6
        '
        Me.lblQuestion6.Location = New System.Drawing.Point(104, 280)
        Me.lblQuestion6.Name = "lblQuestion6"
        Me.lblQuestion6.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion6.TabIndex = 48
        Me.lblQuestion6.Text = "Question 6:"
        Me.lblQuestion6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuestion6
        '
        Me.btnQuestion6.Location = New System.Drawing.Point(23, 276)
        Me.btnQuestion6.Name = "btnQuestion6"
        Me.btnQuestion6.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion6.TabIndex = 46
        Me.btnQuestion6.Text = "Begin 6"
        Me.btnQuestion6.UseVisualStyleBackColor = True
        '
        'lblQText6
        '
        Me.lblQText6.Location = New System.Drawing.Point(167, 270)
        Me.lblQText6.Name = "lblQText6"
        Me.lblQText6.Size = New System.Drawing.Size(463, 43)
        Me.lblQText6.TabIndex = 44
        Me.lblQText6.Text = "Reading in text from question 5, sort each unique word into a dynamically-sized a" &
    "rray.  Sort the list of words and display in a listbox."
        Me.lblQText6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion7
        '
        Me.lblQuestion7.Location = New System.Drawing.Point(104, 319)
        Me.lblQuestion7.Name = "lblQuestion7"
        Me.lblQuestion7.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion7.TabIndex = 54
        Me.lblQuestion7.Text = "Question 7:"
        Me.lblQuestion7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuestion7
        '
        Me.btnQuestion7.Location = New System.Drawing.Point(23, 315)
        Me.btnQuestion7.Name = "btnQuestion7"
        Me.btnQuestion7.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion7.TabIndex = 52
        Me.btnQuestion7.Text = "Begin 7"
        Me.btnQuestion7.UseVisualStyleBackColor = True
        '
        'lblQText7
        '
        Me.lblQText7.Location = New System.Drawing.Point(167, 308)
        Me.lblQText7.Name = "lblQText7"
        Me.lblQText7.Size = New System.Drawing.Size(463, 44)
        Me.lblQText7.TabIndex = 50
        Me.lblQText7.Text = "Inherit a virtual class, Shape, to create classes Rectangle and Square.  Create a" &
    "nd display Square and Rectangle objects from file input."
        Me.lblQText7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion8
        '
        Me.lblQuestion8.Location = New System.Drawing.Point(104, 359)
        Me.lblQuestion8.Name = "lblQuestion8"
        Me.lblQuestion8.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion8.TabIndex = 60
        Me.lblQuestion8.Text = "Question 8:"
        Me.lblQuestion8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuestion8
        '
        Me.btnQuestion8.Location = New System.Drawing.Point(23, 355)
        Me.btnQuestion8.Name = "btnQuestion8"
        Me.btnQuestion8.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion8.TabIndex = 58
        Me.btnQuestion8.Text = "Begin 8"
        Me.btnQuestion8.UseVisualStyleBackColor = True
        '
        'lblQText8
        '
        Me.lblQText8.Location = New System.Drawing.Point(167, 348)
        Me.lblQText8.Name = "lblQText8"
        Me.lblQText8.Size = New System.Drawing.Size(463, 44)
        Me.lblQText8.TabIndex = 56
        Me.lblQText8.Text = "Every time the button is pressed, begin a new thread.  Allow the form to be resiz" &
    "ed while the threads run."
        Me.lblQText8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion9
        '
        Me.lblQuestion9.Location = New System.Drawing.Point(104, 399)
        Me.lblQuestion9.Name = "lblQuestion9"
        Me.lblQuestion9.Size = New System.Drawing.Size(63, 23)
        Me.lblQuestion9.TabIndex = 66
        Me.lblQuestion9.Text = "Question 9:"
        Me.lblQuestion9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuestion9
        '
        Me.btnQuestion9.Location = New System.Drawing.Point(23, 395)
        Me.btnQuestion9.Name = "btnQuestion9"
        Me.btnQuestion9.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion9.TabIndex = 65
        Me.btnQuestion9.Text = "Begin 9"
        Me.btnQuestion9.UseVisualStyleBackColor = True
        '
        'lblQText9
        '
        Me.lblQText9.Location = New System.Drawing.Point(167, 386)
        Me.lblQText9.Name = "lblQText9"
        Me.lblQText9.Size = New System.Drawing.Size(463, 49)
        Me.lblQText9.TabIndex = 64
        Me.lblQText9.Text = "Given a randomly generated exception, display an appropriate error message in a m" &
    "essage box."
        Me.lblQText9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFilepath
        '
        Me.lblFilepath.Location = New System.Drawing.Point(29, 46)
        Me.lblFilepath.Name = "lblFilepath"
        Me.lblFilepath.Size = New System.Drawing.Size(63, 23)
        Me.lblFilepath.TabIndex = 67
        Me.lblFilepath.Text = "Filepath:"
        Me.lblFilepath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txbFilepath
        '
        Me.txbFilepath.Location = New System.Drawing.Point(74, 48)
        Me.txbFilepath.Name = "txbFilepath"
        Me.txbFilepath.Size = New System.Drawing.Size(556, 20)
        Me.txbFilepath.TabIndex = 69
        Me.txbFilepath.Text = "[filepath]"
        '
        'lsbOutput
        '
        Me.lsbOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbOutput.FormattingEnabled = True
        Me.lsbOutput.ItemHeight = 14
        Me.lsbOutput.Location = New System.Drawing.Point(338, 447)
        Me.lsbOutput.Name = "lsbOutput"
        Me.lsbOutput.Size = New System.Drawing.Size(300, 214)
        Me.lsbOutput.TabIndex = 70
        Me.lsbOutput.Visible = False
        '
        'btnQuestion3
        '
        Me.btnQuestion3.Enabled = False
        Me.btnQuestion3.Location = New System.Drawing.Point(23, 159)
        Me.btnQuestion3.Name = "btnQuestion3"
        Me.btnQuestion3.Size = New System.Drawing.Size(75, 30)
        Me.btnQuestion3.TabIndex = 28
        Me.btnQuestion3.Text = "[Enabled]"
        Me.btnQuestion3.UseVisualStyleBackColor = True
        '
        'formTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(667, 703)
        Me.Controls.Add(Me.lsbOutput)
        Me.Controls.Add(Me.txbFilepath)
        Me.Controls.Add(Me.lblFilepath)
        Me.Controls.Add(Me.lblQuestion9)
        Me.Controls.Add(Me.btnQuestion9)
        Me.Controls.Add(Me.lblQText9)
        Me.Controls.Add(Me.lblQuestion8)
        Me.Controls.Add(Me.btnQuestion8)
        Me.Controls.Add(Me.lblQText8)
        Me.Controls.Add(Me.lblQuestion7)
        Me.Controls.Add(Me.btnQuestion7)
        Me.Controls.Add(Me.lblQText7)
        Me.Controls.Add(Me.lblQuestion6)
        Me.Controls.Add(Me.btnQuestion6)
        Me.Controls.Add(Me.lblQText6)
        Me.Controls.Add(Me.lblQuestion5)
        Me.Controls.Add(Me.btnQuestion5)
        Me.Controls.Add(Me.lblQText5)
        Me.Controls.Add(Me.lblQuestion4)
        Me.Controls.Add(Me.btnQuestion4)
        Me.Controls.Add(Me.lblQText4)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Controls.Add(Me.btnQuestion3)
        Me.Controls.Add(Me.lblQText3)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txbOutput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txbInput)
        Me.Controls.Add(Me.btnQuestion2)
        Me.Controls.Add(Me.btnQuestion1)
        Me.Controls.Add(Me.lblQText2)
        Me.Controls.Add(Me.lblQText1)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "formTest"
        Me.Text = "VB.Net Practice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Windows.Forms.Label
    Friend WithEvents lblQText1 As Windows.Forms.Label
    Friend WithEvents lblQText2 As Windows.Forms.Label
    Friend WithEvents btnQuestion1 As Windows.Forms.Button
    Friend WithEvents btnQuestion2 As Windows.Forms.Button
    Friend WithEvents lblInput As Windows.Forms.Label
    Friend WithEvents txbInput As Windows.Forms.TextBox
    Friend WithEvents txbOutput As Windows.Forms.TextBox
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Timer2 As Windows.Forms.Timer
    Friend WithEvents lblOutput As Windows.Forms.Label
    Friend WithEvents lblQuestion1 As Windows.Forms.Label
    Friend WithEvents lblQuestion2 As Windows.Forms.Label
    Friend WithEvents lblQuestion3 As Windows.Forms.Label
    Friend WithEvents lblQText3 As Windows.Forms.Label
    Friend WithEvents lblQuestion4 As Windows.Forms.Label
    Friend WithEvents btnQuestion4 As Windows.Forms.Button
    Friend WithEvents lblQText4 As Windows.Forms.Label
    Friend WithEvents lblQText5 As Windows.Forms.Label
    Friend WithEvents btnQuestion5 As Windows.Forms.Button
    Friend WithEvents lblQuestion5 As Windows.Forms.Label
    Friend WithEvents lblQuestion6 As Windows.Forms.Label
    Friend WithEvents btnQuestion6 As Windows.Forms.Button
    Friend WithEvents lblQText6 As Windows.Forms.Label
    Friend WithEvents lblQuestion7 As Windows.Forms.Label
    Friend WithEvents btnQuestion7 As Windows.Forms.Button
    Friend WithEvents lblQText7 As Windows.Forms.Label
    Friend WithEvents lblQuestion8 As Windows.Forms.Label
    Friend WithEvents btnQuestion8 As Windows.Forms.Button
    Friend WithEvents lblQText8 As Windows.Forms.Label
    Friend WithEvents lblQuestion9 As Windows.Forms.Label
    Friend WithEvents btnQuestion9 As Windows.Forms.Button
    Friend WithEvents lblQText9 As Windows.Forms.Label
    Friend WithEvents lblFilepath As Windows.Forms.Label
    Friend WithEvents txbFilepath As Windows.Forms.TextBox
    Friend WithEvents lsbOutput As Windows.Forms.ListBox
    Friend WithEvents btnQuestion3 As Windows.Forms.Button
End Class
