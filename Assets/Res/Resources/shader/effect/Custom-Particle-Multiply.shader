Shader "Custom/Particles/Multiply" {
Properties {
	_MainTex ("Particle Texture", 2D) = "white" {}
	_AlphaTex("Alpha Texture",2D) = "white" {}
	_InvFade ("Soft Particles Factor", Range(0.01,3.0)) = 1.0
	//----------------------add------------------------------
	_Position ("Position", Vector) = (0,0,0,0)
	_Scale ("Scale", Vector) = (1,1,1,1)
	//----------------------add------------------------------	
}

Category {
	Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
	Blend Zero SrcColor
	Cull Off Lighting Off ZWrite Off
	
	SubShader {
		Pass {
		
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_particles
			#pragma multi_compile_fog

			#include "UnityCG.cginc"

			sampler2D _MainTex;
			sampler2D _AlphaTex;
			fixed4 _TintColor;
			
			struct appdata_t {
				float4 vertex : POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				#ifdef SOFTPARTICLES_ON
				float4 projPos : TEXCOORD2;
				#endif
			};
			
			float4 _MainTex_ST;
			fixed4 _AlphaTex_ST;
			//----------------------add------------------------------
			float4 _Position;
			float4 _Scale;
			//----------------------add------------------------------
			v2f vert (appdata_t v)
			{
				v2f o;
				//----------------------add------------------------------
				float4 objV = mul(UNITY_MATRIX_MV, v.vertex);
				objV.xyz -= _Position;
				objV.xyz = float3(_Scale.x * objV.x, _Scale.y * objV.y, _Scale.z * objV.z);
				objV.xyz += _Position;
				o.vertex = mul(UNITY_MATRIX_P, objV);
				//----------------------add------------------------------
				//o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				#ifdef SOFTPARTICLES_ON
				o.projPos = ComputeScreenPos (o.vertex);
				COMPUTE_EYEDEPTH(o.projPos.z);
				#endif
				o.color = v.color;
				o.texcoord = TRANSFORM_TEX(v.texcoord,_MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}

			sampler2D_float _CameraDepthTexture;
			float _InvFade;
			
			fixed4 frag (v2f i) : SV_Target
			{
				#ifdef SOFTPARTICLES_ON
				float sceneZ = LinearEyeDepth (SAMPLE_DEPTH_TEXTURE_PROJ(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)));
				float partZ = i.projPos.z;
				float fade = saturate (_InvFade * (sceneZ-partZ));
				i.color.a *= fade;
				#endif
				
				half4 tex= tex2D(_MainTex, i.texcoord);
				tex.a = tex2D(_AlphaTex, i.texcoord).r;
				half4 prev = i.color * tex;
				fixed4 col = lerp(half4(1,1,1,1), prev, prev.a);
				UNITY_APPLY_FOG_COLOR(i.fogCoord, col, fixed4(1,1,1,1)); // fog towards white due to our blend mode
				return col;
			}
			ENDCG 
		}
	}
}
}
