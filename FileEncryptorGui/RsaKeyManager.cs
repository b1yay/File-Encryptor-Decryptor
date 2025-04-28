using System.Security.Cryptography;

namespace FileEncryptorGui
{
    public static class RsaKeyManager
    {
        private static RSAParameters publicKey;
        private static RSAParameters privateKey;

        static RsaKeyManager()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                publicKey = rsa.ExportParameters(false);  // public only
                privateKey = rsa.ExportParameters(true);  // public + private
            }
        }

        public static RSAParameters PublicKey => publicKey;
        public static RSAParameters PrivateKey => privateKey;
    }
}
