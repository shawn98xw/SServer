﻿using System;
using System.Data.Common;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Common.Net;

namespace SceneServer;

public class SceneServer
{
	public NetNode Node { get; set; }

	public SceneServer()
	{
		Node = new NetNode(EServiceType.Scene);
	}
}
