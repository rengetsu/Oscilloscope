using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinUsbDll;

namespace Oscilloscope
{
    public class SystemSysUtils
    {
        /// <summary>
        /// Raise last win32 error
        /// </summary>
        private void RaiseLastWin32Error()
        {
            try { Win32Check(false); }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
        }

        /// <summary>
        /// Win32 check
        /// </summary>
        /// <param name="RetVal"></param>
        /// <returns></returns>
        public Boolean Win32Check(Boolean RetVal)
        {
            if (!RetVal)    RaiseLastWin32Error();
            return RetVal;
        }
    }

    public class WinUSBConnect
    {
        SystemSysUtils systemutils = new SystemSysUtils();
        WinUsbDll WinUsbDll = new WinUsbDll();

        bool Initialized = false;
        private object hWinUSBInterface;

        /// <summary>
        /// Check if we have now USB Connection or not. <br/>
        /// Now this function is used only in some DeviceInterface elements. <br/>
        /// It's bad way to check is device is connected or not, so need to rewrite it for something better later <br/>
        /// </summary>
        /// <returns></returns>
        public Boolean checkUSBConnection()
        {
            Boolean Result = Initialized;
            return Result;
        }

        /// <summary>
        /// Windows USB Initialization function
        /// </summary>
        void WinUSB_Initialize()
        {
            if (Initialized == false)
            {
                try
                {
                    //  Trying to load WinUSB Dll
                    WinUsbDll.LoadWinUSBDLL();
                    Initialized = true;
                }
                catch (Exception ex)
                {
                    //  Error loading WinUSB Dll
                    throw new Exception(String.Format("Error loading WinUSB.dll. Make sure device USB driver is installed."), ex);
                }
            }
        }

        /// <summary>
        /// Function to open USB connection
        /// </summary>
        /// <param name="DevicePath">Get a device path value</param>
        public void WinUSB_Open(string DevicePath)
        {
            WinUSB_Initialize();
        }

        /// <summary>
        /// Function to reset Pipe
        /// </summary>
        /// <param name="PipeID">Pipe ID</param>
        public void WinUSB_ResetPipe(Byte PipeID)
        {
            int NonZero = 1;
            systemutils.Win32Check(WinUsb_SetPipePolicy(hWinUSBInterface, PipeID, 2, 4, NonZero));
            systemutils.Win32Check(WinUsb_ResetPipe(hWinUSBInterface, PipeID));
        }

        /// <summary>
        /// Win USB reset pipe
        /// </summary>
        /// <param name="hWinUSBInterface"></param>
        /// <param name="pipeID"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool WinUsb_ResetPipe(object hWinUSBInterface, byte pipeID)
        {
            try
            {
                _WINUSB_SETUP_PACKET.ReferenceEquals(hWinUSBInterface, pipeID);
            }
            catch
            {
                throw new NotImplementedException();
            }
            return true; 
        }

        /// <summary>
        /// WinUsb SetPipePolicy
        /// </summary>
        /// <param name="hWinUSBInterface"></param>
        /// <param name="pipeID"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="nonZero"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool WinUsb_SetPipePolicy(object hWinUSBInterface, byte pipeID, int v1, int v2, int nonZero)
        {
            try
            {
                _WINUSB_PIPE_INFORMATION.ReferenceEquals(hWinUSBInterface, pipeID);
            }
            catch
            {
                throw new NotImplementedException();
            }
            return true;
        }

