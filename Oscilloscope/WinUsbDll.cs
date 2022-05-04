using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WinUsbDll
{
    // #pragma pack(1)
    // not tested so don't use
    public struct _WINUSB_SETUP_PACKET
    {
        public byte RequestType_UNTESTED_DO_NOT_USE;
        public byte Request_UNTESTED_DO_NOT_USE;
        public ushort Value_UNTESTED_DO_NOT_USE;
        public ushort Index_UNTESTED_DO_NOT_USE;
        public ushort Length_UNTESTED_DO_NOT_USE;
    } // end _WINUSB_SETUP_PACKET

    public struct DESCRIPTOR
    {
        // Generic descriptor
        public byte Length;
        public byte DescriptorType;
        public byte[] Data;
    } // end DESCRIPTOR

    public struct _WINUSB_PIPE_INFORMATION
    {
        public uint PipeType;
        public ushort PipeId;
        // strange, I know, but seems to fit the data
        public ushort MaximumPacketSize;
        public ushort Interval;
    } // end _WINUSB_PIPE_INFORMATION

    // #pragma pack()
    public enum USBD_PIPE_TYPE
    {
        UsbdPipeTypeControl,
        UsbdPipeTypeIsochronous,
        UsbdPipeTypeBulk,
        UsbdPipeTypeInterrupt
    } // end USBD_PIPE_TYPE

    public class WinUsbDllUnit
    {
#if WIN32
#endif
        public static bool WinUsb_Initialize = false;
#if WIN32
#endif
        public static bool WinUsb_Free = false;
#if WIN32
#endif
        public static bool WinUsb_GetAssociatedInterface_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_GetDescriptor = false;
#if WIN32
#endif
        public static bool WinUsb_QueryInterfaceSettings_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_QueryDeviceInformation_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_SetCurrentAlternateSetting_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_GetCurrentAlternateSetting_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_QueryPipe = false;
#if WIN32
#endif
        public static bool WinUsb_SetPipePolicy = false;
#if WIN32
#endif
        public static bool WinUsb_GetPipePolicy_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_ReadPipe = false;
#if WIN32
#endif
        public static bool WinUsb_WritePipe = false;
#if WIN32
#endif
        public static bool WinUsb_ControlTransfer_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_ResetPipe = false;
#if WIN32
#endif
        public static bool WinUsb_AbortPipe_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_FlushPipe_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_SetPowerPolicy_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_GetPowerPolicy_NotYetTested = false;
#if WIN32
#endif
        public static bool WinUsb_GetOverlappedResult = false;
#if WIN32
#endif
        public static DESCRIPTOR WinUsb_ParseConfigurationDescriptor_NotYetTested;
#if WIN32
#endif
        public static DESCRIPTOR WinUsb_ParseDescriptors_NotYetTested;
        public static bool DLLLoaded = false;
        public static long DLLHandle = 0;
        public static void UnloadWinUSBDLL()
        {
            //@ Unsupported function or procedure: 'FreeLibrary'
            FreeLibrary(DLLHandle);
            DLLLoaded = false;
        }

        private static void FreeLibrary(long dLLHandle)
        {
            throw new NotImplementedException();
        }

        // ???? ?????? ??? ?????????? ????????? ? ????????? UTF-8 "?"
        // Quick wrapper for WinUSB.DLL by Panu-Kristian Poiksalo
        // WARNING: Mostly untested - Only initialize, readpipe and writepipe work ok
        // License: LGPL. Assume that it doesn't work and don't blame me for any errors.
        // Most data types were manually converted from strange types to Pascal types.
        // Much of it was jus a quick hack. Those types that were not known or interesting
        // to me were guessed so don't rely on any structured type to work properly.
        // This is very early and very untested code. Only use it as basis for bad ideas.
        // P.S. Instead of using winusb.dll, I think someone should make a delphi
        // implementation for the WinUSB COM interface.
        // Version: 0.01 Date: 18.11(November).2007
        public static void LoadWinUSBDLL()
        {
            if (DLLLoaded)
            {
                return;
            }
            // ErrorMode := SetErrorMode($8000{SEM_NoOpenFileErrorBox});
            //@ Unsupported function or procedure: 'LoadLibrary'
            DLLHandle = LoadLibrary("WINUSB.DLL");
            //@ Unsupported function or procedure: 'Win32Check'
            Win32Check(DLLHandle != 0);
            DLLLoaded = true;
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_Initialize = GetProcAddress(DLLHandle, "WinUsb_Initialize");
#if WIN32
            Debug.Assert(WinUsb_Initialize != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_Free = GetProcAddress(DLLHandle, "WinUsb_Free");
#if WIN32
            Debug.Assert(WinUsb_Free != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_GetAssociatedInterface_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_GetAssociatedInterface");
#if WIN32
            Debug.Assert(WinUsb_GetAssociatedInterface_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_GetDescriptor = GetProcAddress(DLLHandle, "WinUsb_GetDescriptor");
#if WIN32
            Debug.Assert(WinUsb_GetDescriptor != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_QueryInterfaceSettings_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_QueryInterfaceSettings");
#if WIN32
            Debug.Assert(WinUsb_QueryInterfaceSettings_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_QueryDeviceInformation_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_QueryDeviceInformation");
#if WIN32
            Debug.Assert(WinUsb_QueryDeviceInformation_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_SetCurrentAlternateSetting_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_SetCurrentAlternateSetting");
#if WIN32
            Debug.Assert(WinUsb_SetCurrentAlternateSetting_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_GetCurrentAlternateSetting_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_GetCurrentAlternateSetting");
#if WIN32
            Debug.Assert(WinUsb_GetCurrentAlternateSetting_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_QueryPipe = GetProcAddress(DLLHandle, "WinUsb_QueryPipe");
#if WIN32
            Debug.Assert(WinUsb_QueryPipe != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_SetPipePolicy = GetProcAddress(DLLHandle, "WinUsb_SetPipePolicy");
#if WIN32
            Debug.Assert(WinUsb_SetPipePolicy != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_GetPipePolicy_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_GetPipePolicy");
#if WIN32
            Debug.Assert(WinUsb_GetPipePolicy_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_ReadPipe = GetProcAddress(DLLHandle, "WinUsb_ReadPipe");
#if WIN32
            Debug.Assert(WinUsb_ReadPipe != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_WritePipe = GetProcAddress(DLLHandle, "WinUsb_WritePipe");
#if WIN32
            Debug.Assert(WinUsb_WritePipe != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_ControlTransfer_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_ControlTransfer");
#if WIN32
            Debug.Assert(WinUsb_ControlTransfer_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_ResetPipe = GetProcAddress(DLLHandle, "WinUsb_ResetPipe");
#if WIN32
            Debug.Assert(WinUsb_ResetPipe != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_AbortPipe_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_AbortPipe");
#if WIN32
            Debug.Assert(WinUsb_AbortPipe_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_FlushPipe_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_FlushPipe");
#if WIN32
            Debug.Assert(WinUsb_FlushPipe_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_SetPowerPolicy_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_SetPowerPolicy");
#if WIN32
            Debug.Assert(WinUsb_SetPowerPolicy_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_GetPowerPolicy_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_GetPowerPolicy");
#if WIN32
            Debug.Assert(WinUsb_GetPowerPolicy_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            WinUsb_GetOverlappedResult = GetProcAddress(DLLHandle, "WinUsb_GetOverlappedResult");
#if WIN32
            Debug.Assert(WinUsb_GetOverlappedResult != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            //WinUsb_ParseConfigurationDescriptor_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_ParseConfigurationDescriptor");
#if WIN32
            Debug.Assert(WinUsb_ParseConfigurationDescriptor_NotYetTested != null);
#endif
            //@ Unsupported function or procedure: 'GetProcAddress'
            //WinUsb_ParseDescriptors_NotYetTested = GetProcAddress(DLLHandle, "WinUsb_ParseDescriptors");
#if WIN32
            Debug.Assert(WinUsb_ParseDescriptors_NotYetTested != null);
#endif
            // LoadDLL

        }

        internal static bool WinUsb_ReadPipe(object hWinUSBInterface, byte pipeID, Buffer buffer, int size, uint result, Overlapped overlapped)
        {
            throw new NotImplementedException();
        }

        private static void Win32Check(bool v)
        {
            throw new NotImplementedException();
        }

        private static long LoadLibrary(string v)
        {
            throw new NotImplementedException();
        }

        private static bool GetProcAddress(long dLLHandle, string v)
        {
            throw new NotImplementedException();
        }
    } // end WinUsbDll
}

namespace Oscilloscope
{
    public class WinUsbDll
    {
        bool DLLLoaded = false;

        public void LoadWinUSBDLL()
        {
            if (DLLLoaded == false)
            {
                DLLLoaded = true;
            }
        }
    }
}
