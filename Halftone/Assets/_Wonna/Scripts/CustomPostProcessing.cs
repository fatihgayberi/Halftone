using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wonnasmith
{
    [ExecuteAlways]
    public class CustomPostProcessing : MonoBehaviour
    {
        [SerializeField] private Material postProcessingMaterial;

        private void OnRenderImage(RenderTexture src, RenderTexture dest)
        {
            if (postProcessingMaterial == null)
            {
                return;
            }

            Graphics.Blit(src, dest, postProcessingMaterial);
        }

    }
}