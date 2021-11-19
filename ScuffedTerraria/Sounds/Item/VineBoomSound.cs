using System;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Audio;

namespace ScuffedTerraria.Sounds.Item
	{
		public class VineBoomSound : ModSound
		{
			public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
			{
				// By creating a new instance, this ModSound allows for overlapping sounds. Non-ModSound behavior is to restart the sound, only permitting 1 instance.
				soundInstance = sound.CreateInstance();
				return soundInstance;
			}


		}
	}
