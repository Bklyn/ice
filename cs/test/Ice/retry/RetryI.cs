// **********************************************************************
//
// Copyright (c) 2003-2006 ZeroC, Inc. All rights reserved.
//
// This copy of Ice-E is licensed to you under the terms described in the
// ICEE_LICENSE file included in this distribution.
//
// **********************************************************************

using System;

public sealed class RetryI : Test.RetryDisp_
{
    public RetryI()
    {
    }

    public override void op(bool kill, Ice.Current current)
    {
        if(kill)
	{
	    current.con.close(true);
	}
    }

    public override void shutdown(Ice.Current current)
    {
        current.adapter.getCommunicator().shutdown();
    }
}
