public static class Wallet
{
    private static float balance = 9999.0f;

    public static void Deduct(float amount)
    {
        balance -= amount;
    }

    public static void Add(float amount)
    {
        balance += amount;
    }

    public static float GetBalance()
    {
        return balance;
    }
}
