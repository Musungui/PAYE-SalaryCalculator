<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        txtSalary = New TextBox()
        btnCalculatePaye = New Button()
        lblPaye = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter Salary:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 1
        Label2.Text = "PAYE:"
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(146, 94)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(229, 27)
        txtSalary.TabIndex = 2
        ' 
        ' btnCalculatePaye
        ' 
        btnCalculatePaye.Location = New Point(83, 240)
        btnCalculatePaye.Name = "btnCalculatePaye"
        btnCalculatePaye.Size = New Size(117, 51)
        btnCalculatePaye.TabIndex = 4
        btnCalculatePaye.Text = "Calculate" & vbCrLf & " PAYE"
        btnCalculatePaye.UseVisualStyleBackColor = True
        ' 
        ' lblPaye
        ' 
        lblPaye.BorderStyle = BorderStyle.Fixed3D
        lblPaye.Location = New Point(148, 153)
        lblPaye.Name = "lblPaye"
        lblPaye.Size = New Size(227, 25)
        lblPaye.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPaye)
        Controls.Add(btnCalculatePaye)
        Controls.Add(txtSalary)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents btnCalculatePaye As Button
    Friend WithEvents lblPaye As Label
End Class
