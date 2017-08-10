/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace agile
{
    public sealed class imuCalib_t : LCM.LCM.LCMEncodable
    {
        public long utime;
        public long timestampDevice;
        public double[] imuBiasAccel;
        public double[] imuBiasGyro;
        public double[] avgAccel;
        public double[] avgGyro;
        public double[] imuVarianceAccel;
        public double[] imuVarianceGyro;
        public double imuAvgBaro;
        public double imuVarianceBaro;
        public double[] imuAvgMagn;
        public double[] imuVarianceMagn;
        public double[] orient;
        public long numMeas;
 
        public imuCalib_t()
        {
            imuBiasAccel = new double[3];
            imuBiasGyro = new double[3];
            avgAccel = new double[3];
            avgGyro = new double[3];
            imuVarianceAccel = new double[3];
            imuVarianceGyro = new double[3];
            imuAvgMagn = new double[3];
            imuVarianceMagn = new double[3];
            orient = new double[4];
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x5b6ced0905b126bfL;
 
        static imuCalib_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("agile.imuCalib_t"))
                return 0L;
 
            classes.Add("agile.imuCalib_t");
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
            outs.Write(this.utime); 
 
            outs.Write(this.timestampDevice); 
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.imuBiasAccel[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.imuBiasGyro[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.avgAccel[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.avgGyro[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.imuVarianceAccel[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.imuVarianceGyro[a]); 
            }
 
            outs.Write(this.imuAvgBaro); 
 
            outs.Write(this.imuVarianceBaro); 
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.imuAvgMagn[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.imuVarianceMagn[a]); 
            }
 
            for (int a = 0; a < 4; a++) {
                outs.Write(this.orient[a]); 
            }
 
            outs.Write(this.numMeas); 
 
        }
 
        public imuCalib_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public imuCalib_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static agile.imuCalib_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            agile.imuCalib_t o = new agile.imuCalib_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.utime = ins.ReadInt64();
 
            this.timestampDevice = ins.ReadInt64();
 
            this.imuBiasAccel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.imuBiasAccel[a] = ins.ReadDouble();
            }
 
            this.imuBiasGyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.imuBiasGyro[a] = ins.ReadDouble();
            }
 
            this.avgAccel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.avgAccel[a] = ins.ReadDouble();
            }
 
            this.avgGyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.avgGyro[a] = ins.ReadDouble();
            }
 
            this.imuVarianceAccel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.imuVarianceAccel[a] = ins.ReadDouble();
            }
 
            this.imuVarianceGyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.imuVarianceGyro[a] = ins.ReadDouble();
            }
 
            this.imuAvgBaro = ins.ReadDouble();
 
            this.imuVarianceBaro = ins.ReadDouble();
 
            this.imuAvgMagn = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.imuAvgMagn[a] = ins.ReadDouble();
            }
 
            this.imuVarianceMagn = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.imuVarianceMagn[a] = ins.ReadDouble();
            }
 
            this.orient = new double[(int) 4];
            for (int a = 0; a < 4; a++) {
                this.orient[a] = ins.ReadDouble();
            }
 
            this.numMeas = ins.ReadInt64();
 
        }
 
        public agile.imuCalib_t Copy()
        {
            agile.imuCalib_t outobj = new agile.imuCalib_t();
            outobj.utime = this.utime;
 
            outobj.timestampDevice = this.timestampDevice;
 
            outobj.imuBiasAccel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.imuBiasAccel[a] = this.imuBiasAccel[a];
            }
 
            outobj.imuBiasGyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.imuBiasGyro[a] = this.imuBiasGyro[a];
            }
 
            outobj.avgAccel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.avgAccel[a] = this.avgAccel[a];
            }
 
            outobj.avgGyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.avgGyro[a] = this.avgGyro[a];
            }
 
            outobj.imuVarianceAccel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.imuVarianceAccel[a] = this.imuVarianceAccel[a];
            }
 
            outobj.imuVarianceGyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.imuVarianceGyro[a] = this.imuVarianceGyro[a];
            }
 
            outobj.imuAvgBaro = this.imuAvgBaro;
 
            outobj.imuVarianceBaro = this.imuVarianceBaro;
 
            outobj.imuAvgMagn = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.imuAvgMagn[a] = this.imuAvgMagn[a];
            }
 
            outobj.imuVarianceMagn = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.imuVarianceMagn[a] = this.imuVarianceMagn[a];
            }
 
            outobj.orient = new double[(int) 4];
            for (int a = 0; a < 4; a++) {
                outobj.orient[a] = this.orient[a];
            }
 
            outobj.numMeas = this.numMeas;
 
            return outobj;
        }
    }
}
