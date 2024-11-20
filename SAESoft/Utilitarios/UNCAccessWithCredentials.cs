using System;
using System.Runtime.InteropServices;
using NET_API_STATUS = System.UInt32;

namespace SAESoft.Utilitarios
{
    public partial class UNCAccessWithCredentials : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct USE_INFO_2
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            internal string ui2_local;

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string ui2_remote;

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string ui2_password;

            internal uint ui2_status;
            internal uint ui2_asg_type;
            internal uint ui2_refcount;
            internal uint ui2_usecount;

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string ui2_username;

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string ui2_domainname;
        }

        internal static partial class Compartida
        {
            [LibraryImport("NetApi32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
            public static partial NET_API_STATUS NetUseAdd(
                [MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
                uint Level,
                IntPtr Buf,  // Cambiado ref a IntPtr
                out uint ParmError);

            [LibraryImport("NetApi32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
            public static partial NET_API_STATUS NetUseDel(
                [MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
                [MarshalAs(UnmanagedType.LPWStr)] string UseName,
                uint ForceCond);
        }

        private bool disposed = false;

        private string sUNCPath;
        private string sUser;
        private string sPassword;
        private string sDomain;
        private int iLastError;

        public UNCAccessWithCredentials() { }

        public int LastError
        {
            get { return iLastError; }
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                NetUseDelete();
            }
            disposed = true;
            GC.SuppressFinalize(this);
        }

        public bool NetUseWithCredentials(string UNCPath, string User, string Domain, string Password)
        {
            sUNCPath = UNCPath;
            sUser = User;
            sPassword = Password;
            sDomain = Domain;
            return NetUseWithCredentials();
        }

        private bool NetUseWithCredentials()
        {
            uint returncode;
            IntPtr bufPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(USE_INFO_2)));
            try
            {
                USE_INFO_2 useinfo = new()
                {
                    ui2_remote = sUNCPath,
                    ui2_username = sUser,
                    ui2_domainname = sDomain,
                    ui2_password = sPassword,
                    ui2_asg_type = 0,
                    ui2_usecount = 1
                };
                Marshal.StructureToPtr(useinfo, bufPtr, false);

                returncode = Compartida.NetUseAdd(null, 2, bufPtr, out uint paramErrorIndex);
                iLastError = (int)returncode;
                return returncode == 0;
            }
            catch
            {
                iLastError = Marshal.GetLastWin32Error();
                return false;
            }
            finally
            {
                Marshal.FreeHGlobal(bufPtr);
            }
        }

        public bool NetUseDelete()
        {
            uint returncode;
            try
            {
                returncode = Compartida.NetUseDel(null, sUNCPath, 2);
                iLastError = (int)returncode;
                return (returncode == 0);
            }
            catch
            {
                iLastError = Marshal.GetLastWin32Error();
                return false;
            }
        }

        ~UNCAccessWithCredentials()
        {
            Dispose();
        }
    }
}
