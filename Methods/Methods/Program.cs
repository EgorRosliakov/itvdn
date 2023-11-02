/*Пользователь вводит количество сотрудников предприятия, стоимость 1 трудодня
сотрудника и количество дней, за которые производится оплата.
Создайте метод, который считает зарплату рабочему, исходя из количества дней и
подневной оплаты труда. Создайте метод, который принимает в себя количество
сотрудников, количество рабочих дней и цену трудодня, и вычисляет общий объем
денег, необходимый для оплаты полученному количеству сотрудников, используя
внутри себя первый метод.
Посчитайте и выведите на экран общий объем денег, необходимый для оплаты
зарплаты введенному пользователем количеству сотрудников.*/



   
        Console.WriteLine("Enter numbers of company employees: ");
        decimal userNumbersEmoloyees = Convert.ToUInt32(Console.ReadLine());

        Console.WriteLine("Enter cost of 1 workday employee: ");
/*decimal userCostWorkDay = Convert.ToUInt32(Console.ReadLine());*/
         decimal.TryParse(Console.ReadLine(), out decimal userCostWorkDay);

        Console.WriteLine("Enter numbers of days for which payment is made: ");
        decimal userNumbersDaysForPayment = Convert.ToUInt32(Console.ReadLine());

        decimal monthlySalary = GetWorkerSalary(userCostWorkDay, userNumbersDaysForPayment);
        decimal totalVolumeMoney = GetOverallVolumeMoney(userNumbersEmoloyees, monthlySalary);

        Console.WriteLine($"The number of employees: {userNumbersEmoloyees}\nRequired amount of money: {totalVolumeMoney}");
    
    static decimal GetWorkerSalary(decimal userCostWorkDay, decimal userNumbersDaysForPayment) => 
        userNumbersDaysForPayment * userCostWorkDay;
    
        /*decimal monthlySalary = userNumbersDaysForPayment * userCostWorkDay;
        return monthlySalary;*/
    

    static decimal GetOverallVolumeMoney(decimal userNumbersEmoloyees, decimal monthlySalary) => 
        userNumbersEmoloyees * monthlySalary;
    
       /* decimal totalVolumeMoney = userNumbersEmoloyees * monthlySalary;
        return totalVolumeMoney;*/
    


