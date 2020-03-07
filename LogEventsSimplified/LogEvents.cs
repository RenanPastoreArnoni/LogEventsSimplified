using System;
using System.Diagnostics;

namespace LogEventsSimplified {
    public static class LogEvents {
        const string MyLog = "Mylog";
        const string MySource = "Mysource";

        public static void logSimpleStringEvent(string LogMessage, EventLogEntryType logEntryType, int EventID) {

            try {

                if (!EventLog.SourceExists(MySource)) {

                    EventLog.CreateEventSource(MySource, MyLog);
                }

                using (EventLog log = new EventLog()) {

                    log.Source = MySource;
                    log.Log = MyLog;
                    log.WriteEntry(LogMessage, logEntryType, EventID);
                }

            } catch (Exception) {

                throw;
            }
        }

        public static void logSimpleStringCustomSource(string LogMessage, EventLogEntryType logEntryType, int EventID, string CSource, string CLog) {
            try {

                if (!EventLog.SourceExists(CSource)) {

                    EventLog.CreateEventSource(CSource, CLog);
                }

                using (EventLog log = new EventLog()) {

                    log.Source = MySource;
                    log.Log = MyLog;
                    log.WriteEntry(LogMessage, logEntryType, EventID);
                }

            } catch (Exception) {

                throw;
            }
        }

    }
}
