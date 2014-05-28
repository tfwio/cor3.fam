/*
 * Created by SharpDevelop.
 * User: tfw
 * Date: 8/23/2009
 * Time: 12:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using fam3;

namespace fam3.res
{
	public sealed class file_sys
	{
		static public Image folder { get { return famfam_silky.folder; } }
		static public Image folder_get { get { return famfam_silky.folder_go; } }

		static public Image drive_find { get { return famfam_silky.drive_magnify; } }
		static public Image drive_go { get { return famfam_silky.drive_magnify; } }

		static public Image fixed_disk { get { return famfam_silky.drive; } }
		static public Image cdrom { get { return famfam_silky.drive_cd; } }
		static public Image network { get { return famfam_silky.drive_network; } }
		static public Image error { get { return famfam_silky.drive_error; } }
		static public Image ram { get { return famfam_silky.brick; } }
		static public Image removable { get { return famfam_silky.ipod; } }

		static public Image FromDriveInfo( System.IO.DriveInfo dinfo )
		{
			switch (dinfo.DriveType)
			{
				case System.IO.DriveType.Fixed: return file_sys.fixed_disk;
				case System.IO.DriveType.CDRom: return  file_sys.cdrom;
				case System.IO.DriveType.Network: return  file_sys.network;
				case System.IO.DriveType.NoRootDirectory: return  file_sys.error;
				case System.IO.DriveType.Ram: return  file_sys.ram;
				case System.IO.DriveType.Removable: return  file_sys.removable;
				default: return  file_sys.error;
			}
		}
	}
}
namespace fam3
{
	public class __fam3
	{
		static public ImageList il_fam3()
		{
			ImageList il = new ImageList();
			return il;
		}
	}
}
