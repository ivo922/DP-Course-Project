# DP-Course-Project
 Facade, Observer, Singleton

Customer class
int balance: Stores available funds of each customer
string name: Stores the name of each customer

Bank class: Facade class, provides access to different methods.

public static void SetBalanceObserver(Customer c) - Adds a new balance observer to a customer
public static void RemoveBalanceObserver(Customer c) - Removes an existing balance observer from the customer
public static Customer NewCustomer(string name) - creates and returns a new customer object
public static void Deposit(Customer c, int value) - Deposit into the customer's balance
public static void Withdraw(Customer c, int value) - withdraw from customer's balance
