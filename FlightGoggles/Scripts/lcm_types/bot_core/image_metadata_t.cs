/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace bot_core
{
    public sealed class image_metadata_t : LCM.LCM.LCMEncodable
    {
        public String key;
        public int n;
        public byte[] value;
 
        public image_metadata_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x4d25b1a682bbfdc7L;
 
        static image_metadata_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("bot_core.image_metadata_t"))
                return 0L;
 
            classes.Add("bot_core.image_metadata_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            byte[] __strbuf = null;
            __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.key); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
 
            outs.Write(this.n); 
 
            for (int a = 0; a < this.n; a++) {
                outs.Write(this.value[a]); 
            }
 
        }
 
        public image_metadata_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public image_metadata_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static bot_core.image_metadata_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            bot_core.image_metadata_t o = new bot_core.image_metadata_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            byte[] __strbuf = null;
            __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.key = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
 
            this.n = ins.ReadInt32();
 
            this.value = new byte[(int) n];
            for (int a = 0; a < this.n; a++) {
                this.value[a] = ins.ReadByte();
            }
 
        }
 
        public bot_core.image_metadata_t Copy()
        {
            bot_core.image_metadata_t outobj = new bot_core.image_metadata_t();
            outobj.key = this.key;
 
            outobj.n = this.n;
 
            outobj.value = new byte[(int) n];
            for (int a = 0; a < this.n; a++) {
                outobj.value[a] = this.value[a];
            }
 
            return outobj;
        }
    }
}
