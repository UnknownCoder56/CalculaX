' Hello!
' This is the code for CalculaX. This calculator includes Addition,
' Subtraction, Multiplication, Division, Percentage, Modulo, Integer division
' and Exponentation. It also includes Error - Handling, which gives an output
' of the detected error and helps the user to correct it. It supports
' 2 - number operations only. It does not stop in an error, but displays the
' error and continues the program execution. 
' Please do not modify the code. 
' By - Arpan Chatterjee

' Code begins here :-
Public Class Form1

    Private Property num1 As String

    Private Property num2 As String

    Private Property writable As String

    Private Property usenum As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonAdd.Click
        Try
            TextBox3.Text = Val(CDec(TextBox1.Text) + CDec(TextBox2.Text))
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " + " + TextBox2.Text + " = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSubtract.Click
        Try
            TextBox3.Text = Val(CDec(TextBox1.Text) - CDec(TextBox2.Text))
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " - " + TextBox2.Text + " = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonMultiply.Click
        Try
            TextBox3.Text = Val(CDec(TextBox1.Text) * CDec(TextBox2.Text))
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " * " + TextBox2.Text + " = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonDivide.Click
        Try
            TextBox3.Text = Val(CDec(TextBox1.Text) / CDec(TextBox2.Text))
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " / " + TextBox2.Text + " = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        Catch ex2 As DivideByZeroException
            TextBox3.Text = "Cannot divide by zero!"
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonExit.Click
        writable = writable + vbNewLine + vbNewLine + "Total actions in this session = " + CStr(usenum) + vbNewLine + "Session Ended on - " + DateString + vbNewLine + "Session Ended in - " + TimeString + vbNewLine + vbNewLine + vbNewLine + "----------------------------------------------------------------------------------------------------"
        Print(21, writable)
        End
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonModulo.Click
        Try
            TextBox3.Text = Val(CDec(TextBox1.Text) Mod CDec(TextBox2.Text))
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " Mod " + TextBox2.Text + " = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        Catch ex2 As DivideByZeroException
            TextBox3.Text = "Cannot divide by zero to find remainder!"
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonClear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        usenum += 1
        writable += vbNewLine + CStr(usenum) + ") " + "All Text Cleared."
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonPercentage.Click
        Try
            TextBox3.Text = CStr(Val((CDec(TextBox1.Text) / CDec(TextBox2.Text)) * 100)) + " %"
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " / " + TextBox2.Text + " * 100 = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        Catch ex2 As DivideByZeroException
            TextBox3.Text = "Cannot divide by zero!"
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonIntDiv.Click
        Try
            TextBox3.Text = Val(CDec(TextBox1.Text) \ CDec(TextBox2.Text))
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " \ " + TextBox2.Text + " = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        Catch ex2 As DivideByZeroException
            TextBox3.Text = "Cannot divide by zero!"
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonExponent.Click
        Try
            TextBox3.Text = Val(CDec(TextBox1.Text) ^ CDec(TextBox2.Text))
            usenum += 1
            writable += vbNewLine + CStr(usenum) + ") " + TextBox1.Text + " ^ " + TextBox2.Text + " = " + TextBox3.Text
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        TextBox3.Text = ""
        Try
            num1 = CDec(num1)
            num2 = CDec(num2)
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            End If
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        TextBox3.Text = ""
        Try
            num1 = CDec(num1)
            num2 = CDec(num2)
        Catch ex As InvalidCastException
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            Else
                TextBox3.Text = "Please enter number only, not string."
            End If
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                TextBox3.Text = "Enter number in both the fields."
            End If
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        writable = vbNewLine + vbNewLine + vbNewLine + "Record Session Started on - " + DateString + vbNewLine + "Record Session Started in - " + TimeString + "." + vbNewLine + "Recorded functions :-" + vbNewLine
        Try
            FileOpen(21, "CALCLOG.txt", OpenMode.Append)
        Catch ex As Exception
            FileOpen(21, "CALCLOG.txt", OpenMode.Output)
        End Try
        usenum = 0
    End Sub
End Class