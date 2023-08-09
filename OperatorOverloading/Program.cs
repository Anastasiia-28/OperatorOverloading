using OperatorOverloading;

Employee employee1 = new Employee { Salary = 3000 };
Console.WriteLine($"Increased salary: {employee1 + 500}");
Console.WriteLine($"Reduced salary: {employee1 - 200}");
Employee employee2 = new Employee { Salary = 3000 };
Console.WriteLine(employee1 == employee2);
Console.WriteLine(employee1.Equals(employee2));
Console.WriteLine(employee1 != employee2);
Console.WriteLine(!employee1.Equals(employee2));
Console.WriteLine();

City Odesa = new City { NumResidents = 993120 };
Console.WriteLine($"After adding residents: {Odesa + 15000}");
Console.WriteLine($"After a decrease in the number of residents: {Odesa - 5000}");
City Dnipro = new City { NumResidents = 966400 };
Console.WriteLine(Odesa == Dnipro);
Console.WriteLine(Odesa.Equals(Dnipro));
Console.WriteLine(Odesa != Dnipro);
Console.WriteLine(!Odesa.Equals(Dnipro));
Console.WriteLine();

CreditCard creditCard1 = new CreditCard("379") {SumOfMoney = 20000 };
CreditCard creditCard2 = new CreditCard("532") {SumOfMoney = 30000 };
Console.WriteLine(creditCard1 + 5000);
Console.WriteLine(creditCard1 - 3000);
Console.WriteLine("379" == creditCard1);
Console.WriteLine("378" != creditCard1);
Console.WriteLine(creditCard1 > creditCard2);
Console.WriteLine(creditCard1 < creditCard2);
Console.WriteLine(!creditCard1.Equals(creditCard2));
Console.WriteLine(creditCard1.Equals(creditCard2));
Console.WriteLine();

Matrix matrix1 = new Matrix(3);
matrix1.CompleteMatrix();
matrix1.ShowMatrix();
Console.WriteLine();
Matrix matrix2 = new Matrix(3);
matrix2.CompleteMatrix();
matrix2.ShowMatrix();
Console.WriteLine();
Console.WriteLine(matrix1==matrix2);
Console.WriteLine(matrix1!=matrix2);
Console.WriteLine(matrix1.Equals(matrix2));
Console.WriteLine(!matrix1.Equals(matrix2));
Console.WriteLine();
Matrix resultMatrix = matrix1*matrix2;
resultMatrix.ShowMatrix();
Console.WriteLine();
Matrix resultMatrix1 = matrix1 * 3;
resultMatrix1.ShowMatrix();
Console.WriteLine();
Matrix resultMatrixAdd = (matrix1 + matrix2);
resultMatrixAdd.ShowMatrix();
Console.WriteLine();
Matrix resultMatrixSub = (matrix1 - matrix2);
resultMatrixSub.ShowMatrix();







