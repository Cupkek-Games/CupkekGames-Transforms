using UnityEngine;

namespace CupkekGames.Transforms
{
  public static class TransformUtils
  {
    /// <summary>
    /// Recursively sets the localScale for the transform and all its descendants
    /// </summary>
    public static void SetScaleRecursive(Transform parent, Vector3 scale)
    {
      parent.localScale = scale;
      foreach (Transform child in parent)
      {
        SetScaleRecursive(child, scale);
      }
    }
  }
}
