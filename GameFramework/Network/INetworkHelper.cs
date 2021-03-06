﻿//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2017 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using System.IO;

namespace GameFramework.Network
{
    /// <summary>
    /// 网络辅助器接口。
    /// </summary>
    public interface INetworkHelper
    {
        /// <summary>
        /// 发送心跳协议包。
        /// </summary>
        /// <param name="networkChannel">网络频道。</param>
        /// <returns>是否发送心跳协议包成功。</returns>
        bool SendHeartBeat(INetworkChannel networkChannel);

        /// <summary>
        /// 序列化协议包。
        /// </summary>
        /// <typeparam name="T">协议包类型。</typeparam>
        /// <param name="networkChannel">网络频道。</param>
        /// <param name="destination">要序列化的目标流。</param>
        /// <param name="packet">要序列化的协议包。</param>
        void Serialize<T>(INetworkChannel networkChannel, Stream destination, T packet) where T : Packet;

        /// <summary>
        /// 反序列化协议包。
        /// </summary>
        /// <param name="networkChannel">网络频道。</param>
        /// <param name="source">要反序列化的来源流。</param>
        /// <param name="customErrorData">用户自定义错误数据。</param>
        /// <returns>反序列化后的协议包。</returns>
        Packet Deserialize(INetworkChannel networkChannel, Stream source, out object customErrorData);
    }
}
