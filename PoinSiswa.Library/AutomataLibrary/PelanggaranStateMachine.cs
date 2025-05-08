using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_Tahap1_KPL_kelompok3.Model;

namespace PoinSiswa.Library.Automata
{
    public class PelanggaranStateMachine
    {
        struct Transisi
        {
            public StatusPelanggaran prevState;
            public StatusPelanggaran nextState;
            public Trigger trigger;

            public Transisi(StatusPelanggaran prevState, StatusPelanggaran nextState, Trigger trigger)
            {
                if (!Enum.IsDefined(typeof(StatusPelanggaran), prevState) ||
                    !Enum.IsDefined(typeof(StatusPelanggaran), nextState) ||
                    !Enum.IsDefined(typeof(Trigger), trigger))
                {
                    throw new ArgumentException("Nilai status atau trigger tidak valid.");
                }

                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        private Transisi[] transitions =
        {
            new Transisi(StatusPelanggaran.DILAPORKAN, StatusPelanggaran.DISETUJUI, Trigger.SETUJUI),
            new Transisi(StatusPelanggaran.DISETUJUI, StatusPelanggaran.DIBERI_SANKSI, Trigger.BERI_SANKSI),
            new Transisi(StatusPelanggaran.DIBERI_SANKSI, StatusPelanggaran.SELESAI, Trigger.SELESAIKAN)
        };

        private StatusPelanggaran currentState = StatusPelanggaran.DILAPORKAN;

        public StatusPelanggaran CurrentState
        {
            get => currentState;
            private set
            {
                if (!Enum.IsDefined(typeof(StatusPelanggaran), value))
                {
                    throw new ArgumentException("Status tidak valid.");
                }
                currentState = value;
            }
        }

        public StatusPelanggaran GetNextState(StatusPelanggaran prevState, Trigger trigger)
        {
            if (!Enum.IsDefined(typeof(StatusPelanggaran), prevState) || !Enum.IsDefined(typeof(Trigger), trigger))
            {
                throw new ArgumentException("PrevState atau trigger tidak valid.");
            }

            foreach (var t in transitions)
            {
                if (t.prevState == prevState && t.trigger == trigger)
                {
                    return t.nextState;
                }
            }

            throw new InvalidOperationException($"Tidak ada transisi yang cocok untuk {prevState} dengan trigger {trigger}");
        }

        public void Activate(Trigger trigger)
        {
            CurrentState = GetNextState(CurrentState, trigger);
        }
    }
}
