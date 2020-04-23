// MyMath.cpp : Implementation of CMyMath

#include "stdafx.h"
#include "MyMath.h"


// CMyMath

STDMETHODIMP CMyMath::InterfaceSupportsErrorInfo(REFIID riid)
{
	static const IID* const arr[] = 
	{
		&IID_IMyMath
	};

	for (int i=0; i < sizeof(arr) / sizeof(arr[0]); i++)
	{
		if (InlineIsEqualGUID(*arr[i],riid))
			return S_OK;
	}
	return S_FALSE;
}


STDMETHODIMP CMyMath::Add(LONG x, LONG y, LONG* z)
{
	// TODO: Add your implementation code here
	*z = x + y;
	return S_OK;
}


STDMETHODIMP CMyMath::Subtract(LONG x, LONG y, LONG* z)
{
	// TODO: Add your implementation code here
	*z = x - y;
	return S_OK;
}


STDMETHODIMP CMyMath::Multiply(LONG x, LONG y, LONG* z)
{
	// TODO: Add your implementation code here
	*z = x * y;
	return S_OK;
}


STDMETHODIMP CMyMath::Divide(LONG x, LONG y, LONG* z)
{
	// TODO: Add your implementation code here
	*z = x / y;
	return S_OK;
}
