using System;
using HarmonyLib;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x0200000F RID: 15
	[HarmonyPatch(typeof(VRRig), "OnDisable")]
	internal class GhostPatch : MonoBehaviour
	{
		// Token: 0x06000201 RID: 513 RVA: 0x0001187C File Offset: 0x0000FA7C
		public static bool Prefix(VRRig __instance)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			bool result;
			while (num2 != 4)
			{
				int num3;
				bool flag;
				bool flag2;
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,VRRig), ref num, ref num2, ref num3, ref flag, ref flag2, __instance, GhostPatch.GetNestedTypesGetValueOrDefault[num]);
			}
			num2 = 0;
			return result;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000118B8 File Offset: 0x0000FAB8
		public GhostPatch()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.GhostPatch), ref num, ref num2, ref num3, this, GhostPatch.GetNestedTypesGetValueOrDefault[num]);
			}
			num2 = 4;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000118EC File Offset: 0x0000FAEC
		private static bool IChannelReceiverHookSetProfileRoot(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00011920 File Offset: 0x0000FB20
		private static bool SiteIdentityPermissionAttributeTwoDigitYearMax(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool result = A_4;
			A_1 = 4;
			return result;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00011940 File Offset: 0x0000FB40
		private static void GetScopeInternalModuleBuilder(ref int A_0, ref int A_1, ref int A_2, GhostPatch A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00011964 File Offset: 0x0000FB64
		private static bool SoapIdrefsSEPMonthSuff(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = true;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00011998 File Offset: 0x0000FB98
		private static bool ScopelessEnumAttributeCreateNodeCallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = A_5 == GorillaTagger.Instance.offlineVRRig;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
			bool result;
			return result;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00011A08 File Offset: 0x0000FC08
		// Note: this type is marked as 'beforefieldinit'.
		static GhostPatch()
		{
			GhostPatch.TokenIsTerminating();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00011A1C File Offset: 0x0000FC1C
		private static void TokenIsTerminating()
		{
			GhostPatch.GetNestedTypesGetValueOrDefault = new IntPtr[5];
			GhostPatch.GetNestedTypesGetValueOrDefault[0] = ldftn(ScopelessEnumAttributeCreateNodeCallback);
			GhostPatch.GetNestedTypesGetValueOrDefault[1] = ldftn(IChannelReceiverHookSetProfileRoot);
			GhostPatch.GetNestedTypesGetValueOrDefault[2] = ldftn(SoapIdrefsSEPMonthSuff);
			GhostPatch.GetNestedTypesGetValueOrDefault[3] = ldftn(SiteIdentityPermissionAttributeTwoDigitYearMax);
			GhostPatch.GetNestedTypesGetValueOrDefault[4] = ldftn(GetScopeInternalModuleBuilder);
		}

		// Token: 0x0400006D RID: 109
		private static IntPtr[] GetNestedTypesGetValueOrDefault;
	}
}
