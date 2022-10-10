
namespace M6502
{
	public static class Utility
	{
		public static Mnemonic ConvertOpCodeToMnemonic(int opcode)
		{
			switch (opcode)
			{
				case 0x69:  // ADC Immediate
				case 0x65:  // ADC Zero Page
				case 0x75:  // ADC Zero Page X
				case 0x6D:  // ADC Absolute
				case 0x7D:  // ADC Absolute X
				case 0x79:  // ADC Absolute Y
				case 0x61:  // ADC Indrect X
				case 0x71:  // ADC Indirect Y
					{
						return Mnemonic.ADC;
					}
				case 0x29:  // AND Immediate
				case 0x25:  // AND Zero Page
				case 0x35:  // AND Zero Page X
				case 0x2D:  // AND Absolute
				case 0x3D:  // AND Absolute X
				case 0x39:  // AND Absolute Y
				case 0x21:  // AND Indirect X
				case 0x31:  // AND Indirect Y
					{
						return Mnemonic.AND;
					}
				case 0x0A:  // ASL Accumulator
				case 0x06:  // ASL Zero Page
				case 0x16:  // ASL Zero Page X
				case 0x0E:  // ASL Absolute
				case 0x1E:  // ASL Absolute X
					{
						return Mnemonic.ASL;
					}
				case 0x90:  // BCC Relative
					{
						return Mnemonic.BCC;
					}
				case 0xB0:  // BCS Relative
					{
						return Mnemonic.BCS;
					}
				case 0xF0:  // BEQ Relative
					{
						return Mnemonic.BEQ;
					}
				case 0x24:  // BIT Zero Page	
				case 0x2C:  // BIT Absolute
					{
						return Mnemonic.BIT;
					}
				case 0x30:  // BMI Relative
					{
						return Mnemonic.BMI;
					}
				case 0xD0:  // BNE Relative
					{
						return Mnemonic.BNE;
					}
				case 0x10:  // BPL Relative
					{
						return Mnemonic.BPL;
					}
				case 0x00:  // BRK Implied
					{
						return Mnemonic.BRK;
					}
				case 0x50: // BVC Relative
					{
						return Mnemonic.BCV;
					}
				case 0x70: //BVS Relative
					{
						return Mnemonic.BVS;
					}
				case 0x18:  // CLC Implied
					{
						return Mnemonic.CLC;
					}
				case 0xD8:  // CLD Implied
					{
						return Mnemonic.CLD;
					}
				case 0x58:  // CLI Implied
					{
						return Mnemonic.CLI;
					}
				case 0xB8:  // CLV Implied
					{
						return Mnemonic.CLV;
					}
				case 0xC9:  // CMP Immediate
				case 0xC5:  // CMP ZeroPage
				case 0xD5:  // CMP Zero Page X
				case 0xCD:  // CMP Absolute
				case 0xDD:  // CMP Absolute X
				case 0xD9:  // CMP Absolute Y
				case 0xC1:  // CMP Indirect X
				case 0xD1:  // CMP Indirect Y
					{
						return Mnemonic.CMP;
					}
				case 0xE0:  // CPX Immediate
				case 0xE4:  // CPX ZeroPage
				case 0xEC:  // CPX Absolute
					{
						return Mnemonic.CPX;
					}
				case 0xC0:  // CPY Immediate
				case 0xC4:  // CPY ZeroPage
				case 0xCC:  // CPY Absolute
					{
						return Mnemonic.CPY;
					}
				case 0xC6:  // DEC Zero Page
				case 0xD6:  // DEC Zero Page X
				case 0xCE:  // DEC Absolute
				case 0xDE:  // DEC Absolute X
					{
						return Mnemonic.DEC;
					}
				case 0xCA:  // DEX Implied
					{
						return Mnemonic.DEX;
					}
				case 0x88:  // DEY Implied
					{
						return Mnemonic.DEY;
					}
				case 0x49:  // EOR Immediate
				case 0x45:  // EOR Zero Page
				case 0x55:  // EOR Zero Page X
				case 0x4D:  // EOR Absolute
				case 0x5D:  // EOR Absolute X
				case 0x59:  // EOR Absolute Y
				case 0x41:  // EOR Indrect X
				case 0x51:  // EOR Indirect Y
					{
						return Mnemonic.EOR;
					}
				case 0xE6:  // INC Zero Page
				case 0xF6:  // INC Zero Page X
				case 0xEE:  // INC Absolute
				case 0xFE:  // INC Absolute X
					{
						return Mnemonic.INC;
					}
				case 0xE8:  // INX Implied
					{
						return Mnemonic.INX;
					}
				case 0xC8:  // INY Implied
					{
						return Mnemonic.INY;
					}
				case 0x4C:  // JMP Absolute
				case 0x6C:  // JMP Indirect
					{
						return Mnemonic.JMP;
					}
				case 0x20:  // JSR Absolute
					{
						return Mnemonic.JSR;
					}
				case 0xA9:  // LDA Immediate
				case 0xA5:  // LDA Zero Page
				case 0xB5:  // LDA Zero Page X
				case 0xAD:  // LDA Absolute
				case 0xBD:  // LDA Absolute X
				case 0xB9:  // LDA Absolute Y
				case 0xA1:  // LDA Indirect X
				case 0xB1:  // LDA Indirect Y
					{
						return Mnemonic.LDA;
					}
				case 0xA2:  // LDX Immediate
				case 0xA6:  // LDX Zero Page
				case 0xB6:  // LDX Zero Page Y
				case 0xAE:  // LDX Absolute
				case 0xBE:  // LDX Absolute Y
					{
						return Mnemonic.LDX;
					}
				case 0xA0:  // LDY Immediate
				case 0xA4:  // LDY Zero Page
				case 0xB4:  // LDY Zero Page Y
				case 0xAC:  // LDY Absolute
				case 0xBC:  // LDY Absolute Y
					{
						return Mnemonic.LDY;
					}
				case 0x4A:  // LSR Accumulator
				case 0x46:  // LSR Zero Page
				case 0x56:  // LSR Zero Page X
				case 0x4E:  // LSR Absolute
				case 0x5E:  // LSR Absolute X
					{
						return Mnemonic.LSR;
					}
				case 0xEA:  // NOP Implied
					{
						return Mnemonic.NOP;
					}
				case 0x09:  // ORA Immediate
				case 0x05:  // ORA Zero Page
				case 0x15:  // ORA Zero Page X
				case 0x0D:  // ORA Absolute
				case 0x1D:  // ORA Absolute X
				case 0x19:  // ORA Absolute Y
				case 0x01:  // ORA Indirect X
				case 0x11:  // ORA Indirect Y
					{
						return Mnemonic.ORA;
					}
				case 0x48:  // PHA Implied
					{
						return Mnemonic.PHA;
					}
				case 0x08:  // PHP Implied
					{
						return Mnemonic.PHP;
					}
				case 0x68:  // PLA Implied
					{
						return Mnemonic.PLA;
					}
				case 0x28:  // PLP Implied
					{
						return Mnemonic.PLP;
					}
				case 0x2A:  // ROL Accumulator
				case 0x26:  // ROL Zero Page
				case 0x36:  // ROL Zero Page X
				case 0x2E:  // ROL Absolute
				case 0x3E:  // ROL Absolute X
					{
						return Mnemonic.ROL;
					}
				case 0x6A:  // ROR Accumulator
				case 0x66:  // ROR Zero Page
				case 0x76:  // ROR Zero Page X
				case 0x6E:  // ROR Absolute
				case 0x7E:  // ROR Absolute X
					{
						return Mnemonic.ROR;
					}
				case 0x40:  // RTI Implied
					{
						return Mnemonic.RTI;
					}
				case 0x60:  // RTS Implied
					{
						return Mnemonic.RTS;
					}
				case 0xE9:  // SBC Immediate
				case 0xE5:  // SBC Zero Page
				case 0xF5:  // SBC Zero Page X
				case 0xED:  // SBC Absolute
				case 0xFD:  // SBC Absolute X
				case 0xF9:  // SBC Absolute Y
				case 0xE1:  // SBC Indrect X
				case 0xF1:  // SBC Indirect Y
					{
						return Mnemonic.SBC;
					}
				case 0x38:  // SEC Implied
					{
						return Mnemonic.SEC;
					}
				case 0xF8:  // SED Implied
					{
						return Mnemonic.SED;
					}
				case 0x78:  // SEI Implied
					{
						return Mnemonic.SEI;
					}
				case 0x85:  // STA ZeroPage
				case 0x95:  // STA Zero Page X
				case 0x8D:  // STA Absolute
				case 0x9D:  // STA Absolute X
				case 0x99:  // STA Absolute Y
				case 0x81:  // STA Indirect X
				case 0x91:  // STA Indirect Y
					{
						return Mnemonic.STA;
					}
				case 0x86:  // STX Zero Page
				case 0x96:  // STX Zero Page Y
				case 0x8E:  // STX Absolute
					{
						return Mnemonic.STX;
					}
				case 0x84:  // STY Zero Page
				case 0x94:  // STY Zero Page X
				case 0x8C:  // STY Absolute
					{
						return Mnemonic.STY;
					}
				case 0xAA:  // TAX Implied
					{
						return Mnemonic.TAX;
					}
				case 0xA8:  // TAY Implied
					{
						return Mnemonic.TAY;
					}
				case 0xBA:  // TSX Implied
					{
						return Mnemonic.TSX;
					}
				case 0x8A:  // TXA Implied
					{
						return Mnemonic.TXA;
					}
				case 0x9A:  // TXS Implied
					{
						return Mnemonic.TXS;
					}
				case 0x98:  // TYA Implied
					{
						return Mnemonic.TYA;
					}
				default:
					{
						return Mnemonic.Invalid;
					}
			}
		}
	}
}
