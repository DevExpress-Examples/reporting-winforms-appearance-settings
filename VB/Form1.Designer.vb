Namespace ResetControlStyleExample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        '#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(72, 89)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(136, 73)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Preview the Report"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.Button1_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 264)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            Me.ResumeLayout(False)
        End Sub

        '#End Region
        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace
