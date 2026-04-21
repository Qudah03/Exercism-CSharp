using System;
using System.Numerics;

public static class DiffieHellman
{
    

    public static BigInteger PrivateKey(BigInteger primeP) 
    {
        // We need a random value between 2 and p-1.
        // For the sake of the exercise, a simple Random will work, 
        // though real crypto uses RandomNumberGenerator.
        Random rand = new Random();

        // This is a pragmatic way to get a value within the range for the tests.
        // BigInteger doesn't have a simple .Next(min, max), 
        // so we often pick a small random for these exercises.
        return new BigInteger(rand.Next(2, (int)primeP -1));
    }

    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) 
    {
        // The public key is g^privateKey mod p
        return BigInteger.ModPow(primeG, privateKey, primeP);
    }

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) 
    {
        // The secret is publicKey^privateKey mod p
        return BigInteger.ModPow(publicKey, privateKey, primeP);
    }
}