        /// <summary>
        /// Win USB read pipe
        /// </summary>
        /// <param name="PipeID"></param>
        /// <param name="A"></param>
        /// <param name="Size"></param>
        /// <param name="Timeout"></param>
        public void WinUSB_ReadPipe(Byte PipeID, Byte A, int Size, int Timeout)
        {
            uint result;
            long hEvent;
            Overlapped Overlapped;
            int WaitResult;
            Debug.Assert(Opened);
            //@ Unsupported function or procedure: 'CreateEvent'
            hEvent = CreateEvent(null, false, false, null);
            //@ Unsupported function or procedure: 'FillChar'
            FillChar(Overlapped, sizeof(Overlapped), 0);
            //@ Unsupported property or method(C): 'hEvent'
            Overlapped.hEvent = hEvent;
            try
            {
                if (!WinUsbDllUnit.WinUsb_ReadPipe(hWinUSBInterface, PipeID, Buffer, Size, result, Overlapped))
                {
                    //@ Unsupported function or procedure: 'GetLastError'
                    //@ Undeclared identifier(3): 'ERROR_IO_PENDING'
                    if (GetLastError != ERROR_IO_PENDING)
                    {
                        //@ Unsupported function or procedure: 'Win32Check'
                        systemutils.Win32Check(false);
                    }
                    try
                    {
                        //@ Unsupported function or procedure: 'WaitForSingleObject'
                        WaitResult = WaitForSingleObject(hEvent, Timeout);
                        //@ Undeclared identifier(3): 'WAIT_FAILED'
                        //@ Unsupported function or procedure: 'Win32Check'
                        systemutils.Win32Check(WaitResult != WAIT_FAILED);
                        //@ Undeclared identifier(3): 'WAIT_TIMEOUT'
                        if (WaitResult == WAIT_TIMEOUT)
                        {
                            throw new EDanWinUSBTimeout("WinUSB ReadPipe Timeout (" + Timeout.ToString() + " ms)");
                        }
                        //@ Unsupported function or procedure: 'Win32Check'
                        systemutils.Win32Check(WinUsbDllUnit.WinUsb_GetOverlappedResult(hWinUSBInterface, Overlapped, result, false));
                    }
                    catch
                    {
                        //@ Undeclared identifier(3): 'CancelIo'
                        //@ Unsupported function or procedure: 'Win32Check'
                        systemutils.Win32Check(CancelIo(hDevice));
                        throw new NotImplementedException();
                    }
                }
            }
            finally
            {
                //@ Unsupported function or procedure: 'CloseHandle'
                CloseHandle(hEvent);
            }
        }

        private bool CancelIo(long hDevice)
        {
            throw new NotImplementedException();
        }

        private int WaitForSingleObject(long hEvent, int timeout)
        {
            throw new NotImplementedException();
        }

        private void CloseHandle(long hEvent)
        {
            throw new NotImplementedException();
        }

