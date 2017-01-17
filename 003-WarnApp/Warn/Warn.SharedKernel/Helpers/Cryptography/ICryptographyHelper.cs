using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warn.SharedKernel.Helpers.Cryptography
{
    public interface ICryptographyHelper
    {
        string CreateHash(string password);
        bool ValidatePassword(string password, string correctHash);
    }
}
