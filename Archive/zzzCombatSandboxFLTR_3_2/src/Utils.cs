using UnityEngine;

namespace CombatSandboxOverrides;

public static class Utils
{
	private static readonly ConnectionManager cm = SingletonMonoBehaviour<ConnectionManager>.Instance;
	public static bool IsHost => GameManager.IsDedicatedServer || cm.IsServer;
	public static bool IsHostAndClient => !GameManager.IsDedicatedServer && cm.IsServer;
	public static bool IsRemoteClient => cm.IsClient && !cm.IsServer && cm.IsConnected;
	public static bool IsOfflineSingleplayer => cm.IsClient && !cm.IsServer && !cm.IsConnected;
}
