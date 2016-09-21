﻿using System;

namespace AlphaOmega.Debug.Data.Tables
{
	/// <summary>One for each caught type, in the order that the types should be tested.</summary>
	public class encoded_type_addr_pair_row : BaseRow
	{
		private Int32 type_idxI { get { return base.GetValue<Int32>(0); } }

		/// <summary>Index into the type_ids list for the type of the exception to catch</summary>
		public type_id_row type_idx { get { return base.File.TYPE_ID_ITEM[(UInt32)this.type_idxI]; } }

		/// <summary>Bytecode address of the associated exception handler</summary>
		public Int32 addr { get { return base.GetValue<Int32>(1); } }
	}
}