        private void FillChar(Overlapped overlapped, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private long CreateEvent(object value1, bool v1, bool v2, object value2)
        {
            throw new NotImplementedException();
        }

        //  Далее идут старые функции Дэна по которым я переписывал код

        //public static bool Initialized = false;
        public static long hDevice = 0;
        //public static long hWinUSBInterface = 0;
        public static bool Opened = false;
        public static void DanWinUSB_Initialize()
        {
            //if (!Initialized)
            //{
                //try
                //{
                    //WinUsbDll.LoadWinUSBDLL();
                    //Initialized = true;
                //}
                //catch (Exception E)
                //{
                //    //E.Message = "Error loading WinUSB.dll. Make sure device USB driver is installed." + "\r\n\r\n" + E.Message;
                //    throw E;
                //}
            //}
        }

        public static void DanWinUSB_Finalize()
        {
            //if (Initialized)
            //{
                //WinUsbDllUnit.UnloadWinUSBDLL();
                //Initialized = false;
            //}
        }

        // ???? ?????? ??? ?????????? ????????? ? ????????? UTF-8 "?"
        public static void DanWinUSB_Open(string DevicePath)
        {
            DanWinUSB_Initialize();
            //Debug.Assert(!Opened);
            try
            {
                //@ Undeclared identifier(3): 'GENERIC_WRITE'
                //@ Undeclared identifier(3): 'GENERIC_READ'
                //@ Undeclared identifier(3): 'FILE_SHARE_READ'
                //@ Undeclared identifier(3): 'FILE_SHARE_WRITE'
                //@ Undeclared identifier(3): 'OPEN_EXISTING'
                //@ Undeclared identifier(3): 'FILE_ATTRIBUTE_NORMAL'
                //@ Undeclared identifier(3): 'FILE_FLAG_OVERLAPPED'
                //@ Undeclared identifier(3): 'CreateFile'
                //hDevice = CreateFile((DevicePath as string), GENERIC_WRITE || GENERIC_READ, FILE_SHARE_READ || FILE_SHARE_WRITE, null, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL || FILE_FLAG_OVERLAPPED, 0);
                //@ Undeclared identifier(3): 'INVALID_HANDLE_VALUE'
                //@ Unsupported function or procedure: 'Win32Check'
                //Win32Check(hDevice != INVALID_HANDLE_VALUE);
            }
            catch (Exception E)
            {
                //E.Message = "Cannot connect to device via USB. Make sure the device is connected and device USB driver is installed." + "\r\n\r\n" + E.Message;
                throw E;
            }
            try
            {
                //@ Unsupported function or procedure: 'Win32Check'
                //Win32Check(WinUsbDllUnit.WinUsb_Initialize(hDevice, hWinUSBInterface));
            }
            catch
            {
                //@ Unsupported function or procedure: 'CloseHandle'
                //CloseHandle(hDevice);
                throw new NotImplementedException();
            }
            Opened = true;
        }

        public static void DanWinUSB_Close()
        {
            if (Opened)
            {
                Opened = false;
                //WinUsbDllUnit.WinUsb_Free(hWinUSBInterface);
                //@ Unsupported function or procedure: 'CloseHandle'
                //CloseHandle(hDevice);
            }
        }

        public static void DanWinUSB_WritePipe(byte PipeID, object Buffer, uint Count)
        {
            uint BytesWritten;
            //Debug.Assert(Opened);
            //@ Unsupported function or procedure: 'Win32Check'
            //Win32Check(WinUsbDllUnit.WinUsb_WritePipe(hWinUSBInterface, PipeID, Buffer, Count, BytesWritten, null));
        }

        public static uint DanWinUSB_ReadPipe(byte PipeID, ref object Buffer, uint Size, int Timeout)
        {
            uint result;
            long hEvent;
            //TOverlapped Overlapped;
            int WaitResult;
            //Debug.Assert(Opened);
            //@ Unsupported function or procedure: 'CreateEvent'
            //hEvent = CreateEvent(null, false, false, null);
            //@ Unsupported function or procedure: 'FillChar'
            //FillChar(Overlapped, sizeof(Overlapped), 0);
            //@ Unsupported property or method(C): 'hEvent'
            //Overlapped.hEvent = hEvent;
            try
            {
                //if (!WinUsbDllUnit.WinUsb_ReadPipe(hWinUSBInterface, PipeID, Buffer, Size, result, Overlapped))
                {
                    //@ Unsupported function or procedure: 'GetLastError'
                    //@ Undeclared identifier(3): 'ERROR_IO_PENDING'
                    //if (GetLastError != ERROR_IO_PENDING)
                    {
                        //@ Unsupported function or procedure: 'Win32Check'
                        //Win32Check(false);
                    }
                    try
                    {
                        //@ Unsupported function or procedure: 'WaitForSingleObject'
                        //WaitResult = WaitForSingleObject(hEvent, Timeout);
                        //@ Undeclared identifier(3): 'WAIT_FAILED'
                        //@ Unsupported function or procedure: 'Win32Check'
                        //Win32Check(WaitResult != WAIT_FAILED);
                        //@ Undeclared identifier(3): 'WAIT_TIMEOUT'
                        //if (WaitResult == WAIT_TIMEOUT)
                        //{
                            //throw new EDanWinUSBTimeout("WinUSB ReadPipe Timeout (" + Timeout.ToString() + " ms)");
                        //}
                        //@ Unsupported function or procedure: 'Win32Check'
                        //Win32Check(WinUsbDllUnit.WinUsb_GetOverlappedResult(hWinUSBInterface, Overlapped, result, false));
                    }
                    catch
                    {
                        //@ Undeclared identifier(3): 'CancelIo'
                        //@ Unsupported function or procedure: 'Win32Check'
                        //Win32Check(CancelIo(hDevice));
                        //throw E;
                    }
                }
            }
            finally
            {
                //@ Unsupported function or procedure: 'CloseHandle'
                //CloseHandle(hEvent);
            }
            //return result
            return 0;
        }

        public static void DanWinUSB_ResetPipe(byte PipeID)
        {
            int NonZero;
            //Debug.Assert(Opened);
            NonZero = 1;
            // AUTO_CLEAR_STALL
            //@ Unsupported function or procedure: 'Win32Check'
            //Win32Check(WinUsbDllUnit.WinUsb_SetPipePolicy(hWinUSBInterface, PipeID, 2, 4, NonZero));
            //@ Unsupported function or procedure: 'Win32Check'
            //Win32Check(WinUsbDllUnit.WinUsb_ResetPipe(hWinUSBInterface, PipeID));
        }

        /// <summary>
        /// Class initialization
        /// </summary>
        public void initialization()
        {
        }

        /// <summary>
        /// Class finalization
        /// </summary>
        public void finalization()
        {
            DanWinUSB_Close();
            DanWinUSB_Finalize();
        }
    }
}
