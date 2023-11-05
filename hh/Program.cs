// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
private void buttonExecute_Click(object sender, EventArgs e)
{
int result = 0;
int number1, number2;
int.TryParse(textBoxNumber1.Text, out number1);
int.TryParse(textBoxNumber2.Text, out number2);

switch (comboBoxSystem.Text)
{
case "Bin":
switch (comboBoxOperation.Text)
{
case "+":
result = number1 + number2;
break;
case "-":
result = number1 — number2;
break;
case "*":
result = number1 * number2;
break;
case "/":
result = number1 / number2;
break;
}
textBoxResult.Text = Convert.ToString(result, 2);
break;

case "Oct":
switch (comboBoxOperation.Text)
{
case "+":
result = number1 + number2;
break;
case "-":
result = number1 — number2;
break;
case "*":
result = number1 * number2;
break;
case "/":
result = number1 / number2;
break;
}
textBoxResult.Text = Convert.ToString(result, 8);
break;

case "Hex":
switch (comboBoxOperation.Text)
{
case "+":
result = number1 + number2;
break;
case "-":
result = number1 — number2;
break;
case "*":
result = number1 * number2;
break;
case "/":
result = number1 / number2;
break;
}
textBoxResult.Text = Convert.ToString(result, 16);
break;
}
}