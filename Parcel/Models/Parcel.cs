using System;
using System.Collections.Generic;

namespace Parcel.Models
{
  public class ParcelVariable
  {
    private int _width;
    private int _height;
    private int _length;
    private int _volume;
    private int _price;

    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }
    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }
    public int GetLength()
    {
      return _length;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
    public int GetVolume()
    {
      _volume = _width * _height * _length;
      return _volume;

    }
    public void SetVolume(int newVolume)
    {
      _volume = newVolume;
    }
    public int GetPrice()
    {
      if( _volume >= 50)
      {
        return 100;
      }
      else if (_volume < 50)
      {
        return 50;
      }
      else
      {
        return 0;
      }
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
  }
}
