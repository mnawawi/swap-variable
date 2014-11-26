
Imports Microsoft.VisualBasic

Public Class Form1

  Dim ValueX As Integer
  Dim ValueY As Integer

  Public Function swapvarable()

    If TextBox1.Text = "" And TextBox2.Text = "" Then

      MessageBox.Show("Insert Number")

    Else

      'get the value

      ValueX = TextBox1.Text
      ValueY = TextBox2.Text

      ' swapping process
      'use Xor algorithm

      ValueX = ValueX Xor ValueY
      ValueY = ValueX Xor ValueY
      ValueX = ValueX Xor ValueY

      'show the value after swap
      TextBox1.Text = ValueX
      TextBox2.Text = ValueY

    End If
    Return 0
  End Function

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    swapvarable()

  End Sub

  Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

      e.Handled = True
      MessageBox.Show("Number Only", "Warning")

    End If
  End Sub

  Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

      e.Handled = True
      MessageBox.Show("Number Only", "Warning")

    End If
  End Sub


End Class
