using CadEditor;
using System;
//css_include ninja_gaiden_2/NinjaGaiden2Utils.cs;

public class Data 
{ 
  public OffsetRec getScreensOffset()  { return new OffsetRec(0x9d6, 1 , 6*120, 6, 120);   }
  
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0x4410 , 1  , 0x1000);  }
  public int getBlocksCount()           { return 256; }
  
  public OffsetRec getBigBlocksOffset()    { return new OffsetRec(0x6c10 , 1  , 0x1000);  }
  public int getBigBlocksCount()           { return 256; }
  
  public int getPalBytesAddr()             { return 0x7e10; }

  public bool getScreenVertical()      { return true; }
  
  public bool isBigBlockEditorEnabled() { return true; }
  public bool isBlockEditorEnabled()    { return true; }
  public bool isEnemyEditorEnabled()    { return false; }
  
  public GetVideoPageAddrFunc getVideoPageAddrFunc() { return getVideoAddress; }
  public GetVideoChunkFunc    getVideoChunkFunc()    { return getVideoChunk;   }
  public SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  
  public GetPalFunc           getPalFunc()           { return getPallete;}
  public SetPalFunc           setPalFunc()           { return null;}
  
  public GetBlocksFunc        getBlocksFunc()        { return NinjaGaiden2Utils.getBlocks;}
  public SetBlocksFunc        setBlocksFunc()        { return NinjaGaiden2Utils.setBlocks;}
  
  public GetBigBlocksFunc     getBigBlocksFunc()     { return NinjaGaiden2Utils.getBigBlocksTT;}
  public SetBigBlocksFunc     setBigBlocksFunc()     { return NinjaGaiden2Utils.setBigBlocksTT;}
  
  //----------------------------------------------------------------------------
  public int getVideoAddress(int id)
  {
    return -1;
  }
  
  public byte[] getVideoChunk(int videoPageId)
  {
     return Utils.readVideoBankFromFile("chr3-2.bin", videoPageId);
  }
  
  public byte[] getPallete(int palId)
  {
      return Utils.readBinFile("pal3-2.bin");
  }
}