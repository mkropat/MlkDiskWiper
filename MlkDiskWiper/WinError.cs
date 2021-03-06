namespace WinApiTypes
{
    public enum WinError : long
    {
        /// <summary>The operation completed successfully.</summary>
        ERROR_SUCCESS                    = 0L,
        /// <summary>Incorrect function.</summary>
        ERROR_INVALID_FUNCTION           = 1L,    // dderror
        /// <summary>The system cannot find the file specified.</summary>
        ERROR_FILE_NOT_FOUND             = 2L,
        /// <summary>The system cannot find the path specified.</summary>
        ERROR_PATH_NOT_FOUND             = 3L,
        /// <summary>The system cannot open the file.</summary>
        ERROR_TOO_MANY_OPEN_FILES        = 4L,
        /// <summary>Access is denied.</summary>
        ERROR_ACCESS_DENIED              = 5L,
        /// <summary>The handle is invalid.</summary>
        ERROR_INVALID_HANDLE             = 6L,
        /// <summary>The storage control blocks were destroyed.</summary>
        ERROR_ARENA_TRASHED              = 7L,
        /// <summary>Not enough storage is available to process this command.</summary>
        ERROR_NOT_ENOUGH_MEMORY          = 8L,    // dderror
        /// <summary>The storage control block address is invalid.</summary>
        ERROR_INVALID_BLOCK              = 9L,
        /// <summary>The environment is incorrect.</summary>
        ERROR_BAD_ENVIRONMENT            = 10L,
        /// <summary>An attempt was made to load a program with an incorrect format.</summary>
        ERROR_BAD_FORMAT                 = 11L,
        /// <summary>The access code is invalid.</summary>
        ERROR_INVALID_ACCESS             = 12L,
        /// <summary>The data is invalid.</summary>
        ERROR_INVALID_DATA               = 13L,
        /// <summary>Not enough storage is available to complete this operation.</summary>
        ERROR_OUTOFMEMORY                = 14L,
        /// <summary>The system cannot find the drive specified.</summary>
        ERROR_INVALID_DRIVE              = 15L,
        /// <summary>The directory cannot be removed.</summary>
        ERROR_CURRENT_DIRECTORY          = 16L,
        /// <summary>The system cannot move the file to a different disk drive.</summary>
        ERROR_NOT_SAME_DEVICE            = 17L,
        /// <summary>There are no more files.</summary>
        ERROR_NO_MORE_FILES              = 18L,
        /// <summary>The media is write protected.</summary>
        ERROR_WRITE_PROTECT              = 19L,
        /// <summary>The system cannot find the device specified.</summary>
        ERROR_BAD_UNIT                   = 20L,
        /// <summary>The device is not ready.</summary>
        ERROR_NOT_READY                  = 21L,
        /// <summary>The device does not recognize the command.</summary>
        ERROR_BAD_COMMAND                = 22L,
        /// <summary>Data error (cyclic redundancy check).</summary>
        ERROR_CRC                        = 23L,
        /// <summary>The program issued a command but the command length is incorrect.</summary>
        ERROR_BAD_LENGTH                 = 24L,
        /// <summary>The drive cannot locate a specific area or track on the disk.</summary>
        ERROR_SEEK                       = 25L,
        /// <summary>The specified disk or diskette cannot be accessed.</summary>
        ERROR_NOT_DOS_DISK               = 26L,
        /// <summary>The drive cannot find the sector requested.</summary>
        ERROR_SECTOR_NOT_FOUND           = 27L,
        /// <summary>The printer is out of paper.</summary>
        ERROR_OUT_OF_PAPER               = 28L,
        /// <summary>The system cannot write to the specified device.</summary>
        ERROR_WRITE_FAULT                = 29L,
        /// <summary>The system cannot read from the specified device.</summary>
        ERROR_READ_FAULT                 = 30L,
        /// <summary>A device attached to the system is not functioning.</summary>
        ERROR_GEN_FAILURE                = 31L,
        /// <summary>The process cannot access the file because it is being used by another process.</summary>
        ERROR_SHARING_VIOLATION          = 32L,
        /// <summary>The process cannot access the file because another process has locked a portion of the file.</summary>
        ERROR_LOCK_VIOLATION             = 33L,
        /// <summary>The wrong diskette is in the drive. Insert %2 (Volume Serial Number: %3) into drive %1.</summary>
        ERROR_WRONG_DISK                 = 34L,
        /// <summary>Too many files opened for sharing.</summary>
        ERROR_SHARING_BUFFER_EXCEEDED    = 36L,
        /// <summary>Reached the end of the file.</summary>
        ERROR_HANDLE_EOF                 = 38L,
        /// <summary>The disk is full.</summary>
        ERROR_HANDLE_DISK_FULL           = 39L,
        /// <summary>The request is not supported.</summary>
        ERROR_NOT_SUPPORTED              = 50L,
        /// <summary>Windows cannot find the network path. Verify that the network path is correct and the destination computer is not busy or turned off. If Windows still cannot find the network path, contact your network administrator.</summary>
        ERROR_REM_NOT_LIST               = 51L,
        /// <summary>You were not connected because a duplicate name exists on the network. If joining a domain, go to System in Control Panel to change the computer name and try again. If joining a workgroup, choose another workgroup name.</summary>
        ERROR_DUP_NAME                   = 52L,
        /// <summary>The network path was not found.</summary>
        ERROR_BAD_NETPATH                = 53L,
        /// <summary>The network is busy.</summary>
        ERROR_NETWORK_BUSY               = 54L,
        /// <summary>The specified network resource or device is no longer available.</summary>
        ERROR_DEV_NOT_EXIST              = 55L,    // dderror
        /// <summary>The network BIOS command limit has been reached.</summary>
        ERROR_TOO_MANY_CMDS              = 56L,
        /// <summary>A network adapter hardware error occurred.</summary>
        ERROR_ADAP_HDW_ERR               = 57L,
        /// <summary>The specified server cannot perform the requested operation.</summary>
        ERROR_BAD_NET_RESP               = 58L,
        /// <summary>An unexpected network error occurred.</summary>
        ERROR_UNEXP_NET_ERR              = 59L,
        /// <summary>The remote adapter is not compatible.</summary>
        ERROR_BAD_REM_ADAP               = 60L,
        /// <summary>The printer queue is full.</summary>
        ERROR_PRINTQ_FULL                = 61L,
        /// <summary>Space to store the file waiting to be printed is not available on the server.</summary>
        ERROR_NO_SPOOL_SPACE             = 62L,
        /// <summary>Your file waiting to be printed was deleted.</summary>
        ERROR_PRINT_CANCELLED            = 63L,
        /// <summary>The specified network name is no longer available.</summary>
        ERROR_NETNAME_DELETED            = 64L,
        /// <summary>Network access is denied.</summary>
        ERROR_NETWORK_ACCESS_DENIED      = 65L,
        /// <summary>The network resource type is not correct.</summary>
        ERROR_BAD_DEV_TYPE               = 66L,
        /// <summary>The network name cannot be found.</summary>
        ERROR_BAD_NET_NAME               = 67L,
        /// <summary>The name limit for the local computer network adapter card was exceeded.</summary>
        ERROR_TOO_MANY_NAMES             = 68L,
        /// <summary>The network BIOS session limit was exceeded.</summary>
        ERROR_TOO_MANY_SESS              = 69L,
        /// <summary>The remote server has been paused or is in the process of being started.</summary>
        ERROR_SHARING_PAUSED             = 70L,
        /// <summary>No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.</summary>
        ERROR_REQ_NOT_ACCEP              = 71L,
        /// <summary>The specified printer or disk device has been paused.</summary>
        ERROR_REDIR_PAUSED               = 72L,
        /// <summary>The file exists.</summary>
        ERROR_FILE_EXISTS                = 80L,
        /// <summary>The directory or file cannot be created.</summary>
        ERROR_CANNOT_MAKE                = 82L,
        /// <summary>Fail on INT 24.</summary>
        ERROR_FAIL_I24                   = 83L,
        /// <summary>Storage to process this request is not available.</summary>
        ERROR_OUT_OF_STRUCTURES          = 84L,
        /// <summary>The local device name is already in use.</summary>
        ERROR_ALREADY_ASSIGNED           = 85L,
        /// <summary>The specified network password is not correct.</summary>
        ERROR_INVALID_PASSWORD           = 86L,
        /// <summary>The parameter is incorrect.</summary>
        ERROR_INVALID_PARAMETER          = 87L,    // dderror
        /// <summary>A write fault occurred on the network.</summary>
        ERROR_NET_WRITE_FAULT            = 88L,
        /// <summary>The system cannot start another process at this time.</summary>
        ERROR_NO_PROC_SLOTS              = 89L,
        /// <summary>Cannot create another system semaphore.</summary>
        ERROR_TOO_MANY_SEMAPHORES        = 100L,
        /// <summary>The exclusive semaphore is owned by another process.</summary>
        ERROR_EXCL_SEM_ALREADY_OWNED     = 101L,
        /// <summary>The semaphore is set and cannot be closed.</summary>
        ERROR_SEM_IS_SET                 = 102L,
        /// <summary>The semaphore cannot be set again.</summary>
        ERROR_TOO_MANY_SEM_REQUESTS      = 103L,
        /// <summary>Cannot request exclusive semaphores at interrupt time.</summary>
        ERROR_INVALID_AT_INTERRUPT_TIME  = 104L,
        /// <summary>The previous ownership of this semaphore has ended.</summary>
        ERROR_SEM_OWNER_DIED             = 105L,
        /// <summary>Insert the diskette for drive %1.</summary>
        ERROR_SEM_USER_LIMIT             = 106L,
        /// <summary>The program stopped because an alternate diskette was not inserted.</summary>
        ERROR_DISK_CHANGE                = 107L,
        /// <summary>The disk is in use or locked by another process.</summary>
        ERROR_DRIVE_LOCKED               = 108L,
        /// <summary>The pipe has been ended.</summary>
        ERROR_BROKEN_PIPE                = 109L,
        /// <summary>The system cannot open the device or file specified.</summary>
        ERROR_OPEN_FAILED                = 110L,
        /// <summary>The file name is too long.</summary>
        ERROR_BUFFER_OVERFLOW            = 111L,
        /// <summary>There is not enough space on the disk.</summary>
        ERROR_DISK_FULL                  = 112L,
        /// <summary>No more internal file identifiers available.</summary>
        ERROR_NO_MORE_SEARCH_HANDLES     = 113L,
        /// <summary>The target internal file identifier is incorrect.</summary>
        ERROR_INVALID_TARGET_HANDLE      = 114L,
        /// <summary>The IOCTL call made by the application program is not correct.</summary>
        ERROR_INVALID_CATEGORY           = 117L,
        /// <summary>The verify-on-write switch parameter value is not correct.</summary>
        ERROR_INVALID_VERIFY_SWITCH      = 118L,
        /// <summary>The system does not support the command requested.</summary>
        ERROR_BAD_DRIVER_LEVEL           = 119L,
        /// <summary>This function is not supported on this system.</summary>
        ERROR_CALL_NOT_IMPLEMENTED       = 120L,
        /// <summary>The semaphore timeout period has expired.</summary>
        ERROR_SEM_TIMEOUT                = 121L,
        /// <summary>The data area passed to a system call is too small.</summary>
        ERROR_INSUFFICIENT_BUFFER        = 122L,    // dderror
        /// <summary>The filename, directory name, or volume label syntax is incorrect.</summary>
        ERROR_INVALID_NAME               = 123L,    // dderror
        /// <summary>The system call level is not correct.</summary>
        ERROR_INVALID_LEVEL              = 124L,
        /// <summary>The disk has no volume label.</summary>
        ERROR_NO_VOLUME_LABEL            = 125L,
        /// <summary>The specified module could not be found.</summary>
        ERROR_MOD_NOT_FOUND              = 126L,
        /// <summary>The specified procedure could not be found.</summary>
        ERROR_PROC_NOT_FOUND             = 127L,
        /// <summary>There are no child processes to wait for.</summary>
        ERROR_WAIT_NO_CHILDREN           = 128L,
        /// <summary>The %1 application cannot be run in Win32 mode.</summary>
        ERROR_CHILD_NOT_COMPLETE         = 129L,
        /// <summary>Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.</summary>
        ERROR_DIRECT_ACCESS_HANDLE       = 130L,
        /// <summary>An attempt was made to move the file pointer before the beginning of the file.</summary>
        ERROR_NEGATIVE_SEEK              = 131L,
        /// <summary>The file pointer cannot be set on the specified device or file.</summary>
        ERROR_SEEK_ON_DEVICE             = 132L,
        /// <summary>A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.</summary>
        ERROR_IS_JOIN_TARGET             = 133L,
        /// <summary>An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.</summary>
        ERROR_IS_JOINED                  = 134L,
        /// <summary>An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.</summary>
        ERROR_IS_SUBSTED                 = 135L,
        /// <summary>The system tried to delete the JOIN of a drive that is not joined.</summary>
        ERROR_NOT_JOINED                 = 136L,
        /// <summary>The system tried to delete the substitution of a drive that is not substituted.</summary>
        ERROR_NOT_SUBSTED                = 137L,
        /// <summary>The system tried to join a drive to a directory on a joined drive.</summary>
        ERROR_JOIN_TO_JOIN               = 138L,
        /// <summary>The system tried to substitute a drive to a directory on a substituted drive.</summary>
        ERROR_SUBST_TO_SUBST             = 139L,
        /// <summary>The system tried to join a drive to a directory on a substituted drive.</summary>
        ERROR_JOIN_TO_SUBST              = 140L,
        /// <summary>The system tried to SUBST a drive to a directory on a joined drive.</summary>
        ERROR_SUBST_TO_JOIN              = 141L,
        /// <summary>The system cannot perform a JOIN or SUBST at this time.</summary>
        ERROR_BUSY_DRIVE                 = 142L,
        /// <summary>The system cannot join or substitute a drive to or for a directory on the same drive.</summary>
        ERROR_SAME_DRIVE                 = 143L,
        /// <summary>The directory is not a subdirectory of the root directory.</summary>
        ERROR_DIR_NOT_ROOT               = 144L,
        /// <summary>The directory is not empty.</summary>
        ERROR_DIR_NOT_EMPTY              = 145L,
        /// <summary>The path specified is being used in a substitute.</summary>
        ERROR_IS_SUBST_PATH              = 146L,
        /// <summary>Not enough resources are available to process this command.</summary>
        ERROR_IS_JOIN_PATH               = 147L,
        /// <summary>The path specified cannot be used at this time.</summary>
        ERROR_PATH_BUSY                  = 148L,
        /// <summary>An attempt was made to join or substitute a drive for which a directory on the drive is the target of a previous substitute.</summary>
        ERROR_IS_SUBST_TARGET            = 149L,
        /// <summary>System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.</summary>
        ERROR_SYSTEM_TRACE               = 150L,
        /// <summary>The number of specified semaphore events for DosMuxSemWait is not correct.</summary>
        ERROR_INVALID_EVENT_COUNT        = 151L,
        /// <summary>DosMuxSemWait did not execute; too many semaphores are already set.</summary>
        ERROR_TOO_MANY_MUXWAITERS        = 152L,
        /// <summary>The DosMuxSemWait list is not correct.</summary>
        ERROR_INVALID_LIST_FORMAT        = 153L,
        /// <summary>The volume label you entered exceeds the label character limit of the target file system.</summary>
        ERROR_LABEL_TOO_LONG             = 154L,
        /// <summary>Cannot create another thread.</summary>
        ERROR_TOO_MANY_TCBS              = 155L,
        /// <summary>The recipient process has refused the signal.</summary>
        ERROR_SIGNAL_REFUSED             = 156L,
        /// <summary>The segment is already discarded and cannot be locked.</summary>
        ERROR_DISCARDED                  = 157L,
        /// <summary>The segment is already unlocked.</summary>
        ERROR_NOT_LOCKED                 = 158L,
        /// <summary>The address for the thread ID is not correct.</summary>
        ERROR_BAD_THREADID_ADDR          = 159L,
        /// <summary>One or more arguments are not correct.</summary>
        ERROR_BAD_ARGUMENTS              = 160L,
        /// <summary>The specified path is invalid.</summary>
        ERROR_BAD_PATHNAME               = 161L,
        /// <summary>A signal is already pending.</summary>
        ERROR_SIGNAL_PENDING             = 162L,
        /// <summary>No more threads can be created in the system.</summary>
        ERROR_MAX_THRDS_REACHED          = 164L,
        /// <summary>Unable to lock a region of a file.</summary>
        ERROR_LOCK_FAILED                = 167L,
        /// <summary>The requested resource is in use.</summary>
        ERROR_BUSY                       = 170L,    // dderror
        /// <summary>Device's command support detection is in progress.</summary>
        ERROR_DEVICE_SUPPORT_IN_PROGRESS = 171L,
        /// <summary>A lock request was not outstanding for the supplied cancel region.</summary>
        ERROR_CANCEL_VIOLATION           = 173L,
        /// <summary>The file system does not support atomic changes to the lock type.</summary>
        ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174L,
        /// <summary>The system detected a segment number that was not correct.</summary>
        ERROR_INVALID_SEGMENT_NUMBER     = 180L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_ORDINAL            = 182L,
        /// <summary>Cannot create a file when that file already exists.</summary>
        ERROR_ALREADY_EXISTS             = 183L,
        /// <summary>The flag passed is not correct.</summary>
        ERROR_INVALID_FLAG_NUMBER        = 186L,
        /// <summary>The specified system semaphore name was not found.</summary>
        ERROR_SEM_NOT_FOUND              = 187L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_STARTING_CODESEG   = 188L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_STACKSEG           = 189L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_MODULETYPE         = 190L,
        /// <summary>Cannot run %1 in Win32 mode.</summary>
        ERROR_INVALID_EXE_SIGNATURE      = 191L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_EXE_MARKED_INVALID         = 192L,
        /// <summary>%1 is not a valid Win32 application.</summary>
        ERROR_BAD_EXE_FORMAT             = 193L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_ITERATED_DATA_EXCEEDS_64k  = 194L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_MINALLOCSIZE       = 195L,
        /// <summary>The operating system cannot run this application program.</summary>
        ERROR_DYNLINK_FROM_INVALID_RING  = 196L,
        /// <summary>The operating system is not presently configured to run this application.</summary>
        ERROR_IOPL_NOT_ENABLED           = 197L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_SEGDPL             = 198L,
        /// <summary>The operating system cannot run this application program.</summary>
        ERROR_AUTODATASEG_EXCEEDS_64k    = 199L,
        /// <summary>The code segment cannot be greater than or equal to 64K.</summary>
        ERROR_RING2SEG_MUST_BE_MOVABLE   = 200L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_RELOC_CHAIN_XEEDS_SEGLIM   = 201L,
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INFLOOP_IN_RELOC_CHAIN     = 202L,
        /// <summary>The system could not find the environment option that was entered.</summary>
        ERROR_ENVVAR_NOT_FOUND           = 203L,
        /// <summary>No process in the command subtree has a signal handler.</summary>
        ERROR_NO_SIGNAL_SENT             = 205L,
        /// <summary>The filename or extension is too long.</summary>
        ERROR_FILENAME_EXCED_RANGE       = 206L,
        /// <summary>The ring 2 stack is in use.</summary>
        ERROR_RING2_STACK_IN_USE         = 207L,
        /// <summary>The global filename characters, * or ?, are entered incorrectly or too many global filename characters are specified.</summary>
        ERROR_META_EXPANSION_TOO_LONG    = 208L,
        /// <summary>The signal being posted is not correct.</summary>
        ERROR_INVALID_SIGNAL_NUMBER      = 209L,
        /// <summary>The signal handler cannot be set.</summary>
        ERROR_THREAD_1_INACTIVE          = 210L,
        /// <summary>The segment is locked and cannot be reallocated.</summary>
        ERROR_LOCKED                     = 212L,
        /// <summary>Too many dynamic-link modules are attached to this program or dynamic-link module.</summary>
        ERROR_TOO_MANY_MODULES           = 214L,
        /// <summary>Cannot nest calls to LoadModule.</summary>
        ERROR_NESTING_NOT_ALLOWED        = 215L,
        /// <summary>This version of %1 is not compatible with the version of Windows you're running. Check your computer's system information and then contact the software publisher.</summary>
        ERROR_EXE_MACHINE_TYPE_MISMATCH  = 216L,
        /// <summary>The image file %1 is signed, unable to modify.</summary>
        ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217L,
        /// <summary>The image file %1 is strong signed, unable to modify.</summary>
        ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218L,
        /// <summary>This file is checked out or locked for editing by another user.</summary>
        ERROR_FILE_CHECKED_OUT           = 220L,
        /// <summary>The file must be checked out before saving changes.</summary>
        ERROR_CHECKOUT_REQUIRED          = 221L,
        /// <summary>The file type being saved or retrieved has been blocked.</summary>
        ERROR_BAD_FILE_TYPE              = 222L,
        /// <summary>The file size exceeds the limit allowed and cannot be saved.</summary>
        ERROR_FILE_TOO_LARGE             = 223L,
        /// <summary>Access Denied. Before opening files in this location, you must first add the web site to your trusted sites list, browse to the web site, and select the option to login automatically.</summary>
        ERROR_FORMS_AUTH_REQUIRED        = 224L,
        /// <summary>Operation did not complete successfully because the file contains a virus or potentially unwanted software.</summary>
        ERROR_VIRUS_INFECTED             = 225L,
        /// <summary>This file contains a virus or potentially unwanted software and cannot be opened. Due to the nature of this virus or potentially unwanted software, the file has been removed from this location.</summary>
        ERROR_VIRUS_DELETED              = 226L,
        /// <summary>The pipe is local.</summary>
        ERROR_PIPE_LOCAL                 = 229L,
        /// <summary>The pipe state is invalid.</summary>
        ERROR_BAD_PIPE                   = 230L,
        /// <summary>All pipe instances are busy.</summary>
        ERROR_PIPE_BUSY                  = 231L,
        /// <summary>The pipe is being closed.</summary>
        ERROR_NO_DATA                    = 232L,
        /// <summary>No process is on the other end of the pipe.</summary>
        ERROR_PIPE_NOT_CONNECTED         = 233L,
        /// <summary>More data is available.</summary>
        ERROR_MORE_DATA                  = 234L,    // dderror
        /// <summary>The action requested resulted in no work being done. Error-style clean-up has been performed.</summary>
        ERROR_NO_WORK_DONE               = 235L,
        /// <summary>The session was canceled.</summary>
        ERROR_VC_DISCONNECTED            = 240L,
        /// <summary>The specified extended attribute name was invalid.</summary>
        ERROR_INVALID_EA_NAME            = 254L,
        /// <summary>The extended attributes are inconsistent.</summary>
        ERROR_EA_LIST_INCONSISTENT       = 255L,
        /// <summary>The wait operation timed out.</summary>
        WAIT_TIMEOUT                     = 258L,    // dderror
        /// <summary>No more data is available.</summary>
        ERROR_NO_MORE_ITEMS              = 259L,
        /// <summary>The copy functions cannot be used.</summary>
        ERROR_CANNOT_COPY                = 266L,
        /// <summary>The directory name is invalid.</summary>
        ERROR_DIRECTORY                  = 267L,
        /// <summary>The extended attributes did not fit in the buffer.</summary>
        ERROR_EAS_DIDNT_FIT              = 275L,
        /// <summary>The extended attribute file on the mounted file system is corrupt.</summary>
        ERROR_EA_FILE_CORRUPT            = 276L,
        /// <summary>The extended attribute table file is full.</summary>
        ERROR_EA_TABLE_FULL              = 277L,
        /// <summary>The specified extended attribute handle is invalid.</summary>
        ERROR_INVALID_EA_HANDLE          = 278L,
        /// <summary>The mounted file system does not support extended attributes.</summary>
        ERROR_EAS_NOT_SUPPORTED          = 282L,
        /// <summary>Attempt to release mutex not owned by caller.</summary>
        ERROR_NOT_OWNER                  = 288L,
        /// <summary>Too many posts were made to a semaphore.</summary>
        ERROR_TOO_MANY_POSTS             = 298L,
        /// <summary>Only part of a ReadProcessMemory or WriteProcessMemory request was completed.</summary>
        ERROR_PARTIAL_COPY               = 299L,
        /// <summary>The oplock request is denied.</summary>
        ERROR_OPLOCK_NOT_GRANTED         = 300L,
        /// <summary>An invalid oplock acknowledgment was received by the system.</summary>
        ERROR_INVALID_OPLOCK_PROTOCOL    = 301L,
        /// <summary>The volume is too fragmented to complete this operation.</summary>
        ERROR_DISK_TOO_FRAGMENTED        = 302L,
        /// <summary>The file cannot be opened because it is in the process of being deleted.</summary>
        ERROR_DELETE_PENDING             = 303L,
        /// <summary>Short name settings may not be changed on this volume due to the global registry setting.</summary>
        ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 304L,
        /// <summary>Short names are not enabled on this volume.</summary>
        ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 305L,
        /// <summary>The security stream for the given volume is in an inconsistent state. Please run CHKDSK on the volume.</summary>
        ERROR_SECURITY_STREAM_IS_INCONSISTENT = 306L,
        /// <summary>A requested file lock operation cannot be processed due to an invalid byte range.</summary>
        ERROR_INVALID_LOCK_RANGE         = 307L,
        /// <summary>The subsystem needed to support the image type is not present.</summary>
        ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 308L,
        /// <summary>The specified file already has a notification GUID associated with it.</summary>
        ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 309L,
        /// <summary>An invalid exception handler routine has been detected.</summary>
        ERROR_INVALID_EXCEPTION_HANDLER  = 310L,
        /// <summary>Duplicate privileges were specified for the token.</summary>
        ERROR_DUPLICATE_PRIVILEGES       = 311L,
        /// <summary>No ranges for the specified operation were able to be processed.</summary>
        ERROR_NO_RANGES_PROCESSED        = 312L,
        /// <summary>Operation is not allowed on a file system internal file.</summary>
        ERROR_NOT_ALLOWED_ON_SYSTEM_FILE = 313L,
        /// <summary>The physical resources of this disk have been exhausted.</summary>
        ERROR_DISK_RESOURCES_EXHAUSTED   = 314L,
        /// <summary>The token representing the data is invalid.</summary>
        ERROR_INVALID_TOKEN              = 315L,
        /// <summary>The device does not support the command feature.</summary>
        ERROR_DEVICE_FEATURE_NOT_SUPPORTED = 316L,
        /// <summary>The system cannot find message text for message number 0x%1 in the message file for %2.</summary>
        ERROR_MR_MID_NOT_FOUND           = 317L,
        /// <summary>The scope specified was not found.</summary>
        ERROR_SCOPE_NOT_FOUND            = 318L,
        /// <summary>The Central Access Policy specified is not defined on the target machine.</summary>
        ERROR_UNDEFINED_SCOPE            = 319L,
        /// <summary>The Central Access Policy obtained from Active Directory is invalid.</summary>
        ERROR_INVALID_CAP                = 320L,
        /// <summary>The device is unreachable.</summary>
        ERROR_DEVICE_UNREACHABLE         = 321L,
        /// <summary>The target device has insufficient resources to complete the operation.</summary>
        ERROR_DEVICE_NO_RESOURCES        = 322L,
        /// <summary>A data integrity checksum error occurred. Data in the file stream is corrupt.</summary>
        ERROR_DATA_CHECKSUM_ERROR        = 323L,
        /// <summary>An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in the same operation.</summary>
        ERROR_INTERMIXED_KERNEL_EA_OPERATION = 324L,
        /// <summary>Device does not support file-level TRIM.</summary>
        ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED = 326L,
        /// <summary>The command specified a data offset that does not align to the device's granularity/alignment.</summary>
        ERROR_OFFSET_ALIGNMENT_VIOLATION = 327L,
        /// <summary>The command specified an invalid field in its parameter list.</summary>
        ERROR_INVALID_FIELD_IN_PARAMETER_LIST = 328L,
        /// <summary>An operation is currently in progress with the device.</summary>
        ERROR_OPERATION_IN_PROGRESS      = 329L,
        /// <summary>An attempt was made to send down the command via an invalid path to the target device.</summary>
        ERROR_BAD_DEVICE_PATH            = 330L,
        /// <summary>The command specified a number of descriptors that exceeded the maximum supported by the device.</summary>
        ERROR_TOO_MANY_DESCRIPTORS       = 331L,
        /// <summary>Scrub is disabled on the specified file.</summary>
        ERROR_SCRUB_DATA_DISABLED        = 332L,
        /// <summary>The storage device does not provide redundancy.</summary>
        ERROR_NOT_REDUNDANT_STORAGE      = 333L,
        /// <summary>An operation is not supported on a resident file.</summary>
        ERROR_RESIDENT_FILE_NOT_SUPPORTED = 334L,
        /// <summary>An operation is not supported on a compressed file.</summary>
        ERROR_COMPRESSED_FILE_NOT_SUPPORTED = 335L,
        /// <summary>An operation is not supported on a directory.</summary>
        ERROR_DIRECTORY_NOT_SUPPORTED    = 336L,
        /// <summary>The specified copy of the requested data could not be read.</summary>
        ERROR_NOT_READ_FROM_COPY         = 337L,
        /// <summary>The specified data could not be written to any of the copies.</summary>
        ERROR_FT_WRITE_FAILURE           = 338L,
        /// <summary>One or more copies of data on this device may be out of sync. No writes may be performed until a data integrity scan is completed.</summary>
        ERROR_FT_DI_SCAN_REQUIRED        = 339L,
        /// <summary>The supplied kernel information version is invalid.</summary>
        ERROR_INVALID_KERNEL_INFO_VERSION = 340L,
        /// <summary>The supplied PEP information version is invalid.</summary>
        ERROR_INVALID_PEP_INFO_VERSION   = 341L,
        /// <summary>This object is not externally backed by any provider.</summary>
        ERROR_OBJECT_NOT_EXTERNALLY_BACKED = 342L,
        /// <summary>The external backing provider is not recognized.</summary>
        ERROR_EXTERNAL_BACKING_PROVIDER_UNKNOWN = 343L,
        /// <summary>Compressing this object would not save space.</summary>
        ERROR_COMPRESSION_NOT_BENEFICIAL = 344L,
        /// <summary>The request failed due to a storage topology ID mismatch.</summary>
        ERROR_STORAGE_TOPOLOGY_ID_MISMATCH = 345L,
        /// <summary>The operation was blocked by parental controls.</summary>
        ERROR_BLOCKED_BY_PARENTAL_CONTROLS = 346L,
        /// <summary>A file system block being referenced has already reached the maximum reference count and can't be referenced any further.</summary>
        ERROR_BLOCK_TOO_MANY_REFERENCES  = 347L,
        /// <summary>The requested operation failed because the file stream is marked to disallow writes.</summary>
        ERROR_MARKED_TO_DISALLOW_WRITES  = 348L,
        /// <summary>The requested operation failed with an architecture-specific failure code.</summary>
        ERROR_ENCLAVE_FAILURE            = 349L,
        /// <summary>No action was taken as a system reboot is required.</summary>
        ERROR_FAIL_NOACTION_REBOOT       = 350L,
        /// <summary>The shutdown operation failed.</summary>
        ERROR_FAIL_SHUTDOWN              = 351L,
        /// <summary>The restart operation failed.</summary>
        ERROR_FAIL_RESTART               = 352L,
        /// <summary>The maximum number of sessions has been reached.</summary>
        ERROR_MAX_SESSIONS_REACHED       = 353L,
        /// <summary>Enterprise Data Protection policy does not allow access to this network resource.</summary>
        ERROR_NETWORK_ACCESS_DENIED_EDP  = 354L,
        /// <summary>The device hint name buffer is too small to receive the remaining name.</summary>
        ERROR_DEVICE_HINT_NAME_BUFFER_TOO_SMALL = 355L,
        /// <summary>The requested operation was blocked by Enterprise Data Protection policy. For more information, contact your system administrator.</summary>
        ERROR_EDP_POLICY_DENIES_OPERATION = 356L,
        /// <summary>The requested operation cannot be performed because hardware or software configuration of the device does not comply with Enterprise Data Protection under Lock policy. Please, verify that user PIN has been created. For more information, contact your system administrator.</summary>
        ERROR_EDP_DPL_POLICY_CANT_BE_SATISFIED = 357L,
        /// <summary>The Cloud File provider is unknown.</summary>
        ERROR_CLOUD_FILE_PROVIDER_UNKNOWN = 358L,
        /// <summary>The device is in maintenance mode.</summary>
        ERROR_DEVICE_IN_MAINTENANCE      = 359L,
        /// <summary>This operation is not supported on a DAX volume.</summary>
        ERROR_NOT_SUPPORTED_ON_DAX       = 360L,
        /// <summary>The volume has active DAX mappings.</summary>
        ERROR_DAX_MAPPING_EXISTS         = 361L,
        /// <summary>The Cloud File provider is not running.</summary>
        ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING = 362L,
        /// <summary>The Cloud File metadata is corrupt and unreadable.</summary>
        ERROR_CLOUD_FILE_METADATA_CORRUPT = 363L,
        /// <summary>The operation could not be completed because the Cloud File metadata has is too large.</summary>
        ERROR_CLOUD_FILE_METADATA_TOO_LARGE = 364L,
        /// <summary>The operation could not be completed because the Cloud File property blob is too large.</summary>
        ERROR_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE = 365L,
        /// <summary>The Cloud File property blob is possibly corrupt. The on-disk checksum does not match the computed checksum.</summary>
        ERROR_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH = 366L,
        /// <summary>The process creation has been blocked.</summary>
        ERROR_CHILD_PROCESS_BLOCKED      = 367L,
        /// <summary>The storage device has lost data or persistence.</summary>
        ERROR_STORAGE_LOST_DATA_PERSISTENCE = 368L,
        /// <summary>The thread is already in background processing mode.</summary>
        ERROR_THREAD_MODE_ALREADY_BACKGROUND = 400L,
        /// <summary>The thread is not in background processing mode.</summary>
        ERROR_THREAD_MODE_NOT_BACKGROUND = 401L,
        /// <summary>The process is already in background processing mode.</summary>
        ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 402L,
        /// <summary>The process is not in background processing mode.</summary>
        ERROR_PROCESS_MODE_NOT_BACKGROUND = 403L,
        /// <summary>Neither developer unlocked mode nor side loading mode is enabled on the device.</summary>
        ERROR_CAPAUTHZ_NOT_DEVUNLOCKED   = 450L,
        /// <summary>Can not change application type during upgrade or re-provision.</summary>
        ERROR_CAPAUTHZ_CHANGE_TYPE       = 451L,
        /// <summary>The application has not been provisioned.</summary>
        ERROR_CAPAUTHZ_NOT_PROVISIONED   = 452L,
        /// <summary>The requested capability can not be authorized for this application.</summary>
        ERROR_CAPAUTHZ_NOT_AUTHORIZED    = 453L,
        /// <summary>There is no capability authorization policy on the device.</summary>
        ERROR_CAPAUTHZ_NO_POLICY         = 454L,
        /// <summary>The capability authorization database has been corrupted.</summary>
        ERROR_CAPAUTHZ_DB_CORRUPTED      = 455L,
        /// <summary>The request failed due to a fatal device hardware error.</summary>
        ERROR_DEVICE_HARDWARE_ERROR      = 483L,
        /// <summary>Attempt to access invalid address.</summary>
        ERROR_INVALID_ADDRESS            = 487L,
        /// <summary>User profile cannot be loaded.</summary>
        ERROR_USER_PROFILE_LOAD          = 500L,
        /// <summary>Arithmetic result exceeded 32 bits.</summary>
        ERROR_ARITHMETIC_OVERFLOW        = 534L,
        /// <summary>There is a process on other end of the pipe.</summary>
        ERROR_PIPE_CONNECTED             = 535L,
        /// <summary>Waiting for a process to open the other end of the pipe.</summary>
        ERROR_PIPE_LISTENING             = 536L,
        /// <summary>Application verifier has found an error in the current process.</summary>
        ERROR_VERIFIER_STOP              = 537L,
        /// <summary>An error occurred in the ABIOS subsystem.</summary>
        ERROR_ABIOS_ERROR                = 538L,
        /// <summary>A warning occurred in the WX86 subsystem.</summary>
        ERROR_WX86_WARNING               = 539L,
        /// <summary>An error occurred in the WX86 subsystem.</summary>
        ERROR_WX86_ERROR                 = 540L,
        /// <summary>An attempt was made to cancel or set a timer that has an associated APC and the subject thread is not the thread that originally set the timer with an associated APC routine.</summary>
        ERROR_TIMER_NOT_CANCELED         = 541L,
        /// <summary>Unwind exception code.</summary>
        ERROR_UNWIND                     = 542L,
        /// <summary>An invalid or unaligned stack was encountered during an unwind operation.</summary>
        ERROR_BAD_STACK                  = 543L,
        /// <summary>An invalid unwind target was encountered during an unwind operation.</summary>
        ERROR_INVALID_UNWIND_TARGET      = 544L,
        /// <summary>Invalid Object Attributes specified to NtCreatePort or invalid Port Attributes specified to NtConnectPort</summary>
        ERROR_INVALID_PORT_ATTRIBUTES    = 545L,
        /// <summary>Length of message passed to NtRequestPort or NtRequestWaitReplyPort was longer than the maximum message allowed by the port.</summary>
        ERROR_PORT_MESSAGE_TOO_LONG      = 546L,
        /// <summary>An attempt was made to lower a quota limit below the current usage.</summary>
        ERROR_INVALID_QUOTA_LOWER        = 547L,
        /// <summary>An attempt was made to attach to a device that was already attached to another device.</summary>
        ERROR_DEVICE_ALREADY_ATTACHED    = 548L,
        /// <summary>An attempt was made to execute an instruction at an unaligned address and the host system does not support unaligned instruction references.</summary>
        ERROR_INSTRUCTION_MISALIGNMENT   = 549L,
        /// <summary>Profiling not started.</summary>
        ERROR_PROFILING_NOT_STARTED      = 550L,
        /// <summary>Profiling not stopped.</summary>
        ERROR_PROFILING_NOT_STOPPED      = 551L,
        /// <summary>The passed ACL did not contain the minimum required information.</summary>
        ERROR_COULD_NOT_INTERPRET        = 552L,
        /// <summary>The number of active profiling objects is at the maximum and no more may be started.</summary>
        ERROR_PROFILING_AT_LIMIT         = 553L,
        /// <summary>Used to indicate that an operation cannot continue without blocking for I/O.</summary>
        ERROR_CANT_WAIT                  = 554L,
        /// <summary>Indicates that a thread attempted to terminate itself by default (called NtTerminateThread with NULL) and it was the last thread in the current process.</summary>
        ERROR_CANT_TERMINATE_SELF        = 555L,
        /// <summary>If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.</summary>
        ERROR_UNEXPECTED_MM_CREATE_ERR   = 556L,
        /// <summary>If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.</summary>
        ERROR_UNEXPECTED_MM_MAP_ERROR    = 557L,
        /// <summary>If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.</summary>
        ERROR_UNEXPECTED_MM_EXTEND_ERR   = 558L,
        /// <summary>A malformed function table was encountered during an unwind operation.</summary>
        ERROR_BAD_FUNCTION_TABLE         = 559L,
        /// <summary>Indicates that an attempt was made to assign protection to a file system file or directory and one of the SIDs in the security descriptor could not be translated into a GUID that could be stored by the file system. This causes the protection attempt to fail, which may cause a file creation attempt to fail.</summary>
        ERROR_NO_GUID_TRANSLATION        = 560L,
        /// <summary>Indicates that an attempt was made to grow an LDT by setting its size, or that the size was not an even number of selectors.</summary>
        ERROR_INVALID_LDT_SIZE           = 561L,
        /// <summary>Indicates that the starting value for the LDT information was not an integral multiple of the selector size.</summary>
        ERROR_INVALID_LDT_OFFSET         = 563L,
        /// <summary>Indicates that the user supplied an invalid descriptor when trying to set up Ldt descriptors.</summary>
        ERROR_INVALID_LDT_DESCRIPTOR     = 564L,
        /// <summary>Indicates a process has too many threads to perform the requested action. For example, assignment of a primary token may only be performed when a process has zero or one threads.</summary>
        ERROR_TOO_MANY_THREADS           = 565L,
        /// <summary>An attempt was made to operate on a thread within a specific process, but the thread specified is not in the process specified.</summary>
        ERROR_THREAD_NOT_IN_PROCESS      = 566L,
        /// <summary>Page file quota was exceeded.</summary>
        ERROR_PAGEFILE_QUOTA_EXCEEDED    = 567L,
        /// <summary>The Netlogon service cannot start because another Netlogon service running in the domain conflicts with the specified role.</summary>
        ERROR_LOGON_SERVER_CONFLICT      = 568L,
        /// <summary>The SAM database on a Windows Server is significantly out of synchronization with the copy on the Domain Controller. A complete synchronization is required.</summary>
        ERROR_SYNCHRONIZATION_REQUIRED   = 569L,
        /// <summary>The NtCreateFile API failed. This error should never be returned to an application, it is a place holder for the Windows Lan Manager Redirector to use in its internal error mapping routines.</summary>
        ERROR_NET_OPEN_FAILED            = 570L,
        /// <summary>{Privilege Failed} The I/O permissions for the process could not be changed.</summary>
        ERROR_IO_PRIVILEGE_FAILED        = 571L,
        /// <summary>{Application Exit by CTRL+C} The application terminated as a result of a CTRL+C.</summary>
        ERROR_CONTROL_C_EXIT             = 572L,    // winnt
        /// <summary>{Missing System File} The required system file %hs is bad or missing.</summary>
        ERROR_MISSING_SYSTEMFILE         = 573L,
        /// <summary>{Application Error} The exception %s (0x%08lx) occurred in the application at location 0x%08lx.</summary>
        ERROR_UNHANDLED_EXCEPTION        = 574L,
        /// <summary>{Application Error} The application was unable to start correctly (0x%lx). Click OK to close the application.</summary>
        ERROR_APP_INIT_FAILURE           = 575L,
        /// <summary>{Unable to Create Paging File} The creation of the paging file %hs failed (%lx). The requested size was %ld.</summary>
        ERROR_PAGEFILE_CREATE_FAILED     = 576L,
        /// <summary>Windows cannot verify the digital signature for this file. A recent hardware or software change might have installed a file that is signed incorrectly or damaged, or that might be malicious software from an unknown source.</summary>
        ERROR_INVALID_IMAGE_HASH         = 577L,
        /// <summary>{No Paging File Specified} No paging file was specified in the system configuration.</summary>
        ERROR_NO_PAGEFILE                = 578L,
        /// <summary>{EXCEPTION} A real-mode application issued a floating-point instruction and floating-point hardware is not present.</summary>
        ERROR_ILLEGAL_FLOAT_CONTEXT      = 579L,
        /// <summary>An event pair synchronization operation was performed using the thread specific client/server event pair object, but no event pair object was associated with the thread.</summary>
        ERROR_NO_EVENT_PAIR              = 580L,
        /// <summary>A Windows Server has an incorrect configuration.</summary>
        ERROR_DOMAIN_CTRLR_CONFIG_ERROR  = 581L,
        /// <summary>An illegal character was encountered. For a multi-byte character set this includes a lead byte without a succeeding trail byte. For the Unicode character set this includes the characters 0xFFFF and 0xFFFE.</summary>
        ERROR_ILLEGAL_CHARACTER          = 582L,
        /// <summary>The Unicode character is not defined in the Unicode character set installed on the system.</summary>
        ERROR_UNDEFINED_CHARACTER        = 583L,
        /// <summary>The paging file cannot be created on a floppy diskette.</summary>
        ERROR_FLOPPY_VOLUME              = 584L,
        /// <summary>The system BIOS failed to connect a system interrupt to the device or bus for which the device is connected.</summary>
        ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT = 585L,
        /// <summary>This operation is only allowed for the Primary Domain Controller of the domain.</summary>
        ERROR_BACKUP_CONTROLLER          = 586L,
        /// <summary>An attempt was made to acquire a mutant such that its maximum count would have been exceeded.</summary>
        ERROR_MUTANT_LIMIT_EXCEEDED      = 587L,
        /// <summary>A volume has been accessed for which a file system driver is required that has not yet been loaded.</summary>
        ERROR_FS_DRIVER_REQUIRED         = 588L,
        /// <summary>{Registry File Failure} The registry cannot load the hive (file): %hs or its log or alternate. It is corrupt, absent, or not writable.</summary>
        ERROR_CANNOT_LOAD_REGISTRY_FILE  = 589L,
        /// <summary>{Unexpected Failure in DebugActiveProcess} An unexpected failure occurred while processing a DebugActiveProcess API request. You may choose OK to terminate the process, or Cancel to ignore the error.</summary>
        ERROR_DEBUG_ATTACH_FAILED        = 590L,
        /// <summary>{Fatal System Error} The %hs system process terminated unexpectedly with a status of 0x%08x (0x%08x 0x%08x). The system has been shut down.</summary>
        ERROR_SYSTEM_PROCESS_TERMINATED  = 591L,
        /// <summary>{Data Not Accepted} The TDI client could not handle the data received during an indication.</summary>
        ERROR_DATA_NOT_ACCEPTED          = 592L,
        /// <summary>NTVDM encountered a hard error.</summary>
        ERROR_VDM_HARD_ERROR             = 593L,
        /// <summary>{Cancel Timeout} The driver %hs failed to complete a cancelled I/O request in the allotted time.</summary>
        ERROR_DRIVER_CANCEL_TIMEOUT      = 594L,
        /// <summary>{Reply Message Mismatch} An attempt was made to reply to an LPC message, but the thread specified by the client ID in the message was not waiting on that message.</summary>
        ERROR_REPLY_MESSAGE_MISMATCH     = 595L,
        /// <summary>{Delayed Write Failed} Windows was unable to save all the data for the file %hs. The data has been lost. This error may be caused by a failure of your computer hardware or network connection. Please try to save this file elsewhere.</summary>
        ERROR_LOST_WRITEBEHIND_DATA      = 596L,
        /// <summary>The parameter(s) passed to the server in the client/server shared memory window were invalid. Too much data may have been put in the shared memory window.</summary>
        ERROR_CLIENT_SERVER_PARAMETERS_INVALID = 597L,
        /// <summary>The stream is not a tiny stream.</summary>
        ERROR_NOT_TINY_STREAM            = 598L,
        /// <summary>The request must be handled by the stack overflow code.</summary>
        ERROR_STACK_OVERFLOW_READ        = 599L,
        /// <summary>Internal OFS status codes indicating how an allocation operation is handled. Either it is retried after the containing onode is moved or the extent stream is converted to a large stream.</summary>
        ERROR_CONVERT_TO_LARGE           = 600L,
        /// <summary>The attempt to find the object found an object matching by ID on the volume but it is out of the scope of the handle used for the operation.</summary>
        ERROR_FOUND_OUT_OF_SCOPE         = 601L,
        /// <summary>The bucket array must be grown. Retry transaction after doing so.</summary>
        ERROR_ALLOCATE_BUCKET            = 602L,
        /// <summary>The user/kernel marshalling buffer has overflowed.</summary>
        ERROR_MARSHALL_OVERFLOW          = 603L,
        /// <summary>The supplied variant structure contains invalid data.</summary>
        ERROR_INVALID_VARIANT            = 604L,
        /// <summary>The specified buffer contains ill-formed data.</summary>
        ERROR_BAD_COMPRESSION_BUFFER     = 605L,
        /// <summary>{Audit Failed} An attempt to generate a security audit failed.</summary>
        ERROR_AUDIT_FAILED               = 606L,
        /// <summary>The timer resolution was not previously set by the current process.</summary>
        ERROR_TIMER_RESOLUTION_NOT_SET   = 607L,
        /// <summary>There is insufficient account information to log you on.</summary>
        ERROR_INSUFFICIENT_LOGON_INFO    = 608L,
        /// <summary>{Invalid DLL Entrypoint} The dynamic link library %hs is not written correctly. The stack pointer has been left in an inconsistent state. The entrypoint should be declared as WINAPI or STDCALL. Select YES to fail the DLL load. Select NO to continue execution. Selecting NO may cause the application to operate incorrectly.</summary>
        ERROR_BAD_DLL_ENTRYPOINT         = 609L,
        /// <summary>{Invalid Service Callback Entrypoint} The %hs service is not written correctly. The stack pointer has been left in an inconsistent state. The callback entrypoint should be declared as WINAPI or STDCALL. Selecting OK will cause the service to continue operation. However, the service process may operate incorrectly.</summary>
        ERROR_BAD_SERVICE_ENTRYPOINT     = 610L,
        /// <summary>There is an IP address conflict with another system on the network</summary>
        ERROR_IP_ADDRESS_CONFLICT1       = 611L,
        /// <summary>There is an IP address conflict with another system on the network</summary>
        ERROR_IP_ADDRESS_CONFLICT2       = 612L,
        /// <summary>{Low On Registry Space} The system has reached the maximum size allowed for the system part of the registry. Additional storage requests will be ignored.</summary>
        ERROR_REGISTRY_QUOTA_LIMIT       = 613L,
        /// <summary>A callback return system service cannot be executed when no callback is active.</summary>
        ERROR_NO_CALLBACK_ACTIVE         = 614L,
        /// <summary>The password provided is too short to meet the policy of your user account. Please choose a longer password.</summary>
        ERROR_PWD_TOO_SHORT              = 615L,
        /// <summary>The policy of your user account does not allow you to change passwords too frequently. This is done to prevent users from changing back to a familiar, but potentially discovered, password. If you feel your password has been compromised then please contact your administrator immediately to have a new one assigned.</summary>
        ERROR_PWD_TOO_RECENT             = 616L,
        /// <summary>You have attempted to change your password to one that you have used in the past. The policy of your user account does not allow this. Please select a password that you have not previously used.</summary>
        ERROR_PWD_HISTORY_CONFLICT       = 617L,
        /// <summary>The specified compression format is unsupported.</summary>
        ERROR_UNSUPPORTED_COMPRESSION    = 618L,
        /// <summary>The specified hardware profile configuration is invalid.</summary>
        ERROR_INVALID_HW_PROFILE         = 619L,
        /// <summary>The specified Plug and Play registry device path is invalid.</summary>
        ERROR_INVALID_PLUGPLAY_DEVICE_PATH = 620L,
        /// <summary>The specified quota list is internally inconsistent with its descriptor.</summary>
        ERROR_QUOTA_LIST_INCONSISTENT    = 621L,
        /// <summary>{Windows Evaluation Notification} The evaluation period for this installation of Windows has expired. This system will shutdown in 1 hour. To restore access to this installation of Windows, please upgrade this installation using a licensed distribution of this product.</summary>
        ERROR_EVALUATION_EXPIRATION      = 622L,
        /// <summary>{Illegal System DLL Relocation} The system DLL %hs was relocated in memory. The application will not run properly. The relocation occurred because the DLL %hs occupied an address range reserved for Windows system DLLs. The vendor supplying the DLL should be contacted for a new DLL.</summary>
        ERROR_ILLEGAL_DLL_RELOCATION     = 623L,
        /// <summary>{DLL Initialization Failed} The application failed to initialize because the window station is shutting down.</summary>
        ERROR_DLL_INIT_FAILED_LOGOFF     = 624L,
        /// <summary>The validation process needs to continue on to the next step.</summary>
        ERROR_VALIDATE_CONTINUE          = 625L,
        /// <summary>There are no more matches for the current index enumeration.</summary>
        ERROR_NO_MORE_MATCHES            = 626L,
        /// <summary>The range could not be added to the range list because of a conflict.</summary>
        ERROR_RANGE_LIST_CONFLICT        = 627L,
        /// <summary>The server process is running under a SID different than that required by client.</summary>
        ERROR_SERVER_SID_MISMATCH        = 628L,
        /// <summary>A group marked use for deny only cannot be enabled.</summary>
        ERROR_CANT_ENABLE_DENY_ONLY      = 629L,
        /// <summary>{EXCEPTION} Multiple floating point faults.</summary>
        ERROR_FLOAT_MULTIPLE_FAULTS      = 630L,    // winnt
        /// <summary>{EXCEPTION} Multiple floating point traps.</summary>
        ERROR_FLOAT_MULTIPLE_TRAPS       = 631L,    // winnt
        /// <summary>The requested interface is not supported.</summary>
        ERROR_NOINTERFACE                = 632L,
        /// <summary>{System Standby Failed} The driver %hs does not support standby mode. Updating this driver may allow the system to go to standby mode.</summary>
        ERROR_DRIVER_FAILED_SLEEP        = 633L,
        /// <summary>The system file %1 has become corrupt and has been replaced.</summary>
        ERROR_CORRUPT_SYSTEM_FILE        = 634L,
        /// <summary>{Virtual Memory Minimum Too Low} Your system is low on virtual memory. Windows is increasing the size of your virtual memory paging file. During this process, memory requests for some applications may be denied. For more information, see Help.</summary>
        ERROR_COMMITMENT_MINIMUM         = 635L,
        /// <summary>A device was removed so enumeration must be restarted.</summary>
        ERROR_PNP_RESTART_ENUMERATION    = 636L,
        /// <summary>{Fatal System Error} The system image %s is not properly signed. The file has been replaced with the signed file. The system has been shut down.</summary>
        ERROR_SYSTEM_IMAGE_BAD_SIGNATURE = 637L,
        /// <summary>Device will not start without a reboot.</summary>
        ERROR_PNP_REBOOT_REQUIRED        = 638L,
        /// <summary>There is not enough power to complete the requested operation.</summary>
        ERROR_INSUFFICIENT_POWER         = 639L,
        /// <summary> ERROR_MULTIPLE_FAULT_VIOLATION</summary>
        ERROR_MULTIPLE_FAULT_VIOLATION   = 640L,
        /// <summary>The system is in the process of shutting down.</summary>
        ERROR_SYSTEM_SHUTDOWN            = 641L,
        /// <summary>An attempt to remove a processes DebugPort was made, but a port was not already associated with the process.</summary>
        ERROR_PORT_NOT_SET               = 642L,
        /// <summary>This version of Windows is not compatible with the behavior version of directory forest, domain or domain controller.</summary>
        ERROR_DS_VERSION_CHECK_FAILURE   = 643L,
        /// <summary>The specified range could not be found in the range list.</summary>
        ERROR_RANGE_NOT_FOUND            = 644L,
        /// <summary>The driver was not loaded because the system is booting into safe mode.</summary>
        ERROR_NOT_SAFE_MODE_DRIVER       = 646L,
        /// <summary>The driver was not loaded because it failed its initialization call.</summary>
        ERROR_FAILED_DRIVER_ENTRY        = 647L,
        /// <summary>The "%hs" encountered an error while applying power or reading the device configuration. This may be caused by a failure of your hardware or by a poor connection.</summary>
        ERROR_DEVICE_ENUMERATION_ERROR   = 648L,
        /// <summary>The create operation failed because the name contained at least one mount point which resolves to a volume to which the specified device object is not attached.</summary>
        ERROR_MOUNT_POINT_NOT_RESOLVED   = 649L,
        /// <summary>The device object parameter is either not a valid device object or is not attached to the volume specified by the file name.</summary>
        ERROR_INVALID_DEVICE_OBJECT_PARAMETER = 650L,
        /// <summary>A Machine Check Error has occurred. Please check the system eventlog for additional information.</summary>
        ERROR_MCA_OCCURED                = 651L,
        /// <summary>There was error [%2] processing the driver database.</summary>
        ERROR_DRIVER_DATABASE_ERROR      = 652L,
        /// <summary>System hive size has exceeded its limit.</summary>
        ERROR_SYSTEM_HIVE_TOO_LARGE      = 653L,
        /// <summary>The driver could not be loaded because a previous version of the driver is still in memory.</summary>
        ERROR_DRIVER_FAILED_PRIOR_UNLOAD = 654L,
        /// <summary>{Volume Shadow Copy Service} Please wait while the Volume Shadow Copy Service prepares volume %hs for hibernation.</summary>
        ERROR_VOLSNAP_PREPARE_HIBERNATE  = 655L,
        /// <summary>The system has failed to hibernate (The error code is %hs). Hibernation will be disabled until the system is restarted.</summary>
        ERROR_HIBERNATION_FAILURE        = 656L,
        /// <summary>The password provided is too long to meet the policy of your user account. Please choose a shorter password.</summary>
        ERROR_PWD_TOO_LONG               = 657L,
        /// <summary>The requested operation could not be completed due to a file system limitation</summary>
        ERROR_FILE_SYSTEM_LIMITATION     = 665L,
        /// <summary>An assertion failure has occurred.</summary>
        ERROR_ASSERTION_FAILURE          = 668L,
        /// <summary>An error occurred in the ACPI subsystem.</summary>
        ERROR_ACPI_ERROR                 = 669L,
        /// <summary>WOW Assertion Error.</summary>
        ERROR_WOW_ASSERTION              = 670L,
        /// <summary>A device is missing in the system BIOS MPS table. This device will not be used. Please contact your system vendor for system BIOS update.</summary>
        ERROR_PNP_BAD_MPS_TABLE          = 671L,
        /// <summary>A translator failed to translate resources.</summary>
        ERROR_PNP_TRANSLATION_FAILED     = 672L,
        /// <summary>A IRQ translator failed to translate resources.</summary>
        ERROR_PNP_IRQ_TRANSLATION_FAILED = 673L,
        /// <summary>Driver %2 returned invalid ID for a child device (%3).</summary>
        ERROR_PNP_INVALID_ID             = 674L,
        /// <summary>{Kernel Debugger Awakened} the system debugger was awakened by an interrupt.</summary>
        ERROR_WAKE_SYSTEM_DEBUGGER       = 675L,
        /// <summary>{Handles Closed} Handles to objects have been automatically closed as a result of the requested operation.</summary>
        ERROR_HANDLES_CLOSED             = 676L,
        /// <summary>{Too Much Information} The specified access control list (ACL) contained more information than was expected.</summary>
        ERROR_EXTRANEOUS_INFORMATION     = 677L,
        /// <summary>This warning level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has NOT been completed, but has not been rolled back either (so it may still be committed if desired).</summary>
        ERROR_RXACT_COMMIT_NECESSARY     = 678L,
        /// <summary>{Media Changed} The media may have changed.</summary>
        ERROR_MEDIA_CHECK                = 679L,
        /// <summary>{GUID Substitution} During the translation of a global identifier (GUID) to a Windows security ID (SID), no administratively-defined GUID prefix was found. A substitute prefix was used, which will not compromise system security. However, this may provide a more restrictive access than intended.</summary>
        ERROR_GUID_SUBSTITUTION_MADE     = 680L,
        /// <summary>The create operation stopped after reaching a symbolic link</summary>
        ERROR_STOPPED_ON_SYMLINK         = 681L,
        /// <summary>A long jump has been executed.</summary>
        ERROR_LONGJUMP                   = 682L,
        /// <summary>The Plug and Play query operation was not successful.</summary>
        ERROR_PLUGPLAY_QUERY_VETOED      = 683L,
        /// <summary>A frame consolidation has been executed.</summary>
        ERROR_UNWIND_CONSOLIDATE         = 684L,
        /// <summary>{Registry Hive Recovered} Registry hive (file): %hs was corrupted and it has been recovered. Some data might have been lost.</summary>
        ERROR_REGISTRY_HIVE_RECOVERED    = 685L,
        /// <summary>The application is attempting to run executable code from the module %hs. This may be insecure. An alternative, %hs, is available. Should the application use the secure module %hs?</summary>
        ERROR_DLL_MIGHT_BE_INSECURE      = 686L,
        /// <summary>The application is loading executable code from the module %hs. This is secure, but may be incompatible with previous releases of the operating system. An alternative, %hs, is available. Should the application use the secure module %hs?</summary>
        ERROR_DLL_MIGHT_BE_INCOMPATIBLE  = 687L,
        /// <summary>Debugger did not handle the exception.</summary>
        ERROR_DBG_EXCEPTION_NOT_HANDLED  = 688L,    // winnt
        /// <summary>Debugger will reply later.</summary>
        ERROR_DBG_REPLY_LATER            = 689L,
        /// <summary>Debugger cannot provide handle.</summary>
        ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE = 690L,
        /// <summary>Debugger terminated thread.</summary>
        ERROR_DBG_TERMINATE_THREAD       = 691L,    // winnt
        /// <summary>Debugger terminated process.</summary>
        ERROR_DBG_TERMINATE_PROCESS      = 692L,    // winnt
        /// <summary>Debugger got control C.</summary>
        ERROR_DBG_CONTROL_C              = 693L,    // winnt
        /// <summary>Debugger printed exception on control C.</summary>
        ERROR_DBG_PRINTEXCEPTION_C       = 694L,
        /// <summary>Debugger received RIP exception.</summary>
        ERROR_DBG_RIPEXCEPTION           = 695L,
        /// <summary>Debugger received control break.</summary>
        ERROR_DBG_CONTROL_BREAK          = 696L,    // winnt
        /// <summary>Debugger command communication exception.</summary>
        ERROR_DBG_COMMAND_EXCEPTION      = 697L,    // winnt
        /// <summary>{Object Exists} An attempt was made to create an object and the object name already existed.</summary>
        ERROR_OBJECT_NAME_EXISTS         = 698L,
        /// <summary>{Thread Suspended} A thread termination occurred while the thread was suspended. The thread was resumed, and termination proceeded.</summary>
        ERROR_THREAD_WAS_SUSPENDED       = 699L,
        /// <summary>{Image Relocated} An image file could not be mapped at the address specified in the image file. Local fixups must be performed on this image.</summary>
        ERROR_IMAGE_NOT_AT_BASE          = 700L,
        /// <summary>This informational level status indicates that a specified registry sub-tree transaction state did not yet exist and had to be created.</summary>
        ERROR_RXACT_STATE_CREATED        = 701L,
        /// <summary>{Segment Load} A virtual DOS machine (VDM) is loading, unloading, or moving an MS-DOS or Win16 program segment image. An exception is raised so a debugger can load, unload or track symbols and breakpoints within these 16-bit segments.</summary>
        ERROR_SEGMENT_NOTIFICATION       = 702L,    // winnt
        /// <summary>{Invalid Current Directory} The process cannot switch to the startup current directory %hs. Select OK to set current directory to %hs, or select CANCEL to exit.</summary>
        ERROR_BAD_CURRENT_DIRECTORY      = 703L,
        /// <summary>{Redundant Read} To satisfy a read request, the NT fault-tolerant file system successfully read the requested data from a redundant copy. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was unable to reassign the failing area of the device.</summary>
        ERROR_FT_READ_RECOVERY_FROM_BACKUP = 704L,
        /// <summary>{Redundant Write} To satisfy a write request, the NT fault-tolerant file system successfully wrote a redundant copy of the information. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was not able to reassign the failing area of the device.</summary>
        ERROR_FT_WRITE_RECOVERY          = 705L,
        /// <summary>{Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine. Select OK to continue, or CANCEL to fail the DLL load.</summary>
        ERROR_IMAGE_MACHINE_TYPE_MISMATCH = 706L,
        /// <summary>{Partial Data Received} The network transport returned partial data to its client. The remaining data will be sent later.</summary>
        ERROR_RECEIVE_PARTIAL            = 707L,
        /// <summary>{Expedited Data Received} The network transport returned data to its client that was marked as expedited by the remote system.</summary>
        ERROR_RECEIVE_EXPEDITED          = 708L,
        /// <summary>{Partial Expedited Data Received} The network transport returned partial data to its client and this data was marked as expedited by the remote system. The remaining data will be sent later.</summary>
        ERROR_RECEIVE_PARTIAL_EXPEDITED  = 709L,
        /// <summary>{TDI Event Done} The TDI indication has completed successfully.</summary>
        ERROR_EVENT_DONE                 = 710L,
        /// <summary>{TDI Event Pending} The TDI indication has entered the pending state.</summary>
        ERROR_EVENT_PENDING              = 711L,
        /// <summary>Checking file system on %wZ</summary>
        ERROR_CHECKING_FILE_SYSTEM       = 712L,
        /// <summary>{Fatal Application Exit} %hs</summary>
        ERROR_FATAL_APP_EXIT             = 713L,
        /// <summary>The specified registry key is referenced by a predefined handle.</summary>
        ERROR_PREDEFINED_HANDLE          = 714L,
        /// <summary>{Page Unlocked} The page protection of a locked page was changed to 'No Access' and the page was unlocked from memory and from the process.</summary>
        ERROR_WAS_UNLOCKED               = 715L,
        /// <summary>%hs</summary>
        ERROR_SERVICE_NOTIFICATION       = 716L,
        /// <summary>{Page Locked} One of the pages to lock was already locked.</summary>
        ERROR_WAS_LOCKED                 = 717L,
        /// <summary>Application popup: %1 : %2</summary>
        ERROR_LOG_HARD_ERROR             = 718L,
        /// <summary> ERROR_ALREADY_WIN32</summary>
        ERROR_ALREADY_WIN32              = 719L,
        /// <summary>{Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine.</summary>
        ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE = 720L,
        /// <summary>A yield execution was performed and no thread was available to run.</summary>
        ERROR_NO_YIELD_PERFORMED         = 721L,
        /// <summary>The resumable flag to a timer API was ignored.</summary>
        ERROR_TIMER_RESUME_IGNORED       = 722L,
        /// <summary>The arbiter has deferred arbitration of these resources to its parent</summary>
        ERROR_ARBITRATION_UNHANDLED      = 723L,
        /// <summary>The inserted CardBus device cannot be started because of a configuration error on "%hs".</summary>
        ERROR_CARDBUS_NOT_SUPPORTED      = 724L,
        /// <summary>The CPUs in this multiprocessor system are not all the same revision level. To use all processors the operating system restricts itself to the features of the least capable processor in the system. Should problems occur with this system, contact the CPU manufacturer to see if this mix of processors is supported.</summary>
        ERROR_MP_PROCESSOR_MISMATCH      = 725L,
        /// <summary>The system was put into hibernation.</summary>
        ERROR_HIBERNATED                 = 726L,    
        /// <summary>The system was resumed from hibernation.</summary>
        ERROR_RESUME_HIBERNATION         = 727L,    
        /// <summary>Windows has detected that the system firmware (BIOS) was updated [previous firmware date = %2, current firmware date %3].</summary>
        ERROR_FIRMWARE_UPDATED           = 728L,
        /// <summary>A device driver is leaking locked I/O pages causing system degradation. The system has automatically enabled tracking code in order to try and catch the culprit.</summary>
        ERROR_DRIVERS_LEAKING_LOCKED_PAGES = 729L,
        /// <summary>The system has awoken</summary>
        ERROR_WAKE_SYSTEM                = 730L,
        /// <summary> ERROR_WAIT_1</summary>
        ERROR_WAIT_1                     = 731L,
        /// <summary> ERROR_WAIT_2</summary>
        ERROR_WAIT_2                     = 732L,
        /// <summary> ERROR_WAIT_3</summary>
        ERROR_WAIT_3                     = 733L,
        /// <summary> ERROR_WAIT_63</summary>
        ERROR_WAIT_63                    = 734L,
        /// <summary> ERROR_ABANDONED_WAIT_0</summary>
        ERROR_ABANDONED_WAIT_0           = 735L,    // winnt
        /// <summary> ERROR_ABANDONED_WAIT_63</summary>
        ERROR_ABANDONED_WAIT_63          = 736L,
        /// <summary> ERROR_USER_APC</summary>
        ERROR_USER_APC                   = 737L,    // winnt
        /// <summary> ERROR_KERNEL_APC</summary>
        ERROR_KERNEL_APC                 = 738L,
        /// <summary> ERROR_ALERTED</summary>
        ERROR_ALERTED                    = 739L,
        /// <summary>The requested operation requires elevation.</summary>
        ERROR_ELEVATION_REQUIRED         = 740L,
        /// <summary>A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.</summary>
        ERROR_REPARSE                    = 741L,
        /// <summary>An open/create operation completed while an oplock break is underway.</summary>
        ERROR_OPLOCK_BREAK_IN_PROGRESS   = 742L,
        /// <summary>A new volume has been mounted by a file system.</summary>
        ERROR_VOLUME_MOUNTED             = 743L,
        /// <summary>This success level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has now been completed.</summary>
        ERROR_RXACT_COMMITTED            = 744L,
        /// <summary>This indicates that a notify change request has been completed due to closing the handle which made the notify change request.</summary>
        ERROR_NOTIFY_CLEANUP             = 745L,
        /// <summary>{Connect Failure on Primary Transport} An attempt was made to connect to the remote server %hs on the primary transport, but the connection failed. The computer WAS able to connect on a secondary transport.</summary>
        ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED = 746L,
        /// <summary>Page fault was a transition fault.</summary>
        ERROR_PAGE_FAULT_TRANSITION      = 747L,
        /// <summary>Page fault was a demand zero fault.</summary>
        ERROR_PAGE_FAULT_DEMAND_ZERO     = 748L,
        /// <summary>Page fault was a demand zero fault.</summary>
        ERROR_PAGE_FAULT_COPY_ON_WRITE   = 749L,
        /// <summary>Page fault was a demand zero fault.</summary>
        ERROR_PAGE_FAULT_GUARD_PAGE      = 750L,
        /// <summary>Page fault was satisfied by reading from a secondary storage device.</summary>
        ERROR_PAGE_FAULT_PAGING_FILE     = 751L,
        /// <summary>Cached page was locked during operation.</summary>
        ERROR_CACHE_PAGE_LOCKED          = 752L,
        /// <summary>Crash dump exists in paging file.</summary>
        ERROR_CRASH_DUMP                 = 753L,
        /// <summary>Specified buffer contains all zeros.</summary>
        ERROR_BUFFER_ALL_ZEROS           = 754L,
        /// <summary>A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.</summary>
        ERROR_REPARSE_OBJECT             = 755L,
        /// <summary>The device has succeeded a query-stop and its resource requirements have changed.</summary>
        ERROR_RESOURCE_REQUIREMENTS_CHANGED = 756L,
        /// <summary>The translator has translated these resources into the global space and no further translations should be performed.</summary>
        ERROR_TRANSLATION_COMPLETE       = 757L,
        /// <summary>A process being terminated has no threads to terminate.</summary>
        ERROR_NOTHING_TO_TERMINATE       = 758L,
        /// <summary>The specified process is not part of a job.</summary>
        ERROR_PROCESS_NOT_IN_JOB         = 759L,
        /// <summary>The specified process is part of a job.</summary>
        ERROR_PROCESS_IN_JOB             = 760L,
        /// <summary>{Volume Shadow Copy Service} The system is now ready for hibernation.</summary>
        ERROR_VOLSNAP_HIBERNATE_READY    = 761L,
        /// <summary>A file system or file system filter driver has successfully completed an FsFilter operation.</summary>
        ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY = 762L,
        /// <summary>The specified interrupt vector was already connected.</summary>
        ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED = 763L,
        /// <summary>The specified interrupt vector is still connected.</summary>
        ERROR_INTERRUPT_STILL_CONNECTED  = 764L,
        /// <summary>An operation is blocked waiting for an oplock.</summary>
        ERROR_WAIT_FOR_OPLOCK            = 765L,
        /// <summary>Debugger handled exception</summary>
        ERROR_DBG_EXCEPTION_HANDLED      = 766L,    // winnt
        /// <summary>Debugger continued</summary>
        ERROR_DBG_CONTINUE               = 767L,    // winnt
        /// <summary>An exception occurred in a user mode callback and the kernel callback frame should be removed.</summary>
        ERROR_CALLBACK_POP_STACK         = 768L,
        /// <summary>Compression is disabled for this volume.</summary>
        ERROR_COMPRESSION_DISABLED       = 769L,
        /// <summary>The data provider cannot fetch backwards through a result set.</summary>
        ERROR_CANTFETCHBACKWARDS         = 770L,
        /// <summary>The data provider cannot scroll backwards through a result set.</summary>
        ERROR_CANTSCROLLBACKWARDS        = 771L,
        /// <summary>The data provider requires that previously fetched data is released before asking for more data.</summary>
        ERROR_ROWSNOTRELEASED            = 772L,
        /// <summary>The data provider was not able to interpret the flags set for a column binding in an accessor.</summary>
        ERROR_BAD_ACCESSOR_FLAGS         = 773L,
        /// <summary>One or more errors occurred while processing the request.</summary>
        ERROR_ERRORS_ENCOUNTERED         = 774L,
        /// <summary>The implementation is not capable of performing the request.</summary>
        ERROR_NOT_CAPABLE                = 775L,
        /// <summary>The client of a component requested an operation which is not valid given the state of the component instance.</summary>
        ERROR_REQUEST_OUT_OF_SEQUENCE    = 776L,
        /// <summary>A version number could not be parsed.</summary>
        ERROR_VERSION_PARSE_ERROR        = 777L,
        /// <summary>The iterator's start position is invalid.</summary>
        ERROR_BADSTARTPOSITION           = 778L,
        /// <summary>The hardware has reported an uncorrectable memory error.</summary>
        ERROR_MEMORY_HARDWARE            = 779L,
        /// <summary>The attempted operation required self healing to be enabled.</summary>
        ERROR_DISK_REPAIR_DISABLED       = 780L,
        /// <summary>The Desktop heap encountered an error while allocating session memory. There is more information in the system event log.</summary>
        ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = 781L,
        /// <summary>The system power state is transitioning from %2 to %3.</summary>
        ERROR_SYSTEM_POWERSTATE_TRANSITION = 782L,
        /// <summary>The system power state is transitioning from %2 to %3 but could enter %4.</summary>
        ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = 783L,
        /// <summary>A thread is getting dispatched with MCA EXCEPTION because of MCA.</summary>
        ERROR_MCA_EXCEPTION              = 784L,
        /// <summary>Access to %1 is monitored by policy rule %2.</summary>
        ERROR_ACCESS_AUDIT_BY_POLICY     = 785L,
        /// <summary>Access to %1 has been restricted by your Administrator by policy rule %2.</summary>
        ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = 786L,
        /// <summary>A valid hibernation file has been invalidated and should be abandoned.</summary>
        ERROR_ABANDON_HIBERFILE          = 787L,
        /// <summary>{Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused by network connectivity issues. Please try to save this file elsewhere.</summary>
        ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = 788L,
        /// <summary>{Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error was returned by the server on which the file exists. Please try to save this file elsewhere.</summary>
        ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = 789L,
        /// <summary>{Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused if the device has been removed or the media is write-protected.</summary>
        ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = 790L,
        /// <summary>The resources required for this device conflict with the MCFG table.</summary>
        ERROR_BAD_MCFG_TABLE             = 791L,
        /// <summary>The volume repair could not be performed while it is online. Please schedule to take the volume offline so that it can be repaired.</summary>
        ERROR_DISK_REPAIR_REDIRECTED     = 792L,
        /// <summary>The volume repair was not successful.</summary>
        ERROR_DISK_REPAIR_UNSUCCESSFUL   = 793L,
        /// <summary>One of the volume corruption logs is full. Further corruptions that may be detected won't be logged.</summary>
        ERROR_CORRUPT_LOG_OVERFULL       = 794L,
        /// <summary>One of the volume corruption logs is internally corrupted and needs to be recreated. The volume may contain undetected corruptions and must be scanned.</summary>
        ERROR_CORRUPT_LOG_CORRUPTED      = 795L,
        /// <summary>One of the volume corruption logs is unavailable for being operated on.</summary>
        ERROR_CORRUPT_LOG_UNAVAILABLE    = 796L,
        /// <summary>One of the volume corruption logs was deleted while still having corruption records in them. The volume contains detected corruptions and must be scanned.</summary>
        ERROR_CORRUPT_LOG_DELETED_FULL   = 797L,
        /// <summary>One of the volume corruption logs was cleared by chkdsk and no longer contains real corruptions.</summary>
        ERROR_CORRUPT_LOG_CLEARED        = 798L,
        /// <summary>Orphaned files exist on the volume but could not be recovered because no more new names could be created in the recovery directory. Files must be moved from the recovery directory.</summary>
        ERROR_ORPHAN_NAME_EXHAUSTED      = 799L,
        /// <summary>The oplock that was associated with this handle is now associated with a different handle.</summary>
        ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE = 800L,
        /// <summary>An oplock of the requested level cannot be granted.  An oplock of a lower level may be available.</summary>
        ERROR_CANNOT_GRANT_REQUESTED_OPLOCK = 801L,
        /// <summary>The operation did not complete successfully because it would cause an oplock to be broken. The caller has requested that existing oplocks not be broken.</summary>
        ERROR_CANNOT_BREAK_OPLOCK        = 802L,
        /// <summary>The handle with which this oplock was associated has been closed.  The oplock is now broken.</summary>
        ERROR_OPLOCK_HANDLE_CLOSED       = 803L,
        /// <summary>The specified access control entry (ACE) does not contain a condition.</summary>
        ERROR_NO_ACE_CONDITION           = 804L,
        /// <summary>The specified access control entry (ACE) contains an invalid condition.</summary>
        ERROR_INVALID_ACE_CONDITION      = 805L,
        /// <summary>Access to the specified file handle has been revoked.</summary>
        ERROR_FILE_HANDLE_REVOKED        = 806L,
        /// <summary>{Image Relocated} An image file was mapped at a different address from the one specified in the image file but fixups will still be automatically performed on the image.</summary>
        ERROR_IMAGE_AT_DIFFERENT_BASE    = 807L,
        /// <summary>The read or write operation to an encrypted file could not be completed because the file has not been opened for data access.</summary>
        ERROR_ENCRYPTED_IO_NOT_POSSIBLE  = 808L,
        /// <summary>File metadata optimization is already in progress.</summary>
        ERROR_FILE_METADATA_OPTIMIZATION_IN_PROGRESS = 809L,
        /// <summary>The requested operation failed due to quota operation is still in progress.</summary>
        ERROR_QUOTA_ACTIVITY             = 810L,
        /// <summary>Access to the specified handle has been revoked.</summary>
        ERROR_HANDLE_REVOKED             = 811L,
        /// <summary>The callback function must be invoked inline.</summary>
        ERROR_CALLBACK_INVOKE_INLINE     = 812L,
        /// <summary>The specified CPU Set IDs are invalid.</summary>
        ERROR_CPU_SET_INVALID            = 813L,
        /// <summary>Access to the extended attribute was denied.</summary>
        ERROR_EA_ACCESS_DENIED           = 994L,
        /// <summary>The I/O operation has been aborted because of either a thread exit or an application request.</summary>
        ERROR_OPERATION_ABORTED          = 995L,
        /// <summary>Overlapped I/O event is not in a signaled state.</summary>
        ERROR_IO_INCOMPLETE              = 996L,
        /// <summary>Overlapped I/O operation is in progress.</summary>
        ERROR_IO_PENDING                 = 997L,    // dderror
        /// <summary>Invalid access to memory location.</summary>
        ERROR_NOACCESS                   = 998L,
        /// <summary>Error performing inpage operation.</summary>
        ERROR_SWAPERROR                  = 999L,
        /// <summary>Recursion too deep; the stack overflowed.</summary>
        ERROR_STACK_OVERFLOW             = 1001L,
        /// <summary>The window cannot act on the sent message.</summary>
        ERROR_INVALID_MESSAGE            = 1002L,
        /// <summary>Cannot complete this function.</summary>
        ERROR_CAN_NOT_COMPLETE           = 1003L,
        /// <summary>Invalid flags.</summary>
        ERROR_INVALID_FLAGS              = 1004L,
        /// <summary>The volume does not contain a recognized file system. Please make sure that all required file system drivers are loaded and that the volume is not corrupted.</summary>
        ERROR_UNRECOGNIZED_VOLUME        = 1005L,
        /// <summary>The volume for a file has been externally altered so that the opened file is no longer valid.</summary>
        ERROR_FILE_INVALID               = 1006L,
        /// <summary>The requested operation cannot be performed in full-screen mode.</summary>
        ERROR_FULLSCREEN_MODE            = 1007L,
        /// <summary>An attempt was made to reference a token that does not exist.</summary>
        ERROR_NO_TOKEN                   = 1008L,
        /// <summary>The configuration registry database is corrupt.</summary>
        ERROR_BADDB                      = 1009L,
        /// <summary>The configuration registry key is invalid.</summary>
        ERROR_BADKEY                     = 1010L,
        /// <summary>The configuration registry key could not be opened.</summary>
        ERROR_CANTOPEN                   = 1011L,
        /// <summary>The configuration registry key could not be read.</summary>
        ERROR_CANTREAD                   = 1012L,
        /// <summary>The configuration registry key could not be written.</summary>
        ERROR_CANTWRITE                  = 1013L,
        /// <summary>One of the files in the registry database had to be recovered by use of a log or alternate copy. The recovery was successful.</summary>
        ERROR_REGISTRY_RECOVERED         = 1014L,
        /// <summary>The registry is corrupted. The structure of one of the files containing registry data is corrupted, or the system's memory image of the file is corrupted, or the file could not be recovered because the alternate copy or log was absent or corrupted.</summary>
        ERROR_REGISTRY_CORRUPT           = 1015L,
        /// <summary>An I/O operation initiated by the registry failed unrecoverably. The registry could not read in, or write out, or flush, one of the files that contain the system's image of the registry.</summary>
        ERROR_REGISTRY_IO_FAILED         = 1016L,
        /// <summary>The system has attempted to load or restore a file into the registry, but the specified file is not in a registry file format.</summary>
        ERROR_NOT_REGISTRY_FILE          = 1017L,
        /// <summary>Illegal operation attempted on a registry key that has been marked for deletion.</summary>
        ERROR_KEY_DELETED                = 1018L,
        /// <summary>System could not allocate the required space in a registry log.</summary>
        ERROR_NO_LOG_SPACE               = 1019L,
        /// <summary>Cannot create a symbolic link in a registry key that already has subkeys or values.</summary>
        ERROR_KEY_HAS_CHILDREN           = 1020L,
        /// <summary>Cannot create a stable subkey under a volatile parent key.</summary>
        ERROR_CHILD_MUST_BE_VOLATILE     = 1021L,
        /// <summary>A notify change request is being completed and the information is not being returned in the caller's buffer. The caller now needs to enumerate the files to find the changes.</summary>
        ERROR_NOTIFY_ENUM_DIR            = 1022L,
        /// <summary>A stop control has been sent to a service that other running services are dependent on.</summary>
        ERROR_DEPENDENT_SERVICES_RUNNING = 1051L,
        /// <summary>The requested control is not valid for this service.</summary>
        ERROR_INVALID_SERVICE_CONTROL    = 1052L,
        /// <summary>The service did not respond to the start or control request in a timely fashion.</summary>
        ERROR_SERVICE_REQUEST_TIMEOUT    = 1053L,
        /// <summary>A thread could not be created for the service.</summary>
        ERROR_SERVICE_NO_THREAD          = 1054L,
        /// <summary>The service database is locked.</summary>
        ERROR_SERVICE_DATABASE_LOCKED    = 1055L,
        /// <summary>An instance of the service is already running.</summary>
        ERROR_SERVICE_ALREADY_RUNNING    = 1056L,
        /// <summary>The account name is invalid or does not exist, or the password is invalid for the account name specified.</summary>
        ERROR_INVALID_SERVICE_ACCOUNT    = 1057L,
        /// <summary>The service cannot be started, either because it is disabled or because it has no enabled devices associated with it.</summary>
        ERROR_SERVICE_DISABLED           = 1058L,
        /// <summary>Circular service dependency was specified.</summary>
        ERROR_CIRCULAR_DEPENDENCY        = 1059L,
        /// <summary>The specified service does not exist as an installed service.</summary>
        ERROR_SERVICE_DOES_NOT_EXIST     = 1060L,
        /// <summary>The service cannot accept control messages at this time.</summary>
        ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061L,
        /// <summary>The service has not been started.</summary>
        ERROR_SERVICE_NOT_ACTIVE         = 1062L,
        /// <summary>The service process could not connect to the service controller.</summary>
        ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063L,
        /// <summary>An exception occurred in the service when handling the control request.</summary>
        ERROR_EXCEPTION_IN_SERVICE       = 1064L,
        /// <summary>The database specified does not exist.</summary>
        ERROR_DATABASE_DOES_NOT_EXIST    = 1065L,
        /// <summary>The service has returned a service-specific error code.</summary>
        ERROR_SERVICE_SPECIFIC_ERROR     = 1066L,
        /// <summary>The process terminated unexpectedly.</summary>
        ERROR_PROCESS_ABORTED            = 1067L,
        /// <summary>The dependency service or group failed to start.</summary>
        ERROR_SERVICE_DEPENDENCY_FAIL    = 1068L,
        /// <summary>The service did not start due to a logon failure.</summary>
        ERROR_SERVICE_LOGON_FAILED       = 1069L,
        /// <summary>After starting, the service hung in a start-pending state.</summary>
        ERROR_SERVICE_START_HANG         = 1070L,
        /// <summary>The specified service database lock is invalid.</summary>
        ERROR_INVALID_SERVICE_LOCK       = 1071L,
        /// <summary>The specified service has been marked for deletion.</summary>
        ERROR_SERVICE_MARKED_FOR_DELETE  = 1072L,
        /// <summary>The specified service already exists.</summary>
        ERROR_SERVICE_EXISTS             = 1073L,
        /// <summary>The system is currently running with the last-known-good configuration.</summary>
        ERROR_ALREADY_RUNNING_LKG        = 1074L,
        /// <summary>The dependency service does not exist or has been marked for deletion.</summary>
        ERROR_SERVICE_DEPENDENCY_DELETED = 1075L,
        /// <summary>The current boot has already been accepted for use as the last-known-good control set.</summary>
        ERROR_BOOT_ALREADY_ACCEPTED      = 1076L,
        /// <summary>No attempts to start the service have been made since the last boot.</summary>
        ERROR_SERVICE_NEVER_STARTED      = 1077L,
        /// <summary>The name is already in use as either a service name or a service display name.</summary>
        ERROR_DUPLICATE_SERVICE_NAME     = 1078L,
        /// <summary>The account specified for this service is different from the account specified for other services running in the same process.</summary>
        ERROR_DIFFERENT_SERVICE_ACCOUNT  = 1079L,
        /// <summary>Failure actions can only be set for Win32 services, not for drivers.</summary>
        ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080L,
        /// <summary>This service runs in the same process as the service control manager. Therefore, the service control manager cannot take action if this service's process terminates unexpectedly.</summary>
        ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081L,
        /// <summary>No recovery program has been configured for this service.</summary>
        ERROR_NO_RECOVERY_PROGRAM        = 1082L,
        /// <summary>The executable program that this service is configured to run in does not implement the service.</summary>
        ERROR_SERVICE_NOT_IN_EXE         = 1083L,
        /// <summary>This service cannot be started in Safe Mode</summary>
        ERROR_NOT_SAFEBOOT_SERVICE       = 1084L,
        /// <summary>The physical end of the tape has been reached.</summary>
        ERROR_END_OF_MEDIA               = 1100L,
        /// <summary>A tape access reached a filemark.</summary>
        ERROR_FILEMARK_DETECTED          = 1101L,
        /// <summary>The beginning of the tape or a partition was encountered.</summary>
        ERROR_BEGINNING_OF_MEDIA         = 1102L,
        /// <summary>A tape access reached the end of a set of files.</summary>
        ERROR_SETMARK_DETECTED           = 1103L,
        /// <summary>No more data is on the tape.</summary>
        ERROR_NO_DATA_DETECTED           = 1104L,
        /// <summary>Tape could not be partitioned.</summary>
        ERROR_PARTITION_FAILURE          = 1105L,
        /// <summary>When accessing a new tape of a multivolume partition, the current block size is incorrect.</summary>
        ERROR_INVALID_BLOCK_LENGTH       = 1106L,
        /// <summary>Tape partition information could not be found when loading a tape.</summary>
        ERROR_DEVICE_NOT_PARTITIONED     = 1107L,
        /// <summary>Unable to lock the media eject mechanism.</summary>
        ERROR_UNABLE_TO_LOCK_MEDIA       = 1108L,
        /// <summary>Unable to unload the media.</summary>
        ERROR_UNABLE_TO_UNLOAD_MEDIA     = 1109L,
        /// <summary>The media in the drive may have changed.</summary>
        ERROR_MEDIA_CHANGED              = 1110L,
        /// <summary>The I/O bus was reset.</summary>
        ERROR_BUS_RESET                  = 1111L,
        /// <summary>No media in drive.</summary>
        ERROR_NO_MEDIA_IN_DRIVE          = 1112L,
        /// <summary>No mapping for the Unicode character exists in the target multi-byte code page.</summary>
        ERROR_NO_UNICODE_TRANSLATION     = 1113L,
        /// <summary>A dynamic link library (DLL) initialization routine failed.</summary>
        ERROR_DLL_INIT_FAILED            = 1114L,
        /// <summary>A system shutdown is in progress.</summary>
        ERROR_SHUTDOWN_IN_PROGRESS       = 1115L,
        /// <summary>Unable to abort the system shutdown because no shutdown was in progress.</summary>
        ERROR_NO_SHUTDOWN_IN_PROGRESS    = 1116L,
        /// <summary>The request could not be performed because of an I/O device error.</summary>
        ERROR_IO_DEVICE                  = 1117L,
        /// <summary>No serial device was successfully initialized. The serial driver will unload.</summary>
        ERROR_SERIAL_NO_DEVICE           = 1118L,
        /// <summary>Unable to open a device that was sharing an interrupt request (IRQ) with other devices. At least one other device that uses that IRQ was already opened.</summary>
        ERROR_IRQ_BUSY                   = 1119L,
        /// <summary>A serial I/O operation was completed by another write to the serial port. (The IOCTL_SERIAL_XOFF_COUNTER reached zero.)</summary>
        ERROR_MORE_WRITES                = 1120L,
        /// <summary>A serial I/O operation completed because the timeout period expired. (The IOCTL_SERIAL_XOFF_COUNTER did not reach zero.)</summary>
        ERROR_COUNTER_TIMEOUT            = 1121L,
        /// <summary>No ID address mark was found on the floppy disk.</summary>
        ERROR_FLOPPY_ID_MARK_NOT_FOUND   = 1122L,
        /// <summary>Mismatch between the floppy disk sector ID field and the floppy disk controller track address.</summary>
        ERROR_FLOPPY_WRONG_CYLINDER      = 1123L,
        /// <summary>The floppy disk controller reported an error that is not recognized by the floppy disk driver.</summary>
        ERROR_FLOPPY_UNKNOWN_ERROR       = 1124L,
        /// <summary>The floppy disk controller returned inconsistent results in its registers.</summary>
        ERROR_FLOPPY_BAD_REGISTERS       = 1125L,
        /// <summary>While accessing the hard disk, a recalibrate operation failed, even after retries.</summary>
        ERROR_DISK_RECALIBRATE_FAILED    = 1126L,
        /// <summary>While accessing the hard disk, a disk operation failed even after retries.</summary>
        ERROR_DISK_OPERATION_FAILED      = 1127L,
        /// <summary>While accessing the hard disk, a disk controller reset was needed, but even that failed.</summary>
        ERROR_DISK_RESET_FAILED          = 1128L,
        /// <summary>Physical end of tape encountered.</summary>
        ERROR_EOM_OVERFLOW               = 1129L,
        /// <summary>Not enough server storage is available to process this command.</summary>
        ERROR_NOT_ENOUGH_SERVER_MEMORY   = 1130L,
        /// <summary>A potential deadlock condition has been detected.</summary>
        ERROR_POSSIBLE_DEADLOCK          = 1131L,
        /// <summary>The base address or the file offset specified does not have the proper alignment.</summary>
        ERROR_MAPPED_ALIGNMENT           = 1132L,
        /// <summary>An attempt to change the system power state was vetoed by another application or driver.</summary>
        ERROR_SET_POWER_STATE_VETOED     = 1140L,
        /// <summary>The system BIOS failed an attempt to change the system power state.</summary>
        ERROR_SET_POWER_STATE_FAILED     = 1141L,
        /// <summary>An attempt was made to create more links on a file than the file system supports.</summary>
        ERROR_TOO_MANY_LINKS             = 1142L,
        /// <summary>The specified program requires a newer version of Windows.</summary>
        ERROR_OLD_WIN_VERSION            = 1150L,
        /// <summary>The specified program is not a Windows or MS-DOS program.</summary>
        ERROR_APP_WRONG_OS               = 1151L,
        /// <summary>Cannot start more than one instance of the specified program.</summary>
        ERROR_SINGLE_INSTANCE_APP        = 1152L,
        /// <summary>The specified program was written for an earlier version of Windows.</summary>
        ERROR_RMODE_APP                  = 1153L,
        /// <summary>One of the library files needed to run this application is damaged.</summary>
        ERROR_INVALID_DLL                = 1154L,
        /// <summary>No application is associated with the specified file for this operation.</summary>
        ERROR_NO_ASSOCIATION             = 1155L,
        /// <summary>An error occurred in sending the command to the application.</summary>
        ERROR_DDE_FAIL                   = 1156L,
        /// <summary>One of the library files needed to run this application cannot be found.</summary>
        ERROR_DLL_NOT_FOUND              = 1157L,
        /// <summary>The current process has used all of its system allowance of handles for Window Manager objects.</summary>
        ERROR_NO_MORE_USER_HANDLES       = 1158L,
        /// <summary>The message can be used only with synchronous operations.</summary>
        ERROR_MESSAGE_SYNC_ONLY          = 1159L,
        /// <summary>The indicated source element has no media.</summary>
        ERROR_SOURCE_ELEMENT_EMPTY       = 1160L,
        /// <summary>The indicated destination element already contains media.</summary>
        ERROR_DESTINATION_ELEMENT_FULL   = 1161L,
        /// <summary>The indicated element does not exist.</summary>
        ERROR_ILLEGAL_ELEMENT_ADDRESS    = 1162L,
        /// <summary>The indicated element is part of a magazine that is not present.</summary>
        ERROR_MAGAZINE_NOT_PRESENT       = 1163L,
        /// <summary>The indicated device requires reinitialization due to hardware errors.</summary>
        ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164L,    // dderror
        /// <summary>The device has indicated that cleaning is required before further operations are attempted.</summary>
        ERROR_DEVICE_REQUIRES_CLEANING   = 1165L,
        /// <summary>The device has indicated that its door is open.</summary>
        ERROR_DEVICE_DOOR_OPEN           = 1166L,
        /// <summary>The device is not connected.</summary>
        ERROR_DEVICE_NOT_CONNECTED       = 1167L,
        /// <summary>Element not found.</summary>
        ERROR_NOT_FOUND                  = 1168L,
        /// <summary>There was no match for the specified key in the index.</summary>
        ERROR_NO_MATCH                   = 1169L,
        /// <summary>The property set specified does not exist on the object.</summary>
        ERROR_SET_NOT_FOUND              = 1170L,
        /// <summary>The point passed to GetMouseMovePoints is not in the buffer.</summary>
        ERROR_POINT_NOT_FOUND            = 1171L,
        /// <summary>The tracking (workstation) service is not running.</summary>
        ERROR_NO_TRACKING_SERVICE        = 1172L,
        /// <summary>The Volume ID could not be found.</summary>
        ERROR_NO_VOLUME_ID               = 1173L,
        /// <summary>Unable to remove the file to be replaced.</summary>
        ERROR_UNABLE_TO_REMOVE_REPLACED  = 1175L,
        /// <summary>Unable to move the replacement file to the file to be replaced. The file to be replaced has retained its original name.</summary>
        ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176L,
        /// <summary>Unable to move the replacement file to the file to be replaced. The file to be replaced has been renamed using the backup name.</summary>
        ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177L,
        /// <summary>The volume change journal is being deleted.</summary>
        ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178L,
        /// <summary>The volume change journal is not active.</summary>
        ERROR_JOURNAL_NOT_ACTIVE         = 1179L,
        /// <summary>A file was found, but it may not be the correct file.</summary>
        ERROR_POTENTIAL_FILE_FOUND       = 1180L,
        /// <summary>The journal entry has been deleted from the journal.</summary>
        ERROR_JOURNAL_ENTRY_DELETED      = 1181L,
        /// <summary>A system shutdown has already been scheduled.</summary>
        ERROR_SHUTDOWN_IS_SCHEDULED      = 1190L,
        /// <summary>The system shutdown cannot be initiated because there are other users logged on to the computer.</summary>
        ERROR_SHUTDOWN_USERS_LOGGED_ON   = 1191L,
        /// <summary>The specified device name is invalid.</summary>
        ERROR_BAD_DEVICE                 = 1200L,
        /// <summary>The device is not currently connected but it is a remembered connection.</summary>
        ERROR_CONNECTION_UNAVAIL         = 1201L,
        /// <summary>The local device name has a remembered connection to another network resource.</summary>
        ERROR_DEVICE_ALREADY_REMEMBERED  = 1202L,
        /// <summary>The network path was either typed incorrectly, does not exist, or the network provider is not currently available. Please try retyping the path or contact your network administrator.</summary>
        ERROR_NO_NET_OR_BAD_PATH         = 1203L,
        /// <summary>The specified network provider name is invalid.</summary>
        ERROR_BAD_PROVIDER               = 1204L,
        /// <summary>Unable to open the network connection profile.</summary>
        ERROR_CANNOT_OPEN_PROFILE        = 1205L,
        /// <summary>The network connection profile is corrupted.</summary>
        ERROR_BAD_PROFILE                = 1206L,
        /// <summary>Cannot enumerate a noncontainer.</summary>
        ERROR_NOT_CONTAINER              = 1207L,
        /// <summary>An extended error has occurred.</summary>
        ERROR_EXTENDED_ERROR             = 1208L,
        /// <summary>The format of the specified group name is invalid.</summary>
        ERROR_INVALID_GROUPNAME          = 1209L,
        /// <summary>The format of the specified computer name is invalid.</summary>
        ERROR_INVALID_COMPUTERNAME       = 1210L,
        /// <summary>The format of the specified event name is invalid.</summary>
        ERROR_INVALID_EVENTNAME          = 1211L,
        /// <summary>The format of the specified domain name is invalid.</summary>
        ERROR_INVALID_DOMAINNAME         = 1212L,
        /// <summary>The format of the specified service name is invalid.</summary>
        ERROR_INVALID_SERVICENAME        = 1213L,
        /// <summary>The format of the specified network name is invalid.</summary>
        ERROR_INVALID_NETNAME            = 1214L,
        /// <summary>The format of the specified share name is invalid.</summary>
        ERROR_INVALID_SHARENAME          = 1215L,
        /// <summary>The format of the specified password is invalid.</summary>
        ERROR_INVALID_PASSWORDNAME       = 1216L,
        /// <summary>The format of the specified message name is invalid.</summary>
        ERROR_INVALID_MESSAGENAME        = 1217L,
        /// <summary>The format of the specified message destination is invalid.</summary>
        ERROR_INVALID_MESSAGEDEST        = 1218L,
        /// <summary>Multiple connections to a server or shared resource by the same user, using more than one user name, are not allowed. Disconnect all previous connections to the server or shared resource and try again.</summary>
        ERROR_SESSION_CREDENTIAL_CONFLICT = 1219L,
        /// <summary>An attempt was made to establish a session to a network server, but there are already too many sessions established to that server.</summary>
        ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220L,
        /// <summary>The workgroup or domain name is already in use by another computer on the network.</summary>
        ERROR_DUP_DOMAINNAME             = 1221L,
        /// <summary>The network is not present or not started.</summary>
        ERROR_NO_NETWORK                 = 1222L,
        /// <summary>The operation was canceled by the user.</summary>
        ERROR_CANCELLED                  = 1223L,
        /// <summary>The requested operation cannot be performed on a file with a user-mapped section open.</summary>
        ERROR_USER_MAPPED_FILE           = 1224L,
        /// <summary>The remote computer refused the network connection.</summary>
        ERROR_CONNECTION_REFUSED         = 1225L,
        /// <summary>The network connection was gracefully closed.</summary>
        ERROR_GRACEFUL_DISCONNECT        = 1226L,
        /// <summary>The network transport endpoint already has an address associated with it.</summary>
        ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227L,
        /// <summary>An address has not yet been associated with the network endpoint.</summary>
        ERROR_ADDRESS_NOT_ASSOCIATED     = 1228L,
        /// <summary>An operation was attempted on a nonexistent network connection.</summary>
        ERROR_CONNECTION_INVALID         = 1229L,
        /// <summary>An invalid operation was attempted on an active network connection.</summary>
        ERROR_CONNECTION_ACTIVE          = 1230L,
        /// <summary>The network location cannot be reached. For information about network troubleshooting, see Windows Help.</summary>
        ERROR_NETWORK_UNREACHABLE        = 1231L,
        /// <summary>The network location cannot be reached. For information about network troubleshooting, see Windows Help.</summary>
        ERROR_HOST_UNREACHABLE           = 1232L,
        /// <summary>The network location cannot be reached. For information about network troubleshooting, see Windows Help.</summary>
        ERROR_PROTOCOL_UNREACHABLE       = 1233L,
        /// <summary>No service is operating at the destination network endpoint on the remote system.</summary>
        ERROR_PORT_UNREACHABLE           = 1234L,
        /// <summary>The request was aborted.</summary>
        ERROR_REQUEST_ABORTED            = 1235L,
        /// <summary>The network connection was aborted by the local system.</summary>
        ERROR_CONNECTION_ABORTED         = 1236L,
        /// <summary>The operation could not be completed. A retry should be performed.</summary>
        ERROR_RETRY                      = 1237L,
        /// <summary>A connection to the server could not be made because the limit on the number of concurrent connections for this account has been reached.</summary>
        ERROR_CONNECTION_COUNT_LIMIT     = 1238L,
        /// <summary>Attempting to log in during an unauthorized time of day for this account.</summary>
        ERROR_LOGIN_TIME_RESTRICTION     = 1239L,
        /// <summary>The account is not authorized to log in from this station.</summary>
        ERROR_LOGIN_WKSTA_RESTRICTION    = 1240L,
        /// <summary>The network address could not be used for the operation requested.</summary>
        ERROR_INCORRECT_ADDRESS          = 1241L,
        /// <summary>The service is already registered.</summary>
        ERROR_ALREADY_REGISTERED         = 1242L,
        /// <summary>The specified service does not exist.</summary>
        ERROR_SERVICE_NOT_FOUND          = 1243L,
        /// <summary>The operation being requested was not performed because the user has not been authenticated.</summary>
        ERROR_NOT_AUTHENTICATED          = 1244L,
        /// <summary>The operation being requested was not performed because the user has not logged on to the network. The specified service does not exist.</summary>
        ERROR_NOT_LOGGED_ON              = 1245L,
        /// <summary>Continue with work in progress.</summary>
        ERROR_CONTINUE                   = 1246L,    // dderror
        /// <summary>An attempt was made to perform an initialization operation when initialization has already been completed.</summary>
        ERROR_ALREADY_INITIALIZED        = 1247L,
        /// <summary>No more local devices.</summary>
        ERROR_NO_MORE_DEVICES            = 1248L,    // dderror
        /// <summary>The specified site does not exist.</summary>
        ERROR_NO_SUCH_SITE               = 1249L,
        /// <summary>A domain controller with the specified name already exists.</summary>
        ERROR_DOMAIN_CONTROLLER_EXISTS   = 1250L,
        /// <summary>This operation is supported only when you are connected to the server.</summary>
        ERROR_ONLY_IF_CONNECTED          = 1251L,
        /// <summary>The group policy framework should call the extension even if there are no changes.</summary>
        ERROR_OVERRIDE_NOCHANGES         = 1252L,
        /// <summary>The specified user does not have a valid profile.</summary>
        ERROR_BAD_USER_PROFILE           = 1253L,
        /// <summary>This operation is not supported on a computer running Windows Server 2003 for Small Business Server</summary>
        ERROR_NOT_SUPPORTED_ON_SBS       = 1254L,
        /// <summary>The server machine is shutting down.</summary>
        ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255L,
        /// <summary>The remote system is not available. For information about network troubleshooting, see Windows Help.</summary>
        ERROR_HOST_DOWN                  = 1256L,
        /// <summary>The security identifier provided is not from an account domain.</summary>
        ERROR_NON_ACCOUNT_SID            = 1257L,
        /// <summary>The security identifier provided does not have a domain component.</summary>
        ERROR_NON_DOMAIN_SID             = 1258L,
        /// <summary>AppHelp dialog canceled thus preventing the application from starting.</summary>
        ERROR_APPHELP_BLOCK              = 1259L,
        /// <summary>This program is blocked by group policy. For more information, contact your system administrator.</summary>
        ERROR_ACCESS_DISABLED_BY_POLICY  = 1260L,
        /// <summary>A program attempt to use an invalid register value. Normally caused by an uninitialized register. This error is Itanium specific.</summary>
        ERROR_REG_NAT_CONSUMPTION        = 1261L,
        /// <summary>The share is currently offline or does not exist.</summary>
        ERROR_CSCSHARE_OFFLINE           = 1262L,
        /// <summary>The Kerberos protocol encountered an error while validating the KDC certificate during smartcard logon. There is more information in the system event log.</summary>
        ERROR_PKINIT_FAILURE             = 1263L,
        /// <summary>The Kerberos protocol encountered an error while attempting to utilize the smartcard subsystem.</summary>
        ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264L,
        /// <summary>The system cannot contact a domain controller to service the authentication request. Please try again later.</summary>
        ERROR_DOWNGRADE_DETECTED         = 1265L,
        /// <summary>The machine is locked and cannot be shut down without the force option.</summary>
        ERROR_MACHINE_LOCKED             = 1271L,
        /// <summary>You can't access this shared folder because your organization's security policies block unauthenticated guest access. These policies help protect your PC from unsafe or malicious devices on the network.</summary>
        ERROR_SMB_GUEST_LOGON_BLOCKED    = 1272L,
        /// <summary>An application-defined callback gave invalid data when called.</summary>
        ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273L,
        /// <summary>The group policy framework should call the extension in the synchronous foreground policy refresh.</summary>
        ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274L,
        /// <summary>This driver has been blocked from loading</summary>
        ERROR_DRIVER_BLOCKED             = 1275L,
        /// <summary>A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's executable image.</summary>
        ERROR_INVALID_IMPORT_OF_NON_DLL  = 1276L,
        /// <summary>Windows cannot open this program since it has been disabled.</summary>
        ERROR_ACCESS_DISABLED_WEBBLADE   = 1277L,
        /// <summary>Windows cannot open this program because the license enforcement system has been tampered with or become corrupted.</summary>
        ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278L,
        /// <summary>A transaction recover failed.</summary>
        ERROR_RECOVERY_FAILURE           = 1279L,
        /// <summary>The current thread has already been converted to a fiber.</summary>
        ERROR_ALREADY_FIBER              = 1280L,
        /// <summary>The current thread has already been converted from a fiber.</summary>
        ERROR_ALREADY_THREAD             = 1281L,
        /// <summary>The system detected an overrun of a stack-based buffer in this application. This overrun could potentially allow a malicious user to gain control of this application.</summary>
        ERROR_STACK_BUFFER_OVERRUN       = 1282L,
        /// <summary>Data present in one of the parameters is more than the function can operate on.</summary>
        ERROR_PARAMETER_QUOTA_EXCEEDED   = 1283L,
        /// <summary>An attempt to do an operation on a debug object failed because the object is in the process of being deleted.</summary>
        ERROR_DEBUGGER_INACTIVE          = 1284L,
        /// <summary>An attempt to delay-load a .dll or get a function address in a delay-loaded .dll failed.</summary>
        ERROR_DELAY_LOAD_FAILED          = 1285L,
        /// <summary>%1 is a 16-bit application. You do not have permissions to execute 16-bit applications. Check your permissions with your system administrator.</summary>
        ERROR_VDM_DISALLOWED             = 1286L,
        /// <summary>Insufficient information exists to identify the cause of failure.</summary>
        ERROR_UNIDENTIFIED_ERROR         = 1287L,
        /// <summary>The parameter passed to a C runtime function is incorrect.</summary>
        ERROR_INVALID_CRUNTIME_PARAMETER = 1288L,
        /// <summary>The operation occurred beyond the valid data length of the file.</summary>
        ERROR_BEYOND_VDL                 = 1289L,
        /// <summary>The service start failed since one or more services in the same process have an incompatible service SID type setting. A service with restricted service SID type can only coexist in the same process with other services with a restricted SID type. If the service SID type for this service was just configured, the hosting process must be restarted in order to start this service.</summary>
        ERROR_INCOMPATIBLE_SERVICE_SID_TYPE = 1290L,
        /// <summary>The process hosting the driver for this device has been terminated.</summary>
        ERROR_DRIVER_PROCESS_TERMINATED  = 1291L,
        /// <summary>An operation attempted to exceed an implementation-defined limit.</summary>
        ERROR_IMPLEMENTATION_LIMIT       = 1292L,
        /// <summary>Either the target process, or the target thread's containing process, is a protected process.</summary>
        ERROR_PROCESS_IS_PROTECTED       = 1293L,
        /// <summary>The service notification client is lagging too far behind the current state of services in the machine.</summary>
        ERROR_SERVICE_NOTIFY_CLIENT_LAGGING = 1294L,
        /// <summary>The requested file operation failed because the storage quota was exceeded. To free up disk space, move files to a different location or delete unnecessary files. For more information, contact your system administrator.</summary>
        ERROR_DISK_QUOTA_EXCEEDED        = 1295L,
        /// <summary>The requested file operation failed because the storage policy blocks that type of file. For more information, contact your system administrator.</summary>
        ERROR_CONTENT_BLOCKED            = 1296L,
        /// <summary>A privilege that the service requires to function properly does not exist in the service account configuration. You may use the Services Microsoft Management Console (MMC) snap-in (services.msc) and the Local Security Settings MMC snap-in (secpol.msc) to view the service configuration and the account configuration.</summary>
        ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE = 1297L,
        /// <summary>A thread involved in this operation appears to be unresponsive.</summary>
        ERROR_APP_HANG                   = 1298L,
        /// <summary>Indicates a particular Security ID may not be assigned as the label of an object.</summary>
        ERROR_INVALID_LABEL              = 1299L,
        /// <summary>Not all privileges or groups referenced are assigned to the caller.</summary>
        ERROR_NOT_ALL_ASSIGNED           = 1300L,
        /// <summary>Some mapping between account names and security IDs was not done.</summary>
        ERROR_SOME_NOT_MAPPED            = 1301L,
        /// <summary>No system quota limits are specifically set for this account.</summary>
        ERROR_NO_QUOTAS_FOR_ACCOUNT      = 1302L,
        /// <summary>No encryption key is available. A well-known encryption key was returned.</summary>
        ERROR_LOCAL_USER_SESSION_KEY     = 1303L,
        /// <summary>The password is too complex to be converted to a LAN Manager password. The LAN Manager password returned is a NULL string.</summary>
        ERROR_NULL_LM_PASSWORD           = 1304L,
        /// <summary>The revision level is unknown.</summary>
        ERROR_UNKNOWN_REVISION           = 1305L,
        /// <summary>Indicates two revision levels are incompatible.</summary>
        ERROR_REVISION_MISMATCH          = 1306L,
        /// <summary>This security ID may not be assigned as the owner of this object.</summary>
        ERROR_INVALID_OWNER              = 1307L,
        /// <summary>This security ID may not be assigned as the primary group of an object.</summary>
        ERROR_INVALID_PRIMARY_GROUP      = 1308L,
        /// <summary>An attempt has been made to operate on an impersonation token by a thread that is not currently impersonating a client.</summary>
        ERROR_NO_IMPERSONATION_TOKEN     = 1309L,
        /// <summary>The group may not be disabled.</summary>
        ERROR_CANT_DISABLE_MANDATORY     = 1310L,
        /// <summary>There are currently no logon servers available to service the logon request.</summary>
        ERROR_NO_LOGON_SERVERS           = 1311L,
        /// <summary>A specified logon session does not exist. It may already have been terminated.</summary>
        ERROR_NO_SUCH_LOGON_SESSION      = 1312L,
        /// <summary>A specified privilege does not exist.</summary>
        ERROR_NO_SUCH_PRIVILEGE          = 1313L,
        /// <summary>A required privilege is not held by the client.</summary>
        ERROR_PRIVILEGE_NOT_HELD         = 1314L,
        /// <summary>The name provided is not a properly formed account name.</summary>
        ERROR_INVALID_ACCOUNT_NAME       = 1315L,
        /// <summary>The specified account already exists.</summary>
        ERROR_USER_EXISTS                = 1316L,
        /// <summary>The specified account does not exist.</summary>
        ERROR_NO_SUCH_USER               = 1317L,
        /// <summary>The specified group already exists.</summary>
        ERROR_GROUP_EXISTS               = 1318L,
        /// <summary>The specified group does not exist.</summary>
        ERROR_NO_SUCH_GROUP              = 1319L,
        /// <summary>Either the specified user account is already a member of the specified group, or the specified group cannot be deleted because it contains a member.</summary>
        ERROR_MEMBER_IN_GROUP            = 1320L,
        /// <summary>The specified user account is not a member of the specified group account.</summary>
        ERROR_MEMBER_NOT_IN_GROUP        = 1321L,
        /// <summary>This operation is disallowed as it could result in an administration account being disabled, deleted or unable to logon.</summary>
        ERROR_LAST_ADMIN                 = 1322L,
        /// <summary>Unable to update the password. The value provided as the current password is incorrect.</summary>
        ERROR_WRONG_PASSWORD             = 1323L,
        /// <summary>Unable to update the password. The value provided for the new password contains values that are not allowed in passwords.</summary>
        ERROR_ILL_FORMED_PASSWORD        = 1324L,
        /// <summary>Unable to update the password. The value provided for the new password does not meet the length, complexity, or history requirements of the domain.</summary>
        ERROR_PASSWORD_RESTRICTION       = 1325L,
        /// <summary>The user name or password is incorrect.</summary>
        ERROR_LOGON_FAILURE              = 1326L,
        /// <summary>Account restrictions are preventing this user from signing in. For example: blank passwords aren't allowed, sign-in times are limited, or a policy restriction has been enforced.</summary>
        ERROR_ACCOUNT_RESTRICTION        = 1327L,
        /// <summary>Your account has time restrictions that keep you from signing in right now.</summary>
        ERROR_INVALID_LOGON_HOURS        = 1328L,
        /// <summary>This user isn't allowed to sign in to this computer.</summary>
        ERROR_INVALID_WORKSTATION        = 1329L,
        /// <summary>The password for this account has expired.</summary>
        ERROR_PASSWORD_EXPIRED           = 1330L,
        /// <summary>This user can't sign in because this account is currently disabled.</summary>
        ERROR_ACCOUNT_DISABLED           = 1331L,
        /// <summary>No mapping between account names and security IDs was done.</summary>
        ERROR_NONE_MAPPED                = 1332L,
        /// <summary>Too many local user identifiers (LUIDs) were requested at one time.</summary>
        ERROR_TOO_MANY_LUIDS_REQUESTED   = 1333L,
        /// <summary>No more local user identifiers (LUIDs) are available.</summary>
        ERROR_LUIDS_EXHAUSTED            = 1334L,
        /// <summary>The subauthority part of a security ID is invalid for this particular use.</summary>
        ERROR_INVALID_SUB_AUTHORITY      = 1335L,
        /// <summary>The access control list (ACL) structure is invalid.</summary>
        ERROR_INVALID_ACL                = 1336L,
        /// <summary>The security ID structure is invalid.</summary>
        ERROR_INVALID_SID                = 1337L,
        /// <summary>The security descriptor structure is invalid.</summary>
        ERROR_INVALID_SECURITY_DESCR     = 1338L,
        /// <summary>The inherited access control list (ACL) or access control entry (ACE) could not be built.</summary>
        ERROR_BAD_INHERITANCE_ACL        = 1340L,
        /// <summary>The server is currently disabled.</summary>
        ERROR_SERVER_DISABLED            = 1341L,
        /// <summary>The server is currently enabled.</summary>
        ERROR_SERVER_NOT_DISABLED        = 1342L,
        /// <summary>The value provided was an invalid value for an identifier authority.</summary>
        ERROR_INVALID_ID_AUTHORITY       = 1343L,
        /// <summary>No more memory is available for security information updates.</summary>
        ERROR_ALLOTTED_SPACE_EXCEEDED    = 1344L,
        /// <summary>The specified attributes are invalid, or incompatible with the attributes for the group as a whole.</summary>
        ERROR_INVALID_GROUP_ATTRIBUTES   = 1345L,
        /// <summary>Either a required impersonation level was not provided, or the provided impersonation level is invalid.</summary>
        ERROR_BAD_IMPERSONATION_LEVEL    = 1346L,
        /// <summary>Cannot open an anonymous level security token.</summary>
        ERROR_CANT_OPEN_ANONYMOUS        = 1347L,
        /// <summary>The validation information class requested was invalid.</summary>
        ERROR_BAD_VALIDATION_CLASS       = 1348L,
        /// <summary>The type of the token is inappropriate for its attempted use.</summary>
        ERROR_BAD_TOKEN_TYPE             = 1349L,
        /// <summary>Unable to perform a security operation on an object that has no associated security.</summary>
        ERROR_NO_SECURITY_ON_OBJECT      = 1350L,
        /// <summary>Configuration information could not be read from the domain controller, either because the machine is unavailable, or access has been denied.</summary>
        ERROR_CANT_ACCESS_DOMAIN_INFO    = 1351L,
        /// <summary>The security account manager (SAM) or local security authority (LSA) server was in the wrong state to perform the security operation.</summary>
        ERROR_INVALID_SERVER_STATE       = 1352L,
        /// <summary>The domain was in the wrong state to perform the security operation.</summary>
        ERROR_INVALID_DOMAIN_STATE       = 1353L,
        /// <summary>This operation is only allowed for the Primary Domain Controller of the domain.</summary>
        ERROR_INVALID_DOMAIN_ROLE        = 1354L,
        /// <summary>The specified domain either does not exist or could not be contacted.</summary>
        ERROR_NO_SUCH_DOMAIN             = 1355L,
        /// <summary>The specified domain already exists.</summary>
        ERROR_DOMAIN_EXISTS              = 1356L,
        /// <summary>An attempt was made to exceed the limit on the number of domains per server.</summary>
        ERROR_DOMAIN_LIMIT_EXCEEDED      = 1357L,
        /// <summary>Unable to complete the requested operation because of either a catastrophic media failure or a data structure corruption on the disk.</summary>
        ERROR_INTERNAL_DB_CORRUPTION     = 1358L,
        /// <summary>An internal error occurred.</summary>
        ERROR_INTERNAL_ERROR             = 1359L,
        /// <summary>Generic access types were contained in an access mask which should already be mapped to nongeneric types.</summary>
        ERROR_GENERIC_NOT_MAPPED         = 1360L,
        /// <summary>A security descriptor is not in the right format (absolute or self-relative).</summary>
        ERROR_BAD_DESCRIPTOR_FORMAT      = 1361L,
        /// <summary>The requested action is restricted for use by logon processes only. The calling process has not registered as a logon process.</summary>
        ERROR_NOT_LOGON_PROCESS          = 1362L,
        /// <summary>Cannot start a new logon session with an ID that is already in use.</summary>
        ERROR_LOGON_SESSION_EXISTS       = 1363L,
        /// <summary>A specified authentication package is unknown.</summary>
        ERROR_NO_SUCH_PACKAGE            = 1364L,
        /// <summary>The logon session is not in a state that is consistent with the requested operation.</summary>
        ERROR_BAD_LOGON_SESSION_STATE    = 1365L,
        /// <summary>The logon session ID is already in use.</summary>
        ERROR_LOGON_SESSION_COLLISION    = 1366L,
        /// <summary>A logon request contained an invalid logon type value.</summary>
        ERROR_INVALID_LOGON_TYPE         = 1367L,
        /// <summary>Unable to impersonate using a named pipe until data has been read from that pipe.</summary>
        ERROR_CANNOT_IMPERSONATE         = 1368L,
        /// <summary>The transaction state of a registry subtree is incompatible with the requested operation.</summary>
        ERROR_RXACT_INVALID_STATE        = 1369L,
        /// <summary>An internal security database corruption has been encountered.</summary>
        ERROR_RXACT_COMMIT_FAILURE       = 1370L,
        /// <summary>Cannot perform this operation on built-in accounts.</summary>
        ERROR_SPECIAL_ACCOUNT            = 1371L,
        /// <summary>Cannot perform this operation on this built-in special group.</summary>
        ERROR_SPECIAL_GROUP              = 1372L,
        /// <summary>Cannot perform this operation on this built-in special user.</summary>
        ERROR_SPECIAL_USER               = 1373L,
        /// <summary>The user cannot be removed from a group because the group is currently the user's primary group.</summary>
        ERROR_MEMBERS_PRIMARY_GROUP      = 1374L,
        /// <summary>The token is already in use as a primary token.</summary>
        ERROR_TOKEN_ALREADY_IN_USE       = 1375L,
        /// <summary>The specified local group does not exist.</summary>
        ERROR_NO_SUCH_ALIAS              = 1376L,
        /// <summary>The specified account name is not a member of the group.</summary>
        ERROR_MEMBER_NOT_IN_ALIAS        = 1377L,
        /// <summary>The specified account name is already a member of the group.</summary>
        ERROR_MEMBER_IN_ALIAS            = 1378L,
        /// <summary>The specified local group already exists.</summary>
        ERROR_ALIAS_EXISTS               = 1379L,
        /// <summary>Logon failure: the user has not been granted the requested logon type at this computer.</summary>
        ERROR_LOGON_NOT_GRANTED          = 1380L,
        /// <summary>The maximum number of secrets that may be stored in a single system has been exceeded.</summary>
        ERROR_TOO_MANY_SECRETS           = 1381L,
        /// <summary>The length of a secret exceeds the maximum length allowed.</summary>
        ERROR_SECRET_TOO_LONG            = 1382L,
        /// <summary>The local security authority database contains an internal inconsistency.</summary>
        ERROR_INTERNAL_DB_ERROR          = 1383L,
        /// <summary>During a logon attempt, the user's security context accumulated too many security IDs.</summary>
        ERROR_TOO_MANY_CONTEXT_IDS       = 1384L,
        /// <summary>Logon failure: the user has not been granted the requested logon type at this computer.</summary>
        ERROR_LOGON_TYPE_NOT_GRANTED     = 1385L,
        /// <summary>A cross-encrypted password is necessary to change a user password.</summary>
        ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386L,
        /// <summary>A member could not be added to or removed from the local group because the member does not exist.</summary>
        ERROR_NO_SUCH_MEMBER             = 1387L,
        /// <summary>A new member could not be added to a local group because the member has the wrong account type.</summary>
        ERROR_INVALID_MEMBER             = 1388L,
        /// <summary>Too many security IDs have been specified.</summary>
        ERROR_TOO_MANY_SIDS              = 1389L,
        /// <summary>A cross-encrypted password is necessary to change this user password.</summary>
        ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390L,
        /// <summary>Indicates an ACL contains no inheritable components.</summary>
        ERROR_NO_INHERITANCE             = 1391L,
        /// <summary>The file or directory is corrupted and unreadable.</summary>
        ERROR_FILE_CORRUPT               = 1392L,
        /// <summary>The disk structure is corrupted and unreadable.</summary>
        ERROR_DISK_CORRUPT               = 1393L,
        /// <summary>There is no user session key for the specified logon session.</summary>
        ERROR_NO_USER_SESSION_KEY        = 1394L,
        /// <summary>The service being accessed is licensed for a particular number of connections. No more connections can be made to the service at this time because there are already as many connections as the service can accept.</summary>
        ERROR_LICENSE_QUOTA_EXCEEDED     = 1395L,
        /// <summary>The target account name is incorrect.</summary>
        ERROR_WRONG_TARGET_NAME          = 1396L,
        /// <summary>Mutual Authentication failed. The server's password is out of date at the domain controller.</summary>
        ERROR_MUTUAL_AUTH_FAILED         = 1397L,
        /// <summary>There is a time and/or date difference between the client and server.</summary>
        ERROR_TIME_SKEW                  = 1398L,
        /// <summary>This operation cannot be performed on the current domain.</summary>
        ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399L,
        /// <summary>Invalid window handle.</summary>
        ERROR_INVALID_WINDOW_HANDLE      = 1400L,
        /// <summary>Invalid menu handle.</summary>
        ERROR_INVALID_MENU_HANDLE        = 1401L,
        /// <summary>Invalid cursor handle.</summary>
        ERROR_INVALID_CURSOR_HANDLE      = 1402L,
        /// <summary>Invalid accelerator table handle.</summary>
        ERROR_INVALID_ACCEL_HANDLE       = 1403L,
        /// <summary>Invalid hook handle.</summary>
        ERROR_INVALID_HOOK_HANDLE        = 1404L,
        /// <summary>Invalid handle to a multiple-window position structure.</summary>
        ERROR_INVALID_DWP_HANDLE         = 1405L,
        /// <summary>Cannot create a top-level child window.</summary>
        ERROR_TLW_WITH_WSCHILD           = 1406L,
        /// <summary>Cannot find window class.</summary>
        ERROR_CANNOT_FIND_WND_CLASS      = 1407L,
        /// <summary>Invalid window; it belongs to other thread.</summary>
        ERROR_WINDOW_OF_OTHER_THREAD     = 1408L,
        /// <summary>Hot key is already registered.</summary>
        ERROR_HOTKEY_ALREADY_REGISTERED  = 1409L,
        /// <summary>Class already exists.</summary>
        ERROR_CLASS_ALREADY_EXISTS       = 1410L,
        /// <summary>Class does not exist.</summary>
        ERROR_CLASS_DOES_NOT_EXIST       = 1411L,
        /// <summary>Class still has open windows.</summary>
        ERROR_CLASS_HAS_WINDOWS          = 1412L,
        /// <summary>Invalid index.</summary>
        ERROR_INVALID_INDEX              = 1413L,
        /// <summary>Invalid icon handle.</summary>
        ERROR_INVALID_ICON_HANDLE        = 1414L,
        /// <summary>Using private DIALOG window words.</summary>
        ERROR_PRIVATE_DIALOG_INDEX       = 1415L,
        /// <summary>The list box identifier was not found.</summary>
        ERROR_LISTBOX_ID_NOT_FOUND       = 1416L,
        /// <summary>No wildcards were found.</summary>
        ERROR_NO_WILDCARD_CHARACTERS     = 1417L,
        /// <summary>Thread does not have a clipboard open.</summary>
        ERROR_CLIPBOARD_NOT_OPEN         = 1418L,
        /// <summary>Hot key is not registered.</summary>
        ERROR_HOTKEY_NOT_REGISTERED      = 1419L,
        /// <summary>The window is not a valid dialog window.</summary>
        ERROR_WINDOW_NOT_DIALOG          = 1420L,
        /// <summary>Control ID not found.</summary>
        ERROR_CONTROL_ID_NOT_FOUND       = 1421L,
        /// <summary>Invalid message for a combo box because it does not have an edit control.</summary>
        ERROR_INVALID_COMBOBOX_MESSAGE   = 1422L,
        /// <summary>The window is not a combo box.</summary>
        ERROR_WINDOW_NOT_COMBOBOX        = 1423L,
        /// <summary>Height must be less than 256.</summary>
        ERROR_INVALID_EDIT_HEIGHT        = 1424L,
        /// <summary>Invalid device context (DC) handle.</summary>
        ERROR_DC_NOT_FOUND               = 1425L,
        /// <summary>Invalid hook procedure type.</summary>
        ERROR_INVALID_HOOK_FILTER        = 1426L,
        /// <summary>Invalid hook procedure.</summary>
        ERROR_INVALID_FILTER_PROC        = 1427L,
        /// <summary>Cannot set nonlocal hook without a module handle.</summary>
        ERROR_HOOK_NEEDS_HMOD            = 1428L,
        /// <summary>This hook procedure can only be set globally.</summary>
        ERROR_GLOBAL_ONLY_HOOK           = 1429L,
        /// <summary>The journal hook procedure is already installed.</summary>
        ERROR_JOURNAL_HOOK_SET           = 1430L,
        /// <summary>The hook procedure is not installed.</summary>
        ERROR_HOOK_NOT_INSTALLED         = 1431L,
        /// <summary>Invalid message for single-selection list box.</summary>
        ERROR_INVALID_LB_MESSAGE         = 1432L,
        /// <summary>LB_SETCOUNT sent to non-lazy list box.</summary>
        ERROR_SETCOUNT_ON_BAD_LB         = 1433L,
        /// <summary>This list box does not support tab stops.</summary>
        ERROR_LB_WITHOUT_TABSTOPS        = 1434L,
        /// <summary>Cannot destroy object created by another thread.</summary>
        ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435L,
        /// <summary>Child windows cannot have menus.</summary>
        ERROR_CHILD_WINDOW_MENU          = 1436L,
        /// <summary>The window does not have a system menu.</summary>
        ERROR_NO_SYSTEM_MENU             = 1437L,
        /// <summary>Invalid message box style.</summary>
        ERROR_INVALID_MSGBOX_STYLE       = 1438L,
        /// <summary>Invalid system-wide (SPI_*) parameter.</summary>
        ERROR_INVALID_SPI_VALUE          = 1439L,
        /// <summary>Screen already locked.</summary>
        ERROR_SCREEN_ALREADY_LOCKED      = 1440L,
        /// <summary>All handles to windows in a multiple-window position structure must have the same parent.</summary>
        ERROR_HWNDS_HAVE_DIFF_PARENT     = 1441L,
        /// <summary>The window is not a child window.</summary>
        ERROR_NOT_CHILD_WINDOW           = 1442L,
        /// <summary>Invalid GW_* command.</summary>
        ERROR_INVALID_GW_COMMAND         = 1443L,
        /// <summary>Invalid thread identifier.</summary>
        ERROR_INVALID_THREAD_ID          = 1444L,
        /// <summary>Cannot process a message from a window that is not a multiple document interface (MDI) window.</summary>
        ERROR_NON_MDICHILD_WINDOW        = 1445L,
        /// <summary>Popup menu already active.</summary>
        ERROR_POPUP_ALREADY_ACTIVE       = 1446L,
        /// <summary>The window does not have scroll bars.</summary>
        ERROR_NO_SCROLLBARS              = 1447L,
        /// <summary>Scroll bar range cannot be greater than MAXLONG.</summary>
        ERROR_INVALID_SCROLLBAR_RANGE    = 1448L,
        /// <summary>Cannot show or remove the window in the way specified.</summary>
        ERROR_INVALID_SHOWWIN_COMMAND    = 1449L,
        /// <summary>Insufficient system resources exist to complete the requested service.</summary>
        ERROR_NO_SYSTEM_RESOURCES        = 1450L,
        /// <summary>Insufficient system resources exist to complete the requested service.</summary>
        ERROR_NONPAGED_SYSTEM_RESOURCES  = 1451L,
        /// <summary>Insufficient system resources exist to complete the requested service.</summary>
        ERROR_PAGED_SYSTEM_RESOURCES     = 1452L,
        /// <summary>Insufficient quota to complete the requested service.</summary>
        ERROR_WORKING_SET_QUOTA          = 1453L,
        /// <summary>Insufficient quota to complete the requested service.</summary>
        ERROR_PAGEFILE_QUOTA             = 1454L,
        /// <summary>The paging file is too small for this operation to complete.</summary>
        ERROR_COMMITMENT_LIMIT           = 1455L,
        /// <summary>A menu item was not found.</summary>
        ERROR_MENU_ITEM_NOT_FOUND        = 1456L,
        /// <summary>Invalid keyboard layout handle.</summary>
        ERROR_INVALID_KEYBOARD_HANDLE    = 1457L,
        /// <summary>Hook type not allowed.</summary>
        ERROR_HOOK_TYPE_NOT_ALLOWED      = 1458L,
        /// <summary>This operation requires an interactive window station.</summary>
        ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459L,
        /// <summary>This operation returned because the timeout period expired.</summary>
        ERROR_TIMEOUT                    = 1460L,
        /// <summary>Invalid monitor handle.</summary>
        ERROR_INVALID_MONITOR_HANDLE     = 1461L,
        /// <summary>Incorrect size argument.</summary>
        ERROR_INCORRECT_SIZE             = 1462L,
        /// <summary>The symbolic link cannot be followed because its type is disabled.</summary>
        ERROR_SYMLINK_CLASS_DISABLED     = 1463L,
        /// <summary>This application does not support the current operation on symbolic links.</summary>
        ERROR_SYMLINK_NOT_SUPPORTED      = 1464L,
        /// <summary>Windows was unable to parse the requested XML data.</summary>
        ERROR_XML_PARSE_ERROR            = 1465L,
        /// <summary>An error was encountered while processing an XML digital signature.</summary>
        ERROR_XMLDSIG_ERROR              = 1466L,
        /// <summary>This application must be restarted.</summary>
        ERROR_RESTART_APPLICATION        = 1467L,
        /// <summary>The caller made the connection request in the wrong routing compartment.</summary>
        ERROR_WRONG_COMPARTMENT          = 1468L,
        /// <summary>There was an AuthIP failure when attempting to connect to the remote host.</summary>
        ERROR_AUTHIP_FAILURE             = 1469L,
        /// <summary>Insufficient NVRAM resources exist to complete the requested service. A reboot might be required.</summary>
        ERROR_NO_NVRAM_RESOURCES         = 1470L,
        /// <summary>Unable to finish the requested operation because the specified process is not a GUI process.</summary>
        ERROR_NOT_GUI_PROCESS            = 1471L,
        /// <summary>The event log file is corrupted.</summary>
        ERROR_EVENTLOG_FILE_CORRUPT      = 1500L,
        /// <summary>No event log file could be opened, so the event logging service did not start.</summary>
        ERROR_EVENTLOG_CANT_START        = 1501L,
        /// <summary>The event log file is full.</summary>
        ERROR_LOG_FILE_FULL              = 1502L,
        /// <summary>The event log file has changed between read operations.</summary>
        ERROR_EVENTLOG_FILE_CHANGED      = 1503L,
        /// <summary>The specified Job already has a container assigned to it.</summary>
        ERROR_CONTAINER_ASSIGNED         = 1504L,
        /// <summary>The specified Job does not have a container assigned to it.</summary>
        ERROR_JOB_NO_CONTAINER           = 1505L,
        /// <summary>The specified task name is invalid.</summary>
        ERROR_INVALID_TASK_NAME          = 1550L,
        /// <summary>The specified task index is invalid.</summary>
        ERROR_INVALID_TASK_INDEX         = 1551L,
        /// <summary>The specified thread is already joining a task.</summary>
        ERROR_THREAD_ALREADY_IN_TASK     = 1552L,
        /// <summary>The Windows Installer Service could not be accessed. This can occur if the Windows Installer is not correctly installed. Contact your support personnel for assistance.</summary>
        ERROR_INSTALL_SERVICE_FAILURE    = 1601L,
        /// <summary>User cancelled installation.</summary>
        ERROR_INSTALL_USEREXIT           = 1602L,
        /// <summary>Fatal error during installation.</summary>
        ERROR_INSTALL_FAILURE            = 1603L,
        /// <summary>Installation suspended, incomplete.</summary>
        ERROR_INSTALL_SUSPEND            = 1604L,
        /// <summary>This action is only valid for products that are currently installed.</summary>
        ERROR_UNKNOWN_PRODUCT            = 1605L,
        /// <summary>Feature ID not registered.</summary>
        ERROR_UNKNOWN_FEATURE            = 1606L,
        /// <summary>Component ID not registered.</summary>
        ERROR_UNKNOWN_COMPONENT          = 1607L,
        /// <summary>Unknown property.</summary>
        ERROR_UNKNOWN_PROPERTY           = 1608L,
        /// <summary>Handle is in an invalid state.</summary>
        ERROR_INVALID_HANDLE_STATE       = 1609L,
        /// <summary>The configuration data for this product is corrupt. Contact your support personnel.</summary>
        ERROR_BAD_CONFIGURATION          = 1610L,
        /// <summary>Component qualifier not present.</summary>
        ERROR_INDEX_ABSENT               = 1611L,
        /// <summary>The installation source for this product is not available. Verify that the source exists and that you can access it.</summary>
        ERROR_INSTALL_SOURCE_ABSENT      = 1612L,
        /// <summary>This installation package cannot be installed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.</summary>
        ERROR_INSTALL_PACKAGE_VERSION    = 1613L,
        /// <summary>Product is uninstalled.</summary>
        ERROR_PRODUCT_UNINSTALLED        = 1614L,
        /// <summary>SQL query syntax invalid or unsupported.</summary>
        ERROR_BAD_QUERY_SYNTAX           = 1615L,
        /// <summary>Record field does not exist.</summary>
        ERROR_INVALID_FIELD              = 1616L,
        /// <summary>The device has been removed.</summary>
        ERROR_DEVICE_REMOVED             = 1617L,
        /// <summary>Another installation is already in progress. Complete that installation before proceeding with this install.</summary>
        ERROR_INSTALL_ALREADY_RUNNING    = 1618L,
        /// <summary>This installation package could not be opened. Verify that the package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer package.</summary>
        ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619L,
        /// <summary>This installation package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer package.</summary>
        ERROR_INSTALL_PACKAGE_INVALID    = 1620L,
        /// <summary>There was an error starting the Windows Installer service user interface. Contact your support personnel.</summary>
        ERROR_INSTALL_UI_FAILURE         = 1621L,
        /// <summary>Error opening installation log file. Verify that the specified log file location exists and that you can write to it.</summary>
        ERROR_INSTALL_LOG_FAILURE        = 1622L,
        /// <summary>The language of this installation package is not supported by your system.</summary>
        ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623L,
        /// <summary>Error applying transforms. Verify that the specified transform paths are valid.</summary>
        ERROR_INSTALL_TRANSFORM_FAILURE  = 1624L,
        /// <summary>This installation is forbidden by system policy. Contact your system administrator.</summary>
        ERROR_INSTALL_PACKAGE_REJECTED   = 1625L,
        /// <summary>Function could not be executed.</summary>
        ERROR_FUNCTION_NOT_CALLED        = 1626L,
        /// <summary>Function failed during execution.</summary>
        ERROR_FUNCTION_FAILED            = 1627L,
        /// <summary>Invalid or unknown table specified.</summary>
        ERROR_INVALID_TABLE              = 1628L,
        /// <summary>Data supplied is of wrong type.</summary>
        ERROR_DATATYPE_MISMATCH          = 1629L,
        /// <summary>Data of this type is not supported.</summary>
        ERROR_UNSUPPORTED_TYPE           = 1630L,
        /// <summary>The Windows Installer service failed to start. Contact your support personnel.</summary>
        ERROR_CREATE_FAILED              = 1631L,
        /// <summary>The Temp folder is on a drive that is full or is inaccessible. Free up space on the drive or verify that you have write permission on the Temp folder.</summary>
        ERROR_INSTALL_TEMP_UNWRITABLE    = 1632L,
        /// <summary>This installation package is not supported by this processor type. Contact your product vendor.</summary>
        ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633L,
        /// <summary>Component not used on this computer.</summary>
        ERROR_INSTALL_NOTUSED            = 1634L,
        /// <summary>This update package could not be opened. Verify that the update package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer update package.</summary>
        ERROR_PATCH_PACKAGE_OPEN_FAILED  = 1635L,
        /// <summary>This update package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer update package.</summary>
        ERROR_PATCH_PACKAGE_INVALID      = 1636L,
        /// <summary>This update package cannot be processed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.</summary>
        ERROR_PATCH_PACKAGE_UNSUPPORTED  = 1637L,
        /// <summary>Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs on the Control Panel.</summary>
        ERROR_PRODUCT_VERSION            = 1638L,
        /// <summary>Invalid command line argument. Consult the Windows Installer SDK for detailed command line help.</summary>
        ERROR_INVALID_COMMAND_LINE       = 1639L,
        /// <summary>Only administrators have permission to add, remove, or configure server software during a Terminal services remote session. If you want to install or configure software on the server, contact your network administrator.</summary>
        ERROR_INSTALL_REMOTE_DISALLOWED  = 1640L,
        /// <summary>The requested operation completed successfully. The system will be restarted so the changes can take effect.</summary>
        ERROR_SUCCESS_REBOOT_INITIATED   = 1641L,
        /// <summary>The upgrade cannot be installed by the Windows Installer service because the program to be upgraded may be missing, or the upgrade may update a different version of the program. Verify that the program to be upgraded exists on your computer and that you have the correct upgrade.</summary>
        ERROR_PATCH_TARGET_NOT_FOUND     = 1642L,
        /// <summary>The update package is not permitted by software restriction policy.</summary>
        ERROR_PATCH_PACKAGE_REJECTED     = 1643L,
        /// <summary>One or more customizations are not permitted by software restriction policy.</summary>
        ERROR_INSTALL_TRANSFORM_REJECTED = 1644L,
        /// <summary>The Windows Installer does not permit installation from a Remote Desktop Connection.</summary>
        ERROR_INSTALL_REMOTE_PROHIBITED  = 1645L,
        /// <summary>Uninstallation of the update package is not supported.</summary>
        ERROR_PATCH_REMOVAL_UNSUPPORTED  = 1646L,
        /// <summary>The update is not applied to this product.</summary>
        ERROR_UNKNOWN_PATCH              = 1647L,
        /// <summary>No valid sequence could be found for the set of updates.</summary>
        ERROR_PATCH_NO_SEQUENCE          = 1648L,
        /// <summary>Update removal was disallowed by policy.</summary>
        ERROR_PATCH_REMOVAL_DISALLOWED   = 1649L,
        /// <summary>The XML update data is invalid.</summary>
        ERROR_INVALID_PATCH_XML          = 1650L,
        /// <summary>Windows Installer does not permit updating of managed advertised products. At least one feature of the product must be installed before applying the update.</summary>
        ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT = 1651L,
        /// <summary>The Windows Installer service is not accessible in Safe Mode. Please try again when your computer is not in Safe Mode or you can use System Restore to return your machine to a previous good state.</summary>
        ERROR_INSTALL_SERVICE_SAFEBOOT   = 1652L,
        /// <summary>A fail fast exception occurred. Exception handlers will not be invoked and the process will be terminated immediately.</summary>
        ERROR_FAIL_FAST_EXCEPTION        = 1653L,
        /// <summary>The app that you are trying to run is not supported on this version of Windows.</summary>
        ERROR_INSTALL_REJECTED           = 1654L,
        /// <summary>The operation was blocked as the process prohibits dynamic code generation.</summary>
        ERROR_DYNAMIC_CODE_BLOCKED       = 1655L,
        /// <summary>The objects are not identical.</summary>
        ERROR_NOT_SAME_OBJECT            = 1656L,
        /// <summary>The string binding is invalid.</summary>
        RPC_S_INVALID_STRING_BINDING     = 1700L,
        /// <summary>The binding handle is not the correct type.</summary>
        RPC_S_WRONG_KIND_OF_BINDING      = 1701L,
        /// <summary>The binding handle is invalid.</summary>
        RPC_S_INVALID_BINDING            = 1702L,
        /// <summary>The RPC protocol sequence is not supported.</summary>
        RPC_S_PROTSEQ_NOT_SUPPORTED      = 1703L,
        /// <summary>The RPC protocol sequence is invalid.</summary>
        RPC_S_INVALID_RPC_PROTSEQ        = 1704L,
        /// <summary>The string universal unique identifier (UUID) is invalid.</summary>
        RPC_S_INVALID_STRING_UUID        = 1705L,
        /// <summary>The endpoint format is invalid.</summary>
        RPC_S_INVALID_ENDPOINT_FORMAT    = 1706L,
        /// <summary>The network address is invalid.</summary>
        RPC_S_INVALID_NET_ADDR           = 1707L,
        /// <summary>No endpoint was found.</summary>
        RPC_S_NO_ENDPOINT_FOUND          = 1708L,
        /// <summary>The timeout value is invalid.</summary>
        RPC_S_INVALID_TIMEOUT            = 1709L,
        /// <summary>The object universal unique identifier (UUID) was not found.</summary>
        RPC_S_OBJECT_NOT_FOUND           = 1710L,
        /// <summary>The object universal unique identifier (UUID) has already been registered.</summary>
        RPC_S_ALREADY_REGISTERED         = 1711L,
        /// <summary>The type universal unique identifier (UUID) has already been registered.</summary>
        RPC_S_TYPE_ALREADY_REGISTERED    = 1712L,
        /// <summary>The RPC server is already listening.</summary>
        RPC_S_ALREADY_LISTENING          = 1713L,
        /// <summary>No protocol sequences have been registered.</summary>
        RPC_S_NO_PROTSEQS_REGISTERED     = 1714L,
        /// <summary>The RPC server is not listening.</summary>
        RPC_S_NOT_LISTENING              = 1715L,
        /// <summary>The manager type is unknown.</summary>
        RPC_S_UNKNOWN_MGR_TYPE           = 1716L,
        /// <summary>The interface is unknown.</summary>
        RPC_S_UNKNOWN_IF                 = 1717L,
        /// <summary>There are no bindings.</summary>
        RPC_S_NO_BINDINGS                = 1718L,
        /// <summary>There are no protocol sequences.</summary>
        RPC_S_NO_PROTSEQS                = 1719L,
        /// <summary>The endpoint cannot be created.</summary>
        RPC_S_CANT_CREATE_ENDPOINT       = 1720L,
        /// <summary>Not enough resources are available to complete this operation.</summary>
        RPC_S_OUT_OF_RESOURCES           = 1721L,
        /// <summary>The RPC server is unavailable.</summary>
        RPC_S_SERVER_UNAVAILABLE         = 1722L,
        /// <summary>The RPC server is too busy to complete this operation.</summary>
        RPC_S_SERVER_TOO_BUSY            = 1723L,
        /// <summary>The network options are invalid.</summary>
        RPC_S_INVALID_NETWORK_OPTIONS    = 1724L,
        /// <summary>There are no remote procedure calls active on this thread.</summary>
        RPC_S_NO_CALL_ACTIVE             = 1725L,
        /// <summary>The remote procedure call failed.</summary>
        RPC_S_CALL_FAILED                = 1726L,
        /// <summary>The remote procedure call failed and did not execute.</summary>
        RPC_S_CALL_FAILED_DNE            = 1727L,
        /// <summary>A remote procedure call (RPC) protocol error occurred.</summary>
        RPC_S_PROTOCOL_ERROR             = 1728L,
        /// <summary>Access to the HTTP proxy is denied.</summary>
        RPC_S_PROXY_ACCESS_DENIED        = 1729L,
        /// <summary>The transfer syntax is not supported by the RPC server.</summary>
        RPC_S_UNSUPPORTED_TRANS_SYN      = 1730L,
        /// <summary>The universal unique identifier (UUID) type is not supported.</summary>
        RPC_S_UNSUPPORTED_TYPE           = 1732L,
        /// <summary>The tag is invalid.</summary>
        RPC_S_INVALID_TAG                = 1733L,
        /// <summary>The array bounds are invalid.</summary>
        RPC_S_INVALID_BOUND              = 1734L,
        /// <summary>The binding does not contain an entry name.</summary>
        RPC_S_NO_ENTRY_NAME              = 1735L,
        /// <summary>The name syntax is invalid.</summary>
        RPC_S_INVALID_NAME_SYNTAX        = 1736L,
        /// <summary>The name syntax is not supported.</summary>
        RPC_S_UNSUPPORTED_NAME_SYNTAX    = 1737L,
        /// <summary>No network address is available to use to construct a universal unique identifier (UUID).</summary>
        RPC_S_UUID_NO_ADDRESS            = 1739L,
        /// <summary>The endpoint is a duplicate.</summary>
        RPC_S_DUPLICATE_ENDPOINT         = 1740L,
        /// <summary>The authentication type is unknown.</summary>
        RPC_S_UNKNOWN_AUTHN_TYPE         = 1741L,
        /// <summary>The maximum number of calls is too small.</summary>
        RPC_S_MAX_CALLS_TOO_SMALL        = 1742L,
        /// <summary>The string is too long.</summary>
        RPC_S_STRING_TOO_LONG            = 1743L,
        /// <summary>The RPC protocol sequence was not found.</summary>
        RPC_S_PROTSEQ_NOT_FOUND          = 1744L,
        /// <summary>The procedure number is out of range.</summary>
        RPC_S_PROCNUM_OUT_OF_RANGE       = 1745L,
        /// <summary>The binding does not contain any authentication information.</summary>
        RPC_S_BINDING_HAS_NO_AUTH        = 1746L,
        /// <summary>The authentication service is unknown.</summary>
        RPC_S_UNKNOWN_AUTHN_SERVICE      = 1747L,
        /// <summary>The authentication level is unknown.</summary>
        RPC_S_UNKNOWN_AUTHN_LEVEL        = 1748L,
        /// <summary>The security context is invalid.</summary>
        RPC_S_INVALID_AUTH_IDENTITY      = 1749L,
        /// <summary>The authorization service is unknown.</summary>
        RPC_S_UNKNOWN_AUTHZ_SERVICE      = 1750L,
        /// <summary>The entry is invalid.</summary>
        EPT_S_INVALID_ENTRY              = 1751L,
        /// <summary>The server endpoint cannot perform the operation.</summary>
        EPT_S_CANT_PERFORM_OP            = 1752L,
        /// <summary>There are no more endpoints available from the endpoint mapper.</summary>
        EPT_S_NOT_REGISTERED             = 1753L,
        /// <summary>No interfaces have been exported.</summary>
        RPC_S_NOTHING_TO_EXPORT          = 1754L,
        /// <summary>The entry name is incomplete.</summary>
        RPC_S_INCOMPLETE_NAME            = 1755L,
        /// <summary>The version option is invalid.</summary>
        RPC_S_INVALID_VERS_OPTION        = 1756L,
        /// <summary>There are no more members.</summary>
        RPC_S_NO_MORE_MEMBERS            = 1757L,
        /// <summary>There is nothing to unexport.</summary>
        RPC_S_NOT_ALL_OBJS_UNEXPORTED    = 1758L,
        /// <summary>The interface was not found.</summary>
        RPC_S_INTERFACE_NOT_FOUND        = 1759L,
        /// <summary>The entry already exists.</summary>
        RPC_S_ENTRY_ALREADY_EXISTS       = 1760L,
        /// <summary>The entry is not found.</summary>
        RPC_S_ENTRY_NOT_FOUND            = 1761L,
        /// <summary>The name service is unavailable.</summary>
        RPC_S_NAME_SERVICE_UNAVAILABLE   = 1762L,
        /// <summary>The network address family is invalid.</summary>
        RPC_S_INVALID_NAF_ID             = 1763L,
        /// <summary>The requested operation is not supported.</summary>
        RPC_S_CANNOT_SUPPORT             = 1764L,
        /// <summary>No security context is available to allow impersonation.</summary>
        RPC_S_NO_CONTEXT_AVAILABLE       = 1765L,
        /// <summary>An internal error occurred in a remote procedure call (RPC).</summary>
        RPC_S_INTERNAL_ERROR             = 1766L,
        /// <summary>The RPC server attempted an integer division by zero.</summary>
        RPC_S_ZERO_DIVIDE                = 1767L,
        /// <summary>An addressing error occurred in the RPC server.</summary>
        RPC_S_ADDRESS_ERROR              = 1768L,
        /// <summary>A floating-point operation at the RPC server caused a division by zero.</summary>
        RPC_S_FP_DIV_ZERO                = 1769L,
        /// <summary>A floating-point underflow occurred at the RPC server.</summary>
        RPC_S_FP_UNDERFLOW               = 1770L,
        /// <summary>A floating-point overflow occurred at the RPC server.</summary>
        RPC_S_FP_OVERFLOW                = 1771L,
        /// <summary>The list of RPC servers available for the binding of auto handles has been exhausted.</summary>
        RPC_X_NO_MORE_ENTRIES            = 1772L,
        /// <summary>Unable to open the character translation table file.</summary>
        RPC_X_SS_CHAR_TRANS_OPEN_FAIL    = 1773L,
        /// <summary>The file containing the character translation table has fewer than 512 bytes.</summary>
        RPC_X_SS_CHAR_TRANS_SHORT_FILE   = 1774L,
        /// <summary>A null context handle was passed from the client to the host during a remote procedure call.</summary>
        RPC_X_SS_IN_NULL_CONTEXT         = 1775L,
        /// <summary>The context handle changed during a remote procedure call.</summary>
        RPC_X_SS_CONTEXT_DAMAGED         = 1777L,
        /// <summary>The binding handles passed to a remote procedure call do not match.</summary>
        RPC_X_SS_HANDLES_MISMATCH        = 1778L,
        /// <summary>The stub is unable to get the remote procedure call handle.</summary>
        RPC_X_SS_CANNOT_GET_CALL_HANDLE  = 1779L,
        /// <summary>A null reference pointer was passed to the stub.</summary>
        RPC_X_NULL_REF_POINTER           = 1780L,
        /// <summary>The enumeration value is out of range.</summary>
        RPC_X_ENUM_VALUE_OUT_OF_RANGE    = 1781L,
        /// <summary>The byte count is too small.</summary>
        RPC_X_BYTE_COUNT_TOO_SMALL       = 1782L,
        /// <summary>The stub received bad data.</summary>
        RPC_X_BAD_STUB_DATA              = 1783L,
        /// <summary>The supplied user buffer is not valid for the requested operation.</summary>
        ERROR_INVALID_USER_BUFFER        = 1784L,
        /// <summary>The disk media is not recognized. It may not be formatted.</summary>
        ERROR_UNRECOGNIZED_MEDIA         = 1785L,
        /// <summary>The workstation does not have a trust secret.</summary>
        ERROR_NO_TRUST_LSA_SECRET        = 1786L,
        /// <summary>The security database on the server does not have a computer account for this workstation trust relationship.</summary>
        ERROR_NO_TRUST_SAM_ACCOUNT       = 1787L,
        /// <summary>The trust relationship between the primary domain and the trusted domain failed.</summary>
        ERROR_TRUSTED_DOMAIN_FAILURE     = 1788L,
        /// <summary>The trust relationship between this workstation and the primary domain failed.</summary>
        ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789L,
        /// <summary>The network logon failed.</summary>
        ERROR_TRUST_FAILURE              = 1790L,
        /// <summary>A remote procedure call is already in progress for this thread.</summary>
        RPC_S_CALL_IN_PROGRESS           = 1791L,
        /// <summary>An attempt was made to logon, but the network logon service was not started.</summary>
        ERROR_NETLOGON_NOT_STARTED       = 1792L,
        /// <summary>The user's account has expired.</summary>
        ERROR_ACCOUNT_EXPIRED            = 1793L,
        /// <summary>The redirector is in use and cannot be unloaded.</summary>
        ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794L,
        /// <summary>The specified printer driver is already installed.</summary>
        ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795L,
        /// <summary>The specified port is unknown.</summary>
        ERROR_UNKNOWN_PORT               = 1796L,
        /// <summary>The printer driver is unknown.</summary>
        ERROR_UNKNOWN_PRINTER_DRIVER     = 1797L,
        /// <summary>The print processor is unknown.</summary>
        ERROR_UNKNOWN_PRINTPROCESSOR     = 1798L,
        /// <summary>The specified separator file is invalid.</summary>
        ERROR_INVALID_SEPARATOR_FILE     = 1799L,
        /// <summary>The specified priority is invalid.</summary>
        ERROR_INVALID_PRIORITY           = 1800L,
        /// <summary>The printer name is invalid.</summary>
        ERROR_INVALID_PRINTER_NAME       = 1801L,
        /// <summary>The printer already exists.</summary>
        ERROR_PRINTER_ALREADY_EXISTS     = 1802L,
        /// <summary>The printer command is invalid.</summary>
        ERROR_INVALID_PRINTER_COMMAND    = 1803L,
        /// <summary>The specified datatype is invalid.</summary>
        ERROR_INVALID_DATATYPE           = 1804L,
        /// <summary>The environment specified is invalid.</summary>
        ERROR_INVALID_ENVIRONMENT        = 1805L,
        /// <summary>There are no more bindings.</summary>
        RPC_S_NO_MORE_BINDINGS           = 1806L,
        /// <summary>The account used is an interdomain trust account. Use your global user account or local user account to access this server.</summary>
        ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807L,
        /// <summary>The account used is a computer account. Use your global user account or local user account to access this server.</summary>
        ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808L,
        /// <summary>The account used is a server trust account. Use your global user account or local user account to access this server.</summary>
        ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809L,
        /// <summary>The name or security ID (SID) of the domain specified is inconsistent with the trust information for that domain.</summary>
        ERROR_DOMAIN_TRUST_INCONSISTENT  = 1810L,
        /// <summary>The server is in use and cannot be unloaded.</summary>
        ERROR_SERVER_HAS_OPEN_HANDLES    = 1811L,
        /// <summary>The specified image file did not contain a resource section.</summary>
        ERROR_RESOURCE_DATA_NOT_FOUND    = 1812L,
        /// <summary>The specified resource type cannot be found in the image file.</summary>
        ERROR_RESOURCE_TYPE_NOT_FOUND    = 1813L,
        /// <summary>The specified resource name cannot be found in the image file.</summary>
        ERROR_RESOURCE_NAME_NOT_FOUND    = 1814L,
        /// <summary>The specified resource language ID cannot be found in the image file.</summary>
        ERROR_RESOURCE_LANG_NOT_FOUND    = 1815L,
        /// <summary>Not enough quota is available to process this command.</summary>
        ERROR_NOT_ENOUGH_QUOTA           = 1816L,
        /// <summary>No interfaces have been registered.</summary>
        RPC_S_NO_INTERFACES              = 1817L,
        /// <summary>The remote procedure call was cancelled.</summary>
        RPC_S_CALL_CANCELLED             = 1818L,
        /// <summary>The binding handle does not contain all required information.</summary>
        RPC_S_BINDING_INCOMPLETE         = 1819L,
        /// <summary>A communications failure occurred during a remote procedure call.</summary>
        RPC_S_COMM_FAILURE               = 1820L,
        /// <summary>The requested authentication level is not supported.</summary>
        RPC_S_UNSUPPORTED_AUTHN_LEVEL    = 1821L,
        /// <summary>No principal name registered.</summary>
        RPC_S_NO_PRINC_NAME              = 1822L,
        /// <summary>The error specified is not a valid Windows RPC error code.</summary>
        RPC_S_NOT_RPC_ERROR              = 1823L,
        /// <summary>A UUID that is valid only on this computer has been allocated.</summary>
        RPC_S_UUID_LOCAL_ONLY            = 1824L,
        /// <summary>A security package specific error occurred.</summary>
        RPC_S_SEC_PKG_ERROR              = 1825L,
        /// <summary>Thread is not canceled.</summary>
        RPC_S_NOT_CANCELLED              = 1826L,
        /// <summary>Invalid operation on the encoding/decoding handle.</summary>
        RPC_X_INVALID_ES_ACTION          = 1827L,
        /// <summary>Incompatible version of the serializing package.</summary>
        RPC_X_WRONG_ES_VERSION           = 1828L,
        /// <summary>Incompatible version of the RPC stub.</summary>
        RPC_X_WRONG_STUB_VERSION         = 1829L,
        /// <summary>The RPC pipe object is invalid or corrupted.</summary>
        RPC_X_INVALID_PIPE_OBJECT        = 1830L,
        /// <summary>An invalid operation was attempted on an RPC pipe object.</summary>
        RPC_X_WRONG_PIPE_ORDER           = 1831L,
        /// <summary>Unsupported RPC pipe version.</summary>
        RPC_X_WRONG_PIPE_VERSION         = 1832L,
        /// <summary>HTTP proxy server rejected the connection because the cookie authentication failed.</summary>
        RPC_S_COOKIE_AUTH_FAILED         = 1833L,
        /// <summary>The RPC server is suspended, and could not be resumed for this request. The call did not execute.</summary>
        RPC_S_DO_NOT_DISTURB             = 1834L,
        /// <summary>The RPC call contains too many handles to be transmitted in a single request.</summary>
        RPC_S_SYSTEM_HANDLE_COUNT_EXCEEDED = 1835L,
        /// <summary>The RPC call contains a handle that differs from the declared handle type.</summary>
        RPC_S_SYSTEM_HANDLE_TYPE_MISMATCH = 1836L,
        /// <summary>The group member was not found.</summary>
        RPC_S_GROUP_MEMBER_NOT_FOUND     = 1898L,
        /// <summary>The endpoint mapper database entry could not be created.</summary>
        EPT_S_CANT_CREATE                = 1899L,
        /// <summary>The object universal unique identifier (UUID) is the nil UUID.</summary>
        RPC_S_INVALID_OBJECT             = 1900L,
        /// <summary>The specified time is invalid.</summary>
        ERROR_INVALID_TIME               = 1901L,
        /// <summary>The specified form name is invalid.</summary>
        ERROR_INVALID_FORM_NAME          = 1902L,
        /// <summary>The specified form size is invalid.</summary>
        ERROR_INVALID_FORM_SIZE          = 1903L,
        /// <summary>The specified printer handle is already being waited on</summary>
        ERROR_ALREADY_WAITING            = 1904L,
        /// <summary>The specified printer has been deleted.</summary>
        ERROR_PRINTER_DELETED            = 1905L,
        /// <summary>The state of the printer is invalid.</summary>
        ERROR_INVALID_PRINTER_STATE      = 1906L,
        /// <summary>The user's password must be changed before signing in.</summary>
        ERROR_PASSWORD_MUST_CHANGE       = 1907L,
        /// <summary>Could not find the domain controller for this domain.</summary>
        ERROR_DOMAIN_CONTROLLER_NOT_FOUND = 1908L,
        /// <summary>The referenced account is currently locked out and may not be logged on to.</summary>
        ERROR_ACCOUNT_LOCKED_OUT         = 1909L,
        /// <summary>The object exporter specified was not found.</summary>
        OR_INVALID_OXID                  = 1910L,
        /// <summary>The object specified was not found.</summary>
        OR_INVALID_OID                   = 1911L,
        /// <summary>The object resolver set specified was not found.</summary>
        OR_INVALID_SET                   = 1912L,
        /// <summary>Some data remains to be sent in the request buffer.</summary>
        RPC_S_SEND_INCOMPLETE            = 1913L,
        /// <summary>Invalid asynchronous remote procedure call handle.</summary>
        RPC_S_INVALID_ASYNC_HANDLE       = 1914L,
        /// <summary>Invalid asynchronous RPC call handle for this operation.</summary>
        RPC_S_INVALID_ASYNC_CALL         = 1915L,
        /// <summary>The RPC pipe object has already been closed.</summary>
        RPC_X_PIPE_CLOSED                = 1916L,
        /// <summary>The RPC call completed before all pipes were processed.</summary>
        RPC_X_PIPE_DISCIPLINE_ERROR      = 1917L,
        /// <summary>No more data is available from the RPC pipe.</summary>
        RPC_X_PIPE_EMPTY                 = 1918L,
        /// <summary>No site name is available for this machine.</summary>
        ERROR_NO_SITENAME                = 1919L,
        /// <summary>The file cannot be accessed by the system.</summary>
        ERROR_CANT_ACCESS_FILE           = 1920L,
        /// <summary>The name of the file cannot be resolved by the system.</summary>
        ERROR_CANT_RESOLVE_FILENAME      = 1921L,
        /// <summary>The entry is not of the expected type.</summary>
        RPC_S_ENTRY_TYPE_MISMATCH        = 1922L,
        /// <summary>Not all object UUIDs could be exported to the specified entry.</summary>
        RPC_S_NOT_ALL_OBJS_EXPORTED      = 1923L,
        /// <summary>Interface could not be exported to the specified entry.</summary>
        RPC_S_INTERFACE_NOT_EXPORTED     = 1924L,
        /// <summary>The specified profile entry could not be added.</summary>
        RPC_S_PROFILE_NOT_ADDED          = 1925L,
        /// <summary>The specified profile element could not be added.</summary>
        RPC_S_PRF_ELT_NOT_ADDED          = 1926L,
        /// <summary>The specified profile element could not be removed.</summary>
        RPC_S_PRF_ELT_NOT_REMOVED        = 1927L,
        /// <summary>The group element could not be added.</summary>
        RPC_S_GRP_ELT_NOT_ADDED          = 1928L,
        /// <summary>The group element could not be removed.</summary>
        RPC_S_GRP_ELT_NOT_REMOVED        = 1929L,
        /// <summary>The printer driver is not compatible with a policy enabled on your computer that blocks NT 4.0 drivers.</summary>
        ERROR_KM_DRIVER_BLOCKED          = 1930L,
        /// <summary>The context has expired and can no longer be used.</summary>
        ERROR_CONTEXT_EXPIRED            = 1931L,
        /// <summary>The current user's delegated trust creation quota has been exceeded.</summary>
        ERROR_PER_USER_TRUST_QUOTA_EXCEEDED = 1932L,
        /// <summary>The total delegated trust creation quota has been exceeded.</summary>
        ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED = 1933L,
        /// <summary>The current user's delegated trust deletion quota has been exceeded.</summary>
        ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED = 1934L,
        /// <summary>The computer you are signing into is protected by an authentication firewall. The specified account is not allowed to authenticate to the computer.</summary>
        ERROR_AUTHENTICATION_FIREWALL_FAILED = 1935L,
        /// <summary>Remote connections to the Print Spooler are blocked by a policy set on your machine.</summary>
        ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED = 1936L,
        /// <summary>Authentication failed because NTLM authentication has been disabled.</summary>
        ERROR_NTLM_BLOCKED               = 1937L,
        /// <summary>Logon Failure: EAS policy requires that the user change their password before this operation can be performed.</summary>
        ERROR_PASSWORD_CHANGE_REQUIRED   = 1938L,
        /// <summary>The pixel format is invalid.</summary>
        ERROR_INVALID_PIXEL_FORMAT       = 2000L,
        /// <summary>The specified driver is invalid.</summary>
        ERROR_BAD_DRIVER                 = 2001L,
        /// <summary>The window style or class attribute is invalid for this operation.</summary>
        ERROR_INVALID_WINDOW_STYLE       = 2002L,
        /// <summary>The requested metafile operation is not supported.</summary>
        ERROR_METAFILE_NOT_SUPPORTED     = 2003L,
        /// <summary>The requested transformation operation is not supported.</summary>
        ERROR_TRANSFORM_NOT_SUPPORTED    = 2004L,
        /// <summary>The requested clipping operation is not supported.</summary>
        ERROR_CLIPPING_NOT_SUPPORTED     = 2005L,
        /// <summary>The specified color management module is invalid.</summary>
        ERROR_INVALID_CMM                = 2010L,
        /// <summary>The specified color profile is invalid.</summary>
        ERROR_INVALID_PROFILE            = 2011L,
        /// <summary>The specified tag was not found.</summary>
        ERROR_TAG_NOT_FOUND              = 2012L,
        /// <summary>A required tag is not present.</summary>
        ERROR_TAG_NOT_PRESENT            = 2013L,
        /// <summary>The specified tag is already present.</summary>
        ERROR_DUPLICATE_TAG              = 2014L,
        /// <summary>The specified color profile is not associated with the specified device.</summary>
        ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE = 2015L,
        /// <summary>The specified color profile was not found.</summary>
        ERROR_PROFILE_NOT_FOUND          = 2016L,
        /// <summary>The specified color space is invalid.</summary>
        ERROR_INVALID_COLORSPACE         = 2017L,
        /// <summary>Image Color Management is not enabled.</summary>
        ERROR_ICM_NOT_ENABLED            = 2018L,
        /// <summary>There was an error while deleting the color transform.</summary>
        ERROR_DELETING_ICM_XFORM         = 2019L,
        /// <summary>The specified color transform is invalid.</summary>
        ERROR_INVALID_TRANSFORM          = 2020L,
        /// <summary>The specified transform does not match the bitmap's color space.</summary>
        ERROR_COLORSPACE_MISMATCH        = 2021L,
        /// <summary>The specified named color index is not present in the profile.</summary>
        ERROR_INVALID_COLORINDEX         = 2022L,
        /// <summary>The specified profile is intended for a device of a different type than the specified device.</summary>
        ERROR_PROFILE_DOES_NOT_MATCH_DEVICE = 2023L,
        /// <summary>The network connection was made successfully, but the user had to be prompted for a password other than the one originally specified.</summary>
        ERROR_CONNECTED_OTHER_PASSWORD   = 2108L,
        /// <summary>The network connection was made successfully using default credentials.</summary>
        ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109L,
        /// <summary>The specified username is invalid.</summary>
        ERROR_BAD_USERNAME               = 2202L,
        /// <summary>This network connection does not exist.</summary>
        ERROR_NOT_CONNECTED              = 2250L,
        /// <summary>This network connection has files open or requests pending.</summary>
        ERROR_OPEN_FILES                 = 2401L,
        /// <summary>Active connections still exist.</summary>
        ERROR_ACTIVE_CONNECTIONS         = 2402L,
        /// <summary>The device is in use by an active process and cannot be disconnected.</summary>
        ERROR_DEVICE_IN_USE              = 2404L,
        /// <summary>The specified print monitor is unknown.</summary>
        ERROR_UNKNOWN_PRINT_MONITOR      = 3000L,
        /// <summary>The specified printer driver is currently in use.</summary>
        ERROR_PRINTER_DRIVER_IN_USE      = 3001L,
        /// <summary>The spool file was not found.</summary>
        ERROR_SPOOL_FILE_NOT_FOUND       = 3002L,
        /// <summary>A StartDocPrinter call was not issued.</summary>
        ERROR_SPL_NO_STARTDOC            = 3003L,
        /// <summary>An AddJob call was not issued.</summary>
        ERROR_SPL_NO_ADDJOB              = 3004L,
        /// <summary>The specified print processor has already been installed.</summary>
        ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005L,
        /// <summary>The specified print monitor has already been installed.</summary>
        ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006L,
        /// <summary>The specified print monitor does not have the required functions.</summary>
        ERROR_INVALID_PRINT_MONITOR      = 3007L,
        /// <summary>The specified print monitor is currently in use.</summary>
        ERROR_PRINT_MONITOR_IN_USE       = 3008L,
        /// <summary>The requested operation is not allowed when there are jobs queued to the printer.</summary>
        ERROR_PRINTER_HAS_JOBS_QUEUED    = 3009L,
        /// <summary>The requested operation is successful. Changes will not be effective until the system is rebooted.</summary>
        ERROR_SUCCESS_REBOOT_REQUIRED    = 3010L,
        /// <summary>The requested operation is successful. Changes will not be effective until the service is restarted.</summary>
        ERROR_SUCCESS_RESTART_REQUIRED   = 3011L,
        /// <summary>No printers were found.</summary>
        ERROR_PRINTER_NOT_FOUND          = 3012L,
        /// <summary>The printer driver is known to be unreliable.</summary>
        ERROR_PRINTER_DRIVER_WARNED      = 3013L,
        /// <summary>The printer driver is known to harm the system.</summary>
        ERROR_PRINTER_DRIVER_BLOCKED     = 3014L,
        /// <summary>The specified printer driver package is currently in use.</summary>
        ERROR_PRINTER_DRIVER_PACKAGE_IN_USE = 3015L,
        /// <summary>Unable to find a core driver package that is required by the printer driver package.</summary>
        ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND = 3016L,
        /// <summary>The requested operation failed. A system reboot is required to roll back changes made.</summary>
        ERROR_FAIL_REBOOT_REQUIRED       = 3017L,
        /// <summary>The requested operation failed. A system reboot has been initiated to roll back changes made.</summary>
        ERROR_FAIL_REBOOT_INITIATED      = 3018L,
        /// <summary>The specified printer driver was not found on the system and needs to be downloaded.</summary>
        ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED = 3019L,
        /// <summary>The requested print job has failed to print. A print system update requires the job to be resubmitted.</summary>
        ERROR_PRINT_JOB_RESTART_REQUIRED = 3020L,
        /// <summary>The printer driver does not contain a valid manifest, or contains too many manifests.</summary>
        ERROR_INVALID_PRINTER_DRIVER_MANIFEST = 3021L,
        /// <summary>The specified printer cannot be shared.</summary>
        ERROR_PRINTER_NOT_SHAREABLE      = 3022L,
        /// <summary>The operation was paused.</summary>
        ERROR_REQUEST_PAUSED             = 3050L,
        /// <summary>Reissue the given operation as a cached IO operation</summary>
        ERROR_IO_REISSUE_AS_CACHED       = 3950L,
        /// <summary>WINS encountered an error while processing the command.</summary>
        ERROR_WINS_INTERNAL              = 4000L,
        /// <summary>The local WINS cannot be deleted.</summary>
        ERROR_CAN_NOT_DEL_LOCAL_WINS     = 4001L,
        /// <summary>The importation from the file failed.</summary>
        ERROR_STATIC_INIT                = 4002L,
        /// <summary>The backup failed. Was a full backup done before?</summary>
        ERROR_INC_BACKUP                 = 4003L,
        /// <summary>The backup failed. Check the directory to which you are backing the database.</summary>
        ERROR_FULL_BACKUP                = 4004L,
        /// <summary>The name does not exist in the WINS database.</summary>
        ERROR_REC_NON_EXISTENT           = 4005L,
        /// <summary>Replication with a nonconfigured partner is not allowed.</summary>
        ERROR_RPL_NOT_ALLOWED            = 4006L,
        /// <summary>The version of the supplied content information is not supported.</summary>
        PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED = 4050L,
        /// <summary>The supplied content information is malformed.</summary>
        PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO = 4051L,
        /// <summary>The requested data cannot be found in local or peer caches.</summary>
        PEERDIST_ERROR_MISSING_DATA      = 4052L,
        /// <summary>No more data is available or required.</summary>
        PEERDIST_ERROR_NO_MORE           = 4053L,
        /// <summary>The supplied object has not been initialized.</summary>
        PEERDIST_ERROR_NOT_INITIALIZED   = 4054L,
        /// <summary>The supplied object has already been initialized.</summary>
        PEERDIST_ERROR_ALREADY_INITIALIZED = 4055L,
        /// <summary>A shutdown operation is already in progress.</summary>
        PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS = 4056L,
        /// <summary>The supplied object has already been invalidated.</summary>
        PEERDIST_ERROR_INVALIDATED       = 4057L,
        /// <summary>An element already exists and was not replaced.</summary>
        PEERDIST_ERROR_ALREADY_EXISTS    = 4058L,
        /// <summary>Can not cancel the requested operation as it has already been completed.</summary>
        PEERDIST_ERROR_OPERATION_NOTFOUND = 4059L,
        /// <summary>Can not perform the reqested operation because it has already been carried out.</summary>
        PEERDIST_ERROR_ALREADY_COMPLETED = 4060L,
        /// <summary>An operation accessed data beyond the bounds of valid data.</summary>
        PEERDIST_ERROR_OUT_OF_BOUNDS     = 4061L,
        /// <summary>The requested version is not supported.</summary>
        PEERDIST_ERROR_VERSION_UNSUPPORTED = 4062L,
        /// <summary>A configuration value is invalid.</summary>
        PEERDIST_ERROR_INVALID_CONFIGURATION = 4063L,
        /// <summary>The SKU is not licensed.</summary>
        PEERDIST_ERROR_NOT_LICENSED      = 4064L,
        /// <summary>PeerDist Service is still initializing and will be available shortly.</summary>
        PEERDIST_ERROR_SERVICE_UNAVAILABLE = 4065L,
        /// <summary>Communication with one or more computers will be temporarily blocked due to recent errors.</summary>
        PEERDIST_ERROR_TRUST_FAILURE     = 4066L,
        /// <summary>The DHCP client has obtained an IP address that is already in use on the network. The local interface will be disabled until the DHCP client can obtain a new address.</summary>
        ERROR_DHCP_ADDRESS_CONFLICT      = 4100L,
        /// <summary>The GUID passed was not recognized as valid by a WMI data provider.</summary>
        ERROR_WMI_GUID_NOT_FOUND         = 4200L,
        /// <summary>The instance name passed was not recognized as valid by a WMI data provider.</summary>
        ERROR_WMI_INSTANCE_NOT_FOUND     = 4201L,
        /// <summary>The data item ID passed was not recognized as valid by a WMI data provider.</summary>
        ERROR_WMI_ITEMID_NOT_FOUND       = 4202L,
        /// <summary>The WMI request could not be completed and should be retried.</summary>
        ERROR_WMI_TRY_AGAIN              = 4203L,
        /// <summary>The WMI data provider could not be located.</summary>
        ERROR_WMI_DP_NOT_FOUND           = 4204L,
        /// <summary>The WMI data provider references an instance set that has not been registered.</summary>
        ERROR_WMI_UNRESOLVED_INSTANCE_REF = 4205L,
        /// <summary>The WMI data block or event notification has already been enabled.</summary>
        ERROR_WMI_ALREADY_ENABLED        = 4206L,
        /// <summary>The WMI data block is no longer available.</summary>
        ERROR_WMI_GUID_DISCONNECTED      = 4207L,
        /// <summary>The WMI data service is not available.</summary>
        ERROR_WMI_SERVER_UNAVAILABLE     = 4208L,
        /// <summary>The WMI data provider failed to carry out the request.</summary>
        ERROR_WMI_DP_FAILED              = 4209L,
        /// <summary>The WMI MOF information is not valid.</summary>
        ERROR_WMI_INVALID_MOF            = 4210L,
        /// <summary>The WMI registration information is not valid.</summary>
        ERROR_WMI_INVALID_REGINFO        = 4211L,
        /// <summary>The WMI data block or event notification has already been disabled.</summary>
        ERROR_WMI_ALREADY_DISABLED       = 4212L,
        /// <summary>The WMI data item or data block is read only.</summary>
        ERROR_WMI_READ_ONLY              = 4213L,
        /// <summary>The WMI data item or data block could not be changed.</summary>
        ERROR_WMI_SET_FAILURE            = 4214L,
        /// <summary>This operation is only valid in the context of an app container.</summary>
        ERROR_NOT_APPCONTAINER           = 4250L,
        /// <summary>This application can only run in the context of an app container.</summary>
        ERROR_APPCONTAINER_REQUIRED      = 4251L,
        /// <summary>This functionality is not supported in the context of an app container.</summary>
        ERROR_NOT_SUPPORTED_IN_APPCONTAINER = 4252L,
        /// <summary>The length of the SID supplied is not a valid length for app container SIDs.</summary>
        ERROR_INVALID_PACKAGE_SID_LENGTH = 4253L,
        /// <summary>The media identifier does not represent a valid medium.</summary>
        ERROR_INVALID_MEDIA              = 4300L,
        /// <summary>The library identifier does not represent a valid library.</summary>
        ERROR_INVALID_LIBRARY            = 4301L,
        /// <summary>The media pool identifier does not represent a valid media pool.</summary>
        ERROR_INVALID_MEDIA_POOL         = 4302L,
        /// <summary>The drive and medium are not compatible or exist in different libraries.</summary>
        ERROR_DRIVE_MEDIA_MISMATCH       = 4303L,
        /// <summary>The medium currently exists in an offline library and must be online to perform this operation.</summary>
        ERROR_MEDIA_OFFLINE              = 4304L,
        /// <summary>The operation cannot be performed on an offline library.</summary>
        ERROR_LIBRARY_OFFLINE            = 4305L,
        /// <summary>The library, drive, or media pool is empty.</summary>
        ERROR_EMPTY                      = 4306L,
        /// <summary>The library, drive, or media pool must be empty to perform this operation.</summary>
        ERROR_NOT_EMPTY                  = 4307L,
        /// <summary>No media is currently available in this media pool or library.</summary>
        ERROR_MEDIA_UNAVAILABLE          = 4308L,
        /// <summary>A resource required for this operation is disabled.</summary>
        ERROR_RESOURCE_DISABLED          = 4309L,
        /// <summary>The media identifier does not represent a valid cleaner.</summary>
        ERROR_INVALID_CLEANER            = 4310L,
        /// <summary>The drive cannot be cleaned or does not support cleaning.</summary>
        ERROR_UNABLE_TO_CLEAN            = 4311L,
        /// <summary>The object identifier does not represent a valid object.</summary>
        ERROR_OBJECT_NOT_FOUND           = 4312L,
        /// <summary>Unable to read from or write to the database.</summary>
        ERROR_DATABASE_FAILURE           = 4313L,
        /// <summary>The database is full.</summary>
        ERROR_DATABASE_FULL              = 4314L,
        /// <summary>The medium is not compatible with the device or media pool.</summary>
        ERROR_MEDIA_INCOMPATIBLE         = 4315L,
        /// <summary>The resource required for this operation does not exist.</summary>
        ERROR_RESOURCE_NOT_PRESENT       = 4316L,
        /// <summary>The operation identifier is not valid.</summary>
        ERROR_INVALID_OPERATION          = 4317L,
        /// <summary>The media is not mounted or ready for use.</summary>
        ERROR_MEDIA_NOT_AVAILABLE        = 4318L,
        /// <summary>The device is not ready for use.</summary>
        ERROR_DEVICE_NOT_AVAILABLE       = 4319L,
        /// <summary>The operator or administrator has refused the request.</summary>
        ERROR_REQUEST_REFUSED            = 4320L,
        /// <summary>The drive identifier does not represent a valid drive.</summary>
        ERROR_INVALID_DRIVE_OBJECT       = 4321L,
        /// <summary>Library is full. No slot is available for use.</summary>
        ERROR_LIBRARY_FULL               = 4322L,
        /// <summary>The transport cannot access the medium.</summary>
        ERROR_MEDIUM_NOT_ACCESSIBLE      = 4323L,
        /// <summary>Unable to load the medium into the drive.</summary>
        ERROR_UNABLE_TO_LOAD_MEDIUM      = 4324L,
        /// <summary>Unable to retrieve the drive status.</summary>
        ERROR_UNABLE_TO_INVENTORY_DRIVE  = 4325L,
        /// <summary>Unable to retrieve the slot status.</summary>
        ERROR_UNABLE_TO_INVENTORY_SLOT   = 4326L,
        /// <summary>Unable to retrieve status about the transport.</summary>
        ERROR_UNABLE_TO_INVENTORY_TRANSPORT = 4327L,
        /// <summary>Cannot use the transport because it is already in use.</summary>
        ERROR_TRANSPORT_FULL             = 4328L,
        /// <summary>Unable to open or close the inject/eject port.</summary>
        ERROR_CONTROLLING_IEPORT         = 4329L,
        /// <summary>Unable to eject the medium because it is in a drive.</summary>
        ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA = 4330L,
        /// <summary>A cleaner slot is already reserved.</summary>
        ERROR_CLEANER_SLOT_SET           = 4331L,
        /// <summary>A cleaner slot is not reserved.</summary>
        ERROR_CLEANER_SLOT_NOT_SET       = 4332L,
        /// <summary>The cleaner cartridge has performed the maximum number of drive cleanings.</summary>
        ERROR_CLEANER_CARTRIDGE_SPENT    = 4333L,
        /// <summary>Unexpected on-medium identifier.</summary>
        ERROR_UNEXPECTED_OMID            = 4334L,
        /// <summary>The last remaining item in this group or resource cannot be deleted.</summary>
        ERROR_CANT_DELETE_LAST_ITEM      = 4335L,
        /// <summary>The message provided exceeds the maximum size allowed for this parameter.</summary>
        ERROR_MESSAGE_EXCEEDS_MAX_SIZE   = 4336L,
        /// <summary>The volume contains system or paging files.</summary>
        ERROR_VOLUME_CONTAINS_SYS_FILES  = 4337L,
        /// <summary>The media type cannot be removed from this library since at least one drive in the library reports it can support this media type.</summary>
        ERROR_INDIGENOUS_TYPE            = 4338L,
        /// <summary>This offline media cannot be mounted on this system since no enabled drives are present which can be used.</summary>
        ERROR_NO_SUPPORTING_DRIVES       = 4339L,
        /// <summary>A cleaner cartridge is present in the tape library.</summary>
        ERROR_CLEANER_CARTRIDGE_INSTALLED = 4340L,
        /// <summary>Cannot use the inject/eject port because it is not empty.</summary>
        ERROR_IEPORT_FULL                = 4341L,
        /// <summary>This file is currently not available for use on this computer.</summary>
        ERROR_FILE_OFFLINE               = 4350L,
        /// <summary>The remote storage service is not operational at this time.</summary>
        ERROR_REMOTE_STORAGE_NOT_ACTIVE  = 4351L,
        /// <summary>The remote storage service encountered a media error.</summary>
        ERROR_REMOTE_STORAGE_MEDIA_ERROR = 4352L,
        /// <summary>The file or directory is not a reparse point.</summary>
        ERROR_NOT_A_REPARSE_POINT        = 4390L,
        /// <summary>The reparse point attribute cannot be set because it conflicts with an existing attribute.</summary>
        ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391L,
        /// <summary>The data present in the reparse point buffer is invalid.</summary>
        ERROR_INVALID_REPARSE_DATA       = 4392L,
        /// <summary>The tag present in the reparse point buffer is invalid.</summary>
        ERROR_REPARSE_TAG_INVALID        = 4393L,
        /// <summary>There is a mismatch between the tag specified in the request and the tag present in the reparse point.</summary>
        ERROR_REPARSE_TAG_MISMATCH       = 4394L,
        /// <summary>The object manager encountered a reparse point while retrieving an object.</summary>
        ERROR_REPARSE_POINT_ENCOUNTERED  = 4395L,
        /// <summary>Fast Cache data not found.</summary>
        ERROR_APP_DATA_NOT_FOUND         = 4400L,
        /// <summary>Fast Cache data expired.</summary>
        ERROR_APP_DATA_EXPIRED           = 4401L,
        /// <summary>Fast Cache data corrupt.</summary>
        ERROR_APP_DATA_CORRUPT           = 4402L,
        /// <summary>Fast Cache data has exceeded its max size and cannot be updated.</summary>
        ERROR_APP_DATA_LIMIT_EXCEEDED    = 4403L,
        /// <summary>Fast Cache has been ReArmed and requires a reboot until it can be updated.</summary>
        ERROR_APP_DATA_REBOOT_REQUIRED   = 4404L,
        /// <summary>Secure Boot detected that rollback of protected data has been attempted.</summary>
        ERROR_SECUREBOOT_ROLLBACK_DETECTED = 4420L,
        /// <summary>The value is protected by Secure Boot policy and cannot be modified or deleted.</summary>
        ERROR_SECUREBOOT_POLICY_VIOLATION = 4421L,
        /// <summary>The Secure Boot policy is invalid.</summary>
        ERROR_SECUREBOOT_INVALID_POLICY  = 4422L,
        /// <summary>A new Secure Boot policy did not contain the current publisher on its update list.</summary>
        ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND = 4423L,
        /// <summary>The Secure Boot policy is either not signed or is signed by a non-trusted signer.</summary>
        ERROR_SECUREBOOT_POLICY_NOT_SIGNED = 4424L,
        /// <summary>Secure Boot is not enabled on this machine.</summary>
        ERROR_SECUREBOOT_NOT_ENABLED     = 4425L,
        /// <summary>Secure Boot requires that certain files and drivers are not replaced by other files or drivers.</summary>
        ERROR_SECUREBOOT_FILE_REPLACED   = 4426L,
        /// <summary>The Secure Boot Supplemental Policy file was not authorized on this machine.</summary>
        ERROR_SECUREBOOT_POLICY_NOT_AUTHORIZED = 4427L,
        /// <summary>The Supplemntal Policy is not recognized on this device.</summary>
        ERROR_SECUREBOOT_POLICY_UNKNOWN  = 4428L,
        /// <summary>The Antirollback version was not found in the Secure Boot Policy.</summary>
        ERROR_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION = 4429L,
        /// <summary>The Platform ID specified in the Secure Boot policy does not match the Platform ID on this device.</summary>
        ERROR_SECUREBOOT_PLATFORM_ID_MISMATCH = 4430L,
        /// <summary>The Secure Boot policy file has an older Antirollback Version than this device.</summary>
        ERROR_SECUREBOOT_POLICY_ROLLBACK_DETECTED = 4431L,
        /// <summary>The Secure Boot policy file does not match the upgraded legacy policy.</summary>
        ERROR_SECUREBOOT_POLICY_UPGRADE_MISMATCH = 4432L,
        /// <summary>The Secure Boot policy file is required but could not be found.</summary>
        ERROR_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING = 4433L,
        /// <summary>Supplemental Secure Boot policy file can not be loaded as a base Secure Boot policy.</summary>
        ERROR_SECUREBOOT_NOT_BASE_POLICY = 4434L,
        /// <summary>Base Secure Boot policy file can not be loaded as a Supplemental Secure Boot policy.</summary>
        ERROR_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY = 4435L,
        /// <summary>The copy offload read operation is not supported by a filter.</summary>
        ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED = 4440L,
        /// <summary>The copy offload write operation is not supported by a filter.</summary>
        ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED = 4441L,
        /// <summary>The copy offload read operation is not supported for the file.</summary>
        ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED = 4442L,
        /// <summary>The copy offload write operation is not supported for the file.</summary>
        ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED = 4443L,
        /// <summary>Single Instance Storage is not available on this volume.</summary>
        ERROR_VOLUME_NOT_SIS_ENABLED     = 4500L,
        /// <summary>System Integrity detected that policy rollback has been attempted.</summary>
        ERROR_SYSTEM_INTEGRITY_ROLLBACK_DETECTED = 4550L,
        /// <summary>Your organization used Device Guard to block this app. Contact your support person for more info.</summary>
        ERROR_SYSTEM_INTEGRITY_POLICY_VIOLATION = 4551L,
        /// <summary>The System Integrity policy is invalid.</summary>
        ERROR_SYSTEM_INTEGRITY_INVALID_POLICY = 4552L,
        /// <summary>The System Integrity policy is either not signed or is signed by a non-trusted signer.</summary>
        ERROR_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED = 4553L,
        /// <summary>Virtual Secure Mode (VSM) is not initialized. The hypervisor or VSM may not be present or enabled.</summary>
        ERROR_VSM_NOT_INITIALIZED        = 4560L,
        /// <summary>The hypervisor is not protecting DMA because an IOMMU is not present or not enabled in the BIOS.</summary>
        ERROR_VSM_DMA_PROTECTION_NOT_IN_USE = 4561L,
        /// <summary>The Platform Manifest file was not authorized on this machine.</summary>
        ERROR_PLATFORM_MANIFEST_NOT_AUTHORIZED = 4570L,
        /// <summary>The Platform Manifest file was not valid.</summary>
        ERROR_PLATFORM_MANIFEST_INVALID  = 4571L,
        /// <summary>The file is not authorized on this platform because an entry was not found in the Platform Manifest.</summary>
        ERROR_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED = 4572L,
        /// <summary>The catalog is not authorized on this platform because an entry was not found in the Platform Manifest.</summary>
        ERROR_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED = 4573L,
        /// <summary>The file is not authorized on this platform because a Binary ID was not found in the embedded signature.</summary>
        ERROR_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND = 4574L,
        /// <summary>No active Platform Manifest exists on this system.</summary>
        ERROR_PLATFORM_MANIFEST_NOT_ACTIVE = 4575L,
        /// <summary>The Platform Manifest file was not properly signed.</summary>
        ERROR_PLATFORM_MANIFEST_NOT_SIGNED = 4576L,
        /// <summary>The operation cannot be completed because other resources are dependent on this resource.</summary>
        ERROR_DEPENDENT_RESOURCE_EXISTS  = 5001L,
        /// <summary>The cluster resource dependency cannot be found.</summary>
        ERROR_DEPENDENCY_NOT_FOUND       = 5002L,
        /// <summary>The cluster resource cannot be made dependent on the specified resource because it is already dependent.</summary>
        ERROR_DEPENDENCY_ALREADY_EXISTS  = 5003L,
        /// <summary>The cluster resource is not online.</summary>
        ERROR_RESOURCE_NOT_ONLINE        = 5004L,
        /// <summary>A cluster node is not available for this operation.</summary>
        ERROR_HOST_NODE_NOT_AVAILABLE    = 5005L,
        /// <summary>The cluster resource is not available.</summary>
        ERROR_RESOURCE_NOT_AVAILABLE     = 5006L,
        /// <summary>The cluster resource could not be found.</summary>
        ERROR_RESOURCE_NOT_FOUND         = 5007L,
        /// <summary>The cluster is being shut down.</summary>
        ERROR_SHUTDOWN_CLUSTER           = 5008L,
        /// <summary>A cluster node cannot be evicted from the cluster unless the node is down or it is the last node.</summary>
        ERROR_CANT_EVICT_ACTIVE_NODE     = 5009L,
        /// <summary>The object already exists.</summary>
        ERROR_OBJECT_ALREADY_EXISTS      = 5010L,
        /// <summary>The object is already in the list.</summary>
        ERROR_OBJECT_IN_LIST             = 5011L,
        /// <summary>The cluster group is not available for any new requests.</summary>
        ERROR_GROUP_NOT_AVAILABLE        = 5012L,
        /// <summary>The cluster group could not be found.</summary>
        ERROR_GROUP_NOT_FOUND            = 5013L,
        /// <summary>The operation could not be completed because the cluster group is not online.</summary>
        ERROR_GROUP_NOT_ONLINE           = 5014L,
        /// <summary>The operation failed because either the specified cluster node is not the owner of the resource, or the node is not a possible owner of the resource.</summary>
        ERROR_HOST_NODE_NOT_RESOURCE_OWNER = 5015L,
        /// <summary>The operation failed because either the specified cluster node is not the owner of the group, or the node is not a possible owner of the group.</summary>
        ERROR_HOST_NODE_NOT_GROUP_OWNER  = 5016L,
        /// <summary>The cluster resource could not be created in the specified resource monitor.</summary>
        ERROR_RESMON_CREATE_FAILED       = 5017L,
        /// <summary>The cluster resource could not be brought online by the resource monitor.</summary>
        ERROR_RESMON_ONLINE_FAILED       = 5018L,
        /// <summary>The operation could not be completed because the cluster resource is online.</summary>
        ERROR_RESOURCE_ONLINE            = 5019L,
        /// <summary>The cluster resource could not be deleted or brought offline because it is the quorum resource.</summary>
        ERROR_QUORUM_RESOURCE            = 5020L,
        /// <summary>The cluster could not make the specified resource a quorum resource because it is not capable of being a quorum resource.</summary>
        ERROR_NOT_QUORUM_CAPABLE         = 5021L,
        /// <summary>The cluster software is shutting down.</summary>
        ERROR_CLUSTER_SHUTTING_DOWN      = 5022L,
        /// <summary>The group or resource is not in the correct state to perform the requested operation.</summary>
        ERROR_INVALID_STATE              = 5023L,
        /// <summary>The properties were stored but not all changes will take effect until the next time the resource is brought online.</summary>
        ERROR_RESOURCE_PROPERTIES_STORED = 5024L,
        /// <summary>The cluster could not make the specified resource a quorum resource because it does not belong to a shared storage class.</summary>
        ERROR_NOT_QUORUM_CLASS           = 5025L,
        /// <summary>The cluster resource could not be deleted since it is a core resource.</summary>
        ERROR_CORE_RESOURCE              = 5026L,
        /// <summary>The quorum resource failed to come online.</summary>
        ERROR_QUORUM_RESOURCE_ONLINE_FAILED = 5027L,
        /// <summary>The quorum log could not be created or mounted successfully.</summary>
        ERROR_QUORUMLOG_OPEN_FAILED      = 5028L,
        /// <summary>The cluster log is corrupt.</summary>
        ERROR_CLUSTERLOG_CORRUPT         = 5029L,
        /// <summary>The record could not be written to the cluster log since it exceeds the maximum size.</summary>
        ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE = 5030L,
        /// <summary>The cluster log exceeds its maximum size.</summary>
        ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE = 5031L,
        /// <summary>No checkpoint record was found in the cluster log.</summary>
        ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND = 5032L,
        /// <summary>The minimum required disk space needed for logging is not available.</summary>
        ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE = 5033L,
        /// <summary>The cluster node failed to take control of the quorum resource because the resource is owned by another active node.</summary>
        ERROR_QUORUM_OWNER_ALIVE         = 5034L,
        /// <summary>A cluster network is not available for this operation.</summary>
        ERROR_NETWORK_NOT_AVAILABLE      = 5035L,
        /// <summary>A cluster node is not available for this operation.</summary>
        ERROR_NODE_NOT_AVAILABLE         = 5036L,
        /// <summary>All cluster nodes must be running to perform this operation.</summary>
        ERROR_ALL_NODES_NOT_AVAILABLE    = 5037L,
        /// <summary>A cluster resource failed.</summary>
        ERROR_RESOURCE_FAILED            = 5038L,
        /// <summary>The cluster node is not valid.</summary>
        ERROR_CLUSTER_INVALID_NODE       = 5039L,
        /// <summary>The cluster node already exists.</summary>
        ERROR_CLUSTER_NODE_EXISTS        = 5040L,
        /// <summary>A node is in the process of joining the cluster.</summary>
        ERROR_CLUSTER_JOIN_IN_PROGRESS   = 5041L,
        /// <summary>The cluster node was not found.</summary>
        ERROR_CLUSTER_NODE_NOT_FOUND     = 5042L,
        /// <summary>The cluster local node information was not found.</summary>
        ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND = 5043L,
        /// <summary>The cluster network already exists.</summary>
        ERROR_CLUSTER_NETWORK_EXISTS     = 5044L,
        /// <summary>The cluster network was not found.</summary>
        ERROR_CLUSTER_NETWORK_NOT_FOUND  = 5045L,
        /// <summary>The cluster network interface already exists.</summary>
        ERROR_CLUSTER_NETINTERFACE_EXISTS = 5046L,
        /// <summary>The cluster network interface was not found.</summary>
        ERROR_CLUSTER_NETINTERFACE_NOT_FOUND = 5047L,
        /// <summary>The cluster request is not valid for this object.</summary>
        ERROR_CLUSTER_INVALID_REQUEST    = 5048L,
        /// <summary>The cluster network provider is not valid.</summary>
        ERROR_CLUSTER_INVALID_NETWORK_PROVIDER = 5049L,
        /// <summary>The cluster node is down.</summary>
        ERROR_CLUSTER_NODE_DOWN          = 5050L,
        /// <summary>The cluster node is not reachable.</summary>
        ERROR_CLUSTER_NODE_UNREACHABLE   = 5051L,
        /// <summary>The cluster node is not a member of the cluster.</summary>
        ERROR_CLUSTER_NODE_NOT_MEMBER    = 5052L,
        /// <summary>A cluster join operation is not in progress.</summary>
        ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS = 5053L,
        /// <summary>The cluster network is not valid.</summary>
        ERROR_CLUSTER_INVALID_NETWORK    = 5054L,
        /// <summary>The cluster node is up.</summary>
        ERROR_CLUSTER_NODE_UP            = 5056L,
        /// <summary>The cluster IP address is already in use.</summary>
        ERROR_CLUSTER_IPADDR_IN_USE      = 5057L,
        /// <summary>The cluster node is not paused.</summary>
        ERROR_CLUSTER_NODE_NOT_PAUSED    = 5058L,
        /// <summary>No cluster security context is available.</summary>
        ERROR_CLUSTER_NO_SECURITY_CONTEXT = 5059L,
        /// <summary>The cluster network is not configured for internal cluster communication.</summary>
        ERROR_CLUSTER_NETWORK_NOT_INTERNAL = 5060L,
        /// <summary>The cluster node is already up.</summary>
        ERROR_CLUSTER_NODE_ALREADY_UP    = 5061L,
        /// <summary>The cluster node is already down.</summary>
        ERROR_CLUSTER_NODE_ALREADY_DOWN  = 5062L,
        /// <summary>The cluster network is already online.</summary>
        ERROR_CLUSTER_NETWORK_ALREADY_ONLINE = 5063L,
        /// <summary>The cluster network is already offline.</summary>
        ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE = 5064L,
        /// <summary>The cluster node is already a member of the cluster.</summary>
        ERROR_CLUSTER_NODE_ALREADY_MEMBER = 5065L,
        /// <summary>The cluster network is the only one configured for internal cluster communication between two or more active cluster nodes. The internal communication capability cannot be removed from the network.</summary>
        ERROR_CLUSTER_LAST_INTERNAL_NETWORK = 5066L,
        /// <summary>One or more cluster resources depend on the network to provide service to clients. The client access capability cannot be removed from the network.</summary>
        ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS = 5067L,
        /// <summary>This operation cannot currently be performed on the cluster group containing the quorum resource.</summary>
        ERROR_INVALID_OPERATION_ON_QUORUM = 5068L,
        /// <summary>The cluster quorum resource is not allowed to have any dependencies.</summary>
        ERROR_DEPENDENCY_NOT_ALLOWED     = 5069L,
        /// <summary>The cluster node is paused.</summary>
        ERROR_CLUSTER_NODE_PAUSED        = 5070L,
        /// <summary>The cluster resource cannot be brought online. The owner node cannot run this resource.</summary>
        ERROR_NODE_CANT_HOST_RESOURCE    = 5071L,
        /// <summary>The cluster node is not ready to perform the requested operation.</summary>
        ERROR_CLUSTER_NODE_NOT_READY     = 5072L,
        /// <summary>The cluster node is shutting down.</summary>
        ERROR_CLUSTER_NODE_SHUTTING_DOWN = 5073L,
        /// <summary>The cluster join operation was aborted.</summary>
        ERROR_CLUSTER_JOIN_ABORTED       = 5074L,
        /// <summary>The node failed to join the cluster because the joining node and other nodes in the cluster have incompatible operating system versions. To get more information about operating system versions of the cluster, run the Validate a Configuration Wizard or the Test-Cluster Windows PowerShell cmdlet.</summary>
        ERROR_CLUSTER_INCOMPATIBLE_VERSIONS = 5075L,
        /// <summary>This resource cannot be created because the cluster has reached the limit on the number of resources it can monitor.</summary>
        ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED = 5076L,
        /// <summary>The system configuration changed during the cluster join or form operation. The join or form operation was aborted.</summary>
        ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED = 5077L,
        /// <summary>The specified resource type was not found.</summary>
        ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND = 5078L,
        /// <summary>The specified node does not support a resource of this type. This may be due to version inconsistencies or due to the absence of the resource DLL on this node.</summary>
        ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED = 5079L,
        /// <summary>The specified resource name is not supported by this resource DLL. This may be due to a bad (or changed) name supplied to the resource DLL.</summary>
        ERROR_CLUSTER_RESNAME_NOT_FOUND  = 5080L,
        /// <summary>No authentication package could be registered with the RPC server.</summary>
        ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED = 5081L,
        /// <summary>You cannot bring the group online because the owner of the group is not in the preferred list for the group. To change the owner node for the group, move the group.</summary>
        ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST = 5082L,
        /// <summary>The join operation failed because the cluster database sequence number has changed or is incompatible with the locker node. This may happen during a join operation if the cluster database was changing during the join.</summary>
        ERROR_CLUSTER_DATABASE_SEQMISMATCH = 5083L,
        /// <summary>The resource monitor will not allow the fail operation to be performed while the resource is in its current state. This may happen if the resource is in a pending state.</summary>
        ERROR_RESMON_INVALID_STATE       = 5084L,
        /// <summary>A non locker code got a request to reserve the lock for making global updates.</summary>
        ERROR_CLUSTER_GUM_NOT_LOCKER     = 5085L,
        /// <summary>The quorum disk could not be located by the cluster service.</summary>
        ERROR_QUORUM_DISK_NOT_FOUND      = 5086L,
        /// <summary>The backed up cluster database is possibly corrupt.</summary>
        ERROR_DATABASE_BACKUP_CORRUPT    = 5087L,
        /// <summary>A DFS root already exists in this cluster node.</summary>
        ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT = 5088L,
        /// <summary>An attempt to modify a resource property failed because it conflicts with another existing property.</summary>
        ERROR_RESOURCE_PROPERTY_UNCHANGEABLE = 5089L,
        /// <summary>This operation is not supported on a cluster without an Administrator Access Point.</summary>
        ERROR_NO_ADMIN_ACCESS_POINT      = 5090L,
        /// <summary>An operation was attempted that is incompatible with the current membership state of the node.</summary>
        ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE = 5890L,
        /// <summary>The quorum resource does not contain the quorum log.</summary>
        ERROR_CLUSTER_QUORUMLOG_NOT_FOUND = 5891L,
        /// <summary>The membership engine requested shutdown of the cluster service on this node.</summary>
        ERROR_CLUSTER_MEMBERSHIP_HALT    = 5892L,
        /// <summary>The join operation failed because the cluster instance ID of the joining node does not match the cluster instance ID of the sponsor node.</summary>
        ERROR_CLUSTER_INSTANCE_ID_MISMATCH = 5893L,
        /// <summary>A matching cluster network for the specified IP address could not be found.</summary>
        ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP = 5894L,
        /// <summary>The actual data type of the property did not match the expected data type of the property.</summary>
        ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH = 5895L,
        /// <summary>The cluster node was evicted from the cluster successfully, but the node was not cleaned up. To determine what cleanup steps failed and how to recover, see the Failover Clustering application event log using Event Viewer.</summary>
        ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP = 5896L,
        /// <summary>Two or more parameter values specified for a resource's properties are in conflict.</summary>
        ERROR_CLUSTER_PARAMETER_MISMATCH = 5897L,
        /// <summary>This computer cannot be made a member of a cluster.</summary>
        ERROR_NODE_CANNOT_BE_CLUSTERED   = 5898L,
        /// <summary>This computer cannot be made a member of a cluster because it does not have the correct version of Windows installed.</summary>
        ERROR_CLUSTER_WRONG_OS_VERSION   = 5899L,
        /// <summary>A cluster cannot be created with the specified cluster name because that cluster name is already in use. Specify a different name for the cluster.</summary>
        ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME = 5900L,
        /// <summary>The cluster configuration action has already been committed.</summary>
        ERROR_CLUSCFG_ALREADY_COMMITTED  = 5901L,
        /// <summary>The cluster configuration action could not be rolled back.</summary>
        ERROR_CLUSCFG_ROLLBACK_FAILED    = 5902L,
        /// <summary>The drive letter assigned to a system disk on one node conflicted with the drive letter assigned to a disk on another node.</summary>
        ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT = 5903L,
        /// <summary>One or more nodes in the cluster are running a version of Windows that does not support this operation.</summary>
        ERROR_CLUSTER_OLD_VERSION        = 5904L,
        /// <summary>The name of the corresponding computer account doesn't match the Network Name for this resource.</summary>
        ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME = 5905L,
        /// <summary>No network adapters are available.</summary>
        ERROR_CLUSTER_NO_NET_ADAPTERS    = 5906L,
        /// <summary>The cluster node has been poisoned.</summary>
        ERROR_CLUSTER_POISONED           = 5907L,
        /// <summary>The group is unable to accept the request since it is moving to another node.</summary>
        ERROR_CLUSTER_GROUP_MOVING       = 5908L,
        /// <summary>The resource type cannot accept the request since is too busy performing another operation.</summary>
        ERROR_CLUSTER_RESOURCE_TYPE_BUSY = 5909L,
        /// <summary>The call to the cluster resource DLL timed out.</summary>
        ERROR_RESOURCE_CALL_TIMED_OUT    = 5910L,
        /// <summary>The address is not valid for an IPv6 Address resource. A global IPv6 address is required, and it must match a cluster network. Compatibility addresses are not permitted.</summary>
        ERROR_INVALID_CLUSTER_IPV6_ADDRESS = 5911L,
        /// <summary>An internal cluster error occurred. A call to an invalid function was attempted.</summary>
        ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION = 5912L,
        /// <summary>A parameter value is out of acceptable range.</summary>
        ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS = 5913L,
        /// <summary>A network error occurred while sending data to another node in the cluster. The number of bytes transmitted was less than required.</summary>
        ERROR_CLUSTER_PARTIAL_SEND       = 5914L,
        /// <summary>An invalid cluster registry operation was attempted.</summary>
        ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION = 5915L,
        /// <summary>An input string of characters is not properly terminated.</summary>
        ERROR_CLUSTER_INVALID_STRING_TERMINATION = 5916L,
        /// <summary>An input string of characters is not in a valid format for the data it represents.</summary>
        ERROR_CLUSTER_INVALID_STRING_FORMAT = 5917L,
        /// <summary>An internal cluster error occurred. A cluster database transaction was attempted while a transaction was already in progress.</summary>
        ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS = 5918L,
        /// <summary>An internal cluster error occurred. There was an attempt to commit a cluster database transaction while no transaction was in progress.</summary>
        ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS = 5919L,
        /// <summary>An internal cluster error occurred. Data was not properly initialized.</summary>
        ERROR_CLUSTER_NULL_DATA          = 5920L,
        /// <summary>An error occurred while reading from a stream of data. An unexpected number of bytes was returned.</summary>
        ERROR_CLUSTER_PARTIAL_READ       = 5921L,
        /// <summary>An error occurred while writing to a stream of data. The required number of bytes could not be written.</summary>
        ERROR_CLUSTER_PARTIAL_WRITE      = 5922L,
        /// <summary>An error occurred while deserializing a stream of cluster data.</summary>
        ERROR_CLUSTER_CANT_DESERIALIZE_DATA = 5923L,
        /// <summary>One or more property values for this resource are in conflict with one or more property values associated with its dependent resource(s).</summary>
        ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT = 5924L,
        /// <summary>A quorum of cluster nodes was not present to form a cluster.</summary>
        ERROR_CLUSTER_NO_QUORUM          = 5925L,
        /// <summary>The cluster network is not valid for an IPv6 Address resource, or it does not match the configured address.</summary>
        ERROR_CLUSTER_INVALID_IPV6_NETWORK = 5926L,
        /// <summary>The cluster network is not valid for an IPv6 Tunnel resource. Check the configuration of the IP Address resource on which the IPv6 Tunnel resource depends.</summary>
        ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK = 5927L,
        /// <summary>Quorum resource cannot reside in the Available Storage group.</summary>
        ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP = 5928L,
        /// <summary>The dependencies for this resource are nested too deeply.</summary>
        ERROR_DEPENDENCY_TREE_TOO_COMPLEX = 5929L,
        /// <summary>The call into the resource DLL raised an unhandled exception.</summary>
        ERROR_EXCEPTION_IN_RESOURCE_CALL = 5930L,
        /// <summary>The RHS process failed to initialize.</summary>
        ERROR_CLUSTER_RHS_FAILED_INITIALIZATION = 5931L,
        /// <summary>The Failover Clustering feature is not installed on this node.</summary>
        ERROR_CLUSTER_NOT_INSTALLED      = 5932L,
        /// <summary>The resources must be online on the same node for this operation</summary>
        ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE = 5933L,
        /// <summary>A new node can not be added since this cluster is already at its maximum number of nodes.</summary>
        ERROR_CLUSTER_MAX_NODES_IN_CLUSTER = 5934L,
        /// <summary>This cluster can not be created since the specified number of nodes exceeds the maximum allowed limit.</summary>
        ERROR_CLUSTER_TOO_MANY_NODES     = 5935L,
        /// <summary>An attempt to use the specified cluster name failed because an enabled computer object with the given name already exists in the domain.</summary>
        ERROR_CLUSTER_OBJECT_ALREADY_USED = 5936L,
        /// <summary>This cluster cannot be destroyed. It has non-core application groups which must be deleted before the cluster can be destroyed.</summary>
        ERROR_NONCORE_GROUPS_FOUND       = 5937L,
        /// <summary>File share associated with file share witness resource cannot be hosted by this cluster or any of its nodes.</summary>
        ERROR_FILE_SHARE_RESOURCE_CONFLICT = 5938L,
        /// <summary>Eviction of this node is invalid at this time. Due to quorum requirements node eviction will result in cluster shutdown. If it is the last node in the cluster, destroy cluster command should be used.</summary>
        ERROR_CLUSTER_EVICT_INVALID_REQUEST = 5939L,
        /// <summary>Only one instance of this resource type is allowed in the cluster.</summary>
        ERROR_CLUSTER_SINGLETON_RESOURCE = 5940L,
        /// <summary>Only one instance of this resource type is allowed per resource group.</summary>
        ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE = 5941L,
        /// <summary>The resource failed to come online due to the failure of one or more provider resources.</summary>
        ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED = 5942L,
        /// <summary>The resource has indicated that it cannot come online on any node.</summary>
        ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR = 5943L,
        /// <summary>The current operation cannot be performed on this group at this time.</summary>
        ERROR_CLUSTER_GROUP_BUSY         = 5944L,
        /// <summary>The directory or file is not located on a cluster shared volume.</summary>
        ERROR_CLUSTER_NOT_SHARED_VOLUME  = 5945L,
        /// <summary>The Security Descriptor does not meet the requirements for a cluster.</summary>
        ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR = 5946L,
        /// <summary>There is one or more shared volumes resources configured in the cluster. Those resources must be moved to available storage in order for operation to succeed.</summary>
        ERROR_CLUSTER_SHARED_VOLUMES_IN_USE = 5947L,
        /// <summary>This group or resource cannot be directly manipulated. Use shared volume APIs to perform desired operation.</summary>
        ERROR_CLUSTER_USE_SHARED_VOLUMES_API = 5948L,
        /// <summary>Back up is in progress. Please wait for backup completion before trying this operation again.</summary>
        ERROR_CLUSTER_BACKUP_IN_PROGRESS = 5949L,
        /// <summary>The path does not belong to a cluster shared volume.</summary>
        ERROR_NON_CSV_PATH               = 5950L,
        /// <summary>The cluster shared volume is not locally mounted on this node.</summary>
        ERROR_CSV_VOLUME_NOT_LOCAL       = 5951L,
        /// <summary>The cluster watchdog is terminating.</summary>
        ERROR_CLUSTER_WATCHDOG_TERMINATING = 5952L,
        /// <summary>A resource vetoed a move between two nodes because they are incompatible.</summary>
        ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES = 5953L,
        /// <summary>The request is invalid either because node weight cannot be changed while the cluster is in disk-only quorum mode, or because changing the node weight would violate the minimum cluster quorum requirements.</summary>
        ERROR_CLUSTER_INVALID_NODE_WEIGHT = 5954L,
        /// <summary>The resource vetoed the call.</summary>
        ERROR_CLUSTER_RESOURCE_VETOED_CALL = 5955L,
        /// <summary>Resource could not start or run because it could not reserve sufficient system resources.</summary>
        ERROR_RESMON_SYSTEM_RESOURCES_LACKING = 5956L,
        /// <summary>A resource vetoed a move between two nodes because the destination currently does not have enough resources to complete the operation.</summary>
        ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION = 5957L,
        /// <summary>A resource vetoed a move between two nodes because the source currently does not have enough resources to complete the operation.</summary>
        ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE = 5958L,
        /// <summary>The requested operation can not be completed because the group is queued for an operation.</summary>
        ERROR_CLUSTER_GROUP_QUEUED       = 5959L,
        /// <summary>The requested operation can not be completed because a resource has locked status.</summary>
        ERROR_CLUSTER_RESOURCE_LOCKED_STATUS = 5960L,
        /// <summary>The resource cannot move to another node because a cluster shared volume vetoed the operation.</summary>
        ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED = 5961L,
        /// <summary>A node drain is already in progress.</summary>
        ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS = 5962L,
        /// <summary>Clustered storage is not connected to the node.</summary>
        ERROR_CLUSTER_DISK_NOT_CONNECTED = 5963L,
        /// <summary>The disk is not configured in a way to be used with CSV. CSV disks must have at least one partition that is formatted with NTFS or REFS.</summary>
        ERROR_DISK_NOT_CSV_CAPABLE       = 5964L,
        /// <summary>The resource must be part of the Available Storage group to complete this action.</summary>
        ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE = 5965L,
        /// <summary>CSVFS failed operation as volume is in redirected mode.</summary>
        ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED = 5966L,
        /// <summary>CSVFS failed operation as volume is not in redirected mode.</summary>
        ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED = 5967L,
        /// <summary>Cluster properties cannot be returned at this time.</summary>
        ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES = 5968L,
        /// <summary>The clustered disk resource contains software snapshot diff area that are not supported for Cluster Shared Volumes.</summary>
        ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES = 5969L,
        /// <summary>The operation cannot be completed because the resource is in maintenance mode.</summary>
        ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE = 5970L,
        /// <summary>The operation cannot be completed because of cluster affinity conflicts</summary>
        ERROR_CLUSTER_AFFINITY_CONFLICT  = 5971L,
        /// <summary>The operation cannot be completed because the resource is a replica virtual machine.</summary>
        ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE = 5972L,
        /// <summary>The Cluster Functional Level could not be increased because not all nodes in the cluster support the updated version.</summary>
        ERROR_CLUSTER_UPGRADE_INCOMPATIBLE_VERSIONS = 5973L,
        /// <summary>Updating the cluster functional level failed because the cluster is running in fix quorum mode. Start additional nodes which are members of the cluster until the cluster reaches quorum and the cluster will automatically switch out of fix quorum mode, or stop and restart the cluster without the FixQuorum switch. Once the cluster is out of fix quorum mode retry the Update-ClusterFunctionalLevel PowerShell cmdlet to update the cluster functional level.</summary>
        ERROR_CLUSTER_UPGRADE_FIX_QUORUM_NOT_SUPPORTED = 5974L,
        /// <summary>The cluster functional level has been successfully updated but not all features are available yet. Restart the cluster by using the Stop-Cluster PowerShell cmdlet followed by the Start-Cluster PowerShell cmdlet and all cluster features will be available.</summary>
        ERROR_CLUSTER_UPGRADE_RESTART_REQUIRED = 5975L,
        /// <summary>The cluster is currently performing a version upgrade.</summary>
        ERROR_CLUSTER_UPGRADE_IN_PROGRESS = 5976L,
        /// <summary>The cluster did not successfully complete the version upgrade.</summary>
        ERROR_CLUSTER_UPGRADE_INCOMPLETE = 5977L,
        /// <summary>The cluster node is in grace period.</summary>
        ERROR_CLUSTER_NODE_IN_GRACE_PERIOD = 5978L,
        /// <summary>The operation has failed because CSV volume was not able to recover in time specified on this file object.</summary>
        ERROR_CLUSTER_CSV_IO_PAUSE_TIMEOUT = 5979L,
        /// <summary>The operation failed because the requested node is not currently part of active cluster membership.</summary>
        ERROR_NODE_NOT_ACTIVE_CLUSTER_MEMBER = 5980L,
        /// <summary>The operation failed because the requested cluster resource is currently unmonitored.</summary>
        ERROR_CLUSTER_RESOURCE_NOT_MONITORED = 5981L,
        /// <summary>The operation failed because a resource does not support running in an unmonitored state.</summary>
        ERROR_CLUSTER_RESOURCE_DOES_NOT_SUPPORT_UNMONITORED = 5982L,
        /// <summary>The operation cannot be completed because a resource participates in replication.</summary>
        ERROR_CLUSTER_RESOURCE_IS_REPLICATED = 5983L,
        /// <summary>The operation failed because the requested cluster node has been isolated</summary>
        ERROR_CLUSTER_NODE_ISOLATED      = 5984L,
        /// <summary>The operation failed because the requested cluster node has been quarantined</summary>
        ERROR_CLUSTER_NODE_QUARANTINED   = 5985L,
        /// <summary>The operation failed because the specified database update condition was not met</summary>
        ERROR_CLUSTER_DATABASE_UPDATE_CONDITION_FAILED = 5986L,
        /// <summary>A clustered space is in a degraded condition and the requested action cannot be completed at this time.</summary>
        ERROR_CLUSTER_SPACE_DEGRADED     = 5987L,
        /// <summary>The operation failed because token delegation for this control is not supported.</summary>
        ERROR_CLUSTER_TOKEN_DELEGATION_NOT_SUPPORTED = 5988L,
        /// <summary>The operation has failed because CSV has invalidated this file object.</summary>
        ERROR_CLUSTER_CSV_INVALID_HANDLE = 5989L,
        /// <summary>This operation is supported only on the CSV coordinator node.</summary>
        ERROR_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR = 5990L,
        /// <summary>The cluster group set is not available for any further requests.</summary>
        ERROR_GROUPSET_NOT_AVAILABLE     = 5991L,
        /// <summary>The cluster group set could not be found.</summary>
        ERROR_GROUPSET_NOT_FOUND         = 5992L,
        /// <summary>The action cannot be completed at this time because the cluster group set would fall below quorum and not be able to act as a provider.</summary>
        ERROR_GROUPSET_CANT_PROVIDE      = 5993L,
        /// <summary>The specified parent fault domain is not found.</summary>
        ERROR_CLUSTER_FAULT_DOMAIN_PARENT_NOT_FOUND = 5994L,
        /// <summary>The fault domain cannot be a child of the parent specified.</summary>
        ERROR_CLUSTER_FAULT_DOMAIN_INVALID_HIERARCHY = 5995L,
        /// <summary>Storage Spaces Direct has rejected the proposed fault domain changes because it impacts the fault tolerance of the storage.</summary>
        ERROR_CLUSTER_FAULT_DOMAIN_FAILED_S2D_VALIDATION = 5996L,
        /// <summary>Storage Spaces Direct has rejected the proposed fault domain changes because it reduces the storage connected to the system.</summary>
        ERROR_CLUSTER_FAULT_DOMAIN_S2D_CONNECTIVITY_LOSS = 5997L,
        /// <summary>The specified file could not be encrypted.</summary>
        ERROR_ENCRYPTION_FAILED          = 6000L,
        /// <summary>The specified file could not be decrypted.</summary>
        ERROR_DECRYPTION_FAILED          = 6001L,
        /// <summary>The specified file is encrypted and the user does not have the ability to decrypt it.</summary>
        ERROR_FILE_ENCRYPTED             = 6002L,
        /// <summary>There is no valid encryption recovery policy configured for this system.</summary>
        ERROR_NO_RECOVERY_POLICY         = 6003L,
        /// <summary>The required encryption driver is not loaded for this system.</summary>
        ERROR_NO_EFS                     = 6004L,
        /// <summary>The file was encrypted with a different encryption driver than is currently loaded.</summary>
        ERROR_WRONG_EFS                  = 6005L,
        /// <summary>There are no EFS keys defined for the user.</summary>
        ERROR_NO_USER_KEYS               = 6006L,
        /// <summary>The specified file is not encrypted.</summary>
        ERROR_FILE_NOT_ENCRYPTED         = 6007L,
        /// <summary>The specified file is not in the defined EFS export format.</summary>
        ERROR_NOT_EXPORT_FORMAT          = 6008L,
        /// <summary>The specified file is read only.</summary>
        ERROR_FILE_READ_ONLY             = 6009L,
        /// <summary>The directory has been disabled for encryption.</summary>
        ERROR_DIR_EFS_DISALLOWED         = 6010L,
        /// <summary>The server is not trusted for remote encryption operation.</summary>
        ERROR_EFS_SERVER_NOT_TRUSTED     = 6011L,
        /// <summary>Recovery policy configured for this system contains invalid recovery certificate.</summary>
        ERROR_BAD_RECOVERY_POLICY        = 6012L,
        /// <summary>The encryption algorithm used on the source file needs a bigger key buffer than the one on the destination file.</summary>
        ERROR_EFS_ALG_BLOB_TOO_BIG       = 6013L,
        /// <summary>The disk partition does not support file encryption.</summary>
        ERROR_VOLUME_NOT_SUPPORT_EFS     = 6014L,
        /// <summary>This machine is disabled for file encryption.</summary>
        ERROR_EFS_DISABLED               = 6015L,
        /// <summary>A newer system is required to decrypt this encrypted file.</summary>
        ERROR_EFS_VERSION_NOT_SUPPORT    = 6016L,
        /// <summary>The remote server sent an invalid response for a file being opened with Client Side Encryption.</summary>
        ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE = 6017L,
        /// <summary>Client Side Encryption is not supported by the remote server even though it claims to support it.</summary>
        ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER = 6018L,
        /// <summary>File is encrypted and should be opened in Client Side Encryption mode.</summary>
        ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE = 6019L,
        /// <summary>A new encrypted file is being created and a $EFS needs to be provided.</summary>
        ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE = 6020L,
        /// <summary>The SMB client requested a CSE FSCTL on a non-CSE file.</summary>
        ERROR_CS_ENCRYPTION_FILE_NOT_CSE = 6021L,
        /// <summary>The requested operation was blocked by policy. For more information, contact your system administrator.</summary>
        ERROR_ENCRYPTION_POLICY_DENIES_OPERATION = 6022L,
        /// <summary>The list of servers for this workgroup is not currently available</summary>
        ERROR_NO_BROWSER_SERVERS_FOUND   = 6118L,
        /// <summary>The Task Scheduler service must be configured to run in the System account to function properly. Individual tasks may be configured to run in other accounts.</summary>
        SCHED_E_SERVICE_NOT_LOCALSYSTEM  = 6200L,
        /// <summary>Log service encountered an invalid log sector.</summary>
        ERROR_LOG_SECTOR_INVALID         = 6600L,
        /// <summary>Log service encountered a log sector with invalid block parity.</summary>
        ERROR_LOG_SECTOR_PARITY_INVALID  = 6601L,
        /// <summary>Log service encountered a remapped log sector.</summary>
        ERROR_LOG_SECTOR_REMAPPED        = 6602L,
        /// <summary>Log service encountered a partial or incomplete log block.</summary>
        ERROR_LOG_BLOCK_INCOMPLETE       = 6603L,
        /// <summary>Log service encountered an attempt access data outside the active log range.</summary>
        ERROR_LOG_INVALID_RANGE          = 6604L,
        /// <summary>Log service user marshalling buffers are exhausted.</summary>
        ERROR_LOG_BLOCKS_EXHAUSTED       = 6605L,
        /// <summary>Log service encountered an attempt read from a marshalling area with an invalid read context.</summary>
        ERROR_LOG_READ_CONTEXT_INVALID   = 6606L,
        /// <summary>Log service encountered an invalid log restart area.</summary>
        ERROR_LOG_RESTART_INVALID        = 6607L,
        /// <summary>Log service encountered an invalid log block version.</summary>
        ERROR_LOG_BLOCK_VERSION          = 6608L,
        /// <summary>Log service encountered an invalid log block.</summary>
        ERROR_LOG_BLOCK_INVALID          = 6609L,
        /// <summary>Log service encountered an attempt to read the log with an invalid read mode.</summary>
        ERROR_LOG_READ_MODE_INVALID      = 6610L,
        /// <summary>Log service encountered a log stream with no restart area.</summary>
        ERROR_LOG_NO_RESTART             = 6611L,
        /// <summary>Log service encountered a corrupted metadata file.</summary>
        ERROR_LOG_METADATA_CORRUPT       = 6612L,
        /// <summary>Log service encountered a metadata file that could not be created by the log file system.</summary>
        ERROR_LOG_METADATA_INVALID       = 6613L,
        /// <summary>Log service encountered a metadata file with inconsistent data.</summary>
        ERROR_LOG_METADATA_INCONSISTENT  = 6614L,
        /// <summary>Log service encountered an attempt to erroneous allocate or dispose reservation space.</summary>
        ERROR_LOG_RESERVATION_INVALID    = 6615L,
        /// <summary>Log service cannot delete log file or file system container.</summary>
        ERROR_LOG_CANT_DELETE            = 6616L,
        /// <summary>Log service has reached the maximum allowable containers allocated to a log file.</summary>
        ERROR_LOG_CONTAINER_LIMIT_EXCEEDED = 6617L,
        /// <summary>Log service has attempted to read or write backward past the start of the log.</summary>
        ERROR_LOG_START_OF_LOG           = 6618L,
        /// <summary>Log policy could not be installed because a policy of the same type is already present.</summary>
        ERROR_LOG_POLICY_ALREADY_INSTALLED = 6619L,
        /// <summary>Log policy in question was not installed at the time of the request.</summary>
        ERROR_LOG_POLICY_NOT_INSTALLED   = 6620L,
        /// <summary>The installed set of policies on the log is invalid.</summary>
        ERROR_LOG_POLICY_INVALID         = 6621L,
        /// <summary>A policy on the log in question prevented the operation from completing.</summary>
        ERROR_LOG_POLICY_CONFLICT        = 6622L,
        /// <summary>Log space cannot be reclaimed because the log is pinned by the archive tail.</summary>
        ERROR_LOG_PINNED_ARCHIVE_TAIL    = 6623L,
        /// <summary>Log record is not a record in the log file.</summary>
        ERROR_LOG_RECORD_NONEXISTENT     = 6624L,
        /// <summary>Number of reserved log records or the adjustment of the number of reserved log records is invalid.</summary>
        ERROR_LOG_RECORDS_RESERVED_INVALID = 6625L,
        /// <summary>Reserved log space or the adjustment of the log space is invalid.</summary>
        ERROR_LOG_SPACE_RESERVED_INVALID = 6626L,
        /// <summary>An new or existing archive tail or base of the active log is invalid.</summary>
        ERROR_LOG_TAIL_INVALID           = 6627L,
        /// <summary>Log space is exhausted.</summary>
        ERROR_LOG_FULL                   = 6628L,
        /// <summary>The log could not be set to the requested size.</summary>
        ERROR_COULD_NOT_RESIZE_LOG       = 6629L,
        /// <summary>Log is multiplexed, no direct writes to the physical log is allowed.</summary>
        ERROR_LOG_MULTIPLEXED            = 6630L,
        /// <summary>The operation failed because the log is a dedicated log.</summary>
        ERROR_LOG_DEDICATED              = 6631L,
        /// <summary>The operation requires an archive context.</summary>
        ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS = 6632L,
        /// <summary>Log archival is in progress.</summary>
        ERROR_LOG_ARCHIVE_IN_PROGRESS    = 6633L,
        /// <summary>The operation requires a non-ephemeral log, but the log is ephemeral.</summary>
        ERROR_LOG_EPHEMERAL              = 6634L,
        /// <summary>The log must have at least two containers before it can be read from or written to.</summary>
        ERROR_LOG_NOT_ENOUGH_CONTAINERS  = 6635L,
        /// <summary>A log client has already registered on the stream.</summary>
        ERROR_LOG_CLIENT_ALREADY_REGISTERED = 6636L,
        /// <summary>A log client has not been registered on the stream.</summary>
        ERROR_LOG_CLIENT_NOT_REGISTERED  = 6637L,
        /// <summary>A request has already been made to handle the log full condition.</summary>
        ERROR_LOG_FULL_HANDLER_IN_PROGRESS = 6638L,
        /// <summary>Log service encountered an error when attempting to read from a log container.</summary>
        ERROR_LOG_CONTAINER_READ_FAILED  = 6639L,
        /// <summary>Log service encountered an error when attempting to write to a log container.</summary>
        ERROR_LOG_CONTAINER_WRITE_FAILED = 6640L,
        /// <summary>Log service encountered an error when attempting open a log container.</summary>
        ERROR_LOG_CONTAINER_OPEN_FAILED  = 6641L,
        /// <summary>Log service encountered an invalid container state when attempting a requested action.</summary>
        ERROR_LOG_CONTAINER_STATE_INVALID = 6642L,
        /// <summary>Log service is not in the correct state to perform a requested action.</summary>
        ERROR_LOG_STATE_INVALID          = 6643L,
        /// <summary>Log space cannot be reclaimed because the log is pinned.</summary>
        ERROR_LOG_PINNED                 = 6644L,
        /// <summary>Log metadata flush failed.</summary>
        ERROR_LOG_METADATA_FLUSH_FAILED  = 6645L,
        /// <summary>Security on the log and its containers is inconsistent.</summary>
        ERROR_LOG_INCONSISTENT_SECURITY  = 6646L,
        /// <summary>Records were appended to the log or reservation changes were made, but the log could not be flushed.</summary>
        ERROR_LOG_APPENDED_FLUSH_FAILED  = 6647L,
        /// <summary>The log is pinned due to reservation consuming most of the log space. Free some reserved records to make space available.</summary>
        ERROR_LOG_PINNED_RESERVATION     = 6648L,
        /// <summary>The transaction handle associated with this operation is not valid.</summary>
        ERROR_INVALID_TRANSACTION        = 6700L,
        /// <summary>The requested operation was made in the context of a transaction that is no longer active.</summary>
        ERROR_TRANSACTION_NOT_ACTIVE     = 6701L,
        /// <summary>The requested operation is not valid on the Transaction object in its current state.</summary>
        ERROR_TRANSACTION_REQUEST_NOT_VALID = 6702L,
        /// <summary>The caller has called a response API, but the response is not expected because the TM did not issue the corresponding request to the caller.</summary>
        ERROR_TRANSACTION_NOT_REQUESTED  = 6703L,
        /// <summary>It is too late to perform the requested operation, since the Transaction has already been aborted.</summary>
        ERROR_TRANSACTION_ALREADY_ABORTED = 6704L,
        /// <summary>It is too late to perform the requested operation, since the Transaction has already been committed.</summary>
        ERROR_TRANSACTION_ALREADY_COMMITTED = 6705L,
        /// <summary>The Transaction Manager was unable to be successfully initialized. Transacted operations are not supported.</summary>
        ERROR_TM_INITIALIZATION_FAILED   = 6706L,
        /// <summary>The specified ResourceManager made no changes or updates to the resource under this transaction.</summary>
        ERROR_RESOURCEMANAGER_READ_ONLY  = 6707L,
        /// <summary>The resource manager has attempted to prepare a transaction that it has not successfully joined.</summary>
        ERROR_TRANSACTION_NOT_JOINED     = 6708L,
        /// <summary>The Transaction object already has a superior enlistment, and the caller attempted an operation that would have created a new superior. Only a single superior enlistment is allow.</summary>
        ERROR_TRANSACTION_SUPERIOR_EXISTS = 6709L,
        /// <summary>The RM tried to register a protocol that already exists.</summary>
        ERROR_CRM_PROTOCOL_ALREADY_EXISTS = 6710L,
        /// <summary>The attempt to propagate the Transaction failed.</summary>
        ERROR_TRANSACTION_PROPAGATION_FAILED = 6711L,
        /// <summary>The requested propagation protocol was not registered as a CRM.</summary>
        ERROR_CRM_PROTOCOL_NOT_FOUND     = 6712L,
        /// <summary>The buffer passed in to PushTransaction or PullTransaction is not in a valid format.</summary>
        ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER = 6713L,
        /// <summary>The current transaction context associated with the thread is not a valid handle to a transaction object.</summary>
        ERROR_CURRENT_TRANSACTION_NOT_VALID = 6714L,
        /// <summary>The specified Transaction object could not be opened, because it was not found.</summary>
        ERROR_TRANSACTION_NOT_FOUND      = 6715L,
        /// <summary>The specified ResourceManager object could not be opened, because it was not found.</summary>
        ERROR_RESOURCEMANAGER_NOT_FOUND  = 6716L,
        /// <summary>The specified Enlistment object could not be opened, because it was not found.</summary>
        ERROR_ENLISTMENT_NOT_FOUND       = 6717L,
        /// <summary>The specified TransactionManager object could not be opened, because it was not found.</summary>
        ERROR_TRANSACTIONMANAGER_NOT_FOUND = 6718L,
        /// <summary>The object specified could not be created or opened, because its associated TransactionManager is not online.  The TransactionManager must be brought fully Online by calling RecoverTransactionManager to recover to the end of its LogFile before objects in its Transaction or ResourceManager namespaces can be opened.  In addition, errors in writing records to its LogFile can cause a TransactionManager to go offline.</summary>
        ERROR_TRANSACTIONMANAGER_NOT_ONLINE = 6719L,
        /// <summary>The specified TransactionManager was unable to create the objects contained in its logfile in the Ob namespace. Therefore, the TransactionManager was unable to recover.</summary>
        ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION = 6720L,
        /// <summary>The call to create a superior Enlistment on this Transaction object could not be completed, because the Transaction object specified for the enlistment is a subordinate branch of the Transaction. Only the root of the Transaction can be enlisted on as a superior.</summary>
        ERROR_TRANSACTION_NOT_ROOT       = 6721L,
        /// <summary>Because the associated transaction manager or resource manager has been closed, the handle is no longer valid.</summary>
        ERROR_TRANSACTION_OBJECT_EXPIRED = 6722L,
        /// <summary>The specified operation could not be performed on this Superior enlistment, because the enlistment was not created with the corresponding completion response in the NotificationMask.</summary>
        ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED = 6723L,
        /// <summary>The specified operation could not be performed, because the record that would be logged was too long. This can occur because of two conditions: either there are too many Enlistments on this Transaction, or the combined RecoveryInformation being logged on behalf of those Enlistments is too long.</summary>
        ERROR_TRANSACTION_RECORD_TOO_LONG = 6724L,
        /// <summary>Implicit transaction are not supported.</summary>
        ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED = 6725L,
        /// <summary>The kernel transaction manager had to abort or forget the transaction because it blocked forward progress.</summary>
        ERROR_TRANSACTION_INTEGRITY_VIOLATED = 6726L,
        /// <summary>The TransactionManager identity that was supplied did not match the one recorded in the TransactionManager's log file.</summary>
        ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH = 6727L,
        /// <summary>This snapshot operation cannot continue because a transactional resource manager cannot be frozen in its current state.  Please try again.</summary>
        ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT = 6728L,
        /// <summary>The transaction cannot be enlisted on with the specified EnlistmentMask, because the transaction has already completed the PrePrepare phase.  In order to ensure correctness, the ResourceManager must switch to a write-through mode and cease caching data within this transaction.  Enlisting for only subsequent transaction phases may still succeed.</summary>
        ERROR_TRANSACTION_MUST_WRITETHROUGH = 6729L,
        /// <summary>The transaction does not have a superior enlistment.</summary>
        ERROR_TRANSACTION_NO_SUPERIOR    = 6730L,
        /// <summary>The attempt to commit the Transaction completed, but it is possible that some portion of the transaction tree did not commit successfully due to heuristics.  Therefore it is possible that some data modified in the transaction may not have committed, resulting in transactional inconsistency.  If possible, check the consistency of the associated data.</summary>
        ERROR_HEURISTIC_DAMAGE_POSSIBLE  = 6731L,
        /// <summary>The function attempted to use a name that is reserved for use by another transaction.</summary>
        ERROR_TRANSACTIONAL_CONFLICT     = 6800L,
        /// <summary>Transaction support within the specified resource manager is not started or was shut down due to an error.</summary>
        ERROR_RM_NOT_ACTIVE              = 6801L,
        /// <summary>The metadata of the RM has been corrupted. The RM will not function.</summary>
        ERROR_RM_METADATA_CORRUPT        = 6802L,
        /// <summary>The specified directory does not contain a resource manager.</summary>
        ERROR_DIRECTORY_NOT_RM           = 6803L,
        /// <summary>The remote server or share does not support transacted file operations.</summary>
        ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE = 6805L,
        /// <summary>The requested log size is invalid.</summary>
        ERROR_LOG_RESIZE_INVALID_SIZE    = 6806L,
        /// <summary>The object (file, stream, link) corresponding to the handle has been deleted by a Transaction Savepoint Rollback.</summary>
        ERROR_OBJECT_NO_LONGER_EXISTS    = 6807L,
        /// <summary>The specified file miniversion was not found for this transacted file open.</summary>
        ERROR_STREAM_MINIVERSION_NOT_FOUND = 6808L,
        /// <summary>The specified file miniversion was found but has been invalidated. Most likely cause is a transaction savepoint rollback.</summary>
        ERROR_STREAM_MINIVERSION_NOT_VALID = 6809L,
        /// <summary>A miniversion may only be opened in the context of the transaction that created it.</summary>
        ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION = 6810L,
        /// <summary>It is not possible to open a miniversion with modify access.</summary>
        ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT = 6811L,
        /// <summary>It is not possible to create any more miniversions for this stream.</summary>
        ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS = 6812L,
        /// <summary>The remote server sent mismatching version number or Fid for a file opened with transactions.</summary>
        ERROR_REMOTE_FILE_VERSION_MISMATCH = 6814L,
        /// <summary>The handle has been invalidated by a transaction. The most likely cause is the presence of memory mapping on a file or an open handle when the transaction ended or rolled back to savepoint.</summary>
        ERROR_HANDLE_NO_LONGER_VALID     = 6815L,
        /// <summary>There is no transaction metadata on the file.</summary>
        ERROR_NO_TXF_METADATA            = 6816L,
        /// <summary>The log data is corrupt.</summary>
        ERROR_LOG_CORRUPTION_DETECTED    = 6817L,
        /// <summary>The file can't be recovered because there is a handle still open on it.</summary>
        ERROR_CANT_RECOVER_WITH_HANDLE_OPEN = 6818L,
        /// <summary>The transaction outcome is unavailable because the resource manager responsible for it has disconnected.</summary>
        ERROR_RM_DISCONNECTED            = 6819L,
        /// <summary>The request was rejected because the enlistment in question is not a superior enlistment.</summary>
        ERROR_ENLISTMENT_NOT_SUPERIOR    = 6820L,
        /// <summary>The transactional resource manager is already consistent. Recovery is not needed.</summary>
        ERROR_RECOVERY_NOT_NEEDED        = 6821L,
        /// <summary>The transactional resource manager has already been started.</summary>
        ERROR_RM_ALREADY_STARTED         = 6822L,
        /// <summary>The file cannot be opened transactionally, because its identity depends on the outcome of an unresolved transaction.</summary>
        ERROR_FILE_IDENTITY_NOT_PERSISTENT = 6823L,
        /// <summary>The operation cannot be performed because another transaction is depending on the fact that this property will not change.</summary>
        ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY = 6824L,
        /// <summary>The operation would involve a single file with two transactional resource managers and is therefore not allowed.</summary>
        ERROR_CANT_CROSS_RM_BOUNDARY     = 6825L,
        /// <summary>The $Txf directory must be empty for this operation to succeed.</summary>
        ERROR_TXF_DIR_NOT_EMPTY          = 6826L,
        /// <summary>The operation would leave a transactional resource manager in an inconsistent state and is therefore not allowed.</summary>
        ERROR_INDOUBT_TRANSACTIONS_EXIST = 6827L,
        /// <summary>The operation could not be completed because the transaction manager does not have a log.</summary>
        ERROR_TM_VOLATILE                = 6828L,
        /// <summary>A rollback could not be scheduled because a previously scheduled rollback has already executed or been queued for execution.</summary>
        ERROR_ROLLBACK_TIMER_EXPIRED     = 6829L,
        /// <summary>The transactional metadata attribute on the file or directory is corrupt and unreadable.</summary>
        ERROR_TXF_ATTRIBUTE_CORRUPT      = 6830L,
        /// <summary>The encryption operation could not be completed because a transaction is active.</summary>
        ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION = 6831L,
        /// <summary>This object is not allowed to be opened in a transaction.</summary>
        ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED = 6832L,
        /// <summary>An attempt to create space in the transactional resource manager's log failed. The failure status has been recorded in the event log.</summary>
        ERROR_LOG_GROWTH_FAILED          = 6833L,
        /// <summary>Memory mapping (creating a mapped section) a remote file under a transaction is not supported.</summary>
        ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE = 6834L,
        /// <summary>Transaction metadata is already present on this file and cannot be superseded.</summary>
        ERROR_TXF_METADATA_ALREADY_PRESENT = 6835L,
        /// <summary>A transaction scope could not be entered because the scope handler has not been initialized.</summary>
        ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET = 6836L,
        /// <summary>Promotion was required in order to allow the resource manager to enlist, but the transaction was set to disallow it.</summary>
        ERROR_TRANSACTION_REQUIRED_PROMOTION = 6837L,
        /// <summary>This file is open for modification in an unresolved transaction and may be opened for execute only by a transacted reader.</summary>
        ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION = 6838L,
        /// <summary>The request to thaw frozen transactions was ignored because transactions had not previously been frozen.</summary>
        ERROR_TRANSACTIONS_NOT_FROZEN    = 6839L,
        /// <summary>Transactions cannot be frozen because a freeze is already in progress.</summary>
        ERROR_TRANSACTION_FREEZE_IN_PROGRESS = 6840L,
        /// <summary>The target volume is not a snapshot volume. This operation is only valid on a volume mounted as a snapshot.</summary>
        ERROR_NOT_SNAPSHOT_VOLUME        = 6841L,
        /// <summary>The savepoint operation failed because files are open on the transaction. This is not permitted.</summary>
        ERROR_NO_SAVEPOINT_WITH_OPEN_FILES = 6842L,
        /// <summary>Windows has discovered corruption in a file, and that file has since been repaired. Data loss may have occurred.</summary>
        ERROR_DATA_LOST_REPAIR           = 6843L,
        /// <summary>The sparse operation could not be completed because a transaction is active on the file.</summary>
        ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION = 6844L,
        /// <summary>The call to create a TransactionManager object failed because the Tm Identity stored in the logfile does not match the Tm Identity that was passed in as an argument.</summary>
        ERROR_TM_IDENTITY_MISMATCH       = 6845L,
        /// <summary>I/O was attempted on a section object that has been floated as a result of a transaction ending. There is no valid data.</summary>
        ERROR_FLOATED_SECTION            = 6846L,
        /// <summary>The transactional resource manager cannot currently accept transacted work due to a transient condition such as low resources.</summary>
        ERROR_CANNOT_ACCEPT_TRANSACTED_WORK = 6847L,
        /// <summary>The transactional resource manager had too many tranactions outstanding that could not be aborted. The transactional resource manger has been shut down.</summary>
        ERROR_CANNOT_ABORT_TRANSACTIONS  = 6848L,
        /// <summary>The operation could not be completed due to bad clusters on disk.</summary>
        ERROR_BAD_CLUSTERS               = 6849L,
        /// <summary>The compression operation could not be completed because a transaction is active on the file.</summary>
        ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION = 6850L,
        /// <summary>The operation could not be completed because the volume is dirty. Please run chkdsk and try again.</summary>
        ERROR_VOLUME_DIRTY               = 6851L,
        /// <summary>The link tracking operation could not be completed because a transaction is active.</summary>
        ERROR_NO_LINK_TRACKING_IN_TRANSACTION = 6852L,
        /// <summary>This operation cannot be performed in a transaction.</summary>
        ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION = 6853L,
        /// <summary>The handle is no longer properly associated with its transaction.  It may have been opened in a transactional resource manager that was subsequently forced to restart.  Please close the handle and open a new one.</summary>
        ERROR_EXPIRED_HANDLE             = 6854L,
        /// <summary>The specified operation could not be performed because the resource manager is not enlisted in the transaction.</summary>
        ERROR_TRANSACTION_NOT_ENLISTED   = 6855L,
        /// <summary>The specified session name is invalid.</summary>
        ERROR_CTX_WINSTATION_NAME_INVALID = 7001L,
        /// <summary>The specified protocol driver is invalid.</summary>
        ERROR_CTX_INVALID_PD             = 7002L,
        /// <summary>The specified protocol driver was not found in the system path.</summary>
        ERROR_CTX_PD_NOT_FOUND           = 7003L,
        /// <summary>The specified terminal connection driver was not found in the system path.</summary>
        ERROR_CTX_WD_NOT_FOUND           = 7004L,
        /// <summary>A registry key for event logging could not be created for this session.</summary>
        ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY = 7005L,
        /// <summary>A service with the same name already exists on the system.</summary>
        ERROR_CTX_SERVICE_NAME_COLLISION = 7006L,
        /// <summary>A close operation is pending on the session.</summary>
        ERROR_CTX_CLOSE_PENDING          = 7007L,
        /// <summary>There are no free output buffers available.</summary>
        ERROR_CTX_NO_OUTBUF              = 7008L,
        /// <summary>The MODEM.INF file was not found.</summary>
        ERROR_CTX_MODEM_INF_NOT_FOUND    = 7009L,
        /// <summary>The modem name was not found in MODEM.INF.</summary>
        ERROR_CTX_INVALID_MODEMNAME      = 7010L,
        /// <summary>The modem did not accept the command sent to it. Verify that the configured modem name matches the attached modem.</summary>
        ERROR_CTX_MODEM_RESPONSE_ERROR   = 7011L,
        /// <summary>The modem did not respond to the command sent to it. Verify that the modem is properly cabled and powered on.</summary>
        ERROR_CTX_MODEM_RESPONSE_TIMEOUT = 7012L,
        /// <summary>Carrier detect has failed or carrier has been dropped due to disconnect.</summary>
        ERROR_CTX_MODEM_RESPONSE_NO_CARRIER = 7013L,
        /// <summary>Dial tone not detected within the required time. Verify that the phone cable is properly attached and functional.</summary>
        ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE = 7014L,
        /// <summary>Busy signal detected at remote site on callback.</summary>
        ERROR_CTX_MODEM_RESPONSE_BUSY    = 7015L,
        /// <summary>Voice detected at remote site on callback.</summary>
        ERROR_CTX_MODEM_RESPONSE_VOICE   = 7016L,
        /// <summary>Transport driver error</summary>
        ERROR_CTX_TD_ERROR               = 7017L,
        /// <summary>The specified session cannot be found.</summary>
        ERROR_CTX_WINSTATION_NOT_FOUND   = 7022L,
        /// <summary>The specified session name is already in use.</summary>
        ERROR_CTX_WINSTATION_ALREADY_EXISTS = 7023L,
        /// <summary>The task you are trying to do can't be completed because Remote Desktop Services is currently busy. Please try again in a few minutes. Other users should still be able to log on.</summary>
        ERROR_CTX_WINSTATION_BUSY        = 7024L,
        /// <summary>An attempt has been made to connect to a session whose video mode is not supported by the current client.</summary>
        ERROR_CTX_BAD_VIDEO_MODE         = 7025L,
        /// <summary>The application attempted to enable DOS graphics mode. DOS graphics mode is not supported.</summary>
        ERROR_CTX_GRAPHICS_INVALID       = 7035L,
        /// <summary>Your interactive logon privilege has been disabled. Please contact your administrator.</summary>
        ERROR_CTX_LOGON_DISABLED         = 7037L,
        /// <summary>The requested operation can be performed only on the system console. This is most often the result of a driver or system DLL requiring direct console access.</summary>
        ERROR_CTX_NOT_CONSOLE            = 7038L,
        /// <summary>The client failed to respond to the server connect message.</summary>
        ERROR_CTX_CLIENT_QUERY_TIMEOUT   = 7040L,
        /// <summary>Disconnecting the console session is not supported.</summary>
        ERROR_CTX_CONSOLE_DISCONNECT     = 7041L,
        /// <summary>Reconnecting a disconnected session to the console is not supported.</summary>
        ERROR_CTX_CONSOLE_CONNECT        = 7042L,
        /// <summary>The request to control another session remotely was denied.</summary>
        ERROR_CTX_SHADOW_DENIED          = 7044L,
        /// <summary>The requested session access is denied.</summary>
        ERROR_CTX_WINSTATION_ACCESS_DENIED = 7045L,
        /// <summary>The specified terminal connection driver is invalid.</summary>
        ERROR_CTX_INVALID_WD             = 7049L,
        /// <summary>The requested session cannot be controlled remotely. This may be because the session is disconnected or does not currently have a user logged on.</summary>
        ERROR_CTX_SHADOW_INVALID         = 7050L,
        /// <summary>The requested session is not configured to allow remote control.</summary>
        ERROR_CTX_SHADOW_DISABLED        = 7051L,
        /// <summary>Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number is currently being used by another user. Please call your system administrator to obtain a unique license number.</summary>
        ERROR_CTX_CLIENT_LICENSE_IN_USE  = 7052L,
        /// <summary>Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number has not been entered for this copy of the Terminal Server client. Please contact your system administrator.</summary>
        ERROR_CTX_CLIENT_LICENSE_NOT_SET = 7053L,
        /// <summary>The number of connections to this computer is limited and all connections are in use right now. Try connecting later or contact your system administrator.</summary>
        ERROR_CTX_LICENSE_NOT_AVAILABLE  = 7054L,
        /// <summary>The client you are using is not licensed to use this system. Your logon request is denied.</summary>
        ERROR_CTX_LICENSE_CLIENT_INVALID = 7055L,
        /// <summary>The system license has expired. Your logon request is denied.</summary>
        ERROR_CTX_LICENSE_EXPIRED        = 7056L,
        /// <summary>Remote control could not be terminated because the specified session is not currently being remotely controlled.</summary>
        ERROR_CTX_SHADOW_NOT_RUNNING     = 7057L,
        /// <summary>The remote control of the console was terminated because the display mode was changed. Changing the display mode in a remote control session is not supported.</summary>
        ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 7058L,
        /// <summary>Activation has already been reset the maximum number of times for this installation. Your activation timer will not be cleared.</summary>
        ERROR_ACTIVATION_COUNT_EXCEEDED  = 7059L,
        /// <summary>Remote logins are currently disabled.</summary>
        ERROR_CTX_WINSTATIONS_DISABLED   = 7060L,
        /// <summary>You do not have the proper encryption level to access this Session.</summary>
        ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED = 7061L,
        /// <summary>The user %s\\%s is currently logged on to this computer. Only the current user or an administrator can log on to this computer.</summary>
        ERROR_CTX_SESSION_IN_USE         = 7062L,
        /// <summary>The user %s\\%s is already logged on to the console of this computer. You do not have permission to log in at this time. To resolve this issue, contact %s\\%s and have them log off.</summary>
        ERROR_CTX_NO_FORCE_LOGOFF        = 7063L,
        /// <summary>Unable to log you on because of an account restriction.</summary>
        ERROR_CTX_ACCOUNT_RESTRICTION    = 7064L,
        /// <summary>The RDP protocol component %2 detected an error in the protocol stream and has disconnected the client.</summary>
        ERROR_RDP_PROTOCOL_ERROR         = 7065L,
        /// <summary>The Client Drive Mapping Service Has Connected on Terminal Connection.</summary>
        ERROR_CTX_CDM_CONNECT            = 7066L,
        /// <summary>The Client Drive Mapping Service Has Disconnected on Terminal Connection.</summary>
        ERROR_CTX_CDM_DISCONNECT         = 7067L,
        /// <summary>The Terminal Server security layer detected an error in the protocol stream and has disconnected the client.</summary>
        ERROR_CTX_SECURITY_LAYER_ERROR   = 7068L,
        /// <summary>The target session is incompatible with the current session.</summary>
        ERROR_TS_INCOMPATIBLE_SESSIONS   = 7069L,
        /// <summary>Windows can't connect to your session because a problem occurred in the Windows video subsystem. Try connecting again later, or contact the server administrator for assistance.</summary>
        ERROR_TS_VIDEO_SUBSYSTEM_ERROR   = 7070L,
        /// <summary>The file replication service API was called incorrectly.</summary>
        FRS_ERR_INVALID_API_SEQUENCE     = 8001L,
        /// <summary>The file replication service cannot be started.</summary>
        FRS_ERR_STARTING_SERVICE         = 8002L,
        /// <summary>The file replication service cannot be stopped.</summary>
        FRS_ERR_STOPPING_SERVICE         = 8003L,
        /// <summary>The file replication service API terminated the request. The event log may have more information.</summary>
        FRS_ERR_INTERNAL_API             = 8004L,
        /// <summary>The file replication service terminated the request. The event log may have more information.</summary>
        FRS_ERR_INTERNAL                 = 8005L,
        /// <summary>The file replication service cannot be contacted. The event log may have more information.</summary>
        FRS_ERR_SERVICE_COMM             = 8006L,
        /// <summary>The file replication service cannot satisfy the request because the user has insufficient privileges. The event log may have more information.</summary>
        FRS_ERR_INSUFFICIENT_PRIV        = 8007L,
        /// <summary>The file replication service cannot satisfy the request because authenticated RPC is not available. The event log may have more information.</summary>
        FRS_ERR_AUTHENTICATION           = 8008L,
        /// <summary>The file replication service cannot satisfy the request because the user has insufficient privileges on the domain controller. The event log may have more information.</summary>
        FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009L,
        /// <summary>The file replication service cannot satisfy the request because authenticated RPC is not available on the domain controller. The event log may have more information.</summary>
        FRS_ERR_PARENT_AUTHENTICATION    = 8010L,
        /// <summary>The file replication service cannot communicate with the file replication service on the domain controller. The event log may have more information.</summary>
        FRS_ERR_CHILD_TO_PARENT_COMM     = 8011L,
        /// <summary>The file replication service on the domain controller cannot communicate with the file replication service on this computer. The event log may have more information.</summary>
        FRS_ERR_PARENT_TO_CHILD_COMM     = 8012L,
        /// <summary>The file replication service cannot populate the system volume because of an internal error. The event log may have more information.</summary>
        FRS_ERR_SYSVOL_POPULATE          = 8013L,
        /// <summary>The file replication service cannot populate the system volume because of an internal timeout. The event log may have more information.</summary>
        FRS_ERR_SYSVOL_POPULATE_TIMEOUT  = 8014L,
        /// <summary>The file replication service cannot process the request. The system volume is busy with a previous request.</summary>
        FRS_ERR_SYSVOL_IS_BUSY           = 8015L,
        /// <summary>The file replication service cannot stop replicating the system volume because of an internal error. The event log may have more information.</summary>
        FRS_ERR_SYSVOL_DEMOTE            = 8016L,
        /// <summary>The file replication service detected an invalid parameter.</summary>
        FRS_ERR_INVALID_SERVICE_PARAMETER = 8017L,
        /// <summary>An error occurred while installing the directory service. For more information, see the event log.</summary>
        ERROR_DS_NOT_INSTALLED           = 8200L,
        /// <summary>The directory service evaluated group memberships locally.</summary>
        ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY = 8201L,
        /// <summary>The specified directory service attribute or value does not exist.</summary>
        ERROR_DS_NO_ATTRIBUTE_OR_VALUE   = 8202L,
        /// <summary>The attribute syntax specified to the directory service is invalid.</summary>
        ERROR_DS_INVALID_ATTRIBUTE_SYNTAX = 8203L,
        /// <summary>The attribute type specified to the directory service is not defined.</summary>
        ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED = 8204L,
        /// <summary>The specified directory service attribute or value already exists.</summary>
        ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS = 8205L,
        /// <summary>The directory service is busy.</summary>
        ERROR_DS_BUSY                    = 8206L,
        /// <summary>The directory service is unavailable.</summary>
        ERROR_DS_UNAVAILABLE             = 8207L,
        /// <summary>The directory service was unable to allocate a relative identifier.</summary>
        ERROR_DS_NO_RIDS_ALLOCATED       = 8208L,
        /// <summary>The directory service has exhausted the pool of relative identifiers.</summary>
        ERROR_DS_NO_MORE_RIDS            = 8209L,
        /// <summary>The requested operation could not be performed because the directory service is not the master for that type of operation.</summary>
        ERROR_DS_INCORRECT_ROLE_OWNER    = 8210L,
        /// <summary>The directory service was unable to initialize the subsystem that allocates relative identifiers.</summary>
        ERROR_DS_RIDMGR_INIT_ERROR       = 8211L,
        /// <summary>The requested operation did not satisfy one or more constraints associated with the class of the object.</summary>
        ERROR_DS_OBJ_CLASS_VIOLATION     = 8212L,
        /// <summary>The directory service can perform the requested operation only on a leaf object.</summary>
        ERROR_DS_CANT_ON_NON_LEAF        = 8213L,
        /// <summary>The directory service cannot perform the requested operation on the RDN attribute of an object.</summary>
        ERROR_DS_CANT_ON_RDN             = 8214L,
        /// <summary>The directory service detected an attempt to modify the object class of an object.</summary>
        ERROR_DS_CANT_MOD_OBJ_CLASS      = 8215L,
        /// <summary>The requested cross-domain move operation could not be performed.</summary>
        ERROR_DS_CROSS_DOM_MOVE_ERROR    = 8216L,
        /// <summary>Unable to contact the global catalog server.</summary>
        ERROR_DS_GC_NOT_AVAILABLE        = 8217L,
        /// <summary>The policy object is shared and can only be modified at the root.</summary>
        ERROR_SHARED_POLICY              = 8218L,
        /// <summary>The policy object does not exist.</summary>
        ERROR_POLICY_OBJECT_NOT_FOUND    = 8219L,
        /// <summary>The requested policy information is only in the directory service.</summary>
        ERROR_POLICY_ONLY_IN_DS          = 8220L,
        /// <summary>A domain controller promotion is currently active.</summary>
        ERROR_PROMOTION_ACTIVE           = 8221L,
        /// <summary>A domain controller promotion is not currently active</summary>
        ERROR_NO_PROMOTION_ACTIVE        = 8222L,
        /// <summary>An operations error occurred.</summary>
        ERROR_DS_OPERATIONS_ERROR        = 8224L,
        /// <summary>A protocol error occurred.</summary>
        ERROR_DS_PROTOCOL_ERROR          = 8225L,
        /// <summary>The time limit for this request was exceeded.</summary>
        ERROR_DS_TIMELIMIT_EXCEEDED      = 8226L,
        /// <summary>The size limit for this request was exceeded.</summary>
        ERROR_DS_SIZELIMIT_EXCEEDED      = 8227L,
        /// <summary>The administrative limit for this request was exceeded.</summary>
        ERROR_DS_ADMIN_LIMIT_EXCEEDED    = 8228L,
        /// <summary>The compare response was false.</summary>
        ERROR_DS_COMPARE_FALSE           = 8229L,
        /// <summary>The compare response was true.</summary>
        ERROR_DS_COMPARE_TRUE            = 8230L,
        /// <summary>The requested authentication method is not supported by the server.</summary>
        ERROR_DS_AUTH_METHOD_NOT_SUPPORTED = 8231L,
        /// <summary>A more secure authentication method is required for this server.</summary>
        ERROR_DS_STRONG_AUTH_REQUIRED    = 8232L,
        /// <summary>Inappropriate authentication.</summary>
        ERROR_DS_INAPPROPRIATE_AUTH      = 8233L,
        /// <summary>The authentication mechanism is unknown.</summary>
        ERROR_DS_AUTH_UNKNOWN            = 8234L,
        /// <summary>A referral was returned from the server.</summary>
        ERROR_DS_REFERRAL                = 8235L,
        /// <summary>The server does not support the requested critical extension.</summary>
        ERROR_DS_UNAVAILABLE_CRIT_EXTENSION = 8236L,
        /// <summary>This request requires a secure connection.</summary>
        ERROR_DS_CONFIDENTIALITY_REQUIRED = 8237L,
        /// <summary>Inappropriate matching.</summary>
        ERROR_DS_INAPPROPRIATE_MATCHING  = 8238L,
        /// <summary>A constraint violation occurred.</summary>
        ERROR_DS_CONSTRAINT_VIOLATION    = 8239L,
        /// <summary>There is no such object on the server.</summary>
        ERROR_DS_NO_SUCH_OBJECT          = 8240L,
        /// <summary>There is an alias problem.</summary>
        ERROR_DS_ALIAS_PROBLEM           = 8241L,
        /// <summary>An invalid dn syntax has been specified.</summary>
        ERROR_DS_INVALID_DN_SYNTAX       = 8242L,
        /// <summary>The object is a leaf object.</summary>
        ERROR_DS_IS_LEAF                 = 8243L,
        /// <summary>There is an alias dereferencing problem.</summary>
        ERROR_DS_ALIAS_DEREF_PROBLEM     = 8244L,
        /// <summary>The server is unwilling to process the request.</summary>
        ERROR_DS_UNWILLING_TO_PERFORM    = 8245L,
        /// <summary>A loop has been detected.</summary>
        ERROR_DS_LOOP_DETECT             = 8246L,
        /// <summary>There is a naming violation.</summary>
        ERROR_DS_NAMING_VIOLATION        = 8247L,
        /// <summary>The result set is too large.</summary>
        ERROR_DS_OBJECT_RESULTS_TOO_LARGE = 8248L,
        /// <summary>The operation affects multiple DSAs</summary>
        ERROR_DS_AFFECTS_MULTIPLE_DSAS   = 8249L,
        /// <summary>The server is not operational.</summary>
        ERROR_DS_SERVER_DOWN             = 8250L,
        /// <summary>A local error has occurred.</summary>
        ERROR_DS_LOCAL_ERROR             = 8251L,
        /// <summary>An encoding error has occurred.</summary>
        ERROR_DS_ENCODING_ERROR          = 8252L,
        /// <summary>A decoding error has occurred.</summary>
        ERROR_DS_DECODING_ERROR          = 8253L,
        /// <summary>The search filter cannot be recognized.</summary>
        ERROR_DS_FILTER_UNKNOWN          = 8254L,
        /// <summary>One or more parameters are illegal.</summary>
        ERROR_DS_PARAM_ERROR             = 8255L,
        /// <summary>The specified method is not supported.</summary>
        ERROR_DS_NOT_SUPPORTED           = 8256L,
        /// <summary>No results were returned.</summary>
        ERROR_DS_NO_RESULTS_RETURNED     = 8257L,
        /// <summary>The specified control is not supported by the server.</summary>
        ERROR_DS_CONTROL_NOT_FOUND       = 8258L,
        /// <summary>A referral loop was detected by the client.</summary>
        ERROR_DS_CLIENT_LOOP             = 8259L,
        /// <summary>The preset referral limit was exceeded.</summary>
        ERROR_DS_REFERRAL_LIMIT_EXCEEDED = 8260L,
        /// <summary>The search requires a SORT control.</summary>
        ERROR_DS_SORT_CONTROL_MISSING    = 8261L,
        /// <summary>The search results exceed the offset range specified.</summary>
        ERROR_DS_OFFSET_RANGE_ERROR      = 8262L,
        /// <summary>The directory service detected the subsystem that allocates relative identifiers is disabled. This can occur as a protective mechanism when the system determines a significant portion of relative identifiers (RIDs) have been exhausted. Please see http://go.microsoft.com/fwlink/?LinkId=228610 for recommended diagnostic steps and the procedure to re-enable account creation.</summary>
        ERROR_DS_RIDMGR_DISABLED         = 8263L,
        /// <summary>The root object must be the head of a naming context. The root object cannot have an instantiated parent.</summary>
        ERROR_DS_ROOT_MUST_BE_NC         = 8301L,
        /// <summary>The add replica operation cannot be performed. The naming context must be writeable in order to create the replica.</summary>
        ERROR_DS_ADD_REPLICA_INHIBITED   = 8302L,
        /// <summary>A reference to an attribute that is not defined in the schema occurred.</summary>
        ERROR_DS_ATT_NOT_DEF_IN_SCHEMA   = 8303L,
        /// <summary>The maximum size of an object has been exceeded.</summary>
        ERROR_DS_MAX_OBJ_SIZE_EXCEEDED   = 8304L,
        /// <summary>An attempt was made to add an object to the directory with a name that is already in use.</summary>
        ERROR_DS_OBJ_STRING_NAME_EXISTS  = 8305L,
        /// <summary>An attempt was made to add an object of a class that does not have an RDN defined in the schema.</summary>
        ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA = 8306L,
        /// <summary>An attempt was made to add an object using an RDN that is not the RDN defined in the schema.</summary>
        ERROR_DS_RDN_DOESNT_MATCH_SCHEMA = 8307L,
        /// <summary>None of the requested attributes were found on the objects.</summary>
        ERROR_DS_NO_REQUESTED_ATTS_FOUND = 8308L,
        /// <summary>The user buffer is too small.</summary>
        ERROR_DS_USER_BUFFER_TO_SMALL    = 8309L,
        /// <summary>The attribute specified in the operation is not present on the object.</summary>
        ERROR_DS_ATT_IS_NOT_ON_OBJ       = 8310L,
        /// <summary>Illegal modify operation. Some aspect of the modification is not permitted.</summary>
        ERROR_DS_ILLEGAL_MOD_OPERATION   = 8311L,
        /// <summary>The specified object is too large.</summary>
        ERROR_DS_OBJ_TOO_LARGE           = 8312L,
        /// <summary>The specified instance type is not valid.</summary>
        ERROR_DS_BAD_INSTANCE_TYPE       = 8313L,
        /// <summary>The operation must be performed at a master DSA.</summary>
        ERROR_DS_MASTERDSA_REQUIRED      = 8314L,
        /// <summary>The object class attribute must be specified.</summary>
        ERROR_DS_OBJECT_CLASS_REQUIRED   = 8315L,
        /// <summary>A required attribute is missing.</summary>
        ERROR_DS_MISSING_REQUIRED_ATT    = 8316L,
        /// <summary>An attempt was made to modify an object to include an attribute that is not legal for its class.</summary>
        ERROR_DS_ATT_NOT_DEF_FOR_CLASS   = 8317L,
        /// <summary>The specified attribute is already present on the object.</summary>
        ERROR_DS_ATT_ALREADY_EXISTS      = 8318L,
        /// <summary>The specified attribute is not present, or has no values.</summary>
        ERROR_DS_CANT_ADD_ATT_VALUES     = 8320L,
        /// <summary>Multiple values were specified for an attribute that can have only one value.</summary>
        ERROR_DS_SINGLE_VALUE_CONSTRAINT = 8321L,
        /// <summary>A value for the attribute was not in the acceptable range of values.</summary>
        ERROR_DS_RANGE_CONSTRAINT        = 8322L,
        /// <summary>The specified value already exists.</summary>
        ERROR_DS_ATT_VAL_ALREADY_EXISTS  = 8323L,
        /// <summary>The attribute cannot be removed because it is not present on the object.</summary>
        ERROR_DS_CANT_REM_MISSING_ATT    = 8324L,
        /// <summary>The attribute value cannot be removed because it is not present on the object.</summary>
        ERROR_DS_CANT_REM_MISSING_ATT_VAL = 8325L,
        /// <summary>The specified root object cannot be a subref.</summary>
        ERROR_DS_ROOT_CANT_BE_SUBREF     = 8326L,
        /// <summary>Chaining is not permitted.</summary>
        ERROR_DS_NO_CHAINING             = 8327L,
        /// <summary>Chained evaluation is not permitted.</summary>
        ERROR_DS_NO_CHAINED_EVAL         = 8328L,
        /// <summary>The operation could not be performed because the object's parent is either uninstantiated or deleted.</summary>
        ERROR_DS_NO_PARENT_OBJECT        = 8329L,
        /// <summary>Having a parent that is an alias is not permitted. Aliases are leaf objects.</summary>
        ERROR_DS_PARENT_IS_AN_ALIAS      = 8330L,
        /// <summary>The object and parent must be of the same type, either both masters or both replicas.</summary>
        ERROR_DS_CANT_MIX_MASTER_AND_REPS = 8331L,
        /// <summary>The operation cannot be performed because child objects exist. This operation can only be performed on a leaf object.</summary>
        ERROR_DS_CHILDREN_EXIST          = 8332L,
        /// <summary>Directory object not found.</summary>
        ERROR_DS_OBJ_NOT_FOUND           = 8333L,
        /// <summary>The aliased object is missing.</summary>
        ERROR_DS_ALIASED_OBJ_MISSING     = 8334L,
        /// <summary>The object name has bad syntax.</summary>
        ERROR_DS_BAD_NAME_SYNTAX         = 8335L,
        /// <summary>It is not permitted for an alias to refer to another alias.</summary>
        ERROR_DS_ALIAS_POINTS_TO_ALIAS   = 8336L,
        /// <summary>The alias cannot be dereferenced.</summary>
        ERROR_DS_CANT_DEREF_ALIAS        = 8337L,
        /// <summary>The operation is out of scope.</summary>
        ERROR_DS_OUT_OF_SCOPE            = 8338L,
        /// <summary>The operation cannot continue because the object is in the process of being removed.</summary>
        ERROR_DS_OBJECT_BEING_REMOVED    = 8339L,
        /// <summary>The DSA object cannot be deleted.</summary>
        ERROR_DS_CANT_DELETE_DSA_OBJ     = 8340L,
        /// <summary>A directory service error has occurred.</summary>
        ERROR_DS_GENERIC_ERROR           = 8341L,
        /// <summary>The operation can only be performed on an internal master DSA object.</summary>
        ERROR_DS_DSA_MUST_BE_INT_MASTER  = 8342L,
        /// <summary>The object must be of class DSA.</summary>
        ERROR_DS_CLASS_NOT_DSA           = 8343L,
        /// <summary>Insufficient access rights to perform the operation.</summary>
        ERROR_DS_INSUFF_ACCESS_RIGHTS    = 8344L,
        /// <summary>The object cannot be added because the parent is not on the list of possible superiors.</summary>
        ERROR_DS_ILLEGAL_SUPERIOR        = 8345L,
        /// <summary>Access to the attribute is not permitted because the attribute is owned by the Security Accounts Manager (SAM).</summary>
        ERROR_DS_ATTRIBUTE_OWNED_BY_SAM  = 8346L,
        /// <summary>The name has too many parts.</summary>
        ERROR_DS_NAME_TOO_MANY_PARTS     = 8347L,
        /// <summary>The name is too long.</summary>
        ERROR_DS_NAME_TOO_LONG           = 8348L,
        /// <summary>The name value is too long.</summary>
        ERROR_DS_NAME_VALUE_TOO_LONG     = 8349L,
        /// <summary>The directory service encountered an error parsing a name.</summary>
        ERROR_DS_NAME_UNPARSEABLE        = 8350L,
        /// <summary>The directory service cannot get the attribute type for a name.</summary>
        ERROR_DS_NAME_TYPE_UNKNOWN       = 8351L,
        /// <summary>The name does not identify an object; the name identifies a phantom.</summary>
        ERROR_DS_NOT_AN_OBJECT           = 8352L,
        /// <summary>The security descriptor is too short.</summary>
        ERROR_DS_SEC_DESC_TOO_SHORT      = 8353L,
        /// <summary>The security descriptor is invalid.</summary>
        ERROR_DS_SEC_DESC_INVALID        = 8354L,
        /// <summary>Failed to create name for deleted object.</summary>
        ERROR_DS_NO_DELETED_NAME         = 8355L,
        /// <summary>The parent of a new subref must exist.</summary>
        ERROR_DS_SUBREF_MUST_HAVE_PARENT = 8356L,
        /// <summary>The object must be a naming context.</summary>
        ERROR_DS_NCNAME_MUST_BE_NC       = 8357L,
        /// <summary>It is not permitted to add an attribute which is owned by the system.</summary>
        ERROR_DS_CANT_ADD_SYSTEM_ONLY    = 8358L,
        /// <summary>The class of the object must be structural; you cannot instantiate an abstract class.</summary>
        ERROR_DS_CLASS_MUST_BE_CONCRETE  = 8359L,
        /// <summary>The schema object could not be found.</summary>
        ERROR_DS_INVALID_DMD             = 8360L,
        /// <summary>A local object with this GUID (dead or alive) already exists.</summary>
        ERROR_DS_OBJ_GUID_EXISTS         = 8361L,
        /// <summary>The operation cannot be performed on a back link.</summary>
        ERROR_DS_NOT_ON_BACKLINK         = 8362L,
        /// <summary>The cross reference for the specified naming context could not be found.</summary>
        ERROR_DS_NO_CROSSREF_FOR_NC      = 8363L,
        /// <summary>The operation could not be performed because the directory service is shutting down.</summary>
        ERROR_DS_SHUTTING_DOWN           = 8364L,
        /// <summary>The directory service request is invalid.</summary>
        ERROR_DS_UNKNOWN_OPERATION       = 8365L,
        /// <summary>The role owner attribute could not be read.</summary>
        ERROR_DS_INVALID_ROLE_OWNER      = 8366L,
        /// <summary>The requested FSMO operation failed. The current FSMO holder could not be contacted.</summary>
        ERROR_DS_COULDNT_CONTACT_FSMO    = 8367L,
        /// <summary>Modification of a DN across a naming context is not permitted.</summary>
        ERROR_DS_CROSS_NC_DN_RENAME      = 8368L,
        /// <summary>The attribute cannot be modified because it is owned by the system.</summary>
        ERROR_DS_CANT_MOD_SYSTEM_ONLY    = 8369L,
        /// <summary>Only the replicator can perform this function.</summary>
        ERROR_DS_REPLICATOR_ONLY         = 8370L,
        /// <summary>The specified class is not defined.</summary>
        ERROR_DS_OBJ_CLASS_NOT_DEFINED   = 8371L,
        /// <summary>The specified class is not a subclass.</summary>
        ERROR_DS_OBJ_CLASS_NOT_SUBCLASS  = 8372L,
        /// <summary>The name reference is invalid.</summary>
        ERROR_DS_NAME_REFERENCE_INVALID  = 8373L,
        /// <summary>A cross reference already exists.</summary>
        ERROR_DS_CROSS_REF_EXISTS        = 8374L,
        /// <summary>It is not permitted to delete a master cross reference.</summary>
        ERROR_DS_CANT_DEL_MASTER_CROSSREF = 8375L,
        /// <summary>Subtree notifications are only supported on NC heads.</summary>
        ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD = 8376L,
        /// <summary>Notification filter is too complex.</summary>
        ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX = 8377L,
        /// <summary>Schema update failed: duplicate RDN.</summary>
        ERROR_DS_DUP_RDN                 = 8378L,
        /// <summary>Schema update failed: duplicate OID.</summary>
        ERROR_DS_DUP_OID                 = 8379L,
        /// <summary>Schema update failed: duplicate MAPI identifier.</summary>
        ERROR_DS_DUP_MAPI_ID             = 8380L,
        /// <summary>Schema update failed: duplicate schema-id GUID.</summary>
        ERROR_DS_DUP_SCHEMA_ID_GUID      = 8381L,
        /// <summary>Schema update failed: duplicate LDAP display name.</summary>
        ERROR_DS_DUP_LDAP_DISPLAY_NAME   = 8382L,
        /// <summary>Schema update failed: range-lower less than range upper.</summary>
        ERROR_DS_SEMANTIC_ATT_TEST       = 8383L,
        /// <summary>Schema update failed: syntax mismatch.</summary>
        ERROR_DS_SYNTAX_MISMATCH         = 8384L,
        /// <summary>Schema deletion failed: attribute is used in must-contain.</summary>
        ERROR_DS_EXISTS_IN_MUST_HAVE     = 8385L,
        /// <summary>Schema deletion failed: attribute is used in may-contain.</summary>
        ERROR_DS_EXISTS_IN_MAY_HAVE      = 8386L,
        /// <summary>Schema update failed: attribute in may-contain does not exist.</summary>
        ERROR_DS_NONEXISTENT_MAY_HAVE    = 8387L,
        /// <summary>Schema update failed: attribute in must-contain does not exist.</summary>
        ERROR_DS_NONEXISTENT_MUST_HAVE   = 8388L,
        /// <summary>Schema update failed: class in aux-class list does not exist or is not an auxiliary class.</summary>
        ERROR_DS_AUX_CLS_TEST_FAIL       = 8389L,
        /// <summary>Schema update failed: class in poss-superiors does not exist.</summary>
        ERROR_DS_NONEXISTENT_POSS_SUP    = 8390L,
        /// <summary>Schema update failed: class in subclassof list does not exist or does not satisfy hierarchy rules.</summary>
        ERROR_DS_SUB_CLS_TEST_FAIL       = 8391L,
        /// <summary>Schema update failed: Rdn-Att-Id has wrong syntax.</summary>
        ERROR_DS_BAD_RDN_ATT_ID_SYNTAX   = 8392L,
        /// <summary>Schema deletion failed: class is used as auxiliary class.</summary>
        ERROR_DS_EXISTS_IN_AUX_CLS       = 8393L,
        /// <summary>Schema deletion failed: class is used as sub class.</summary>
        ERROR_DS_EXISTS_IN_SUB_CLS       = 8394L,
        /// <summary>Schema deletion failed: class is used as poss superior.</summary>
        ERROR_DS_EXISTS_IN_POSS_SUP      = 8395L,
        /// <summary>Schema update failed in recalculating validation cache.</summary>
        ERROR_DS_RECALCSCHEMA_FAILED     = 8396L,
        /// <summary>The tree deletion is not finished. The request must be made again to continue deleting the tree.</summary>
        ERROR_DS_TREE_DELETE_NOT_FINISHED = 8397L,
        /// <summary>The requested delete operation could not be performed.</summary>
        ERROR_DS_CANT_DELETE             = 8398L,
        /// <summary>Cannot read the governs class identifier for the schema record.</summary>
        ERROR_DS_ATT_SCHEMA_REQ_ID       = 8399L,
        /// <summary>The attribute schema has bad syntax.</summary>
        ERROR_DS_BAD_ATT_SCHEMA_SYNTAX   = 8400L,
        /// <summary>The attribute could not be cached.</summary>
        ERROR_DS_CANT_CACHE_ATT          = 8401L,
        /// <summary>The class could not be cached.</summary>
        ERROR_DS_CANT_CACHE_CLASS        = 8402L,
        /// <summary>The attribute could not be removed from the cache.</summary>
        ERROR_DS_CANT_REMOVE_ATT_CACHE   = 8403L,
        /// <summary>The class could not be removed from the cache.</summary>
        ERROR_DS_CANT_REMOVE_CLASS_CACHE = 8404L,
        /// <summary>The distinguished name attribute could not be read.</summary>
        ERROR_DS_CANT_RETRIEVE_DN        = 8405L,
        /// <summary>No superior reference has been configured for the directory service. The directory service is therefore unable to issue referrals to objects outside this forest.</summary>
        ERROR_DS_MISSING_SUPREF          = 8406L,
        /// <summary>The instance type attribute could not be retrieved.</summary>
        ERROR_DS_CANT_RETRIEVE_INSTANCE  = 8407L,
        /// <summary>An internal error has occurred.</summary>
        ERROR_DS_CODE_INCONSISTENCY      = 8408L,
        /// <summary>A database error has occurred.</summary>
        ERROR_DS_DATABASE_ERROR          = 8409L,
        /// <summary>The attribute GOVERNSID is missing.</summary>
        ERROR_DS_GOVERNSID_MISSING       = 8410L,
        /// <summary>An expected attribute is missing.</summary>
        ERROR_DS_MISSING_EXPECTED_ATT    = 8411L,
        /// <summary>The specified naming context is missing a cross reference.</summary>
        ERROR_DS_NCNAME_MISSING_CR_REF   = 8412L,
        /// <summary>A security checking error has occurred.</summary>
        ERROR_DS_SECURITY_CHECKING_ERROR = 8413L,
        /// <summary>The schema is not loaded.</summary>
        ERROR_DS_SCHEMA_NOT_LOADED       = 8414L,
        /// <summary>Schema allocation failed. Please check if the machine is running low on memory.</summary>
        ERROR_DS_SCHEMA_ALLOC_FAILED     = 8415L,
        /// <summary>Failed to obtain the required syntax for the attribute schema.</summary>
        ERROR_DS_ATT_SCHEMA_REQ_SYNTAX   = 8416L,
        /// <summary>The global catalog verification failed. The global catalog is not available or does not support the operation. Some part of the directory is currently not available.</summary>
        ERROR_DS_GCVERIFY_ERROR          = 8417L,
        /// <summary>The replication operation failed because of a schema mismatch between the servers involved.</summary>
        ERROR_DS_DRA_SCHEMA_MISMATCH     = 8418L,
        /// <summary>The DSA object could not be found.</summary>
        ERROR_DS_CANT_FIND_DSA_OBJ       = 8419L,
        /// <summary>The naming context could not be found.</summary>
        ERROR_DS_CANT_FIND_EXPECTED_NC   = 8420L,
        /// <summary>The naming context could not be found in the cache.</summary>
        ERROR_DS_CANT_FIND_NC_IN_CACHE   = 8421L,
        /// <summary>The child object could not be retrieved.</summary>
        ERROR_DS_CANT_RETRIEVE_CHILD     = 8422L,
        /// <summary>The modification was not permitted for security reasons.</summary>
        ERROR_DS_SECURITY_ILLEGAL_MODIFY = 8423L,
        /// <summary>The operation cannot replace the hidden record.</summary>
        ERROR_DS_CANT_REPLACE_HIDDEN_REC = 8424L,
        /// <summary>The hierarchy file is invalid.</summary>
        ERROR_DS_BAD_HIERARCHY_FILE      = 8425L,
        /// <summary>The attempt to build the hierarchy table failed.</summary>
        ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED = 8426L,
        /// <summary>The directory configuration parameter is missing from the registry.</summary>
        ERROR_DS_CONFIG_PARAM_MISSING    = 8427L,
        /// <summary>The attempt to count the address book indices failed.</summary>
        ERROR_DS_COUNTING_AB_INDICES_FAILED = 8428L,
        /// <summary>The allocation of the hierarchy table failed.</summary>
        ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED = 8429L,
        /// <summary>The directory service encountered an internal failure.</summary>
        ERROR_DS_INTERNAL_FAILURE        = 8430L,
        /// <summary>The directory service encountered an unknown failure.</summary>
        ERROR_DS_UNKNOWN_ERROR           = 8431L,
        /// <summary>A root object requires a class of 'top'.</summary>
        ERROR_DS_ROOT_REQUIRES_CLASS_TOP = 8432L,
        /// <summary>This directory server is shutting down, and cannot take ownership of new floating single-master operation roles.</summary>
        ERROR_DS_REFUSING_FSMO_ROLES     = 8433L,
        /// <summary>The directory service is missing mandatory configuration information, and is unable to determine the ownership of floating single-master operation roles.</summary>
        ERROR_DS_MISSING_FSMO_SETTINGS   = 8434L,
        /// <summary>The directory service was unable to transfer ownership of one or more floating single-master operation roles to other servers.</summary>
        ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435L,
        /// <summary>The replication operation failed.</summary>
        ERROR_DS_DRA_GENERIC             = 8436L,
        /// <summary>An invalid parameter was specified for this replication operation.</summary>
        ERROR_DS_DRA_INVALID_PARAMETER   = 8437L,
        /// <summary>The directory service is too busy to complete the replication operation at this time.</summary>
        ERROR_DS_DRA_BUSY                = 8438L,
        /// <summary>The distinguished name specified for this replication operation is invalid.</summary>
        ERROR_DS_DRA_BAD_DN              = 8439L,
        /// <summary>The naming context specified for this replication operation is invalid.</summary>
        ERROR_DS_DRA_BAD_NC              = 8440L,
        /// <summary>The distinguished name specified for this replication operation already exists.</summary>
        ERROR_DS_DRA_DN_EXISTS           = 8441L,
        /// <summary>The replication system encountered an internal error.</summary>
        ERROR_DS_DRA_INTERNAL_ERROR      = 8442L,
        /// <summary>The replication operation encountered a database inconsistency.</summary>
        ERROR_DS_DRA_INCONSISTENT_DIT    = 8443L,
        /// <summary>The server specified for this replication operation could not be contacted.</summary>
        ERROR_DS_DRA_CONNECTION_FAILED   = 8444L,
        /// <summary>The replication operation encountered an object with an invalid instance type.</summary>
        ERROR_DS_DRA_BAD_INSTANCE_TYPE   = 8445L,
        /// <summary>The replication operation failed to allocate memory.</summary>
        ERROR_DS_DRA_OUT_OF_MEM          = 8446L,
        /// <summary>The replication operation encountered an error with the mail system.</summary>
        ERROR_DS_DRA_MAIL_PROBLEM        = 8447L,
        /// <summary>The replication reference information for the target server already exists.</summary>
        ERROR_DS_DRA_REF_ALREADY_EXISTS  = 8448L,
        /// <summary>The replication reference information for the target server does not exist.</summary>
        ERROR_DS_DRA_REF_NOT_FOUND       = 8449L,
        /// <summary>The naming context cannot be removed because it is replicated to another server.</summary>
        ERROR_DS_DRA_OBJ_IS_REP_SOURCE   = 8450L,
        /// <summary>The replication operation encountered a database error.</summary>
        ERROR_DS_DRA_DB_ERROR            = 8451L,
        /// <summary>The naming context is in the process of being removed or is not replicated from the specified server.</summary>
        ERROR_DS_DRA_NO_REPLICA          = 8452L,
        /// <summary>Replication access was denied.</summary>
        ERROR_DS_DRA_ACCESS_DENIED       = 8453L,
        /// <summary>The requested operation is not supported by this version of the directory service.</summary>
        ERROR_DS_DRA_NOT_SUPPORTED       = 8454L,
        /// <summary>The replication remote procedure call was cancelled.</summary>
        ERROR_DS_DRA_RPC_CANCELLED       = 8455L,
        /// <summary>The source server is currently rejecting replication requests.</summary>
        ERROR_DS_DRA_SOURCE_DISABLED     = 8456L,
        /// <summary>The destination server is currently rejecting replication requests.</summary>
        ERROR_DS_DRA_SINK_DISABLED       = 8457L,
        /// <summary>The replication operation failed due to a collision of object names.</summary>
        ERROR_DS_DRA_NAME_COLLISION      = 8458L,
        /// <summary>The replication source has been reinstalled.</summary>
        ERROR_DS_DRA_SOURCE_REINSTALLED  = 8459L,
        /// <summary>The replication operation failed because a required parent object is missing.</summary>
        ERROR_DS_DRA_MISSING_PARENT      = 8460L,
        /// <summary>The replication operation was preempted.</summary>
        ERROR_DS_DRA_PREEMPTED           = 8461L,
        /// <summary>The replication synchronization attempt was abandoned because of a lack of updates.</summary>
        ERROR_DS_DRA_ABANDON_SYNC        = 8462L,
        /// <summary>The replication operation was terminated because the system is shutting down.</summary>
        ERROR_DS_DRA_SHUTDOWN            = 8463L,
        /// <summary>Synchronization attempt failed because the destination DC is currently waiting to synchronize new partial attributes from source. This condition is normal if a recent schema change modified the partial attribute set. The destination partial attribute set is not a subset of source partial attribute set.</summary>
        ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET = 8464L,
        /// <summary>The replication synchronization attempt failed because a master replica attempted to sync from a partial replica.</summary>
        ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA = 8465L,
        /// <summary>The server specified for this replication operation was contacted, but that server was unable to contact an additional server needed to complete the operation.</summary>
        ERROR_DS_DRA_EXTN_CONNECTION_FAILED = 8466L,
        /// <summary>The version of the directory service schema of the source forest is not compatible with the version of directory service on this computer.</summary>
        ERROR_DS_INSTALL_SCHEMA_MISMATCH = 8467L,
        /// <summary>Schema update failed: An attribute with the same link identifier already exists.</summary>
        ERROR_DS_DUP_LINK_ID             = 8468L,
        /// <summary>Name translation: Generic processing error.</summary>
        ERROR_DS_NAME_ERROR_RESOLVING    = 8469L,
        /// <summary>Name translation: Could not find the name or insufficient right to see name.</summary>
        ERROR_DS_NAME_ERROR_NOT_FOUND    = 8470L,
        /// <summary>Name translation: Input name mapped to more than one output name.</summary>
        ERROR_DS_NAME_ERROR_NOT_UNIQUE   = 8471L,
        /// <summary>Name translation: Input name found, but not the associated output format.</summary>
        ERROR_DS_NAME_ERROR_NO_MAPPING   = 8472L,
        /// <summary>Name translation: Unable to resolve completely, only the domain was found.</summary>
        ERROR_DS_NAME_ERROR_DOMAIN_ONLY  = 8473L,
        /// <summary>Name translation: Unable to perform purely syntactical mapping at the client without going out to the wire.</summary>
        ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 8474L,
        /// <summary>Modification of a constructed attribute is not allowed.</summary>
        ERROR_DS_CONSTRUCTED_ATT_MOD     = 8475L,
        /// <summary>The OM-Object-Class specified is incorrect for an attribute with the specified syntax.</summary>
        ERROR_DS_WRONG_OM_OBJ_CLASS      = 8476L,
        /// <summary>The replication request has been posted; waiting for reply.</summary>
        ERROR_DS_DRA_REPL_PENDING        = 8477L,
        /// <summary>The requested operation requires a directory service, and none was available.</summary>
        ERROR_DS_DS_REQUIRED             = 8478L,
        /// <summary>The LDAP display name of the class or attribute contains non-ASCII characters.</summary>
        ERROR_DS_INVALID_LDAP_DISPLAY_NAME = 8479L,
        /// <summary>The requested search operation is only supported for base searches.</summary>
        ERROR_DS_NON_BASE_SEARCH         = 8480L,
        /// <summary>The search failed to retrieve attributes from the database.</summary>
        ERROR_DS_CANT_RETRIEVE_ATTS      = 8481L,
        /// <summary>The schema update operation tried to add a backward link attribute that has no corresponding forward link.</summary>
        ERROR_DS_BACKLINK_WITHOUT_LINK   = 8482L,
        /// <summary>Source and destination of a cross-domain move do not agree on the object's epoch number. Either source or destination does not have the latest version of the object.</summary>
        ERROR_DS_EPOCH_MISMATCH          = 8483L,
        /// <summary>Source and destination of a cross-domain move do not agree on the object's current name. Either source or destination does not have the latest version of the object.</summary>
        ERROR_DS_SRC_NAME_MISMATCH       = 8484L,
        /// <summary>Source and destination for the cross-domain move operation are identical. Caller should use local move operation instead of cross-domain move operation.</summary>
        ERROR_DS_SRC_AND_DST_NC_IDENTICAL = 8485L,
        /// <summary>Source and destination for a cross-domain move are not in agreement on the naming contexts in the forest. Either source or destination does not have the latest version of the Partitions container.</summary>
        ERROR_DS_DST_NC_MISMATCH         = 8486L,
        /// <summary>Destination of a cross-domain move is not authoritative for the destination naming context.</summary>
        ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC = 8487L,
        /// <summary>Source and destination of a cross-domain move do not agree on the identity of the source object. Either source or destination does not have the latest version of the source object.</summary>
        ERROR_DS_SRC_GUID_MISMATCH       = 8488L,
        /// <summary>Object being moved across-domains is already known to be deleted by the destination server. The source server does not have the latest version of the source object.</summary>
        ERROR_DS_CANT_MOVE_DELETED_OBJECT = 8489L,
        /// <summary>Another operation which requires exclusive access to the PDC FSMO is already in progress.</summary>
        ERROR_DS_PDC_OPERATION_IN_PROGRESS = 8490L,
        /// <summary>A cross-domain move operation failed such that two versions of the moved object exist - one each in the source and destination domains. The destination object needs to be removed to restore the system to a consistent state.</summary>
        ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD = 8491L,
        /// <summary>This object may not be moved across domain boundaries either because cross-domain moves for this class are disallowed, or the object has some special characteristics, e.g.: trust account or restricted RID, which prevent its move.</summary>
        ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION = 8492L,
        /// <summary>Can't move objects with memberships across domain boundaries as once moved, this would violate the membership conditions of the account group. Remove the object from any account group memberships and retry.</summary>
        ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS = 8493L,
        /// <summary>A naming context head must be the immediate child of another naming context head, not of an interior node.</summary>
        ERROR_DS_NC_MUST_HAVE_NC_PARENT  = 8494L,
        /// <summary>The directory cannot validate the proposed naming context name because it does not hold a replica of the naming context above the proposed naming context. Please ensure that the domain naming master role is held by a server that is configured as a global catalog server, and that the server is up to date with its replication partners. (Applies only to Windows 2000 Domain Naming masters)</summary>
        ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE = 8495L,
        /// <summary>Destination domain must be in native mode.</summary>
        ERROR_DS_DST_DOMAIN_NOT_NATIVE   = 8496L,
        /// <summary>The operation cannot be performed because the server does not have an infrastructure container in the domain of interest.</summary>
        ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER = 8497L,
        /// <summary>Cross-domain move of non-empty account groups is not allowed.</summary>
        ERROR_DS_CANT_MOVE_ACCOUNT_GROUP = 8498L,
        /// <summary>Cross-domain move of non-empty resource groups is not allowed.</summary>
        ERROR_DS_CANT_MOVE_RESOURCE_GROUP = 8499L,
        /// <summary>The search flags for the attribute are invalid. The ANR bit is valid only on attributes of Unicode or Teletex strings.</summary>
        ERROR_DS_INVALID_SEARCH_FLAG     = 8500L,
        /// <summary>Tree deletions starting at an object which has an NC head as a descendant are not allowed.</summary>
        ERROR_DS_NO_TREE_DELETE_ABOVE_NC = 8501L,
        /// <summary>The directory service failed to lock a tree in preparation for a tree deletion because the tree was in use.</summary>
        ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE = 8502L,
        /// <summary>The directory service failed to identify the list of objects to delete while attempting a tree deletion.</summary>
        ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE = 8503L,
        /// <summary>Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please shutdown this system and reboot into Directory Services Restore Mode, check the event log for more detailed information.</summary>
        ERROR_DS_SAM_INIT_FAILURE        = 8504L,
        /// <summary>Only an administrator can modify the membership list of an administrative group.</summary>
        ERROR_DS_SENSITIVE_GROUP_VIOLATION = 8505L,
        /// <summary>Cannot change the primary group ID of a domain controller account.</summary>
        ERROR_DS_CANT_MOD_PRIMARYGROUPID = 8506L,
        /// <summary>An attempt is made to modify the base schema.</summary>
        ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD = 8507L,
        /// <summary>Adding a new mandatory attribute to an existing class, deleting a mandatory attribute from an existing class, or adding an optional attribute to the special class Top that is not a backlink attribute (directly or through inheritance, for example, by adding or deleting an auxiliary class) is not allowed.</summary>
        ERROR_DS_NONSAFE_SCHEMA_CHANGE   = 8508L,
        /// <summary>Schema update is not allowed on this DC because the DC is not the schema FSMO Role Owner.</summary>
        ERROR_DS_SCHEMA_UPDATE_DISALLOWED = 8509L,
        /// <summary>An object of this class cannot be created under the schema container. You can only create attribute-schema and class-schema objects under the schema container.</summary>
        ERROR_DS_CANT_CREATE_UNDER_SCHEMA = 8510L,
        /// <summary>The replica/child install failed to get the objectVersion attribute on the schema container on the source DC. Either the attribute is missing on the schema container or the credentials supplied do not have permission to read it.</summary>
        ERROR_DS_INSTALL_NO_SRC_SCH_VERSION = 8511L,
        /// <summary>The replica/child install failed to read the objectVersion attribute in the SCHEMA section of the file schema.ini in the system32 directory.</summary>
        ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE = 8512L,
        /// <summary>The specified group type is invalid.</summary>
        ERROR_DS_INVALID_GROUP_TYPE      = 8513L,
        /// <summary>You cannot nest global groups in a mixed domain if the group is security-enabled.</summary>
        ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 8514L,
        /// <summary>You cannot nest local groups in a mixed domain if the group is security-enabled.</summary>
        ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 8515L,
        /// <summary>A global group cannot have a local group as a member.</summary>
        ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 8516L,
        /// <summary>A global group cannot have a universal group as a member.</summary>
        ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 8517L,
        /// <summary>A universal group cannot have a local group as a member.</summary>
        ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 8518L,
        /// <summary>A global group cannot have a cross-domain member.</summary>
        ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 8519L,
        /// <summary>A local group cannot have another cross domain local group as a member.</summary>
        ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 8520L,
        /// <summary>A group with primary members cannot change to a security-disabled group.</summary>
        ERROR_DS_HAVE_PRIMARY_MEMBERS    = 8521L,
        /// <summary>The schema cache load failed to convert the string default SD on a class-schema object.</summary>
        ERROR_DS_STRING_SD_CONVERSION_FAILED = 8522L,
        /// <summary>Only DSAs configured to be Global Catalog servers should be allowed to hold the Domain Naming Master FSMO role. (Applies only to Windows 2000 servers)</summary>
        ERROR_DS_NAMING_MASTER_GC        = 8523L,
        /// <summary>The DSA operation is unable to proceed because of a DNS lookup failure.</summary>
        ERROR_DS_DNS_LOOKUP_FAILURE      = 8524L,
        /// <summary>While processing a change to the DNS Host Name for an object, the Service Principal Name values could not be kept in sync.</summary>
        ERROR_DS_COULDNT_UPDATE_SPNS     = 8525L,
        /// <summary>The Security Descriptor attribute could not be read.</summary>
        ERROR_DS_CANT_RETRIEVE_SD        = 8526L,
        /// <summary>The object requested was not found, but an object with that key was found.</summary>
        ERROR_DS_KEY_NOT_UNIQUE          = 8527L,
        /// <summary>The syntax of the linked attribute being added is incorrect. Forward links can only have syntax 2.5.5.1, 2.5.5.7, and 2.5.5.14, and backlinks can only have syntax 2.5.5.1</summary>
        ERROR_DS_WRONG_LINKED_ATT_SYNTAX = 8528L,
        /// <summary>Security Account Manager needs to get the boot password.</summary>
        ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD = 8529L,
        /// <summary>Security Account Manager needs to get the boot key from floppy disk.</summary>
        ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY = 8530L,
        /// <summary>Directory Service cannot start.</summary>
        ERROR_DS_CANT_START              = 8531L,
        /// <summary>Directory Services could not start.</summary>
        ERROR_DS_INIT_FAILURE            = 8532L,
        /// <summary>The connection between client and server requires packet privacy or better.</summary>
        ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION = 8533L,
        /// <summary>The source domain may not be in the same forest as destination.</summary>
        ERROR_DS_SOURCE_DOMAIN_IN_FOREST = 8534L,
        /// <summary>The destination domain must be in the forest.</summary>
        ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST = 8535L,
        /// <summary>The operation requires that destination domain auditing be enabled.</summary>
        ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED = 8536L,
        /// <summary>The operation couldn't locate a DC for the source domain.</summary>
        ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN = 8537L,
        /// <summary>The source object must be a group or user.</summary>
        ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER = 8538L,
        /// <summary>The source object's SID already exists in destination forest.</summary>
        ERROR_DS_SRC_SID_EXISTS_IN_FOREST = 8539L,
        /// <summary>The source and destination object must be of the same type.</summary>
        ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH = 8540L,
        /// <summary>Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Click OK to shut down the system and reboot into Safe Mode. Check the event log for detailed information.</summary>
        ERROR_SAM_INIT_FAILURE           = 8541L,
        /// <summary>Schema information could not be included in the replication request.</summary>
        ERROR_DS_DRA_SCHEMA_INFO_SHIP    = 8542L,
        /// <summary>The replication operation could not be completed due to a schema incompatibility.</summary>
        ERROR_DS_DRA_SCHEMA_CONFLICT     = 8543L,
        /// <summary>The replication operation could not be completed due to a previous schema incompatibility.</summary>
        ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT = 8544L,
        /// <summary>The replication update could not be applied because either the source or the destination has not yet received information regarding a recent cross-domain move operation.</summary>
        ERROR_DS_DRA_OBJ_NC_MISMATCH     = 8545L,
        /// <summary>The requested domain could not be deleted because there exist domain controllers that still host this domain.</summary>
        ERROR_DS_NC_STILL_HAS_DSAS       = 8546L,
        /// <summary>The requested operation can be performed only on a global catalog server.</summary>
        ERROR_DS_GC_REQUIRED             = 8547L,
        /// <summary>A local group can only be a member of other local groups in the same domain.</summary>
        ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 8548L,
        /// <summary>Foreign security principals cannot be members of universal groups.</summary>
        ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 8549L,
        /// <summary>The attribute is not allowed to be replicated to the GC because of security reasons.</summary>
        ERROR_DS_CANT_ADD_TO_GC          = 8550L,
        /// <summary>The checkpoint with the PDC could not be taken because there too many modifications being processed currently.</summary>
        ERROR_DS_NO_CHECKPOINT_WITH_PDC  = 8551L,
        /// <summary>The operation requires that source domain auditing be enabled.</summary>
        ERROR_DS_SOURCE_AUDITING_NOT_ENABLED = 8552L,
        /// <summary>Security principal objects can only be created inside domain naming contexts.</summary>
        ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC = 8553L,
        /// <summary>A Service Principal Name (SPN) could not be constructed because the provided hostname is not in the necessary format.</summary>
        ERROR_DS_INVALID_NAME_FOR_SPN    = 8554L,
        /// <summary>A Filter was passed that uses constructed attributes.</summary>
        ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS = 8555L,
        /// <summary>The unicodePwd attribute value must be enclosed in double quotes.</summary>
        ERROR_DS_UNICODEPWD_NOT_IN_QUOTES = 8556L,
        /// <summary>Your computer could not be joined to the domain. You have exceeded the maximum number of computer accounts you are allowed to create in this domain. Contact your system administrator to have this limit reset or increased.</summary>
        ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 8557L,
        /// <summary>For security reasons, the operation must be run on the destination DC.</summary>
        ERROR_DS_MUST_BE_RUN_ON_DST_DC   = 8558L,
        /// <summary>For security reasons, the source DC must be NT4SP4 or greater.</summary>
        ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER = 8559L,
        /// <summary>Critical Directory Service System objects cannot be deleted during tree delete operations. The tree delete may have been partially performed.</summary>
        ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ = 8560L,
        /// <summary>Directory Services could not start because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.</summary>
        ERROR_DS_INIT_FAILURE_CONSOLE    = 8561L,
        /// <summary>Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.</summary>
        ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562L,
        /// <summary>The version of the operating system is incompatible with the current AD DS forest functional level or AD LDS Configuration Set functional level. You must upgrade to a new version of the operating system before this server can become an AD DS Domain Controller or add an AD LDS Instance in this AD DS Forest or AD LDS Configuration Set.</summary>
        ERROR_DS_FOREST_VERSION_TOO_HIGH = 8563L,
        /// <summary>The version of the operating system installed is incompatible with the current domain functional level. You must upgrade to a new version of the operating system before this server can become a domain controller in this domain.</summary>
        ERROR_DS_DOMAIN_VERSION_TOO_HIGH = 8564L,
        /// <summary>The version of the operating system installed on this server no longer supports the current AD DS Forest functional level or AD LDS Configuration Set functional level. You must raise the AD DS Forest functional level or AD LDS Configuration Set functional level before this server can become an AD DS Domain Controller or an AD LDS Instance in this Forest or Configuration Set.</summary>
        ERROR_DS_FOREST_VERSION_TOO_LOW  = 8565L,
        /// <summary>The version of the operating system installed on this server no longer supports the current domain functional level. You must raise the domain functional level before this server can become a domain controller in this domain.</summary>
        ERROR_DS_DOMAIN_VERSION_TOO_LOW  = 8566L,
        /// <summary>The version of the operating system installed on this server is incompatible with the functional level of the domain or forest.</summary>
        ERROR_DS_INCOMPATIBLE_VERSION    = 8567L,
        /// <summary>The functional level of the domain (or forest) cannot be raised to the requested value, because there exist one or more domain controllers in the domain (or forest) that are at a lower incompatible functional level.</summary>
        ERROR_DS_LOW_DSA_VERSION         = 8568L,
        /// <summary>The forest functional level cannot be raised to the requested value since one or more domains are still in mixed domain mode. All domains in the forest must be in native mode, for you to raise the forest functional level.</summary>
        ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN = 8569L,
        /// <summary>The sort order requested is not supported.</summary>
        ERROR_DS_NOT_SUPPORTED_SORT_ORDER = 8570L,
        /// <summary>The requested name already exists as a unique identifier.</summary>
        ERROR_DS_NAME_NOT_UNIQUE         = 8571L,
        /// <summary>The machine account was created pre-NT4. The account needs to be recreated.</summary>
        ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 = 8572L,
        /// <summary>The database is out of version store.</summary>
        ERROR_DS_OUT_OF_VERSION_STORE    = 8573L,
        /// <summary>Unable to continue operation because multiple conflicting controls were used.</summary>
        ERROR_DS_INCOMPATIBLE_CONTROLS_USED = 8574L,
        /// <summary>Unable to find a valid security descriptor reference domain for this partition.</summary>
        ERROR_DS_NO_REF_DOMAIN           = 8575L,
        /// <summary>Schema update failed: The link identifier is reserved.</summary>
        ERROR_DS_RESERVED_LINK_ID        = 8576L,
        /// <summary>Schema update failed: There are no link identifiers available.</summary>
        ERROR_DS_LINK_ID_NOT_AVAILABLE   = 8577L,
        /// <summary>An account group cannot have a universal group as a member.</summary>
        ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 8578L,
        /// <summary>Rename or move operations on naming context heads or read-only objects are not allowed.</summary>
        ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE = 8579L,
        /// <summary>Move operations on objects in the schema naming context are not allowed.</summary>
        ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC = 8580L,
        /// <summary>A system flag has been set on the object and does not allow the object to be moved or renamed.</summary>
        ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG = 8581L,
        /// <summary>This object is not allowed to change its grandparent container. Moves are not forbidden on this object, but are restricted to sibling containers.</summary>
        ERROR_DS_MODIFYDN_WRONG_GRANDPARENT = 8582L,
        /// <summary>Unable to resolve completely, a referral to another forest is generated.</summary>
        ERROR_DS_NAME_ERROR_TRUST_REFERRAL = 8583L,
        /// <summary>The requested action is not supported on standard server.</summary>
        ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER = 8584L,
        /// <summary>Could not access a partition of the directory service located on a remote server. Make sure at least one server is running for the partition in question.</summary>
        ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD = 8585L,
        /// <summary>The directory cannot validate the proposed naming context (or partition) name because it does not hold a replica nor can it contact a replica of the naming context above the proposed naming context. Please ensure that the parent naming context is properly registered in DNS, and at least one replica of this naming context is reachable by the Domain Naming master.</summary>
        ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 = 8586L,
        /// <summary>The thread limit for this request was exceeded.</summary>
        ERROR_DS_THREAD_LIMIT_EXCEEDED   = 8587L,
        /// <summary>The Global catalog server is not in the closest site.</summary>
        ERROR_DS_NOT_CLOSEST             = 8588L,
        /// <summary>The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the corresponding server object in the local DS database has no serverReference attribute.</summary>
        ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF = 8589L,
        /// <summary>The Directory Service failed to enter single user mode.</summary>
        ERROR_DS_SINGLE_USER_MODE_FAILED = 8590L,
        /// <summary>The Directory Service cannot parse the script because of a syntax error.</summary>
        ERROR_DS_NTDSCRIPT_SYNTAX_ERROR  = 8591L,
        /// <summary>The Directory Service cannot process the script because of an error.</summary>
        ERROR_DS_NTDSCRIPT_PROCESS_ERROR = 8592L,
        /// <summary>The directory service cannot perform the requested operation because the servers involved are of different replication epochs (which is usually related to a domain rename that is in progress).</summary>
        ERROR_DS_DIFFERENT_REPL_EPOCHS   = 8593L,
        /// <summary>The directory service binding must be renegotiated due to a change in the server extensions information.</summary>
        ERROR_DS_DRS_EXTENSIONS_CHANGED  = 8594L,
        /// <summary>Operation not allowed on a disabled cross ref.</summary>
        ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR = 8595L,
        /// <summary>Schema update failed: No values for msDS-IntId are available.</summary>
        ERROR_DS_NO_MSDS_INTID           = 8596L,
        /// <summary>Schema update failed: Duplicate msDS-INtId. Retry the operation.</summary>
        ERROR_DS_DUP_MSDS_INTID          = 8597L,
        /// <summary>Schema deletion failed: attribute is used in rDNAttID.</summary>
        ERROR_DS_EXISTS_IN_RDNATTID      = 8598L,
        /// <summary>The directory service failed to authorize the request.</summary>
        ERROR_DS_AUTHORIZATION_FAILED    = 8599L,
        /// <summary>The Directory Service cannot process the script because it is invalid.</summary>
        ERROR_DS_INVALID_SCRIPT          = 8600L,
        /// <summary>The remote create cross reference operation failed on the Domain Naming Master FSMO. The operation's error is in the extended data.</summary>
        ERROR_DS_REMOTE_CROSSREF_OP_FAILED = 8601L,
        /// <summary>A cross reference is in use locally with the same name.</summary>
        ERROR_DS_CROSS_REF_BUSY          = 8602L,
        /// <summary>The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the server's domain has been deleted from the forest.</summary>
        ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN = 8603L,
        /// <summary>Writeable NCs prevent this DC from demoting.</summary>
        ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC = 8604L,
        /// <summary>The requested object has a non-unique identifier and cannot be retrieved.</summary>
        ERROR_DS_DUPLICATE_ID_FOUND      = 8605L,
        /// <summary>Insufficient attributes were given to create an object. This object may not exist because it may have been deleted and already garbage collected.</summary>
        ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT = 8606L,
        /// <summary>The group cannot be converted due to attribute restrictions on the requested group type.</summary>
        ERROR_DS_GROUP_CONVERSION_ERROR  = 8607L,
        /// <summary>Cross-domain move of non-empty basic application groups is not allowed.</summary>
        ERROR_DS_CANT_MOVE_APP_BASIC_GROUP = 8608L,
        /// <summary>Cross-domain move of non-empty query based application groups is not allowed.</summary>
        ERROR_DS_CANT_MOVE_APP_QUERY_GROUP = 8609L,
        /// <summary>The FSMO role ownership could not be verified because its directory partition has not replicated successfully with at least one replication partner.</summary>
        ERROR_DS_ROLE_NOT_VERIFIED       = 8610L,
        /// <summary>The target container for a redirection of a well known object container cannot already be a special container.</summary>
        ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL = 8611L,
        /// <summary>The Directory Service cannot perform the requested operation because a domain rename operation is in progress.</summary>
        ERROR_DS_DOMAIN_RENAME_IN_PROGRESS = 8612L,
        /// <summary>The directory service detected a child partition below the requested partition name. The partition hierarchy must be created in a top down method.</summary>
        ERROR_DS_EXISTING_AD_CHILD_NC    = 8613L,
        /// <summary>The directory service cannot replicate with this server because the time since the last replication with this server has exceeded the tombstone lifetime.</summary>
        ERROR_DS_REPL_LIFETIME_EXCEEDED  = 8614L,
        /// <summary>The requested operation is not allowed on an object under the system container.</summary>
        ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER = 8615L,
        /// <summary>The LDAP servers network send queue has filled up because the client is not processing the results of its requests fast enough. No more requests will be processed until the client catches up. If the client does not catch up then it will be disconnected.</summary>
        ERROR_DS_LDAP_SEND_QUEUE_FULL    = 8616L,
        /// <summary>The scheduled replication did not take place because the system was too busy to execute the request within the schedule window. The replication queue is overloaded. Consider reducing the number of partners or decreasing the scheduled replication frequency.</summary>
        ERROR_DS_DRA_OUT_SCHEDULE_WINDOW = 8617L,
        /// <summary>At this time, it cannot be determined if the branch replication policy is available on the hub domain controller. Please retry at a later time to account for replication latencies.</summary>
        ERROR_DS_POLICY_NOT_KNOWN        = 8618L,
        /// <summary>The site settings object for the specified site does not exist.</summary>
        ERROR_NO_SITE_SETTINGS_OBJECT    = 8619L,
        /// <summary>The local account store does not contain secret material for the specified account.</summary>
        ERROR_NO_SECRETS                 = 8620L,
        /// <summary>Could not find a writable domain controller in the domain.</summary>
        ERROR_NO_WRITABLE_DC_FOUND       = 8621L,
        /// <summary>The server object for the domain controller does not exist.</summary>
        ERROR_DS_NO_SERVER_OBJECT        = 8622L,
        /// <summary>The NTDS Settings object for the domain controller does not exist.</summary>
        ERROR_DS_NO_NTDSA_OBJECT         = 8623L,
        /// <summary>The requested search operation is not supported for ASQ searches.</summary>
        ERROR_DS_NON_ASQ_SEARCH          = 8624L,
        /// <summary>A required audit event could not be generated for the operation.</summary>
        ERROR_DS_AUDIT_FAILURE           = 8625L,
        /// <summary>The search flags for the attribute are invalid. The subtree index bit is valid only on single valued attributes.</summary>
        ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE = 8626L,
        /// <summary>The search flags for the attribute are invalid. The tuple index bit is valid only on attributes of Unicode strings.</summary>
        ERROR_DS_INVALID_SEARCH_FLAG_TUPLE = 8627L,
        /// <summary>The address books are nested too deeply. Failed to build the hierarchy table.</summary>
        ERROR_DS_HIERARCHY_TABLE_TOO_DEEP = 8628L,
        /// <summary>The specified up-to-date-ness vector is corrupt.</summary>
        ERROR_DS_DRA_CORRUPT_UTD_VECTOR  = 8629L,
        /// <summary>The request to replicate secrets is denied.</summary>
        ERROR_DS_DRA_SECRETS_DENIED      = 8630L,
        /// <summary>Schema update failed: The MAPI identifier is reserved.</summary>
        ERROR_DS_RESERVED_MAPI_ID        = 8631L,
        /// <summary>Schema update failed: There are no MAPI identifiers available.</summary>
        ERROR_DS_MAPI_ID_NOT_AVAILABLE   = 8632L,
        /// <summary>The replication operation failed because the required attributes of the local krbtgt object are missing.</summary>
        ERROR_DS_DRA_MISSING_KRBTGT_SECRET = 8633L,
        /// <summary>The domain name of the trusted domain already exists in the forest.</summary>
        ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST = 8634L,
        /// <summary>The flat name of the trusted domain already exists in the forest.</summary>
        ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST = 8635L,
        /// <summary>The User Principal Name (UPN) is invalid.</summary>
        ERROR_INVALID_USER_PRINCIPAL_NAME = 8636L,
        /// <summary>OID mapped groups cannot have members.</summary>
        ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS = 8637L,
        /// <summary>The specified OID cannot be found.</summary>
        ERROR_DS_OID_NOT_FOUND           = 8638L,
        /// <summary>The replication operation failed because the target object referred by a link value is recycled.</summary>
        ERROR_DS_DRA_RECYCLED_TARGET     = 8639L,
        /// <summary>The redirect operation failed because the target object is in a NC different from the domain NC of the current domain controller.</summary>
        ERROR_DS_DISALLOWED_NC_REDIRECT  = 8640L,
        /// <summary>The functional level of the AD LDS configuration set cannot be lowered to the requested value.</summary>
        ERROR_DS_HIGH_ADLDS_FFL          = 8641L,
        /// <summary>The functional level of the domain (or forest) cannot be lowered to the requested value.</summary>
        ERROR_DS_HIGH_DSA_VERSION        = 8642L,
        /// <summary>The functional level of the AD LDS configuration set cannot be raised to the requested value, because there exist one or more ADLDS instances that are at a lower incompatible functional level.</summary>
        ERROR_DS_LOW_ADLDS_FFL           = 8643L,
        /// <summary>The domain join cannot be completed because the SID of the domain you attempted to join was identical to the SID of this machine. This is a symptom of an improperly cloned operating system install.  You should run sysprep on this machine in order to generate a new machine SID. Please see http://go.microsoft.com/fwlink/?LinkId=168895 for more information.</summary>
        ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION = 8644L,
        /// <summary>The undelete operation failed because the Sam Account Name or Additional Sam Account Name of the object being undeleted conflicts with an existing live object.</summary>
        ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED = 8645L,
        /// <summary>The system is not authoritative for the specified account and therefore cannot complete the operation. Please retry the operation using the provider associated with this account. If this is an online provider please use the provider's online site.</summary>
        ERROR_INCORRECT_ACCOUNT_TYPE     = 8646L,
        /// <summary>The operation failed because SPN value provided for addition/modification is not unique forest-wide.</summary>
        ERROR_DS_SPN_VALUE_NOT_UNIQUE_IN_FOREST = 8647L,
        /// <summary>The operation failed because UPN value provided for addition/modification is not unique forest-wide.</summary>
        ERROR_DS_UPN_VALUE_NOT_UNIQUE_IN_FOREST = 8648L,
        /// <summary>The operation failed because the addition/modification referenced an inbound forest-wide trust that is not present.</summary>
        ERROR_DS_MISSING_FOREST_TRUST    = 8649L,
        /// <summary>The link value specified was not found, but a link value with that key was found.</summary>
        ERROR_DS_VALUE_KEY_NOT_UNIQUE    = 8650L,
        /// <summary>DNS server unable to interpret format.</summary>
        DNS_ERROR_RCODE_FORMAT_ERROR     = 9001L,
        /// <summary>DNS server failure.</summary>
        DNS_ERROR_RCODE_SERVER_FAILURE   = 9002L,
        /// <summary>DNS name does not exist.</summary>
        DNS_ERROR_RCODE_NAME_ERROR       = 9003L,
        /// <summary>DNS request not supported by name server.</summary>
        DNS_ERROR_RCODE_NOT_IMPLEMENTED  = 9004L,
        /// <summary>DNS operation refused.</summary>
        DNS_ERROR_RCODE_REFUSED          = 9005L,
        /// <summary>DNS name that ought not exist, does exist.</summary>
        DNS_ERROR_RCODE_YXDOMAIN         = 9006L,
        /// <summary>DNS RR set that ought not exist, does exist.</summary>
        DNS_ERROR_RCODE_YXRRSET          = 9007L,
        /// <summary>DNS RR set that ought to exist, does not exist.</summary>
        DNS_ERROR_RCODE_NXRRSET          = 9008L,
        /// <summary>DNS server not authoritative for zone.</summary>
        DNS_ERROR_RCODE_NOTAUTH          = 9009L,
        /// <summary>DNS name in update or prereq is not in zone.</summary>
        DNS_ERROR_RCODE_NOTZONE          = 9010L,
        /// <summary>DNS signature failed to verify.</summary>
        DNS_ERROR_RCODE_BADSIG           = 9016L,
        /// <summary>DNS bad key.</summary>
        DNS_ERROR_RCODE_BADKEY           = 9017L,
        /// <summary>DNS signature validity expired.</summary>
        DNS_ERROR_RCODE_BADTIME          = 9018L,
        /// <summary>Only the DNS server acting as the key master for the zone may perform this operation.</summary>
        DNS_ERROR_KEYMASTER_REQUIRED     = 9101L,
        /// <summary>This operation is not allowed on a zone that is signed or has signing keys.</summary>
        DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE = 9102L,
        /// <summary>NSEC3 is not compatible with the RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC.</summary>
        DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1 = 9103L,
        /// <summary>The zone does not have enough signing keys. There must be at least one key signing key (KSK) and at least one zone signing key (ZSK).</summary>
        DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS = 9104L,
        /// <summary>The specified algorithm is not supported.</summary>
        DNS_ERROR_UNSUPPORTED_ALGORITHM  = 9105L,
        /// <summary>The specified key size is not supported.</summary>
        DNS_ERROR_INVALID_KEY_SIZE       = 9106L,
        /// <summary>One or more of the signing keys for a zone are not accessible to the DNS server. Zone signing will not be operational until this error is resolved.</summary>
        DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE = 9107L,
        /// <summary>The specified key storage provider does not support DPAPI++ data protection. Zone signing will not be operational until this error is resolved.</summary>
        DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION = 9108L,
        /// <summary>An unexpected DPAPI++ error was encountered. Zone signing will not be operational until this error is resolved.</summary>
        DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR = 9109L,
        /// <summary>An unexpected crypto error was encountered. Zone signing may not be operational until this error is resolved.</summary>
        DNS_ERROR_UNEXPECTED_CNG_ERROR   = 9110L,
        /// <summary>The DNS server encountered a signing key with an unknown version. Zone signing will not be operational until this error is resolved.</summary>
        DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION = 9111L,
        /// <summary>The specified key service provider cannot be opened by the DNS server.</summary>
        DNS_ERROR_KSP_NOT_ACCESSIBLE     = 9112L,
        /// <summary>The DNS server cannot accept any more signing keys with the specified algorithm and KSK flag value for this zone.</summary>
        DNS_ERROR_TOO_MANY_SKDS          = 9113L,
        /// <summary>The specified rollover period is invalid.</summary>
        DNS_ERROR_INVALID_ROLLOVER_PERIOD = 9114L,
        /// <summary>The specified initial rollover offset is invalid.</summary>
        DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET = 9115L,
        /// <summary>The specified signing key is already in process of rolling over keys.</summary>
        DNS_ERROR_ROLLOVER_IN_PROGRESS   = 9116L,
        /// <summary>The specified signing key does not have a standby key to revoke.</summary>
        DNS_ERROR_STANDBY_KEY_NOT_PRESENT = 9117L,
        /// <summary>This operation is not allowed on a zone signing key (ZSK).</summary>
        DNS_ERROR_NOT_ALLOWED_ON_ZSK     = 9118L,
        /// <summary>This operation is not allowed on an active signing key.</summary>
        DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD = 9119L,
        /// <summary>The specified signing key is already queued for rollover.</summary>
        DNS_ERROR_ROLLOVER_ALREADY_QUEUED = 9120L,
        /// <summary>This operation is not allowed on an unsigned zone.</summary>
        DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE = 9121L,
        /// <summary>This operation could not be completed because the DNS server listed as the current key master for this zone is down or misconfigured. Resolve the problem on the current key master for this zone or use another DNS server to seize the key master role.</summary>
        DNS_ERROR_BAD_KEYMASTER          = 9122L,
        /// <summary>The specified signature validity period is invalid.</summary>
        DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD = 9123L,
        /// <summary>The specified NSEC3 iteration count is higher than allowed by the minimum key length used in the zone.</summary>
        DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT = 9124L,
        /// <summary>This operation could not be completed because the DNS server has been configured with DNSSEC features disabled. Enable DNSSEC on the DNS server.</summary>
        DNS_ERROR_DNSSEC_IS_DISABLED     = 9125L,
        /// <summary>This operation could not be completed because the XML stream received is empty or syntactically invalid.</summary>
        DNS_ERROR_INVALID_XML            = 9126L,
        /// <summary>This operation completed, but no trust anchors were added because all of the trust anchors received were either invalid, unsupported, expired, or would not become valid in less than 30 days.</summary>
        DNS_ERROR_NO_VALID_TRUST_ANCHORS = 9127L,
        /// <summary>The specified signing key is not waiting for parental DS update.</summary>
        DNS_ERROR_ROLLOVER_NOT_POKEABLE  = 9128L,
        /// <summary>Hash collision detected during NSEC3 signing. Specify a different user-provided salt, or use a randomly generated salt, and attempt to sign the zone again.</summary>
        DNS_ERROR_NSEC3_NAME_COLLISION   = 9129L,
        /// <summary>NSEC is not compatible with the NSEC3-RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC3.</summary>
        DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1 = 9130L,
        /// <summary>No records found for given DNS query.</summary>
        DNS_INFO_NO_RECORDS              = 9501L,
        /// <summary>Bad DNS packet.</summary>
        DNS_ERROR_BAD_PACKET             = 9502L,
        /// <summary>No DNS packet.</summary>
        DNS_ERROR_NO_PACKET              = 9503L,
        /// <summary>DNS error, check rcode.</summary>
        DNS_ERROR_RCODE                  = 9504L,
        /// <summary>Unsecured DNS packet.</summary>
        DNS_ERROR_UNSECURE_PACKET        = 9505L,
        /// <summary>DNS query request is pending.</summary>
        DNS_REQUEST_PENDING              = 9506L,
        /// <summary>Invalid DNS type.</summary>
        DNS_ERROR_INVALID_TYPE           = 9551L,
        /// <summary>Invalid IP address.</summary>
        DNS_ERROR_INVALID_IP_ADDRESS     = 9552L,
        /// <summary>Invalid property.</summary>
        DNS_ERROR_INVALID_PROPERTY       = 9553L,
        /// <summary>Try DNS operation again later.</summary>
        DNS_ERROR_TRY_AGAIN_LATER        = 9554L,
        /// <summary>Record for given name and type is not unique.</summary>
        DNS_ERROR_NOT_UNIQUE             = 9555L,
        /// <summary>DNS name does not comply with RFC specifications.</summary>
        DNS_ERROR_NON_RFC_NAME           = 9556L,
        /// <summary>DNS name is a fully-qualified DNS name.</summary>
        DNS_STATUS_FQDN                  = 9557L,
        /// <summary>DNS name is dotted (multi-label).</summary>
        DNS_STATUS_DOTTED_NAME           = 9558L,
        /// <summary>DNS name is a single-part name.</summary>
        DNS_STATUS_SINGLE_PART_NAME      = 9559L,
        /// <summary>DNS name contains an invalid character.</summary>
        DNS_ERROR_INVALID_NAME_CHAR      = 9560L,
        /// <summary>DNS name is entirely numeric.</summary>
        DNS_ERROR_NUMERIC_NAME           = 9561L,
        /// <summary>The operation requested is not permitted on a DNS root server.</summary>
        DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562L,
        /// <summary>The record could not be created because this part of the DNS namespace has been delegated to another server.</summary>
        DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563L,
        /// <summary>The DNS server could not find a set of root hints.</summary>
        DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564L,
        /// <summary>The DNS server found root hints but they were not consistent across all adapters.</summary>
        DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565L,
        /// <summary>The specified value is too small for this parameter.</summary>
        DNS_ERROR_DWORD_VALUE_TOO_SMALL  = 9566L,
        /// <summary>The specified value is too large for this parameter.</summary>
        DNS_ERROR_DWORD_VALUE_TOO_LARGE  = 9567L,
        /// <summary>This operation is not allowed while the DNS server is loading zones in the background. Please try again later.</summary>
        DNS_ERROR_BACKGROUND_LOADING     = 9568L,
        /// <summary>The operation requested is not permitted on against a DNS server running on a read-only DC.</summary>
        DNS_ERROR_NOT_ALLOWED_ON_RODC    = 9569L,
        /// <summary>No data is allowed to exist underneath a DNAME record.</summary>
        DNS_ERROR_NOT_ALLOWED_UNDER_DNAME = 9570L,
        /// <summary>This operation requires credentials delegation.</summary>
        DNS_ERROR_DELEGATION_REQUIRED    = 9571L,
        /// <summary>Name resolution policy table has been corrupted. DNS resolution will fail until it is fixed. Contact your network administrator.</summary>
        DNS_ERROR_INVALID_POLICY_TABLE   = 9572L,
        /// <summary>Not allowed to remove all addresses.</summary>
        DNS_ERROR_ADDRESS_REQUIRED       = 9573L,
        /// <summary>DNS zone does not exist.</summary>
        DNS_ERROR_ZONE_DOES_NOT_EXIST    = 9601L,
        /// <summary>DNS zone information not available.</summary>
        DNS_ERROR_NO_ZONE_INFO           = 9602L,
        /// <summary>Invalid operation for DNS zone.</summary>
        DNS_ERROR_INVALID_ZONE_OPERATION = 9603L,
        /// <summary>Invalid DNS zone configuration.</summary>
        DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604L,
        /// <summary>DNS zone has no start of authority (SOA) record.</summary>
        DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605L,
        /// <summary>DNS zone has no Name Server (NS) record.</summary>
        DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606L,
        /// <summary>DNS zone is locked.</summary>
        DNS_ERROR_ZONE_LOCKED            = 9607L,
        /// <summary>DNS zone creation failed.</summary>
        DNS_ERROR_ZONE_CREATION_FAILED   = 9608L,
        /// <summary>DNS zone already exists.</summary>
        DNS_ERROR_ZONE_ALREADY_EXISTS    = 9609L,
        /// <summary>DNS automatic zone already exists.</summary>
        DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610L,
        /// <summary>Invalid DNS zone type.</summary>
        DNS_ERROR_INVALID_ZONE_TYPE      = 9611L,
        /// <summary>Secondary DNS zone requires master IP address.</summary>
        DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612L,
        /// <summary>DNS zone not secondary.</summary>
        DNS_ERROR_ZONE_NOT_SECONDARY     = 9613L,
        /// <summary>Need secondary IP address.</summary>
        DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614L,
        /// <summary>WINS initialization failed.</summary>
        DNS_ERROR_WINS_INIT_FAILED       = 9615L,
        /// <summary>Need WINS servers.</summary>
        DNS_ERROR_NEED_WINS_SERVERS      = 9616L,
        /// <summary>NBTSTAT initialization call failed.</summary>
        DNS_ERROR_NBSTAT_INIT_FAILED     = 9617L,
        /// <summary>Invalid delete of start of authority (SOA)</summary>
        DNS_ERROR_SOA_DELETE_INVALID     = 9618L,
        /// <summary>A conditional forwarding zone already exists for that name.</summary>
        DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619L,
        /// <summary>This zone must be configured with one or more master DNS server IP addresses.</summary>
        DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620L,
        /// <summary>The operation cannot be performed because this zone is shut down.</summary>
        DNS_ERROR_ZONE_IS_SHUTDOWN       = 9621L,
        /// <summary>This operation cannot be performed because the zone is currently being signed. Please try again later.</summary>
        DNS_ERROR_ZONE_LOCKED_FOR_SIGNING = 9622L,
        /// <summary>Primary DNS zone requires datafile.</summary>
        DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651L,
        /// <summary>Invalid datafile name for DNS zone.</summary>
        DNS_ERROR_INVALID_DATAFILE_NAME  = 9652L,
        /// <summary>Failed to open datafile for DNS zone.</summary>
        DNS_ERROR_DATAFILE_OPEN_FAILURE  = 9653L,
        /// <summary>Failed to write datafile for DNS zone.</summary>
        DNS_ERROR_FILE_WRITEBACK_FAILED  = 9654L,
        /// <summary>Failure while reading datafile for DNS zone.</summary>
        DNS_ERROR_DATAFILE_PARSING       = 9655L,
        /// <summary>DNS record does not exist.</summary>
        DNS_ERROR_RECORD_DOES_NOT_EXIST  = 9701L,
        /// <summary>DNS record format error.</summary>
        DNS_ERROR_RECORD_FORMAT          = 9702L,
        /// <summary>Node creation failure in DNS.</summary>
        DNS_ERROR_NODE_CREATION_FAILED   = 9703L,
        /// <summary>Unknown DNS record type.</summary>
        DNS_ERROR_UNKNOWN_RECORD_TYPE    = 9704L,
        /// <summary>DNS record timed out.</summary>
        DNS_ERROR_RECORD_TIMED_OUT       = 9705L,
        /// <summary>Name not in DNS zone.</summary>
        DNS_ERROR_NAME_NOT_IN_ZONE       = 9706L,
        /// <summary>CNAME loop detected.</summary>
        DNS_ERROR_CNAME_LOOP             = 9707L,
        /// <summary>Node is a CNAME DNS record.</summary>
        DNS_ERROR_NODE_IS_CNAME          = 9708L,
        /// <summary>A CNAME record already exists for given name.</summary>
        DNS_ERROR_CNAME_COLLISION        = 9709L,
        /// <summary>Record only at DNS zone root.</summary>
        DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710L,
        /// <summary>DNS record already exists.</summary>
        DNS_ERROR_RECORD_ALREADY_EXISTS  = 9711L,
        /// <summary>Secondary DNS zone data error.</summary>
        DNS_ERROR_SECONDARY_DATA         = 9712L,
        /// <summary>Could not create DNS cache data.</summary>
        DNS_ERROR_NO_CREATE_CACHE_DATA   = 9713L,
        /// <summary>DNS name does not exist.</summary>
        DNS_ERROR_NAME_DOES_NOT_EXIST    = 9714L,
        /// <summary>Could not create pointer (PTR) record.</summary>
        DNS_WARNING_PTR_CREATE_FAILED    = 9715L,
        /// <summary>DNS domain was undeleted.</summary>
        DNS_WARNING_DOMAIN_UNDELETED     = 9716L,
        /// <summary>The directory service is unavailable.</summary>
        DNS_ERROR_DS_UNAVAILABLE         = 9717L,
        /// <summary>DNS zone already exists in the directory service.</summary>
        DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718L,
        /// <summary>DNS server not creating or reading the boot file for the directory service integrated DNS zone.</summary>
        DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719L,
        /// <summary>Node is a DNAME DNS record.</summary>
        DNS_ERROR_NODE_IS_DNAME          = 9720L,
        /// <summary>A DNAME record already exists for given name.</summary>
        DNS_ERROR_DNAME_COLLISION        = 9721L,
        /// <summary>An alias loop has been detected with either CNAME or DNAME records.</summary>
        DNS_ERROR_ALIAS_LOOP             = 9722L,
        /// <summary>DNS AXFR (zone transfer) complete.</summary>
        DNS_INFO_AXFR_COMPLETE           = 9751L,
        /// <summary>DNS zone transfer failed.</summary>
        DNS_ERROR_AXFR                   = 9752L,
        /// <summary>Added local WINS server.</summary>
        DNS_INFO_ADDED_LOCAL_WINS        = 9753L,
        /// <summary>Secure update call needs to continue update request.</summary>
        DNS_STATUS_CONTINUE_NEEDED       = 9801L,
        /// <summary>TCP/IP network protocol not installed.</summary>
        DNS_ERROR_NO_TCPIP               = 9851L,
        /// <summary>No DNS servers configured for local system.</summary>
        DNS_ERROR_NO_DNS_SERVERS         = 9852L,
        /// <summary>The specified directory partition does not exist.</summary>
        DNS_ERROR_DP_DOES_NOT_EXIST      = 9901L,
        /// <summary>The specified directory partition already exists.</summary>
        DNS_ERROR_DP_ALREADY_EXISTS      = 9902L,
        /// <summary>This DNS server is not enlisted in the specified directory partition.</summary>
        DNS_ERROR_DP_NOT_ENLISTED        = 9903L,
        /// <summary>This DNS server is already enlisted in the specified directory partition.</summary>
        DNS_ERROR_DP_ALREADY_ENLISTED    = 9904L,
        /// <summary>The directory partition is not available at this time. Please wait a few minutes and try again.</summary>
        DNS_ERROR_DP_NOT_AVAILABLE       = 9905L,
        /// <summary>The operation failed because the domain naming master FSMO role could not be reached. The domain controller holding the domain naming master FSMO role is down or unable to service the request or is not running Windows Server 2003 or later.</summary>
        DNS_ERROR_DP_FSMO_ERROR          = 9906L,
        /// <summary>The RRL is not enabled.</summary>
        DNS_ERROR_RRL_NOT_ENABLED        = 9911L,
        /// <summary>The window size parameter is invalid. It should be greater than or equal to 1.</summary>
        DNS_ERROR_RRL_INVALID_WINDOW_SIZE = 9912L,
        /// <summary>The IPv4 prefix length parameter is invalid. It should be less than or equal to 32.</summary>
        DNS_ERROR_RRL_INVALID_IPV4_PREFIX = 9913L,
        /// <summary>The IPv6 prefix length parameter is invalid. It should be less than or equal to 128.</summary>
        DNS_ERROR_RRL_INVALID_IPV6_PREFIX = 9914L,
        /// <summary>The TC Rate parameter is invalid. It should be less than 10.</summary>
        DNS_ERROR_RRL_INVALID_TC_RATE    = 9915L,
        /// <summary>The Leak Rate parameter is invalid. It should be either 0, or between 2 and 10.</summary>
        DNS_ERROR_RRL_INVALID_LEAK_RATE  = 9916L,
        /// <summary>The Leak Rate or TC Rate parameter is invalid. Leak Rate should be greater than TC Rate.</summary>
        DNS_ERROR_RRL_LEAK_RATE_LESSTHAN_TC_RATE = 9917L,
        /// <summary>The virtualization instance already exists.</summary>
        DNS_ERROR_VIRTUALIZATION_INSTANCE_ALREADY_EXISTS = 9921L,
        /// <summary>The virtualization instance does not exist.</summary>
        DNS_ERROR_VIRTUALIZATION_INSTANCE_DOES_NOT_EXIST = 9922L,
        /// <summary>The virtualization tree is locked.</summary>
        DNS_ERROR_VIRTUALIZATION_TREE_LOCKED = 9923L,
        /// <summary>Invalid virtualization instance name.</summary>
        DNS_ERROR_INVAILD_VIRTUALIZATION_INSTANCE_NAME = 9924L,
        /// <summary>The default virtualization instance cannot be added, removed or modified.</summary>
        DNS_ERROR_DEFAULT_VIRTUALIZATION_INSTANCE = 9925L,
        /// <summary>The scope already exists for the zone.</summary>
        DNS_ERROR_ZONESCOPE_ALREADY_EXISTS = 9951L,
        /// <summary>The scope does not exist for the zone.</summary>
        DNS_ERROR_ZONESCOPE_DOES_NOT_EXIST = 9952L,
        /// <summary>The scope is the same as the default zone scope.</summary>
        DNS_ERROR_DEFAULT_ZONESCOPE      = 9953L,
        /// <summary>The scope name contains invalid characters.</summary>
        DNS_ERROR_INVALID_ZONESCOPE_NAME = 9954L,
        /// <summary>Operation not allowed when the zone has scopes.</summary>
        DNS_ERROR_NOT_ALLOWED_WITH_ZONESCOPES = 9955L,
        /// <summary>Failed to load zone scope.</summary>
        DNS_ERROR_LOAD_ZONESCOPE_FAILED  = 9956L,
        /// <summary>Failed to write data file for DNS zone scope. Please verify the file exists and is writable.</summary>
        DNS_ERROR_ZONESCOPE_FILE_WRITEBACK_FAILED = 9957L,
        /// <summary>The scope name contains invalid characters.</summary>
        DNS_ERROR_INVALID_SCOPE_NAME     = 9958L,
        /// <summary>The scope does not exist.</summary>
        DNS_ERROR_SCOPE_DOES_NOT_EXIST   = 9959L,
        /// <summary>The scope is the same as the default scope.</summary>
        DNS_ERROR_DEFAULT_SCOPE          = 9960L,
        /// <summary>The operation is invalid on the scope.</summary>
        DNS_ERROR_INVALID_SCOPE_OPERATION = 9961L,
        /// <summary>The scope is locked.</summary>
        DNS_ERROR_SCOPE_LOCKED           = 9962L,
        /// <summary>The scope already exists.</summary>
        DNS_ERROR_SCOPE_ALREADY_EXISTS   = 9963L,
        /// <summary>A policy with the same name already exists on this level (server level or zone level) on the DNS server.</summary>
        DNS_ERROR_POLICY_ALREADY_EXISTS  = 9971L,
        /// <summary>No policy with this name exists on this level (server level or zone level) on the DNS server.</summary>
        DNS_ERROR_POLICY_DOES_NOT_EXIST  = 9972L,
        /// <summary>The criteria provided in the policy are invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA = 9973L,
        /// <summary>At least one of the settings of this policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_SETTINGS = 9974L,
        /// <summary>The client subnet cannot be deleted while it is being accessed by a policy.</summary>
        DNS_ERROR_CLIENT_SUBNET_IS_ACCESSED = 9975L,
        /// <summary>The client subnet does not exist on the DNS server.</summary>
        DNS_ERROR_CLIENT_SUBNET_DOES_NOT_EXIST = 9976L,
        /// <summary>A client subnet with this name already exists on the DNS server.</summary>
        DNS_ERROR_CLIENT_SUBNET_ALREADY_EXISTS = 9977L,
        /// <summary>The IP subnet specified does not exist in the client subnet.</summary>
        DNS_ERROR_SUBNET_DOES_NOT_EXIST  = 9978L,
        /// <summary>The IP subnet that is being added, already exists in the client subnet.</summary>
        DNS_ERROR_SUBNET_ALREADY_EXISTS  = 9979L,
        /// <summary>The policy is locked.</summary>
        DNS_ERROR_POLICY_LOCKED          = 9980L,
        /// <summary>The weight of the scope in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_WEIGHT  = 9981L,
        /// <summary>The DNS policy name is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_NAME    = 9982L,
        /// <summary>The policy is missing criteria.</summary>
        DNS_ERROR_POLICY_MISSING_CRITERIA = 9983L,
        /// <summary>The name of the the client subnet record is invalid.</summary>
        DNS_ERROR_INVALID_CLIENT_SUBNET_NAME = 9984L,
        /// <summary>Invalid policy processing order.</summary>
        DNS_ERROR_POLICY_PROCESSING_ORDER_INVALID = 9985L,
        /// <summary>The scope information has not been provided for a policy that requires it.</summary>
        DNS_ERROR_POLICY_SCOPE_MISSING   = 9986L,
        /// <summary>The scope information has been provided for a policy that does not require it.</summary>
        DNS_ERROR_POLICY_SCOPE_NOT_ALLOWED = 9987L,
        /// <summary>The server scope cannot be deleted because it is referenced by a DNS Policy.</summary>
        DNS_ERROR_SERVERSCOPE_IS_REFERENCED = 9988L,
        /// <summary>The zone scope cannot be deleted because it is referenced by a DNS Policy.</summary>
        DNS_ERROR_ZONESCOPE_IS_REFERENCED = 9989L,
        /// <summary>The criterion client subnet provided in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA_CLIENT_SUBNET = 9990L,
        /// <summary>The criterion transport protocol provided in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA_TRANSPORT_PROTOCOL = 9991L,
        /// <summary>The criterion network protocol provided in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA_NETWORK_PROTOCOL = 9992L,
        /// <summary>The criterion interface provided in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA_INTERFACE = 9993L,
        /// <summary>The criterion FQDN provided in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA_FQDN = 9994L,
        /// <summary>The criterion query type provided in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA_QUERY_TYPE = 9995L,
        /// <summary>The criterion time of day provided in the policy is invalid.</summary>
        DNS_ERROR_POLICY_INVALID_CRITERIA_TIME_OF_DAY = 9996L,
        /// <summary>A blocking operation was interrupted by a call to WSACancelBlockingCall.</summary>
        WSAEINTR                         = 10004L,
        /// <summary>The file handle supplied is not valid.</summary>
        WSAEBADF                         = 10009L,
        /// <summary>An attempt was made to access a socket in a way forbidden by its access permissions.</summary>
        WSAEACCES                        = 10013L,
        /// <summary>The system detected an invalid pointer address in attempting to use a pointer argument in a call.</summary>
        WSAEFAULT                        = 10014L,
        /// <summary>An invalid argument was supplied.</summary>
        WSAEINVAL                        = 10022L,
        /// <summary>Too many open sockets.</summary>
        WSAEMFILE                        = 10024L,
        /// <summary>A non-blocking socket operation could not be completed immediately.</summary>
        WSAEWOULDBLOCK                   = 10035L,
        /// <summary>A blocking operation is currently executing.</summary>
        WSAEINPROGRESS                   = 10036L,
        /// <summary>An operation was attempted on a non-blocking socket that already had an operation in progress.</summary>
        WSAEALREADY                      = 10037L,
        /// <summary>An operation was attempted on something that is not a socket.</summary>
        WSAENOTSOCK                      = 10038L,
        /// <summary>A required address was omitted from an operation on a socket.</summary>
        WSAEDESTADDRREQ                  = 10039L,
        /// <summary>A message sent on a datagram socket was larger than the internal message buffer or some other network limit, or the buffer used to receive a datagram into was smaller than the datagram itself.</summary>
        WSAEMSGSIZE                      = 10040L,
        /// <summary>A protocol was specified in the socket function call that does not support the semantics of the socket type requested.</summary>
        WSAEPROTOTYPE                    = 10041L,
        /// <summary>An unknown, invalid, or unsupported option or level was specified in a getsockopt or setsockopt call.</summary>
        WSAENOPROTOOPT                   = 10042L,
        /// <summary>The requested protocol has not been configured into the system, or no implementation for it exists.</summary>
        WSAEPROTONOSUPPORT               = 10043L,
        /// <summary>The support for the specified socket type does not exist in this address family.</summary>
        WSAESOCKTNOSUPPORT               = 10044L,
        /// <summary>The attempted operation is not supported for the type of object referenced.</summary>
        WSAEOPNOTSUPP                    = 10045L,
        /// <summary>The protocol family has not been configured into the system or no implementation for it exists.</summary>
        WSAEPFNOSUPPORT                  = 10046L,
        /// <summary>An address incompatible with the requested protocol was used.</summary>
        WSAEAFNOSUPPORT                  = 10047L,
        /// <summary>Only one usage of each socket address (protocol/network address/port) is normally permitted.</summary>
        WSAEADDRINUSE                    = 10048L,
        /// <summary>The requested address is not valid in its context.</summary>
        WSAEADDRNOTAVAIL                 = 10049L,
        /// <summary>A socket operation encountered a dead network.</summary>
        WSAENETDOWN                      = 10050L,
        /// <summary>A socket operation was attempted to an unreachable network.</summary>
        WSAENETUNREACH                   = 10051L,
        /// <summary>The connection has been broken due to keep-alive activity detecting a failure while the operation was in progress.</summary>
        WSAENETRESET                     = 10052L,
        /// <summary>An established connection was aborted by the software in your host machine.</summary>
        WSAECONNABORTED                  = 10053L,
        /// <summary>An existing connection was forcibly closed by the remote host.</summary>
        WSAECONNRESET                    = 10054L,
        /// <summary>An operation on a socket could not be performed because the system lacked sufficient buffer space or because a queue was full.</summary>
        WSAENOBUFS                       = 10055L,
        /// <summary>A connect request was made on an already connected socket.</summary>
        WSAEISCONN                       = 10056L,
        /// <summary>A request to send or receive data was disallowed because the socket is not connected and (when sending on a datagram socket using a sendto call) no address was supplied.</summary>
        WSAENOTCONN                      = 10057L,
        /// <summary>A request to send or receive data was disallowed because the socket had already been shut down in that direction with a previous shutdown call.</summary>
        WSAESHUTDOWN                     = 10058L,
        /// <summary>Too many references to some kernel object.</summary>
        WSAETOOMANYREFS                  = 10059L,
        /// <summary>A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond.</summary>
        WSAETIMEDOUT                     = 10060L,
        /// <summary>No connection could be made because the target machine actively refused it.</summary>
        WSAECONNREFUSED                  = 10061L,
        /// <summary>Cannot translate name.</summary>
        WSAELOOP                         = 10062L,
        /// <summary>Name component or name was too long.</summary>
        WSAENAMETOOLONG                  = 10063L,
        /// <summary>A socket operation failed because the destination host was down.</summary>
        WSAEHOSTDOWN                     = 10064L,
        /// <summary>A socket operation was attempted to an unreachable host.</summary>
        WSAEHOSTUNREACH                  = 10065L,
        /// <summary>Cannot remove a directory that is not empty.</summary>
        WSAENOTEMPTY                     = 10066L,
        /// <summary>A Windows Sockets implementation may have a limit on the number of applications that may use it simultaneously.</summary>
        WSAEPROCLIM                      = 10067L,
        /// <summary>Ran out of quota.</summary>
        WSAEUSERS                        = 10068L,
        /// <summary>Ran out of disk quota.</summary>
        WSAEDQUOT                        = 10069L,
        /// <summary>File handle reference is no longer available.</summary>
        WSAESTALE                        = 10070L,
        /// <summary>Item is not available locally.</summary>
        WSAEREMOTE                       = 10071L,
        /// <summary>WSAStartup cannot function at this time because the underlying system it uses to provide network services is currently unavailable.</summary>
        WSASYSNOTREADY                   = 10091L,
        /// <summary>The Windows Sockets version requested is not supported.</summary>
        WSAVERNOTSUPPORTED               = 10092L,
        /// <summary>Either the application has not called WSAStartup, or WSAStartup failed.</summary>
        WSANOTINITIALISED                = 10093L,
        /// <summary>Returned by WSARecv or WSARecvFrom to indicate the remote party has initiated a graceful shutdown sequence.</summary>
        WSAEDISCON                       = 10101L,
        /// <summary>No more results can be returned by WSALookupServiceNext.</summary>
        WSAENOMORE                       = 10102L,
        /// <summary>A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.</summary>
        WSAECANCELLED                    = 10103L,
        /// <summary>The procedure call table is invalid.</summary>
        WSAEINVALIDPROCTABLE             = 10104L,
        /// <summary>The requested service provider is invalid.</summary>
        WSAEINVALIDPROVIDER              = 10105L,
        /// <summary>The requested service provider could not be loaded or initialized.</summary>
        WSAEPROVIDERFAILEDINIT           = 10106L,
        /// <summary>A system call has failed.</summary>
        WSASYSCALLFAILURE                = 10107L,
        /// <summary>No such service is known. The service cannot be found in the specified name space.</summary>
        WSASERVICE_NOT_FOUND             = 10108L,
        /// <summary>The specified class was not found.</summary>
        WSATYPE_NOT_FOUND                = 10109L,
        /// <summary>No more results can be returned by WSALookupServiceNext.</summary>
        WSA_E_NO_MORE                    = 10110L,
        /// <summary>A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.</summary>
        WSA_E_CANCELLED                  = 10111L,
        /// <summary>A database query failed because it was actively refused.</summary>
        WSAEREFUSED                      = 10112L,
        /// <summary>No such host is known.</summary>
        WSAHOST_NOT_FOUND                = 11001L,
        /// <summary>This is usually a temporary error during hostname resolution and means that the local server did not receive a response from an authoritative server.</summary>
        WSATRY_AGAIN                     = 11002L,
        /// <summary>A non-recoverable error occurred during a database lookup.</summary>
        WSANO_RECOVERY                   = 11003L,
        /// <summary>The requested name is valid, but no data of the requested type was found.</summary>
        WSANO_DATA                       = 11004L,
        /// <summary>At least one reserve has arrived.</summary>
        WSA_QOS_RECEIVERS                = 11005L,
        /// <summary>At least one path has arrived.</summary>
        WSA_QOS_SENDERS                  = 11006L,
        /// <summary>There are no senders.</summary>
        WSA_QOS_NO_SENDERS               = 11007L,
        /// <summary>There are no receivers.</summary>
        WSA_QOS_NO_RECEIVERS             = 11008L,
        /// <summary>Reserve has been confirmed.</summary>
        WSA_QOS_REQUEST_CONFIRMED        = 11009L,
        /// <summary>Error due to lack of resources.</summary>
        WSA_QOS_ADMISSION_FAILURE        = 11010L,
        /// <summary>Rejected for administrative reasons - bad credentials.</summary>
        WSA_QOS_POLICY_FAILURE           = 11011L,
        /// <summary>Unknown or conflicting style.</summary>
        WSA_QOS_BAD_STYLE                = 11012L,
        /// <summary>Problem with some part of the filterspec or providerspecific buffer in general.</summary>
        WSA_QOS_BAD_OBJECT               = 11013L,
        /// <summary>Problem with some part of the flowspec.</summary>
        WSA_QOS_TRAFFIC_CTRL_ERROR       = 11014L,
        /// <summary>General QOS error.</summary>
        WSA_QOS_GENERIC_ERROR            = 11015L,
        /// <summary>An invalid or unrecognized service type was found in the flowspec.</summary>
        WSA_QOS_ESERVICETYPE             = 11016L,
        /// <summary>An invalid or inconsistent flowspec was found in the QOS structure.</summary>
        WSA_QOS_EFLOWSPEC                = 11017L,
        /// <summary>Invalid QOS provider-specific buffer.</summary>
        WSA_QOS_EPROVSPECBUF             = 11018L,
        /// <summary>An invalid QOS filter style was used.</summary>
        WSA_QOS_EFILTERSTYLE             = 11019L,
        /// <summary>An invalid QOS filter type was used.</summary>
        WSA_QOS_EFILTERTYPE              = 11020L,
        /// <summary>An incorrect number of QOS FILTERSPECs were specified in the FLOWDESCRIPTOR.</summary>
        WSA_QOS_EFILTERCOUNT             = 11021L,
        /// <summary>An object with an invalid ObjectLength field was specified in the QOS provider-specific buffer.</summary>
        WSA_QOS_EOBJLENGTH               = 11022L,
        /// <summary>An incorrect number of flow descriptors was specified in the QOS structure.</summary>
        WSA_QOS_EFLOWCOUNT               = 11023L,
        /// <summary>An unrecognized object was found in the QOS provider-specific buffer.</summary>
        WSA_QOS_EUNKOWNPSOBJ             = 11024L,
        /// <summary>An invalid policy object was found in the QOS provider-specific buffer.</summary>
        WSA_QOS_EPOLICYOBJ               = 11025L,
        /// <summary>An invalid QOS flow descriptor was found in the flow descriptor list.</summary>
        WSA_QOS_EFLOWDESC                = 11026L,
        /// <summary>An invalid or inconsistent flowspec was found in the QOS provider specific buffer.</summary>
        WSA_QOS_EPSFLOWSPEC              = 11027L,
        /// <summary>An invalid FILTERSPEC was found in the QOS provider-specific buffer.</summary>
        WSA_QOS_EPSFILTERSPEC            = 11028L,
        /// <summary>An invalid shape discard mode object was found in the QOS provider specific buffer.</summary>
        WSA_QOS_ESDMODEOBJ               = 11029L,
        /// <summary>An invalid shaping rate object was found in the QOS provider-specific buffer.</summary>
        WSA_QOS_ESHAPERATEOBJ            = 11030L,
        /// <summary>A reserved policy element was found in the QOS provider-specific buffer.</summary>
        WSA_QOS_RESERVED_PETYPE          = 11031L,
        /// <summary>No such host is known securely.</summary>
        WSA_SECURE_HOST_NOT_FOUND        = 11032L,
        /// <summary>Name based IPSEC policy could not be added.</summary>
        WSA_IPSEC_NAME_POLICY_ERROR      = 11033L,
        /// <summary>The specified quick mode policy already exists.</summary>
        ERROR_IPSEC_QM_POLICY_EXISTS     = 13000L,
        /// <summary>The specified quick mode policy was not found.</summary>
        ERROR_IPSEC_QM_POLICY_NOT_FOUND  = 13001L,
        /// <summary>The specified quick mode policy is being used.</summary>
        ERROR_IPSEC_QM_POLICY_IN_USE     = 13002L,
        /// <summary>The specified main mode policy already exists.</summary>
        ERROR_IPSEC_MM_POLICY_EXISTS     = 13003L,
        /// <summary>The specified main mode policy was not found</summary>
        ERROR_IPSEC_MM_POLICY_NOT_FOUND  = 13004L,
        /// <summary>The specified main mode policy is being used.</summary>
        ERROR_IPSEC_MM_POLICY_IN_USE     = 13005L,
        /// <summary>The specified main mode filter already exists.</summary>
        ERROR_IPSEC_MM_FILTER_EXISTS     = 13006L,
        /// <summary>The specified main mode filter was not found.</summary>
        ERROR_IPSEC_MM_FILTER_NOT_FOUND  = 13007L,
        /// <summary>The specified transport mode filter already exists.</summary>
        ERROR_IPSEC_TRANSPORT_FILTER_EXISTS = 13008L,
        /// <summary>The specified transport mode filter does not exist.</summary>
        ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND = 13009L,
        /// <summary>The specified main mode authentication list exists.</summary>
        ERROR_IPSEC_MM_AUTH_EXISTS       = 13010L,
        /// <summary>The specified main mode authentication list was not found.</summary>
        ERROR_IPSEC_MM_AUTH_NOT_FOUND    = 13011L,
        /// <summary>The specified main mode authentication list is being used.</summary>
        ERROR_IPSEC_MM_AUTH_IN_USE       = 13012L,
        /// <summary>The specified default main mode policy was not found.</summary>
        ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND = 13013L,
        /// <summary>The specified default main mode authentication list was not found.</summary>
        ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND = 13014L,
        /// <summary>The specified default quick mode policy was not found.</summary>
        ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND = 13015L,
        /// <summary>The specified tunnel mode filter exists.</summary>
        ERROR_IPSEC_TUNNEL_FILTER_EXISTS = 13016L,
        /// <summary>The specified tunnel mode filter was not found.</summary>
        ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND = 13017L,
        /// <summary>The Main Mode filter is pending deletion.</summary>
        ERROR_IPSEC_MM_FILTER_PENDING_DELETION = 13018L,
        /// <summary>The transport filter is pending deletion.</summary>
        ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION = 13019L,
        /// <summary>The tunnel filter is pending deletion.</summary>
        ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION = 13020L,
        /// <summary>The Main Mode policy is pending deletion.</summary>
        ERROR_IPSEC_MM_POLICY_PENDING_DELETION = 13021L,
        /// <summary>The Main Mode authentication bundle is pending deletion.</summary>
        ERROR_IPSEC_MM_AUTH_PENDING_DELETION = 13022L,
        /// <summary>The Quick Mode policy is pending deletion.</summary>
        ERROR_IPSEC_QM_POLICY_PENDING_DELETION = 13023L,
        /// <summary>The Main Mode policy was successfully added, but some of the requested offers are not supported.</summary>
        WARNING_IPSEC_MM_POLICY_PRUNED   = 13024L,
        /// <summary>The Quick Mode policy was successfully added, but some of the requested offers are not supported.</summary>
        WARNING_IPSEC_QM_POLICY_PRUNED   = 13025L,
        /// <summary> ERROR_IPSEC_IKE_NEG_STATUS_BEGIN</summary>
        ERROR_IPSEC_IKE_NEG_STATUS_BEGIN = 13800L,
        /// <summary>IKE authentication credentials are unacceptable</summary>
        ERROR_IPSEC_IKE_AUTH_FAIL        = 13801L,
        /// <summary>IKE security attributes are unacceptable</summary>
        ERROR_IPSEC_IKE_ATTRIB_FAIL      = 13802L,
        /// <summary>IKE Negotiation in progress</summary>
        ERROR_IPSEC_IKE_NEGOTIATION_PENDING = 13803L,
        /// <summary>General processing error</summary>
        ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR = 13804L,
        /// <summary>Negotiation timed out</summary>
        ERROR_IPSEC_IKE_TIMED_OUT        = 13805L,
        /// <summary>IKE failed to find valid machine certificate. Contact your Network Security Administrator about installing a valid certificate in the appropriate Certificate Store.</summary>
        ERROR_IPSEC_IKE_NO_CERT          = 13806L,
        /// <summary>IKE SA deleted by peer before establishment completed</summary>
        ERROR_IPSEC_IKE_SA_DELETED       = 13807L,
        /// <summary>IKE SA deleted before establishment completed</summary>
        ERROR_IPSEC_IKE_SA_REAPED        = 13808L,
        /// <summary>Negotiation request sat in Queue too long</summary>
        ERROR_IPSEC_IKE_MM_ACQUIRE_DROP  = 13809L,
        /// <summary>Negotiation request sat in Queue too long</summary>
        ERROR_IPSEC_IKE_QM_ACQUIRE_DROP  = 13810L,
        /// <summary>Negotiation request sat in Queue too long</summary>
        ERROR_IPSEC_IKE_QUEUE_DROP_MM    = 13811L,
        /// <summary>Negotiation request sat in Queue too long</summary>
        ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM = 13812L,
        /// <summary>No response from peer</summary>
        ERROR_IPSEC_IKE_DROP_NO_RESPONSE = 13813L,
        /// <summary>Negotiation took too long</summary>
        ERROR_IPSEC_IKE_MM_DELAY_DROP    = 13814L,
        /// <summary>Negotiation took too long</summary>
        ERROR_IPSEC_IKE_QM_DELAY_DROP    = 13815L,
        /// <summary>Unknown error occurred</summary>
        ERROR_IPSEC_IKE_ERROR            = 13816L,
        /// <summary>Certificate Revocation Check failed</summary>
        ERROR_IPSEC_IKE_CRL_FAILED       = 13817L,
        /// <summary>Invalid certificate key usage</summary>
        ERROR_IPSEC_IKE_INVALID_KEY_USAGE = 13818L,
        /// <summary>Invalid certificate type</summary>
        ERROR_IPSEC_IKE_INVALID_CERT_TYPE = 13819L,
        /// <summary>IKE negotiation failed because the machine certificate used does not have a private key. IPsec certificates require a private key. Contact your Network Security administrator about replacing with a certificate that has a private key.</summary>
        ERROR_IPSEC_IKE_NO_PRIVATE_KEY   = 13820L,
        /// <summary>Simultaneous rekeys were detected.</summary>
        ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY = 13821L,
        /// <summary>Failure in Diffie-Hellman computation</summary>
        ERROR_IPSEC_IKE_DH_FAIL          = 13822L,
        /// <summary>Don't know how to process critical payload</summary>
        ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED = 13823L,
        /// <summary>Invalid header</summary>
        ERROR_IPSEC_IKE_INVALID_HEADER   = 13824L,
        /// <summary>No policy configured</summary>
        ERROR_IPSEC_IKE_NO_POLICY        = 13825L,
        /// <summary>Failed to verify signature</summary>
        ERROR_IPSEC_IKE_INVALID_SIGNATURE = 13826L,
        /// <summary>Failed to authenticate using Kerberos</summary>
        ERROR_IPSEC_IKE_KERBEROS_ERROR   = 13827L,
        /// <summary>Peer's certificate did not have a public key</summary>
        ERROR_IPSEC_IKE_NO_PUBLIC_KEY    = 13828L,
        /// <summary>Error processing error payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR      = 13829L,
        /// <summary>Error processing SA payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_SA   = 13830L,
        /// <summary>Error processing Proposal payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_PROP = 13831L,
        /// <summary>Error processing Transform payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_TRANS = 13832L,
        /// <summary>Error processing KE payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_KE   = 13833L,
        /// <summary>Error processing ID payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_ID   = 13834L,
        /// <summary>Error processing Cert payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_CERT = 13835L,
        /// <summary>Error processing Certificate Request payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ = 13836L,
        /// <summary>Error processing Hash payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_HASH = 13837L,
        /// <summary>Error processing Signature payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_SIG  = 13838L,
        /// <summary>Error processing Nonce payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_NONCE = 13839L,
        /// <summary>Error processing Notify payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY = 13840L,
        /// <summary>Error processing Delete Payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_DELETE = 13841L,
        /// <summary>Error processing VendorId payload</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR = 13842L,
        /// <summary>Invalid payload received</summary>
        ERROR_IPSEC_IKE_INVALID_PAYLOAD  = 13843L,
        /// <summary>Soft SA loaded</summary>
        ERROR_IPSEC_IKE_LOAD_SOFT_SA     = 13844L,
        /// <summary>Soft SA torn down</summary>
        ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN = 13845L,
        /// <summary>Invalid cookie received.</summary>
        ERROR_IPSEC_IKE_INVALID_COOKIE   = 13846L,
        /// <summary>Peer failed to send valid machine certificate</summary>
        ERROR_IPSEC_IKE_NO_PEER_CERT     = 13847L,
        /// <summary>Certification Revocation check of peer's certificate failed</summary>
        ERROR_IPSEC_IKE_PEER_CRL_FAILED  = 13848L,
        /// <summary>New policy invalidated SAs formed with old policy</summary>
        ERROR_IPSEC_IKE_POLICY_CHANGE    = 13849L,
        /// <summary>There is no available Main Mode IKE policy.</summary>
        ERROR_IPSEC_IKE_NO_MM_POLICY     = 13850L,
        /// <summary>Failed to enabled TCB privilege.</summary>
        ERROR_IPSEC_IKE_NOTCBPRIV        = 13851L,
        /// <summary>Failed to load SECURITY.DLL.</summary>
        ERROR_IPSEC_IKE_SECLOADFAIL      = 13852L,
        /// <summary>Failed to obtain security function table dispatch address from SSPI.</summary>
        ERROR_IPSEC_IKE_FAILSSPINIT      = 13853L,
        /// <summary>Failed to query Kerberos package to obtain max token size.</summary>
        ERROR_IPSEC_IKE_FAILQUERYSSP     = 13854L,
        /// <summary>Failed to obtain Kerberos server credentials for ISAKMP/ERROR_IPSEC_IKE service. Kerberos authentication will not function. The most likely reason for this is lack of domain membership. This is normal if your computer is a member of a workgroup.</summary>
        ERROR_IPSEC_IKE_SRVACQFAIL       = 13855L,
        /// <summary>Failed to determine SSPI principal name for ISAKMP/ERROR_IPSEC_IKE service (QueryCredentialsAttributes).</summary>
        ERROR_IPSEC_IKE_SRVQUERYCRED     = 13856L,
        /// <summary>Failed to obtain new SPI for the inbound SA from IPsec driver. The most common cause for this is that the driver does not have the correct filter. Check your policy to verify the filters.</summary>
        ERROR_IPSEC_IKE_GETSPIFAIL       = 13857L,
        /// <summary>Given filter is invalid</summary>
        ERROR_IPSEC_IKE_INVALID_FILTER   = 13858L,
        /// <summary>Memory allocation failed.</summary>
        ERROR_IPSEC_IKE_OUT_OF_MEMORY    = 13859L,
        /// <summary>Failed to add Security Association to IPsec Driver. The most common cause for this is if the IKE negotiation took too long to complete. If the problem persists, reduce the load on the faulting machine.</summary>
        ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED = 13860L,
        /// <summary>Invalid policy</summary>
        ERROR_IPSEC_IKE_INVALID_POLICY   = 13861L,
        /// <summary>Invalid DOI</summary>
        ERROR_IPSEC_IKE_UNKNOWN_DOI      = 13862L,
        /// <summary>Invalid situation</summary>
        ERROR_IPSEC_IKE_INVALID_SITUATION = 13863L,
        /// <summary>Diffie-Hellman failure</summary>
        ERROR_IPSEC_IKE_DH_FAILURE       = 13864L,
        /// <summary>Invalid Diffie-Hellman group</summary>
        ERROR_IPSEC_IKE_INVALID_GROUP    = 13865L,
        /// <summary>Error encrypting payload</summary>
        ERROR_IPSEC_IKE_ENCRYPT          = 13866L,
        /// <summary>Error decrypting payload</summary>
        ERROR_IPSEC_IKE_DECRYPT          = 13867L,
        /// <summary>Policy match error</summary>
        ERROR_IPSEC_IKE_POLICY_MATCH     = 13868L,
        /// <summary>Unsupported ID</summary>
        ERROR_IPSEC_IKE_UNSUPPORTED_ID   = 13869L,
        /// <summary>Hash verification failed</summary>
        ERROR_IPSEC_IKE_INVALID_HASH     = 13870L,
        /// <summary>Invalid hash algorithm</summary>
        ERROR_IPSEC_IKE_INVALID_HASH_ALG = 13871L,
        /// <summary>Invalid hash size</summary>
        ERROR_IPSEC_IKE_INVALID_HASH_SIZE = 13872L,
        /// <summary>Invalid encryption algorithm</summary>
        ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG = 13873L,
        /// <summary>Invalid authentication algorithm</summary>
        ERROR_IPSEC_IKE_INVALID_AUTH_ALG = 13874L,
        /// <summary>Invalid certificate signature</summary>
        ERROR_IPSEC_IKE_INVALID_SIG      = 13875L,
        /// <summary>Load failed</summary>
        ERROR_IPSEC_IKE_LOAD_FAILED      = 13876L,
        /// <summary>Deleted via RPC call</summary>
        ERROR_IPSEC_IKE_RPC_DELETE       = 13877L,
        /// <summary>Temporary state created to perform reinitialization. This is not a real failure.</summary>
        ERROR_IPSEC_IKE_BENIGN_REINIT    = 13878L,
        /// <summary>The lifetime value received in the Responder Lifetime Notify is below the Windows 2000 configured minimum value. Please fix the policy on the peer machine.</summary>
        ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY = 13879L,
        /// <summary>The recipient cannot handle version of IKE specified in the header.</summary>
        ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION = 13880L,
        /// <summary>Key length in certificate is too small for configured security requirements.</summary>
        ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN = 13881L,
        /// <summary>Max number of established MM SAs to peer exceeded.</summary>
        ERROR_IPSEC_IKE_MM_LIMIT         = 13882L,
        /// <summary>IKE received a policy that disables negotiation.</summary>
        ERROR_IPSEC_IKE_NEGOTIATION_DISABLED = 13883L,
        /// <summary>Reached maximum quick mode limit for the main mode. New main mode will be started.</summary>
        ERROR_IPSEC_IKE_QM_LIMIT         = 13884L,
        /// <summary>Main mode SA lifetime expired or peer sent a main mode delete.</summary>
        ERROR_IPSEC_IKE_MM_EXPIRED       = 13885L,
        /// <summary>Main mode SA assumed to be invalid because peer stopped responding.</summary>
        ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID = 13886L,
        /// <summary>Certificate doesn't chain to a trusted root in IPsec policy.</summary>
        ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH = 13887L,
        /// <summary>Received unexpected message ID.</summary>
        ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID = 13888L,
        /// <summary>Received invalid authentication offers.</summary>
        ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD = 13889L,
        /// <summary>Sent DoS cookie notify to initiator.</summary>
        ERROR_IPSEC_IKE_DOS_COOKIE_SENT  = 13890L,
        /// <summary>IKE service is shutting down.</summary>
        ERROR_IPSEC_IKE_SHUTTING_DOWN    = 13891L,
        /// <summary>Could not verify binding between CGA address and certificate.</summary>
        ERROR_IPSEC_IKE_CGA_AUTH_FAILED  = 13892L,
        /// <summary>Error processing NatOA payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_NATOA = 13893L,
        /// <summary>Parameters of the main mode are invalid for this quick mode.</summary>
        ERROR_IPSEC_IKE_INVALID_MM_FOR_QM = 13894L,
        /// <summary>Quick mode SA was expired by IPsec driver.</summary>
        ERROR_IPSEC_IKE_QM_EXPIRED       = 13895L,
        /// <summary>Too many dynamically added IKEEXT filters were detected.</summary>
        ERROR_IPSEC_IKE_TOO_MANY_FILTERS = 13896L,
        /// <summary> ERROR_IPSEC_IKE_NEG_STATUS_END</summary>
        ERROR_IPSEC_IKE_NEG_STATUS_END   = 13897L,
        /// <summary>NAP reauth succeeded and must delete the dummy NAP IKEv2 tunnel.</summary>
        ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL = 13898L,
        /// <summary>Error in assigning inner IP address to initiator in tunnel mode.</summary>
        ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE = 13899L,
        /// <summary>Require configuration payload missing.</summary>
        ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING = 13900L,
        /// <summary>A negotiation running as the security principle who issued the connection is in progress</summary>
        ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING = 13901L,
        /// <summary>SA was deleted due to IKEv1/AuthIP co-existence suppress check.</summary>
        ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS = 13902L,
        /// <summary>Incoming SA request was dropped due to peer IP address rate limiting.</summary>
        ERROR_IPSEC_IKE_RATELIMIT_DROP   = 13903L,
        /// <summary>Peer does not support MOBIKE.</summary>
        ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE = 13904L,
        /// <summary>SA establishment is not authorized.</summary>
        ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE = 13905L,
        /// <summary>SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential.</summary>
        ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE = 13906L,
        /// <summary>SA establishment is not authorized.  You may need to enter updated or different credentials such as a smartcard.</summary>
        ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY = 13907L,
        /// <summary>SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential. This might be related to certificate-to-account mapping failure for the SA.</summary>
        ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE = 13908L,
        /// <summary> ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END</summary>
        ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END = 13909L,
        /// <summary>The SPI in the packet does not match a valid IPsec SA.</summary>
        ERROR_IPSEC_BAD_SPI              = 13910L,
        /// <summary>Packet was received on an IPsec SA whose lifetime has expired.</summary>
        ERROR_IPSEC_SA_LIFETIME_EXPIRED  = 13911L,
        /// <summary>Packet was received on an IPsec SA that does not match the packet characteristics.</summary>
        ERROR_IPSEC_WRONG_SA             = 13912L,
        /// <summary>Packet sequence number replay check failed.</summary>
        ERROR_IPSEC_REPLAY_CHECK_FAILED  = 13913L,
        /// <summary>IPsec header and/or trailer in the packet is invalid.</summary>
        ERROR_IPSEC_INVALID_PACKET       = 13914L,
        /// <summary>IPsec integrity check failed.</summary>
        ERROR_IPSEC_INTEGRITY_CHECK_FAILED = 13915L,
        /// <summary>IPsec dropped a clear text packet.</summary>
        ERROR_IPSEC_CLEAR_TEXT_DROP      = 13916L,
        /// <summary>IPsec dropped an incoming ESP packet in authenticated firewall mode. This drop is benign.</summary>
        ERROR_IPSEC_AUTH_FIREWALL_DROP   = 13917L,
        /// <summary>IPsec dropped a packet due to DoS throttling.</summary>
        ERROR_IPSEC_THROTTLE_DROP        = 13918L,
        /// <summary>IPsec DoS Protection matched an explicit block rule.</summary>
        ERROR_IPSEC_DOSP_BLOCK           = 13925L,
        /// <summary>IPsec DoS Protection received an IPsec specific multicast packet which is not allowed.</summary>
        ERROR_IPSEC_DOSP_RECEIVED_MULTICAST = 13926L,
        /// <summary>IPsec DoS Protection received an incorrectly formatted packet.</summary>
        ERROR_IPSEC_DOSP_INVALID_PACKET  = 13927L,
        /// <summary>IPsec DoS Protection failed to look up state.</summary>
        ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED = 13928L,
        /// <summary>IPsec DoS Protection failed to create state because the maximum number of entries allowed by policy has been reached.</summary>
        ERROR_IPSEC_DOSP_MAX_ENTRIES     = 13929L,
        /// <summary>IPsec DoS Protection received an IPsec negotiation packet for a keying module which is not allowed by policy.</summary>
        ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED = 13930L,
        /// <summary>IPsec DoS Protection has not been enabled.</summary>
        ERROR_IPSEC_DOSP_NOT_INSTALLED   = 13931L,
        /// <summary>IPsec DoS Protection failed to create a per internal IP rate limit queue because the maximum number of queues allowed by policy has been reached.</summary>
        ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES = 13932L,
        /// <summary>The requested section was not present in the activation context.</summary>
        ERROR_SXS_SECTION_NOT_FOUND      = 14000L,
        /// <summary>The application has failed to start because its side-by-side configuration is incorrect. Please see the application event log or use the command-line sxstrace.exe tool for more detail.</summary>
        ERROR_SXS_CANT_GEN_ACTCTX        = 14001L,
        /// <summary>The application binding data format is invalid.</summary>
        ERROR_SXS_INVALID_ACTCTXDATA_FORMAT = 14002L,
        /// <summary>The referenced assembly is not installed on your system.</summary>
        ERROR_SXS_ASSEMBLY_NOT_FOUND     = 14003L,
        /// <summary>The manifest file does not begin with the required tag and format information.</summary>
        ERROR_SXS_MANIFEST_FORMAT_ERROR  = 14004L,
        /// <summary>The manifest file contains one or more syntax errors.</summary>
        ERROR_SXS_MANIFEST_PARSE_ERROR   = 14005L,
        /// <summary>The application attempted to activate a disabled activation context.</summary>
        ERROR_SXS_ACTIVATION_CONTEXT_DISABLED = 14006L,
        /// <summary>The requested lookup key was not found in any active activation context.</summary>
        ERROR_SXS_KEY_NOT_FOUND          = 14007L,
        /// <summary>A component version required by the application conflicts with another component version already active.</summary>
        ERROR_SXS_VERSION_CONFLICT       = 14008L,
        /// <summary>The type requested activation context section does not match the query API used.</summary>
        ERROR_SXS_WRONG_SECTION_TYPE     = 14009L,
        /// <summary>Lack of system resources has required isolated activation to be disabled for the current thread of execution.</summary>
        ERROR_SXS_THREAD_QUERIES_DISABLED = 14010L,
        /// <summary>An attempt to set the process default activation context failed because the process default activation context was already set.</summary>
        ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET = 14011L,
        /// <summary>The encoding group identifier specified is not recognized.</summary>
        ERROR_SXS_UNKNOWN_ENCODING_GROUP = 14012L,
        /// <summary>The encoding requested is not recognized.</summary>
        ERROR_SXS_UNKNOWN_ENCODING       = 14013L,
        /// <summary>The manifest contains a reference to an invalid URI.</summary>
        ERROR_SXS_INVALID_XML_NAMESPACE_URI = 14014L,
        /// <summary>The application manifest contains a reference to a dependent assembly which is not installed</summary>
        ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14015L,
        /// <summary>The manifest for an assembly used by the application has a reference to a dependent assembly which is not installed</summary>
        ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14016L,
        /// <summary>The manifest contains an attribute for the assembly identity which is not valid.</summary>
        ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE = 14017L,
        /// <summary>The manifest is missing the required default namespace specification on the assembly element.</summary>
        ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE = 14018L,
        /// <summary>The manifest has a default namespace specified on the assembly element but its value is not "urn:schemas-microsoft-com:asm.v1".</summary>
        ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE = 14019L,
        /// <summary>The private manifest probed has crossed a path with an unsupported reparse point.</summary>
        ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT = 14020L,
        /// <summary>Two or more components referenced directly or indirectly by the application manifest have files by the same name.</summary>
        ERROR_SXS_DUPLICATE_DLL_NAME     = 14021L,
        /// <summary>Two or more components referenced directly or indirectly by the application manifest have window classes with the same name.</summary>
        ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME = 14022L,
        /// <summary>Two or more components referenced directly or indirectly by the application manifest have the same COM server CLSIDs.</summary>
        ERROR_SXS_DUPLICATE_CLSID        = 14023L,
        /// <summary>Two or more components referenced directly or indirectly by the application manifest have proxies for the same COM interface IIDs.</summary>
        ERROR_SXS_DUPLICATE_IID          = 14024L,
        /// <summary>Two or more components referenced directly or indirectly by the application manifest have the same COM type library TLBIDs.</summary>
        ERROR_SXS_DUPLICATE_TLBID        = 14025L,
        /// <summary>Two or more components referenced directly or indirectly by the application manifest have the same COM ProgIDs.</summary>
        ERROR_SXS_DUPLICATE_PROGID       = 14026L,
        /// <summary>Two or more components referenced directly or indirectly by the application manifest are different versions of the same component which is not permitted.</summary>
        ERROR_SXS_DUPLICATE_ASSEMBLY_NAME = 14027L,
        /// <summary>A component's file does not match the verification information present in the component manifest.</summary>
        ERROR_SXS_FILE_HASH_MISMATCH     = 14028L,
        /// <summary>The policy manifest contains one or more syntax errors.</summary>
        ERROR_SXS_POLICY_PARSE_ERROR     = 14029L,
        /// <summary>Manifest Parse Error : A string literal was expected, but no opening quote character was found.</summary>
        ERROR_SXS_XML_E_MISSINGQUOTE     = 14030L,
        /// <summary>Manifest Parse Error : Incorrect syntax was used in a comment.</summary>
        ERROR_SXS_XML_E_COMMENTSYNTAX    = 14031L,
        /// <summary>Manifest Parse Error : A name was started with an invalid character.</summary>
        ERROR_SXS_XML_E_BADSTARTNAMECHAR = 14032L,
        /// <summary>Manifest Parse Error : A name contained an invalid character.</summary>
        ERROR_SXS_XML_E_BADNAMECHAR      = 14033L,
        /// <summary>Manifest Parse Error : A string literal contained an invalid character.</summary>
        ERROR_SXS_XML_E_BADCHARINSTRING  = 14034L,
        /// <summary>Manifest Parse Error : Invalid syntax for an xml declaration.</summary>
        ERROR_SXS_XML_E_XMLDECLSYNTAX    = 14035L,
        /// <summary>Manifest Parse Error : An Invalid character was found in text content.</summary>
        ERROR_SXS_XML_E_BADCHARDATA      = 14036L,
        /// <summary>Manifest Parse Error : Required white space was missing.</summary>
        ERROR_SXS_XML_E_MISSINGWHITESPACE = 14037L,
        /// <summary>Manifest Parse Error : The character '>' was expected.</summary>
        ERROR_SXS_XML_E_EXPECTINGTAGEND  = 14038L,
        /// <summary>Manifest Parse Error : A semi colon character was expected.</summary>
        ERROR_SXS_XML_E_MISSINGSEMICOLON = 14039L,
        /// <summary>Manifest Parse Error : Unbalanced parentheses.</summary>
        ERROR_SXS_XML_E_UNBALANCEDPAREN  = 14040L,
        /// <summary>Manifest Parse Error : Internal error.</summary>
        ERROR_SXS_XML_E_INTERNALERROR    = 14041L,
        /// <summary>Manifest Parse Error : Whitespace is not allowed at this location.</summary>
        ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE = 14042L,
        /// <summary>Manifest Parse Error : End of file reached in invalid state for current encoding.</summary>
        ERROR_SXS_XML_E_INCOMPLETE_ENCODING = 14043L,
        /// <summary>Manifest Parse Error : Missing parenthesis.</summary>
        ERROR_SXS_XML_E_MISSING_PAREN    = 14044L,
        /// <summary>Manifest Parse Error : A single or double closing quote character (\' or \") is missing.</summary>
        ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE = 14045L,
        /// <summary>Manifest Parse Error : Multiple colons are not allowed in a name.</summary>
        ERROR_SXS_XML_E_MULTIPLE_COLONS  = 14046L,
        /// <summary>Manifest Parse Error : Invalid character for decimal digit.</summary>
        ERROR_SXS_XML_E_INVALID_DECIMAL  = 14047L,
        /// <summary>Manifest Parse Error : Invalid character for hexadecimal digit.</summary>
        ERROR_SXS_XML_E_INVALID_HEXIDECIMAL = 14048L,
        /// <summary>Manifest Parse Error : Invalid unicode character value for this platform.</summary>
        ERROR_SXS_XML_E_INVALID_UNICODE  = 14049L,
        /// <summary>Manifest Parse Error : Expecting whitespace or '?'.</summary>
        ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK = 14050L,
        /// <summary>Manifest Parse Error : End tag was not expected at this location.</summary>
        ERROR_SXS_XML_E_UNEXPECTEDENDTAG = 14051L,
        /// <summary>Manifest Parse Error : The following tags were not closed: %1.</summary>
        ERROR_SXS_XML_E_UNCLOSEDTAG      = 14052L,
        /// <summary>Manifest Parse Error : Duplicate attribute.</summary>
        ERROR_SXS_XML_E_DUPLICATEATTRIBUTE = 14053L,
        /// <summary>Manifest Parse Error : Only one top level element is allowed in an XML document.</summary>
        ERROR_SXS_XML_E_MULTIPLEROOTS    = 14054L,
        /// <summary>Manifest Parse Error : Invalid at the top level of the document.</summary>
        ERROR_SXS_XML_E_INVALIDATROOTLEVEL = 14055L,
        /// <summary>Manifest Parse Error : Invalid xml declaration.</summary>
        ERROR_SXS_XML_E_BADXMLDECL       = 14056L,
        /// <summary>Manifest Parse Error : XML document must have a top level element.</summary>
        ERROR_SXS_XML_E_MISSINGROOT      = 14057L,
        /// <summary>Manifest Parse Error : Unexpected end of file.</summary>
        ERROR_SXS_XML_E_UNEXPECTEDEOF    = 14058L,
        /// <summary>Manifest Parse Error : Parameter entities cannot be used inside markup declarations in an internal subset.</summary>
        ERROR_SXS_XML_E_BADPEREFINSUBSET = 14059L,
        /// <summary>Manifest Parse Error : Element was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDSTARTTAG = 14060L,
        /// <summary>Manifest Parse Error : End element was missing the character '>'.</summary>
        ERROR_SXS_XML_E_UNCLOSEDENDTAG   = 14061L,
        /// <summary>Manifest Parse Error : A string literal was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDSTRING   = 14062L,
        /// <summary>Manifest Parse Error : A comment was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDCOMMENT  = 14063L,
        /// <summary>Manifest Parse Error : A declaration was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDDECL     = 14064L,
        /// <summary>Manifest Parse Error : A CDATA section was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDCDATA    = 14065L,
        /// <summary>Manifest Parse Error : The namespace prefix is not allowed to start with the reserved string "xml".</summary>
        ERROR_SXS_XML_E_RESERVEDNAMESPACE = 14066L,
        /// <summary>Manifest Parse Error : System does not support the specified encoding.</summary>
        ERROR_SXS_XML_E_INVALIDENCODING  = 14067L,
        /// <summary>Manifest Parse Error : Switch from current encoding to specified encoding not supported.</summary>
        ERROR_SXS_XML_E_INVALIDSWITCH    = 14068L,
        /// <summary>Manifest Parse Error : The name 'xml' is reserved and must be lower case.</summary>
        ERROR_SXS_XML_E_BADXMLCASE       = 14069L,
        /// <summary>Manifest Parse Error : The standalone attribute must have the value 'yes' or 'no'.</summary>
        ERROR_SXS_XML_E_INVALID_STANDALONE = 14070L,
        /// <summary>Manifest Parse Error : The standalone attribute cannot be used in external entities.</summary>
        ERROR_SXS_XML_E_UNEXPECTED_STANDALONE = 14071L,
        /// <summary>Manifest Parse Error : Invalid version number.</summary>
        ERROR_SXS_XML_E_INVALID_VERSION  = 14072L,
        /// <summary>Manifest Parse Error : Missing equals sign between attribute and attribute value.</summary>
        ERROR_SXS_XML_E_MISSINGEQUALS    = 14073L,
        /// <summary>Assembly Protection Error : Unable to recover the specified assembly.</summary>
        ERROR_SXS_PROTECTION_RECOVERY_FAILED = 14074L,
        /// <summary>Assembly Protection Error : The public key for an assembly was too short to be allowed.</summary>
        ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT = 14075L,
        /// <summary>Assembly Protection Error : The catalog for an assembly is not valid, or does not match the assembly's manifest.</summary>
        ERROR_SXS_PROTECTION_CATALOG_NOT_VALID = 14076L,
        /// <summary>An HRESULT could not be translated to a corresponding Win32 error code.</summary>
        ERROR_SXS_UNTRANSLATABLE_HRESULT = 14077L,
        /// <summary>Assembly Protection Error : The catalog for an assembly is missing.</summary>
        ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING = 14078L,
        /// <summary>The supplied assembly identity is missing one or more attributes which must be present in this context.</summary>
        ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE = 14079L,
        /// <summary>The supplied assembly identity has one or more attribute names that contain characters not permitted in XML names.</summary>
        ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME = 14080L,
        /// <summary>The referenced assembly could not be found.</summary>
        ERROR_SXS_ASSEMBLY_MISSING       = 14081L,
        /// <summary>The activation context activation stack for the running thread of execution is corrupt.</summary>
        ERROR_SXS_CORRUPT_ACTIVATION_STACK = 14082L,
        /// <summary>The application isolation metadata for this process or thread has become corrupt.</summary>
        ERROR_SXS_CORRUPTION             = 14083L,
        /// <summary>The activation context being deactivated is not the most recently activated one.</summary>
        ERROR_SXS_EARLY_DEACTIVATION     = 14084L,
        /// <summary>The activation context being deactivated is not active for the current thread of execution.</summary>
        ERROR_SXS_INVALID_DEACTIVATION   = 14085L,
        /// <summary>The activation context being deactivated has already been deactivated.</summary>
        ERROR_SXS_MULTIPLE_DEACTIVATION  = 14086L,
        /// <summary>A component used by the isolation facility has requested to terminate the process.</summary>
        ERROR_SXS_PROCESS_TERMINATION_REQUESTED = 14087L,
        /// <summary>A kernel mode component is releasing a reference on an activation context.</summary>
        ERROR_SXS_RELEASE_ACTIVATION_CONTEXT = 14088L,
        /// <summary>The activation context of system default assembly could not be generated.</summary>
        ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY = 14089L,
        /// <summary>The value of an attribute in an identity is not within the legal range.</summary>
        ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE = 14090L,
        /// <summary>The name of an attribute in an identity is not within the legal range.</summary>
        ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME = 14091L,
        /// <summary>An identity contains two definitions for the same attribute.</summary>
        ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE = 14092L,
        /// <summary>The identity string is malformed. This may be due to a trailing comma, more than two unnamed attributes, missing attribute name or missing attribute value.</summary>
        ERROR_SXS_IDENTITY_PARSE_ERROR   = 14093L,
        /// <summary>A string containing localized substitutable content was malformed. Either a dollar sign ($) was followed by something other than a left parenthesis or another dollar sign or an substitution's right parenthesis was not found.</summary>
        ERROR_MALFORMED_SUBSTITUTION_STRING = 14094L,
        /// <summary>The public key token does not correspond to the public key specified.</summary>
        ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN = 14095L,
        /// <summary>A substitution string had no mapping.</summary>
        ERROR_UNMAPPED_SUBSTITUTION_STRING = 14096L,
        /// <summary>The component must be locked before making the request.</summary>
        ERROR_SXS_ASSEMBLY_NOT_LOCKED    = 14097L,
        /// <summary>The component store has been corrupted.</summary>
        ERROR_SXS_COMPONENT_STORE_CORRUPT = 14098L,
        /// <summary>An advanced installer failed during setup or servicing.</summary>
        ERROR_ADVANCED_INSTALLER_FAILED  = 14099L,
        /// <summary>The character encoding in the XML declaration did not match the encoding used in the document.</summary>
        ERROR_XML_ENCODING_MISMATCH      = 14100L,
        /// <summary>The identities of the manifests are identical but their contents are different.</summary>
        ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT = 14101L,
        /// <summary>The component identities are different.</summary>
        ERROR_SXS_IDENTITIES_DIFFERENT   = 14102L,
        /// <summary>The assembly is not a deployment.</summary>
        ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT = 14103L,
        /// <summary>The file is not a part of the assembly.</summary>
        ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY = 14104L,
        /// <summary>The size of the manifest exceeds the maximum allowed.</summary>
        ERROR_SXS_MANIFEST_TOO_BIG       = 14105L,
        /// <summary>The setting is not registered.</summary>
        ERROR_SXS_SETTING_NOT_REGISTERED = 14106L,
        /// <summary>One or more required members of the transaction are not present.</summary>
        ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE = 14107L,
        /// <summary>The SMI primitive installer failed during setup or servicing.</summary>
        ERROR_SMI_PRIMITIVE_INSTALLER_FAILED = 14108L,
        /// <summary>A generic command executable returned a result that indicates failure.</summary>
        ERROR_GENERIC_COMMAND_FAILED     = 14109L,
        /// <summary>A component is missing file verification information in its manifest.</summary>
        ERROR_SXS_FILE_HASH_MISSING      = 14110L,
        /// <summary>The specified channel path is invalid.</summary>
        ERROR_EVT_INVALID_CHANNEL_PATH   = 15000L,
        /// <summary>The specified query is invalid.</summary>
        ERROR_EVT_INVALID_QUERY          = 15001L,
        /// <summary>The publisher metadata cannot be found in the resource.</summary>
        ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND = 15002L,
        /// <summary>The template for an event definition cannot be found in the resource (error = %1).</summary>
        ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND = 15003L,
        /// <summary>The specified publisher name is invalid.</summary>
        ERROR_EVT_INVALID_PUBLISHER_NAME = 15004L,
        /// <summary>The event data raised by the publisher is not compatible with the event template definition in the publisher's manifest</summary>
        ERROR_EVT_INVALID_EVENT_DATA     = 15005L,
        /// <summary>The specified channel could not be found. Check channel configuration.</summary>
        ERROR_EVT_CHANNEL_NOT_FOUND      = 15007L,
        /// <summary>The specified xml text was not well-formed. See Extended Error for more details.</summary>
        ERROR_EVT_MALFORMED_XML_TEXT     = 15008L,
        /// <summary>The caller is trying to subscribe to a direct channel which is not allowed. The events for a direct channel go directly to a logfile and cannot be subscribed to.</summary>
        ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL = 15009L,
        /// <summary>Configuration error.</summary>
        ERROR_EVT_CONFIGURATION_ERROR    = 15010L,
        /// <summary>The query result is stale / invalid. This may be due to the log being cleared or rolling over after the query result was created. Users should handle this code by releasing the query result object and reissuing the query.</summary>
        ERROR_EVT_QUERY_RESULT_STALE     = 15011L,
        /// <summary>Query result is currently at an invalid position.</summary>
        ERROR_EVT_QUERY_RESULT_INVALID_POSITION = 15012L,
        /// <summary>Registered MSXML doesn't support validation.</summary>
        ERROR_EVT_NON_VALIDATING_MSXML   = 15013L,
        /// <summary>An expression can only be followed by a change of scope operation if it itself evaluates to a node set and is not already part of some other change of scope operation.</summary>
        ERROR_EVT_FILTER_ALREADYSCOPED   = 15014L,
        /// <summary>Can't perform a step operation from a term that does not represent an element set.</summary>
        ERROR_EVT_FILTER_NOTELTSET       = 15015L,
        /// <summary>Left hand side arguments to binary operators must be either attributes, nodes or variables and right hand side arguments must be constants.</summary>
        ERROR_EVT_FILTER_INVARG          = 15016L,
        /// <summary>A step operation must involve either a node test or, in the case of a predicate, an algebraic expression against which to test each node in the node set identified by the preceeding node set can be evaluated.</summary>
        ERROR_EVT_FILTER_INVTEST         = 15017L,
        /// <summary>This data type is currently unsupported.</summary>
        ERROR_EVT_FILTER_INVTYPE         = 15018L,
        /// <summary>A syntax error occurred at position %1!d!</summary>
        ERROR_EVT_FILTER_PARSEERR        = 15019L,
        /// <summary>This operator is unsupported by this implementation of the filter.</summary>
        ERROR_EVT_FILTER_UNSUPPORTEDOP   = 15020L,
        /// <summary>The token encountered was unexpected.</summary>
        ERROR_EVT_FILTER_UNEXPECTEDTOKEN = 15021L,
        /// <summary>The requested operation cannot be performed over an enabled direct channel. The channel must first be disabled before performing the requested operation.</summary>
        ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL = 15022L,
        /// <summary>Channel property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of channel.</summary>
        ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE = 15023L,
        /// <summary>Publisher property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of publisher.</summary>
        ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE = 15024L,
        /// <summary>The channel fails to activate.</summary>
        ERROR_EVT_CHANNEL_CANNOT_ACTIVATE = 15025L,
        /// <summary>The xpath expression exceeded supported complexity. Please symplify it or split it into two or more simple expressions.</summary>
        ERROR_EVT_FILTER_TOO_COMPLEX     = 15026L,
        /// <summary>the message resource is present but the message is not found in the string/message table</summary>
        ERROR_EVT_MESSAGE_NOT_FOUND      = 15027L,
        /// <summary>The message id for the desired message could not be found.</summary>
        ERROR_EVT_MESSAGE_ID_NOT_FOUND   = 15028L,
        /// <summary>The substitution string for insert index (%1) could not be found.</summary>
        ERROR_EVT_UNRESOLVED_VALUE_INSERT = 15029L,
        /// <summary>The description string for parameter reference (%1) could not be found.</summary>
        ERROR_EVT_UNRESOLVED_PARAMETER_INSERT = 15030L,
        /// <summary>The maximum number of replacements has been reached.</summary>
        ERROR_EVT_MAX_INSERTS_REACHED    = 15031L,
        /// <summary>The event definition could not be found for event id (%1).</summary>
        ERROR_EVT_EVENT_DEFINITION_NOT_FOUND = 15032L,
        /// <summary>The locale specific resource for the desired message is not present.</summary>
        ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND = 15033L,
        /// <summary>The resource is too old to be compatible.</summary>
        ERROR_EVT_VERSION_TOO_OLD        = 15034L,
        /// <summary>The resource is too new to be compatible.</summary>
        ERROR_EVT_VERSION_TOO_NEW        = 15035L,
        /// <summary>The channel at index %1!d! of the query can't be opened.</summary>
        ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY = 15036L,
        /// <summary>The publisher has been disabled and its resource is not available. This usually occurs when the publisher is in the process of being uninstalled or upgraded.</summary>
        ERROR_EVT_PUBLISHER_DISABLED     = 15037L,
        /// <summary>Attempted to create a numeric type that is outside of its valid range.</summary>
        ERROR_EVT_FILTER_OUT_OF_RANGE    = 15038L,
        /// <summary>The subscription fails to activate.</summary>
        ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE = 15080L,
        /// <summary>The log of the subscription is in disabled state, and can not be used to forward events to. The log must first be enabled before the subscription can be activated.</summary>
        ERROR_EC_LOG_DISABLED            = 15081L,
        /// <summary>When forwarding events from local machine to itself, the query of the subscription can't contain target log of the subscription.</summary>
        ERROR_EC_CIRCULAR_FORWARDING     = 15082L,
        /// <summary>The credential store that is used to save credentials is full.</summary>
        ERROR_EC_CREDSTORE_FULL          = 15083L,
        /// <summary>The credential used by this subscription can't be found in credential store.</summary>
        ERROR_EC_CRED_NOT_FOUND          = 15084L,
        /// <summary>No active channel is found for the query.</summary>
        ERROR_EC_NO_ACTIVE_CHANNEL       = 15085L,
        /// <summary>The resource loader failed to find MUI file.</summary>
        ERROR_MUI_FILE_NOT_FOUND         = 15100L,    
        /// <summary>The resource loader failed to load MUI file because the file fail to pass validation.</summary>
        ERROR_MUI_INVALID_FILE           = 15101L,    
        /// <summary>The RC Manifest is corrupted with garbage data or unsupported version or missing required item.</summary>
        ERROR_MUI_INVALID_RC_CONFIG      = 15102L,    
        /// <summary>The RC Manifest has invalid culture name.</summary>
        ERROR_MUI_INVALID_LOCALE_NAME    = 15103L,    
        /// <summary>The RC Manifest has invalid ultimatefallback name.</summary>
        ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME = 15104L,    
        /// <summary>The resource loader cache doesn't have loaded MUI entry.</summary>
        ERROR_MUI_FILE_NOT_LOADED        = 15105L,    
        /// <summary>User stopped resource enumeration.</summary>
        ERROR_RESOURCE_ENUM_USER_STOP    = 15106L,
        /// <summary>UI language installation failed.</summary>
        ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED = 15107L,
        /// <summary>Locale installation failed.</summary>
        ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME = 15108L,
        /// <summary>A resource does not have default or neutral value.</summary>
        ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE = 15110L,
        /// <summary>Invalid PRI config file.</summary>
        ERROR_MRM_INVALID_PRICONFIG      = 15111L,
        /// <summary>Invalid file type.</summary>
        ERROR_MRM_INVALID_FILE_TYPE      = 15112L,
        /// <summary>Unknown qualifier.</summary>
        ERROR_MRM_UNKNOWN_QUALIFIER      = 15113L,
        /// <summary>Invalid qualifier value.</summary>
        ERROR_MRM_INVALID_QUALIFIER_VALUE = 15114L,
        /// <summary>No Candidate found.</summary>
        ERROR_MRM_NO_CANDIDATE           = 15115L,
        /// <summary>The ResourceMap or NamedResource has an item that does not have default or neutral resource..</summary>
        ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE = 15116L,
        /// <summary>Invalid ResourceCandidate type.</summary>
        ERROR_MRM_RESOURCE_TYPE_MISMATCH = 15117L,
        /// <summary>Duplicate Resource Map.</summary>
        ERROR_MRM_DUPLICATE_MAP_NAME     = 15118L,
        /// <summary>Duplicate Entry.</summary>
        ERROR_MRM_DUPLICATE_ENTRY        = 15119L,
        /// <summary>Invalid Resource Identifier.</summary>
        ERROR_MRM_INVALID_RESOURCE_IDENTIFIER = 15120L,
        /// <summary>Filepath too long.</summary>
        ERROR_MRM_FILEPATH_TOO_LONG      = 15121L,
        /// <summary>Unsupported directory type.</summary>
        ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE = 15122L,
        /// <summary>Invalid PRI File.</summary>
        ERROR_MRM_INVALID_PRI_FILE       = 15126L,
        /// <summary>NamedResource Not Found.</summary>
        ERROR_MRM_NAMED_RESOURCE_NOT_FOUND = 15127L,
        /// <summary>ResourceMap Not Found.</summary>
        ERROR_MRM_MAP_NOT_FOUND          = 15135L,
        /// <summary>Unsupported MRT profile type.</summary>
        ERROR_MRM_UNSUPPORTED_PROFILE_TYPE = 15136L,
        /// <summary>Invalid qualifier operator.</summary>
        ERROR_MRM_INVALID_QUALIFIER_OPERATOR = 15137L,
        /// <summary>Unable to determine qualifier value or qualifier value has not been set.</summary>
        ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE = 15138L,
        /// <summary>Automerge is enabled in the PRI file.</summary>
        ERROR_MRM_AUTOMERGE_ENABLED      = 15139L,
        /// <summary>Too many resources defined for package.</summary>
        ERROR_MRM_TOO_MANY_RESOURCES     = 15140L,
        /// <summary>Resource File can not be used for merge operation.</summary>
        ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_MERGE = 15141L,
        /// <summary>Load/UnloadPriFiles cannot be used with resource packages.</summary>
        ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_LOAD_UNLOAD_PRI_FILE = 15142L,
        /// <summary>Resource Contexts may not be created on threads that do not have a CoreWindow.</summary>
        ERROR_MRM_NO_CURRENT_VIEW_ON_THREAD = 15143L,
        /// <summary>The singleton Resource Manager with different profile is already created.</summary>
        ERROR_DIFFERENT_PROFILE_RESOURCE_MANAGER_EXIST = 15144L,
        /// <summary>The system component cannot operate given API operation</summary>
        ERROR_OPERATION_NOT_ALLOWED_FROM_SYSTEM_COMPONENT = 15145L,
        /// <summary>The resource is a direct reference to a non-default resource candidate.</summary>
        ERROR_MRM_DIRECT_REF_TO_NON_DEFAULT_RESOURCE = 15146L,
        /// <summary>Resource Map has been re-generated and the query string is not valid anymore.</summary>
        ERROR_MRM_GENERATION_COUNT_MISMATCH = 15147L,
        /// <summary>The PRI files to be merged have incompatible versions.</summary>
        ERROR_PRI_MERGE_VERSION_MISMATCH = 15148L,
        /// <summary>The primary PRI files to be merged does not contain a schema.</summary>
        ERROR_PRI_MERGE_MISSING_SCHEMA   = 15149L,
        /// <summary>Unable to load one of the PRI files to be merged.</summary>
        ERROR_PRI_MERGE_LOAD_FILE_FAILED = 15150L,
        /// <summary>Unable to add one of the PRI files to the merged file.</summary>
        ERROR_PRI_MERGE_ADD_FILE_FAILED  = 15151L,
        /// <summary>Unable to create the merged PRI file.</summary>
        ERROR_PRI_MERGE_WRITE_FILE_FAILED = 15152L,
        /// <summary>The monitor returned a DDC/CI capabilities string that did not comply with the ACCESS.bus 3.0, DDC/CI 1.1 or MCCS 2 Revision 1 specification.</summary>
        ERROR_MCA_INVALID_CAPABILITIES_STRING = 15200L,
        /// <summary>The monitor's VCP Version (0xDF) VCP code returned an invalid version value.</summary>
        ERROR_MCA_INVALID_VCP_VERSION    = 15201L,
        /// <summary>The monitor does not comply with the MCCS specification it claims to support.</summary>
        ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION = 15202L,
        /// <summary>The MCCS version in a monitor's mccs_ver capability does not match the MCCS version the monitor reports when the VCP Version (0xDF) VCP code is used.</summary>
        ERROR_MCA_MCCS_VERSION_MISMATCH  = 15203L,
        /// <summary>The Monitor Configuration API only works with monitors that support the MCCS 1.0 specification, MCCS 2.0 specification or the MCCS 2.0 Revision 1 specification.</summary>
        ERROR_MCA_UNSUPPORTED_MCCS_VERSION = 15204L,
        /// <summary>An internal Monitor Configuration API error occurred.</summary>
        ERROR_MCA_INTERNAL_ERROR         = 15205L,
        /// <summary>The monitor returned an invalid monitor technology type. CRT, Plasma and LCD (TFT) are examples of monitor technology types. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.</summary>
        ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED = 15206L,
        /// <summary>The caller of SetMonitorColorTemperature specified a color temperature that the current monitor did not support. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.</summary>
        ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE = 15207L,
        /// <summary>The requested system device cannot be identified due to multiple indistinguishable devices potentially matching the identification criteria.</summary>
        ERROR_AMBIGUOUS_SYSTEM_DEVICE    = 15250L,
        /// <summary>The requested system device cannot be found.</summary>
        ERROR_SYSTEM_DEVICE_NOT_FOUND    = 15299L,
        /// <summary>Hash generation for the specified hash version and hash type is not enabled on the server.</summary>
        ERROR_HASH_NOT_SUPPORTED         = 15300L,
        /// <summary>The hash requested from the server is not available or no longer valid.</summary>
        ERROR_HASH_NOT_PRESENT           = 15301L,
        /// <summary>The secondary interrupt controller instance that manages the specified interrupt is not registered.</summary>
        ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED = 15321L,
        /// <summary>The information supplied by the GPIO client driver is invalid.</summary>
        ERROR_GPIO_CLIENT_INFORMATION_INVALID = 15322L,
        /// <summary>The version specified by the GPIO client driver is not supported.</summary>
        ERROR_GPIO_VERSION_NOT_SUPPORTED = 15323L,
        /// <summary>The registration packet supplied by the GPIO client driver is not valid.</summary>
        ERROR_GPIO_INVALID_REGISTRATION_PACKET = 15324L,
        /// <summary>The requested operation is not suppported for the specified handle.</summary>
        ERROR_GPIO_OPERATION_DENIED      = 15325L,
        /// <summary>The requested connect mode conflicts with an existing mode on one or more of the specified pins.</summary>
        ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE = 15326L,
        /// <summary>The interrupt requested to be unmasked is not masked.</summary>
        ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED = 15327L,
        /// <summary>The requested run level switch cannot be completed successfully.</summary>
        ERROR_CANNOT_SWITCH_RUNLEVEL     = 15400L,
        /// <summary>The service has an invalid run level setting. The run level for a service must not be higher than the run level of its dependent services.</summary>
        ERROR_INVALID_RUNLEVEL_SETTING   = 15401L,
        /// <summary>The requested run level switch cannot be completed successfully since one or more services will not stop or restart within the specified timeout.</summary>
        ERROR_RUNLEVEL_SWITCH_TIMEOUT    = 15402L,
        /// <summary>A run level switch agent did not respond within the specified timeout.</summary>
        ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT = 15403L,
        /// <summary>A run level switch is currently in progress.</summary>
        ERROR_RUNLEVEL_SWITCH_IN_PROGRESS = 15404L,
        /// <summary>One or more services failed to start during the service startup phase of a run level switch.</summary>
        ERROR_SERVICES_FAILED_AUTOSTART  = 15405L,
        /// <summary>The task stop request cannot be completed immediately since task needs more time to shutdown.</summary>
        ERROR_COM_TASK_STOP_PENDING      = 15501L,
        /// <summary>Package could not be opened.</summary>
        ERROR_INSTALL_OPEN_PACKAGE_FAILED = 15600L,
        /// <summary>Package was not found.</summary>
        ERROR_INSTALL_PACKAGE_NOT_FOUND  = 15601L,
        /// <summary>Package data is invalid.</summary>
        ERROR_INSTALL_INVALID_PACKAGE    = 15602L,
        /// <summary>Package failed updates, dependency or conflict validation.</summary>
        ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED = 15603L,
        /// <summary>There is not enough disk space on your computer. Please free up some space and try again.</summary>
        ERROR_INSTALL_OUT_OF_DISK_SPACE  = 15604L,
        /// <summary>There was a problem downloading your product.</summary>
        ERROR_INSTALL_NETWORK_FAILURE    = 15605L,
        /// <summary>Package could not be registered.</summary>
        ERROR_INSTALL_REGISTRATION_FAILURE = 15606L,
        /// <summary>Package could not be unregistered.</summary>
        ERROR_INSTALL_DEREGISTRATION_FAILURE = 15607L,
        /// <summary>User cancelled the install request.</summary>
        ERROR_INSTALL_CANCEL             = 15608L,
        /// <summary>Install failed. Please contact your software vendor.</summary>
        ERROR_INSTALL_FAILED             = 15609L,
        /// <summary>Removal failed. Please contact your software vendor.</summary>
        ERROR_REMOVE_FAILED              = 15610L,
        /// <summary>The provided package is already installed, and reinstallation of the package was blocked. Check the AppXDeployment-Server event log for details.</summary>
        ERROR_PACKAGE_ALREADY_EXISTS     = 15611L,
        /// <summary>The application cannot be started. Try reinstalling the application to fix the problem.</summary>
        ERROR_NEEDS_REMEDIATION          = 15612L,
        /// <summary>A Prerequisite for an install could not be satisfied.</summary>
        ERROR_INSTALL_PREREQUISITE_FAILED = 15613L,
        /// <summary>The package repository is corrupted.</summary>
        ERROR_PACKAGE_REPOSITORY_CORRUPTED = 15614L,
        /// <summary>To install this application you need either a Windows developer license or a sideloading-enabled system.</summary>
        ERROR_INSTALL_POLICY_FAILURE     = 15615L,
        /// <summary>The application cannot be started because it is currently updating.</summary>
        ERROR_PACKAGE_UPDATING           = 15616L,
        /// <summary>The package deployment operation is blocked by policy. Please contact your system administrator.</summary>
        ERROR_DEPLOYMENT_BLOCKED_BY_POLICY = 15617L,
        /// <summary>The package could not be installed because resources it modifies are currently in use.</summary>
        ERROR_PACKAGES_IN_USE            = 15618L,
        /// <summary>The package could not be recovered because necessary data for recovery have been corrupted.</summary>
        ERROR_RECOVERY_FILE_CORRUPT      = 15619L,
        /// <summary>The signature is invalid. To register in developer mode, AppxSignature.p7x and AppxBlockMap.xml must be valid or should not be present.</summary>
        ERROR_INVALID_STAGED_SIGNATURE   = 15620L,
        /// <summary>An error occurred while deleting the package's previously existing application data.</summary>
        ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED = 15621L,
        /// <summary>The package could not be installed because a higher version of this package is already installed.</summary>
        ERROR_INSTALL_PACKAGE_DOWNGRADE  = 15622L,
        /// <summary>An error in a system binary was detected. Try refreshing the PC to fix the problem.</summary>
        ERROR_SYSTEM_NEEDS_REMEDIATION   = 15623L,
        /// <summary>A corrupted CLR NGEN binary was detected on the system.</summary>
        ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN = 15624L,
        /// <summary>The operation could not be resumed because necessary data for recovery have been corrupted.</summary>
        ERROR_RESILIENCY_FILE_CORRUPT    = 15625L,
        /// <summary>The package could not be installed because the Windows Firewall service is not running. Enable the Windows Firewall service and try again.</summary>
        ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING = 15626L,
        /// <summary>Package move failed.</summary>
        ERROR_PACKAGE_MOVE_FAILED        = 15627L,
        /// <summary>The deployment operation failed because the volume is not empty.</summary>
        ERROR_INSTALL_VOLUME_NOT_EMPTY   = 15628L,
        /// <summary>The deployment operation failed because the volume is offline.</summary>
        ERROR_INSTALL_VOLUME_OFFLINE     = 15629L,
        /// <summary>The deployment operation failed because the specified volume is corrupt.</summary>
        ERROR_INSTALL_VOLUME_CORRUPT     = 15630L,
        /// <summary>The deployment operation failed because the specified application needs to be registered first.</summary>
        ERROR_NEEDS_REGISTRATION         = 15631L,
        /// <summary>The deployment operation failed because the package targets the wrong processor architecture.</summary>
        ERROR_INSTALL_WRONG_PROCESSOR_ARCHITECTURE = 15632L,
        /// <summary>You have reached the maximum number of developer sideloaded packages allowed on this device. Please uninstall a sideloaded package and try again.</summary>
        ERROR_DEV_SIDELOAD_LIMIT_EXCEEDED = 15633L,
        /// <summary>A main app package is required to install this optional package.  Install the main package first and try again.</summary>
        ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE = 15634L,
        /// <summary>This app package type is not supported on this filesystem</summary>
        ERROR_PACKAGE_NOT_SUPPORTED_ON_FILESYSTEM = 15635L,
        /// <summary>The process has no package identity.</summary>
        APPMODEL_ERROR_NO_PACKAGE        = 15700L,
        /// <summary>The package runtime information is corrupted.</summary>
        APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT = 15701L,
        /// <summary>The package identity is corrupted.</summary>
        APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT = 15702L,
        /// <summary>The process has no application identity.</summary>
        APPMODEL_ERROR_NO_APPLICATION    = 15703L,
        /// <summary>One or more AppModel Runtime group policy values could not be read. Please contact your system administrator with the contents of your AppModel Runtime event log.</summary>
        APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED = 15704L,
        /// <summary>One or more AppModel Runtime group policy values are invalid. Please contact your system administrator with the contents of your AppModel Runtime event log.</summary>
        APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID = 15705L,
        /// <summary>The package is currently not available.</summary>
        APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE = 15706L,
        /// <summary>Loading the state store failed.</summary>
        ERROR_STATE_LOAD_STORE_FAILED    = 15800L,
        /// <summary>Retrieving the state version for the application failed.</summary>
        ERROR_STATE_GET_VERSION_FAILED   = 15801L,
        /// <summary>Setting the state version for the application failed.</summary>
        ERROR_STATE_SET_VERSION_FAILED   = 15802L,
        /// <summary>Resetting the structured state of the application failed.</summary>
        ERROR_STATE_STRUCTURED_RESET_FAILED = 15803L,
        /// <summary>State Manager failed to open the container.</summary>
        ERROR_STATE_OPEN_CONTAINER_FAILED = 15804L,
        /// <summary>State Manager failed to create the container.</summary>
        ERROR_STATE_CREATE_CONTAINER_FAILED = 15805L,
        /// <summary>State Manager failed to delete the container.</summary>
        ERROR_STATE_DELETE_CONTAINER_FAILED = 15806L,
        /// <summary>State Manager failed to read the setting.</summary>
        ERROR_STATE_READ_SETTING_FAILED  = 15807L,
        /// <summary>State Manager failed to write the setting.</summary>
        ERROR_STATE_WRITE_SETTING_FAILED = 15808L,
        /// <summary>State Manager failed to delete the setting.</summary>
        ERROR_STATE_DELETE_SETTING_FAILED = 15809L,
        /// <summary>State Manager failed to query the setting.</summary>
        ERROR_STATE_QUERY_SETTING_FAILED = 15810L,
        /// <summary>State Manager failed to read the composite setting.</summary>
        ERROR_STATE_READ_COMPOSITE_SETTING_FAILED = 15811L,
        /// <summary>State Manager failed to write the composite setting.</summary>
        ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED = 15812L,
        /// <summary>State Manager failed to enumerate the containers.</summary>
        ERROR_STATE_ENUMERATE_CONTAINER_FAILED = 15813L,
        /// <summary>State Manager failed to enumerate the settings.</summary>
        ERROR_STATE_ENUMERATE_SETTINGS_FAILED = 15814L,
        /// <summary>The size of the state manager composite setting value has exceeded the limit.</summary>
        ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15815L,
        /// <summary>The size of the state manager setting value has exceeded the limit.</summary>
        ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15816L,
        /// <summary>The length of the state manager setting name has exceeded the limit.</summary>
        ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED = 15817L,
        /// <summary>The length of the state manager container name has exceeded the limit.</summary>
        ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED = 15818L,
        /// <summary>This API cannot be used in the context of the caller's application type.</summary>
        ERROR_API_UNAVAILABLE            = 15841L,
        /// <summary>This PC does not have a valid license for the application or product.</summary>
        STORE_ERROR_UNLICENSED           = 15861L,
        /// <summary>The authenticated user does not have a valid license for the application or product.</summary>
        STORE_ERROR_UNLICENSED_USER      = 15862L,
        /// <summary>The commerce transaction associated with this license is still pending verification.</summary>
        STORE_ERROR_PENDING_COM_TRANSACTION = 15863L,
        /// <summary>The license has been revoked for this user.</summary>
        STORE_ERROR_LICENSE_REVOKED      = 15864L,
        /// <summary>Catastrophic failure</summary>
        E_UNEXPECTED                     = 0x8000FFFFL,
        /// <summary>Not implemented</summary>
        E_NOTIMPL                        = 0x80004001L,
        /// <summary>Ran out of memory</summary>
        E_OUTOFMEMORY                    = 0x8007000EL,
        /// <summary>One or more arguments are invalid</summary>
        E_INVALIDARG                     = 0x80070057L,
        /// <summary>No such interface supported</summary>
        E_NOINTERFACE                    = 0x80004002L,
        /// <summary>Invalid pointer</summary>
        E_POINTER                        = 0x80004003L,
        /// <summary>Invalid handle</summary>
        E_HANDLE                         = 0x80070006L,
        /// <summary>Operation aborted</summary>
        E_ABORT                          = 0x80004004L,
        /// <summary>Unspecified error</summary>
        E_FAIL                           = 0x80004005L,
        /// <summary>General access denied error</summary>
        E_ACCESSDENIED                   = 0x80070005L,
        /// <summary>The data necessary to complete this operation is not yet available.</summary>
        E_PENDING                        = 0x8000000AL,
        /// <summary>The operation attempted to access data outside the valid range</summary>
        E_BOUNDS                         = 0x8000000BL,
        /// <summary>A concurrent or interleaved operation changed the state of the object, invalidating this operation.</summary>
        E_CHANGED_STATE                  = 0x8000000CL,
        /// <summary>An illegal state change was requested.</summary>
        E_ILLEGAL_STATE_CHANGE           = 0x8000000DL,
        /// <summary>A method was called at an unexpected time.</summary>
        E_ILLEGAL_METHOD_CALL            = 0x8000000EL,
        /// <summary>Typename or Namespace was not found in metadata file.</summary>
        RO_E_METADATA_NAME_NOT_FOUND     = 0x8000000FL,
        /// <summary>Name is an existing namespace rather than a typename.</summary>
        RO_E_METADATA_NAME_IS_NAMESPACE  = 0x80000010L,
        /// <summary>Typename has an invalid format.</summary>
        RO_E_METADATA_INVALID_TYPE_FORMAT = 0x80000011L,
        /// <summary>Metadata file is invalid or corrupted.</summary>
        RO_E_INVALID_METADATA_FILE       = 0x80000012L,
        /// <summary>The object has been closed.</summary>
        RO_E_CLOSED                      = 0x80000013L,
        /// <summary>Only one thread may access the object during a write operation.</summary>
        RO_E_EXCLUSIVE_WRITE             = 0x80000014L,
        /// <summary>Operation is prohibited during change notification.</summary>
        RO_E_CHANGE_NOTIFICATION_IN_PROGRESS = 0x80000015L,
        /// <summary>The text associated with this error code could not be found.</summary>
        RO_E_ERROR_STRING_NOT_FOUND      = 0x80000016L,
        /// <summary>String not null terminated.</summary>
        E_STRING_NOT_NULL_TERMINATED     = 0x80000017L,
        /// <summary>A delegate was assigned when not allowed.</summary>
        E_ILLEGAL_DELEGATE_ASSIGNMENT    = 0x80000018L,
        /// <summary>An async operation was not properly started.</summary>
        E_ASYNC_OPERATION_NOT_STARTED    = 0x80000019L,
        /// <summary>The application is exiting and cannot service this request</summary>
        E_APPLICATION_EXITING            = 0x8000001AL,
        /// <summary>The application view is exiting and cannot service this request</summary>
        E_APPLICATION_VIEW_EXITING       = 0x8000001BL,
        /// <summary>The object must support the IAgileObject interface</summary>
        RO_E_MUST_BE_AGILE               = 0x8000001CL,
        /// <summary>Activating a single-threaded class from MTA is not supported</summary>
        RO_E_UNSUPPORTED_FROM_MTA        = 0x8000001DL,
        /// <summary>The object has been committed.</summary>
        RO_E_COMMITTED                   = 0x8000001EL,
        /// <summary>A COM call to an ASTA was blocked because the call chain originated in or passed through another ASTA. This call pattern is deadlock-prone and disallowed by apartment call control.</summary>
        RO_E_BLOCKED_CROSS_ASTA_CALL     = 0x8000001FL,
        /// <summary>Thread local storage failure</summary>
        CO_E_INIT_TLS                    = 0x80004006L,
        /// <summary>Get shared memory allocator failure</summary>
        CO_E_INIT_SHARED_ALLOCATOR       = 0x80004007L,
        /// <summary>Get memory allocator failure</summary>
        CO_E_INIT_MEMORY_ALLOCATOR       = 0x80004008L,
        /// <summary>Unable to initialize class cache</summary>
        CO_E_INIT_CLASS_CACHE            = 0x80004009L,
        /// <summary>Unable to initialize RPC services</summary>
        CO_E_INIT_RPC_CHANNEL            = 0x8000400AL,
        /// <summary>Cannot set thread local storage channel control</summary>
        CO_E_INIT_TLS_SET_CHANNEL_CONTROL = 0x8000400BL,
        /// <summary>Could not allocate thread local storage channel control</summary>
        CO_E_INIT_TLS_CHANNEL_CONTROL    = 0x8000400CL,
        /// <summary>The user supplied memory allocator is unacceptable</summary>
        CO_E_INIT_UNACCEPTED_USER_ALLOCATOR = 0x8000400DL,
        /// <summary>The OLE service mutex already exists</summary>
        CO_E_INIT_SCM_MUTEX_EXISTS       = 0x8000400EL,
        /// <summary>The OLE service file mapping already exists</summary>
        CO_E_INIT_SCM_FILE_MAPPING_EXISTS = 0x8000400FL,
        /// <summary>Unable to map view of file for OLE service</summary>
        CO_E_INIT_SCM_MAP_VIEW_OF_FILE   = 0x80004010L,
        /// <summary>Failure attempting to launch OLE service</summary>
        CO_E_INIT_SCM_EXEC_FAILURE       = 0x80004011L,
        /// <summary>There was an attempt to call CoInitialize a second time while single threaded</summary>
        CO_E_INIT_ONLY_SINGLE_THREADED   = 0x80004012L,
        /// <summary>A Remote activation was necessary but was not allowed</summary>
        CO_E_CANT_REMOTE                 = 0x80004013L,
        /// <summary>A Remote activation was necessary but the server name provided was invalid</summary>
        CO_E_BAD_SERVER_NAME             = 0x80004014L,
        /// <summary>The class is configured to run as a security id different from the caller</summary>
        CO_E_WRONG_SERVER_IDENTITY       = 0x80004015L,
        /// <summary>Use of Ole1 services requiring DDE windows is disabled</summary>
        CO_E_OLE1DDE_DISABLED            = 0x80004016L,
        /// <summary>A RunAs specification must be <domain name>\<user name> or simply <user name></summary>
        CO_E_RUNAS_SYNTAX                = 0x80004017L,
        /// <summary>The server process could not be started. The pathname may be incorrect.</summary>
        CO_E_CREATEPROCESS_FAILURE       = 0x80004018L,
        /// <summary>The server process could not be started as the configured identity. The pathname may be incorrect or unavailable.</summary>
        CO_E_RUNAS_CREATEPROCESS_FAILURE = 0x80004019L,
        /// <summary>The server process could not be started because the configured identity is incorrect. Check the username and password.</summary>
        CO_E_RUNAS_LOGON_FAILURE         = 0x8000401AL,
        /// <summary>The client is not allowed to launch this server.</summary>
        CO_E_LAUNCH_PERMSSION_DENIED     = 0x8000401BL,
        /// <summary>The service providing this server could not be started.</summary>
        CO_E_START_SERVICE_FAILURE       = 0x8000401CL,
        /// <summary>This computer was unable to communicate with the computer providing the server.</summary>
        CO_E_REMOTE_COMMUNICATION_FAILURE = 0x8000401DL,
        /// <summary>The server did not respond after being launched.</summary>
        CO_E_SERVER_START_TIMEOUT        = 0x8000401EL,
        /// <summary>The registration information for this server is inconsistent or incomplete.</summary>
        CO_E_CLSREG_INCONSISTENT         = 0x8000401FL,
        /// <summary>The registration information for this interface is inconsistent or incomplete.</summary>
        CO_E_IIDREG_INCONSISTENT         = 0x80004020L,
        /// <summary>The operation attempted is not supported.</summary>
        CO_E_NOT_SUPPORTED               = 0x80004021L,
        /// <summary>A dll must be loaded.</summary>
        CO_E_RELOAD_DLL                  = 0x80004022L,
        /// <summary>A Microsoft Software Installer error was encountered.</summary>
        CO_E_MSI_ERROR                   = 0x80004023L,
        /// <summary>The specified activation could not occur in the client context as specified.</summary>
        CO_E_ATTEMPT_TO_CREATE_OUTSIDE_CLIENT_CONTEXT = 0x80004024L,
        /// <summary>Activations on the server are paused.</summary>
        CO_E_SERVER_PAUSED               = 0x80004025L,
        /// <summary>Activations on the server are not paused.</summary>
        CO_E_SERVER_NOT_PAUSED           = 0x80004026L,
        /// <summary>The component or application containing the component has been disabled.</summary>
        CO_E_CLASS_DISABLED              = 0x80004027L,
        /// <summary>The common language runtime is not available</summary>
        CO_E_CLRNOTAVAILABLE             = 0x80004028L,
        /// <summary>The thread-pool rejected the submitted asynchronous work.</summary>
        CO_E_ASYNC_WORK_REJECTED         = 0x80004029L,
        /// <summary>The server started, but did not finish initializing in a timely fashion.</summary>
        CO_E_SERVER_INIT_TIMEOUT         = 0x8000402AL,
        /// <summary>Unable to complete the call since there is no COM+ security context inside IObjectControl.Activate.</summary>
        CO_E_NO_SECCTX_IN_ACTIVATE       = 0x8000402BL,
        /// <summary>The provided tracker configuration is invalid</summary>
        CO_E_TRACKER_CONFIG              = 0x80004030L,
        /// <summary>The provided thread pool configuration is invalid</summary>
        CO_E_THREADPOOL_CONFIG           = 0x80004031L,
        /// <summary>The provided side-by-side configuration is invalid</summary>
        CO_E_SXS_CONFIG                  = 0x80004032L,
        /// <summary>The server principal name (SPN) obtained during security negotiation is malformed.</summary>
        CO_E_MALFORMED_SPN               = 0x80004033L,
        /// <summary>The caller failed to revoke a per-apartment registration before apartment shutdown.</summary>
        CO_E_UNREVOKED_REGISTRATION_ON_APARTMENT_SHUTDOWN = 0x80004034L,
        /// <summary>The object has been rundown by the stub manager while there are external clients.</summary>
        CO_E_PREMATURE_STUB_RUNDOWN      = 0x80004035L,
        /// <summary>Invalid OLEVERB structure</summary>
        OLE_E_OLEVERB                    = 0x80040000L,
        /// <summary>Invalid advise flags</summary>
        OLE_E_ADVF                       = 0x80040001L,
        /// <summary>Can't enumerate any more, because the associated data is missing</summary>
        OLE_E_ENUM_NOMORE                = 0x80040002L,
        /// <summary>This implementation doesn't take advises</summary>
        OLE_E_ADVISENOTSUPPORTED         = 0x80040003L,
        /// <summary>There is no connection for this connection ID</summary>
        OLE_E_NOCONNECTION               = 0x80040004L,
        /// <summary>Need to run the object to perform this operation</summary>
        OLE_E_NOTRUNNING                 = 0x80040005L,
        /// <summary>There is no cache to operate on</summary>
        OLE_E_NOCACHE                    = 0x80040006L,
        /// <summary>Uninitialized object</summary>
        OLE_E_BLANK                      = 0x80040007L,
        /// <summary>Linked object's source class has changed</summary>
        OLE_E_CLASSDIFF                  = 0x80040008L,
        /// <summary>Not able to get the moniker of the object</summary>
        OLE_E_CANT_GETMONIKER            = 0x80040009L,
        /// <summary>Not able to bind to the source</summary>
        OLE_E_CANT_BINDTOSOURCE          = 0x8004000AL,
        /// <summary>Object is static; operation not allowed</summary>
        OLE_E_STATIC                     = 0x8004000BL,
        /// <summary>User canceled out of save dialog</summary>
        OLE_E_PROMPTSAVECANCELLED        = 0x8004000CL,
        /// <summary>Invalid rectangle</summary>
        OLE_E_INVALIDRECT                = 0x8004000DL,
        /// <summary>compobj.dll is too old for the ole2.dll initialized</summary>
        OLE_E_WRONGCOMPOBJ               = 0x8004000EL,
        /// <summary>Invalid window handle</summary>
        OLE_E_INVALIDHWND                = 0x8004000FL,
        /// <summary>Object is not in any of the inplace active states</summary>
        OLE_E_NOT_INPLACEACTIVE          = 0x80040010L,
        /// <summary>Not able to convert object</summary>
        OLE_E_CANTCONVERT                = 0x80040011L,
        /// <summary>Not able to perform the operation because object is not given storage yet</summary>
        OLE_E_NOSTORAGE                  = 0x80040012L,
        /// <summary>Invalid FORMATETC structure</summary>
        DV_E_FORMATETC                   = 0x80040064L,
        /// <summary>Invalid DVTARGETDEVICE structure</summary>
        DV_E_DVTARGETDEVICE              = 0x80040065L,
        /// <summary>Invalid STDGMEDIUM structure</summary>
        DV_E_STGMEDIUM                   = 0x80040066L,
        /// <summary>Invalid STATDATA structure</summary>
        DV_E_STATDATA                    = 0x80040067L,
        /// <summary>Invalid lindex</summary>
        DV_E_LINDEX                      = 0x80040068L,
        /// <summary>Invalid tymed</summary>
        DV_E_TYMED                       = 0x80040069L,
        /// <summary>Invalid clipboard format</summary>
        DV_E_CLIPFORMAT                  = 0x8004006AL,
        /// <summary>Invalid aspect(s)</summary>
        DV_E_DVASPECT                    = 0x8004006BL,
        /// <summary>tdSize parameter of the DVTARGETDEVICE structure is invalid</summary>
        DV_E_DVTARGETDEVICE_SIZE         = 0x8004006CL,
        /// <summary>Object doesn't support IViewObject interface</summary>
        DV_E_NOIVIEWOBJECT               = 0x8004006DL,
        /// <summary>Trying to revoke a drop target that has not been registered</summary>
        DRAGDROP_E_NOTREGISTERED         = 0x80040100L,
        /// <summary>This window has already been registered as a drop target</summary>
        DRAGDROP_E_ALREADYREGISTERED     = 0x80040101L,
        /// <summary>Invalid window handle</summary>
        DRAGDROP_E_INVALIDHWND           = 0x80040102L,
        /// <summary>A drag operation is already in progress</summary>
        DRAGDROP_E_CONCURRENT_DRAG_ATTEMPTED = 0x80040103L,
        /// <summary>Class does not support aggregation (or class object is remote)</summary>
        CLASS_E_NOAGGREGATION            = 0x80040110L,
        /// <summary>ClassFactory cannot supply requested class</summary>
        CLASS_E_CLASSNOTAVAILABLE        = 0x80040111L,
        /// <summary>Class is not licensed for use</summary>
        CLASS_E_NOTLICENSED              = 0x80040112L,
        /// <summary>Error drawing view</summary>
        VIEW_E_DRAW                      = 0x80040140L,
        /// <summary>Could not read key from registry</summary>
        REGDB_E_READREGDB                = 0x80040150L,
        /// <summary>Could not write key to registry</summary>
        REGDB_E_WRITEREGDB               = 0x80040151L,
        /// <summary>Could not find the key in the registry</summary>
        REGDB_E_KEYMISSING               = 0x80040152L,
        /// <summary>Invalid value for registry</summary>
        REGDB_E_INVALIDVALUE             = 0x80040153L,
        /// <summary>Class not registered</summary>
        REGDB_E_CLASSNOTREG              = 0x80040154L,
        /// <summary>Interface not registered</summary>
        REGDB_E_IIDNOTREG                = 0x80040155L,
        /// <summary>Threading model entry is not valid</summary>
        REGDB_E_BADTHREADINGMODEL        = 0x80040156L,
        /// <summary>A registration in a package violates package-specific policies</summary>
        REGDB_E_PACKAGEPOLICYVIOLATION   = 0x80040157L,
        /// <summary>CATID does not exist</summary>
        CAT_E_CATIDNOEXIST               = 0x80040160L,
        /// <summary>Description not found</summary>
        CAT_E_NODESCRIPTION              = 0x80040161L,
        /// <summary>No package in the software installation data in the Active Directory meets this criteria.</summary>
        CS_E_PACKAGE_NOTFOUND            = 0x80040164L,
        /// <summary>Deleting this will break the referential integrity of the software installation data in the Active Directory.</summary>
        CS_E_NOT_DELETABLE               = 0x80040165L,
        /// <summary>The CLSID was not found in the software installation data in the Active Directory.</summary>
        CS_E_CLASS_NOTFOUND              = 0x80040166L,
        /// <summary>The software installation data in the Active Directory is corrupt.</summary>
        CS_E_INVALID_VERSION             = 0x80040167L,
        /// <summary>There is no software installation data in the Active Directory.</summary>
        CS_E_NO_CLASSSTORE               = 0x80040168L,
        /// <summary>There is no software installation data object in the Active Directory.</summary>
        CS_E_OBJECT_NOTFOUND             = 0x80040169L,
        /// <summary>The software installation data object in the Active Directory already exists.</summary>
        CS_E_OBJECT_ALREADY_EXISTS       = 0x8004016AL,
        /// <summary>The path to the software installation data in the Active Directory is not correct.</summary>
        CS_E_INVALID_PATH                = 0x8004016BL,
        /// <summary>A network error interrupted the operation.</summary>
        CS_E_NETWORK_ERROR               = 0x8004016CL,
        /// <summary>The size of this object exceeds the maximum size set by the Administrator.</summary>
        CS_E_ADMIN_LIMIT_EXCEEDED        = 0x8004016DL,
        /// <summary>The schema for the software installation data in the Active Directory does not match the required schema.</summary>
        CS_E_SCHEMA_MISMATCH             = 0x8004016EL,
        /// <summary>An error occurred in the software installation data in the Active Directory.</summary>
        CS_E_INTERNAL_ERROR              = 0x8004016FL,
        /// <summary>Cache not updated</summary>
        CACHE_E_NOCACHE_UPDATED          = 0x80040170L,
        /// <summary>No verbs for OLE object</summary>
        OLEOBJ_E_NOVERBS                 = 0x80040180L,
        /// <summary>Invalid verb for OLE object</summary>
        OLEOBJ_E_INVALIDVERB             = 0x80040181L,
        /// <summary>Undo is not available</summary>
        INPLACE_E_NOTUNDOABLE            = 0x800401A0L,
        /// <summary>Space for tools is not available</summary>
        INPLACE_E_NOTOOLSPACE            = 0x800401A1L,
        /// <summary>OLESTREAM Get method failed</summary>
        CONVERT10_E_OLESTREAM_GET        = 0x800401C0L,
        /// <summary>OLESTREAM Put method failed</summary>
        CONVERT10_E_OLESTREAM_PUT        = 0x800401C1L,
        /// <summary>Contents of the OLESTREAM not in correct format</summary>
        CONVERT10_E_OLESTREAM_FMT        = 0x800401C2L,
        /// <summary>There was an error in a Windows GDI call while converting the bitmap to a DIB</summary>
        CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = 0x800401C3L,
        /// <summary>Contents of the IStorage not in correct format</summary>
        CONVERT10_E_STG_FMT              = 0x800401C4L,
        /// <summary>Contents of IStorage is missing one of the standard streams</summary>
        CONVERT10_E_STG_NO_STD_STREAM    = 0x800401C5L,
        /// <summary>There was an error in a Windows GDI call while converting the DIB to a bitmap.</summary>
        CONVERT10_E_STG_DIB_TO_BITMAP    = 0x800401C6L,
        /// <summary>OpenClipboard Failed</summary>
        CLIPBRD_E_CANT_OPEN              = 0x800401D0L,
        /// <summary>EmptyClipboard Failed</summary>
        CLIPBRD_E_CANT_EMPTY             = 0x800401D1L,
        /// <summary>SetClipboard Failed</summary>
        CLIPBRD_E_CANT_SET               = 0x800401D2L,
        /// <summary>Data on clipboard is invalid</summary>
        CLIPBRD_E_BAD_DATA               = 0x800401D3L,
        /// <summary>CloseClipboard Failed</summary>
        CLIPBRD_E_CANT_CLOSE             = 0x800401D4L,
        /// <summary>Moniker needs to be connected manually</summary>
        MK_E_CONNECTMANUALLY             = 0x800401E0L,
        /// <summary>Operation exceeded deadline</summary>
        MK_E_EXCEEDEDDEADLINE            = 0x800401E1L,
        /// <summary>Moniker needs to be generic</summary>
        MK_E_NEEDGENERIC                 = 0x800401E2L,
        /// <summary>Operation unavailable</summary>
        MK_E_UNAVAILABLE                 = 0x800401E3L,
        /// <summary>Invalid syntax</summary>
        MK_E_SYNTAX                      = 0x800401E4L,
        /// <summary>No object for moniker</summary>
        MK_E_NOOBJECT                    = 0x800401E5L,
        /// <summary>Bad extension for file</summary>
        MK_E_INVALIDEXTENSION            = 0x800401E6L,
        /// <summary>Intermediate operation failed</summary>
        MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = 0x800401E7L,
        /// <summary>Moniker is not bindable</summary>
        MK_E_NOTBINDABLE                 = 0x800401E8L,
        /// <summary>Moniker is not bound</summary>
        MK_E_NOTBOUND                    = 0x800401E9L,
        /// <summary>Moniker cannot open file</summary>
        MK_E_CANTOPENFILE                = 0x800401EAL,
        /// <summary>User input required for operation to succeed</summary>
        MK_E_MUSTBOTHERUSER              = 0x800401EBL,
        /// <summary>Moniker class has no inverse</summary>
        MK_E_NOINVERSE                   = 0x800401ECL,
        /// <summary>Moniker does not refer to storage</summary>
        MK_E_NOSTORAGE                   = 0x800401EDL,
        /// <summary>No common prefix</summary>
        MK_E_NOPREFIX                    = 0x800401EEL,
        /// <summary>Moniker could not be enumerated</summary>
        MK_E_ENUMERATION_FAILED          = 0x800401EFL,
        /// <summary>CoInitialize has not been called.</summary>
        CO_E_NOTINITIALIZED              = 0x800401F0L,
        /// <summary>CoInitialize has already been called.</summary>
        CO_E_ALREADYINITIALIZED          = 0x800401F1L,
        /// <summary>Class of object cannot be determined</summary>
        CO_E_CANTDETERMINECLASS          = 0x800401F2L,
        /// <summary>Invalid class string</summary>
        CO_E_CLASSSTRING                 = 0x800401F3L,
        /// <summary>Invalid interface string</summary>
        CO_E_IIDSTRING                   = 0x800401F4L,
        /// <summary>Application not found</summary>
        CO_E_APPNOTFOUND                 = 0x800401F5L,
        /// <summary>Application cannot be run more than once</summary>
        CO_E_APPSINGLEUSE                = 0x800401F6L,
        /// <summary>Some error in application program</summary>
        CO_E_ERRORINAPP                  = 0x800401F7L,
        /// <summary>DLL for class not found</summary>
        CO_E_DLLNOTFOUND                 = 0x800401F8L,
        /// <summary>Error in the DLL</summary>
        CO_E_ERRORINDLL                  = 0x800401F9L,
        /// <summary>Wrong OS or OS version for application</summary>
        CO_E_WRONGOSFORAPP               = 0x800401FAL,
        /// <summary>Object is not registered</summary>
        CO_E_OBJNOTREG                   = 0x800401FBL,
        /// <summary>Object is already registered</summary>
        CO_E_OBJISREG                    = 0x800401FCL,
        /// <summary>Object is not connected to server</summary>
        CO_E_OBJNOTCONNECTED             = 0x800401FDL,
        /// <summary>Application was launched but it didn't register a class factory</summary>
        CO_E_APPDIDNTREG                 = 0x800401FEL,
        /// <summary>Object has been released</summary>
        CO_E_RELEASED                    = 0x800401FFL,
        /// <summary>An event was able to invoke some but not all of the subscribers</summary>
        EVENT_S_SOME_SUBSCRIBERS_FAILED  = 0x00040200L,
        /// <summary>An event was unable to invoke any of the subscribers</summary>
        EVENT_E_ALL_SUBSCRIBERS_FAILED   = 0x80040201L,
        /// <summary>An event was delivered but there were no subscribers</summary>
        EVENT_S_NOSUBSCRIBERS            = 0x00040202L,
        /// <summary>A syntax error occurred trying to evaluate a query string</summary>
        EVENT_E_QUERYSYNTAX              = 0x80040203L,
        /// <summary>An invalid field name was used in a query string</summary>
        EVENT_E_QUERYFIELD               = 0x80040204L,
        /// <summary>An unexpected exception was raised</summary>
        EVENT_E_INTERNALEXCEPTION        = 0x80040205L,
        /// <summary>An unexpected internal error was detected</summary>
        EVENT_E_INTERNALERROR            = 0x80040206L,
        /// <summary>The owner SID on a per-user subscription doesn't exist</summary>
        EVENT_E_INVALID_PER_USER_SID     = 0x80040207L,
        /// <summary>A user-supplied component or subscriber raised an exception</summary>
        EVENT_E_USER_EXCEPTION           = 0x80040208L,
        /// <summary>An interface has too many methods to fire events from</summary>
        EVENT_E_TOO_MANY_METHODS         = 0x80040209L,
        /// <summary>A subscription cannot be stored unless its event class already exists</summary>
        EVENT_E_MISSING_EVENTCLASS       = 0x8004020AL,
        /// <summary>Not all the objects requested could be removed</summary>
        EVENT_E_NOT_ALL_REMOVED          = 0x8004020BL,
        /// <summary>COM+ is required for this operation, but is not installed</summary>
        EVENT_E_COMPLUS_NOT_INSTALLED    = 0x8004020CL,
        /// <summary>Cannot modify or delete an object that was not added using the COM+ Admin SDK</summary>
        EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT = 0x8004020DL,
        /// <summary>Cannot modify or delete an object that was added using the COM+ Admin SDK</summary>
        EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT = 0x8004020EL,
        /// <summary>The event class for this subscription is in an invalid partition</summary>
        EVENT_E_INVALID_EVENT_CLASS_PARTITION = 0x8004020FL,
        /// <summary>The owner of the PerUser subscription is not logged on to the system specified</summary>
        EVENT_E_PER_USER_SID_NOT_LOGGED_ON = 0x80040210L,
        /// <summary>TabletPC inking error code. The property was not found, or supported by the recognizer</summary>
        TPC_E_INVALID_PROPERTY           = 0x80040241L,
        /// <summary>TabletPC inking error code. No default tablet</summary>
        TPC_E_NO_DEFAULT_TABLET          = 0x80040212L,
        /// <summary>TabletPC inking error code. Unknown property specified</summary>
        TPC_E_UNKNOWN_PROPERTY           = 0x8004021BL,
        /// <summary>TabletPC inking error code. An invalid input rectangle was specified</summary>
        TPC_E_INVALID_INPUT_RECT         = 0x80040219L,
        /// <summary>TabletPC inking error code. The stroke object was deleted</summary>
        TPC_E_INVALID_STROKE             = 0x80040222L,
        /// <summary>TabletPC inking error code. Initialization failure</summary>
        TPC_E_INITIALIZE_FAIL            = 0x80040223L,
        /// <summary>TabletPC inking error code. The data required for the operation was not supplied</summary>
        TPC_E_NOT_RELEVANT               = 0x80040232L,
        /// <summary>TabletPC inking error code. Invalid packet description</summary>
        TPC_E_INVALID_PACKET_DESCRIPTION = 0x80040233L,
        /// <summary>TabletPC inking error code. There are no handwriting recognizers registered</summary>
        TPC_E_RECOGNIZER_NOT_REGISTERED  = 0x80040235L,
        /// <summary>TabletPC inking error code. User does not have the necessary rights to read recognizer information</summary>
        TPC_E_INVALID_RIGHTS             = 0x80040236L,
        /// <summary>TabletPC inking error code. API calls were made in an incorrect order</summary>
        TPC_E_OUT_OF_ORDER_CALL          = 0x80040237L,
        /// <summary>TabletPC inking error code. Queue is full</summary>
        TPC_E_QUEUE_FULL                 = 0x80040238L,
        /// <summary>TabletPC inking error code. RtpEnabled called multiple times</summary>
        TPC_E_INVALID_CONFIGURATION      = 0x80040239L,
        /// <summary>TabletPC inking error code. A recognizer returned invalid data</summary>
        TPC_E_INVALID_DATA_FROM_RECOGNIZER = 0x8004023AL,
        /// <summary>TabletPC inking error code. String was truncated</summary>
        TPC_S_TRUNCATED                  = 0x00040252L,
        /// <summary>TabletPC inking error code. Recognition or training was interrupted</summary>
        TPC_S_INTERRUPTED                = 0x00040253L,
        /// <summary>TabletPC inking error code. No personalization update to the recognizer because no training data found</summary>
        TPC_S_NO_DATA_TO_PROCESS         = 0x00040254L,
        /// <summary>Another single phase resource manager has already been enlisted in this transaction.</summary>
        XACT_E_ALREADYOTHERSINGLEPHASE   = 0x8004D000L,
        /// <summary>A retaining commit or abort is not supported</summary>
        XACT_E_CANTRETAIN                = 0x8004D001L,
        /// <summary>The transaction failed to commit for an unknown reason. The transaction was aborted.</summary>
        XACT_E_COMMITFAILED              = 0x8004D002L,
        /// <summary>Cannot call commit on this transaction object because the calling application did not initiate the transaction.</summary>
        XACT_E_COMMITPREVENTED           = 0x8004D003L,
        /// <summary>Instead of committing, the resource heuristically aborted.</summary>
        XACT_E_HEURISTICABORT            = 0x8004D004L,
        /// <summary>Instead of aborting, the resource heuristically committed.</summary>
        XACT_E_HEURISTICCOMMIT           = 0x8004D005L,
        /// <summary>Some of the states of the resource were committed while others were aborted, likely because of heuristic decisions.</summary>
        XACT_E_HEURISTICDAMAGE           = 0x8004D006L,
        /// <summary>Some of the states of the resource may have been committed while others may have been aborted, likely because of heuristic decisions.</summary>
        XACT_E_HEURISTICDANGER           = 0x8004D007L,
        /// <summary>The requested isolation level is not valid or supported.</summary>
        XACT_E_ISOLATIONLEVEL            = 0x8004D008L,
        /// <summary>The transaction manager doesn't support an asynchronous operation for this method.</summary>
        XACT_E_NOASYNC                   = 0x8004D009L,
        /// <summary>Unable to enlist in the transaction.</summary>
        XACT_E_NOENLIST                  = 0x8004D00AL,
        /// <summary>The requested semantics of retention of isolation across retaining commit and abort boundaries cannot be supported by this transaction implementation, or isoFlags was not equal to zero.</summary>
        XACT_E_NOISORETAIN               = 0x8004D00BL,
        /// <summary>There is no resource presently associated with this enlistment</summary>
        XACT_E_NORESOURCE                = 0x8004D00CL,
        /// <summary>The transaction failed to commit due to the failure of optimistic concurrency control in at least one of the resource managers.</summary>
        XACT_E_NOTCURRENT                = 0x8004D00DL,
        /// <summary>The transaction has already been implicitly or explicitly committed or aborted</summary>
        XACT_E_NOTRANSACTION             = 0x8004D00EL,
        /// <summary>An invalid combination of flags was specified</summary>
        XACT_E_NOTSUPPORTED              = 0x8004D00FL,
        /// <summary>The resource manager id is not associated with this transaction or the transaction manager.</summary>
        XACT_E_UNKNOWNRMGRID             = 0x8004D010L,
        /// <summary>This method was called in the wrong state</summary>
        XACT_E_WRONGSTATE                = 0x8004D011L,
        /// <summary>The indicated unit of work does not match the unit of work expected by the resource manager.</summary>
        XACT_E_WRONGUOW                  = 0x8004D012L,
        /// <summary>An enlistment in a transaction already exists.</summary>
        XACT_E_XTIONEXISTS               = 0x8004D013L,
        /// <summary>An import object for the transaction could not be found.</summary>
        XACT_E_NOIMPORTOBJECT            = 0x8004D014L,
        /// <summary>The transaction cookie is invalid.</summary>
        XACT_E_INVALIDCOOKIE             = 0x8004D015L,
        /// <summary>The transaction status is in doubt. A communication failure occurred, or a transaction manager or resource manager has failed</summary>
        XACT_E_INDOUBT                   = 0x8004D016L,
        /// <summary>A time-out was specified, but time-outs are not supported.</summary>
        XACT_E_NOTIMEOUT                 = 0x8004D017L,
        /// <summary>The requested operation is already in progress for the transaction.</summary>
        XACT_E_ALREADYINPROGRESS         = 0x8004D018L,
        /// <summary>The transaction has already been aborted.</summary>
        XACT_E_ABORTED                   = 0x8004D019L,
        /// <summary>The Transaction Manager returned a log full error.</summary>
        XACT_E_LOGFULL                   = 0x8004D01AL,
        /// <summary>The Transaction Manager is not available.</summary>
        XACT_E_TMNOTAVAILABLE            = 0x8004D01BL,
        /// <summary>A connection with the transaction manager was lost.</summary>
        XACT_E_CONNECTION_DOWN           = 0x8004D01CL,
        /// <summary>A request to establish a connection with the transaction manager was denied.</summary>
        XACT_E_CONNECTION_DENIED         = 0x8004D01DL,
        /// <summary>Resource manager reenlistment to determine transaction status timed out.</summary>
        XACT_E_REENLISTTIMEOUT           = 0x8004D01EL,
        /// <summary>This transaction manager failed to establish a connection with another TIP transaction manager.</summary>
        XACT_E_TIP_CONNECT_FAILED        = 0x8004D01FL,
        /// <summary>This transaction manager encountered a protocol error with another TIP transaction manager.</summary>
        XACT_E_TIP_PROTOCOL_ERROR        = 0x8004D020L,
        /// <summary>This transaction manager could not propagate a transaction from another TIP transaction manager.</summary>
        XACT_E_TIP_PULL_FAILED           = 0x8004D021L,
        /// <summary>The Transaction Manager on the destination machine is not available.</summary>
        XACT_E_DEST_TMNOTAVAILABLE       = 0x8004D022L,
        /// <summary>The Transaction Manager has disabled its support for TIP.</summary>
        XACT_E_TIP_DISABLED              = 0x8004D023L,
        /// <summary>The transaction manager has disabled its support for remote/network transactions.</summary>
        XACT_E_NETWORK_TX_DISABLED       = 0x8004D024L,
        /// <summary>The partner transaction manager has disabled its support for remote/network transactions.</summary>
        XACT_E_PARTNER_NETWORK_TX_DISABLED = 0x8004D025L,
        /// <summary>The transaction manager has disabled its support for XA transactions.</summary>
        XACT_E_XA_TX_DISABLED            = 0x8004D026L,
        /// <summary>MSDTC was unable to read its configuration information.</summary>
        XACT_E_UNABLE_TO_READ_DTC_CONFIG = 0x8004D027L,
        /// <summary>MSDTC was unable to load the dtc proxy dll.</summary>
        XACT_E_UNABLE_TO_LOAD_DTC_PROXY  = 0x8004D028L,
        /// <summary>The local transaction has aborted.</summary>
        XACT_E_ABORTING                  = 0x8004D029L,
        /// <summary>The MSDTC transaction manager was unable to push the transaction to the destination transaction manager due to communication problems. Possible causes are: a firewall is present and it doesn't have an exception for the MSDTC process, the two machines cannot find each other by their NetBIOS names, or the support for network transactions is not enabled for one of the two transaction managers.</summary>
        XACT_E_PUSH_COMM_FAILURE         = 0x8004D02AL,
        /// <summary>The MSDTC transaction manager was unable to pull the transaction from the source transaction manager due to communication problems. Possible causes are: a firewall is present and it doesn't have an exception for the MSDTC process, the two machines cannot find each other by their NetBIOS names, or the support for network transactions is not enabled for one of the two transaction managers.</summary>
        XACT_E_PULL_COMM_FAILURE         = 0x8004D02BL,
        /// <summary>The MSDTC transaction manager has disabled its support for SNA LU 6.2 transactions.</summary>
        XACT_E_LU_TX_DISABLED            = 0x8004D02CL,
        /// <summary> XACT_E_CLERKNOTFOUND</summary>
        XACT_E_CLERKNOTFOUND             = 0x8004D080L,
        /// <summary> XACT_E_CLERKEXISTS</summary>
        XACT_E_CLERKEXISTS               = 0x8004D081L,
        /// <summary> XACT_E_RECOVERYINPROGRESS</summary>
        XACT_E_RECOVERYINPROGRESS        = 0x8004D082L,
        /// <summary> XACT_E_TRANSACTIONCLOSED</summary>
        XACT_E_TRANSACTIONCLOSED         = 0x8004D083L,
        /// <summary> XACT_E_INVALIDLSN</summary>
        XACT_E_INVALIDLSN                = 0x8004D084L,
        /// <summary> XACT_E_REPLAYREQUEST</summary>
        XACT_E_REPLAYREQUEST             = 0x8004D085L,
        /// <summary>The request to connect to the specified transaction coordinator was denied. SymbolicName=XACT_E_TOOMANY_ENLISTMENTS MessageId: 0x8004D101L (No symbolic name defined) The maximum number of enlistments for the specified transaction has been reached. SymbolicName=XACT_E_DUPLICATE_GUID MessageId: 0x8004D102L (No symbolic name defined) A resource manager with the same identifier is already registered with the specified transaction coordinator. SymbolicName=XACT_E_NOTSINGLEPHASE MessageId: 0x8004D103L (No symbolic name defined) The prepare request given was not eligible for single phase optimizations. SymbolicName=XACT_E_RECOVERYALREADYDONE MessageId: 0x8004D104L (No symbolic name defined) RecoveryComplete has already been called for the given resource manager. SymbolicName=XACT_E_PROTOCOL MessageId: 0x8004D105L (No symbolic name defined) The interface call made was incorrect for the current state of the protocol. SymbolicName=XACT_E_RM_FAILURE MessageId: 0x8004D106L (No symbolic name defined) xa_open call failed for the XA resource. SymbolicName=XACT_E_RECOVERY_FAILED MessageId: 0x8004D107L (No symbolic name defined) xa_recover call failed for the XA resource. SymbolicName=XACT_E_LU_NOT_FOUND MessageId: 0x8004D108L (No symbolic name defined) The Logical Unit of Work specified cannot be found. SymbolicName=XACT_E_DUPLICATE_LU MessageId: 0x8004D109L (No symbolic name defined) The specified Logical Unit of Work already exists. SymbolicName=XACT_E_LU_NOT_CONNECTED MessageId: 0x8004D10AL (No symbolic name defined) Subordinate creation failed. The specified Logical Unit of Work was not connected. SymbolicName=XACT_E_DUPLICATE_TRANSID MessageId: 0x8004D10BL (No symbolic name defined) A transaction with the given identifier already exists. SymbolicName=XACT_E_LU_BUSY MessageId: 0x8004D10CL (No symbolic name defined) The resource is in use. SymbolicName=XACT_E_LU_NO_RECOVERY_PROCESS MessageId: 0x8004D10DL (No symbolic name defined) The LU Recovery process is down. SymbolicName=XACT_E_LU_DOWN MessageId: 0x8004D10EL (No symbolic name defined) The remote session was lost. SymbolicName=XACT_E_LU_RECOVERING MessageId: 0x8004D10FL (No symbolic name defined) The resource is currently recovering. SymbolicName=XACT_E_LU_RECOVERY_MISMATCH MessageId: 0x8004D110L (No symbolic name defined) There was a mismatch in driving recovery. SymbolicName=XACT_E_RM_UNAVAILABLE MessageId: 0x8004D111L (No symbolic name defined) An error occurred with the XA resource. End XACT_DTC_CONSTANTS enumerated values defined in txdtc.h OleTx Success codes. MessageId: XACT_S_ASYNC An asynchronous operation was specified. The operation has begun, but its outcome is not known yet.</summary>
        XACT_S_ASYNC                     = 0x0004D000L,
        /// <summary> XACT_S_DEFECT</summary>
        XACT_S_DEFECT                    = 0x0004D001L,
        /// <summary>The method call succeeded because the transaction was read-only.</summary>
        XACT_S_READONLY                  = 0x0004D002L,
        /// <summary>The transaction was successfully aborted. However, this is a coordinated transaction, and some number of enlisted resources were aborted outright because they could not support abort-retaining semantics</summary>
        XACT_S_SOMENORETAIN              = 0x0004D003L,
        /// <summary>No changes were made during this call, but the sink wants another chance to look if any other sinks make further changes.</summary>
        XACT_S_OKINFORM                  = 0x0004D004L,
        /// <summary>The sink is content and wishes the transaction to proceed. Changes were made to one or more resources during this call.</summary>
        XACT_S_MADECHANGESCONTENT        = 0x0004D005L,
        /// <summary>The sink is for the moment and wishes the transaction to proceed, but if other changes are made following this return by other event sinks then this sink wants another chance to look</summary>
        XACT_S_MADECHANGESINFORM         = 0x0004D006L,
        /// <summary>The transaction was successfully aborted. However, the abort was non-retaining.</summary>
        XACT_S_ALLNORETAIN               = 0x0004D007L,
        /// <summary>An abort operation was already in progress.</summary>
        XACT_S_ABORTING                  = 0x0004D008L,
        /// <summary>The resource manager has performed a single-phase commit of the transaction.</summary>
        XACT_S_SINGLEPHASE               = 0x0004D009L,
        /// <summary>The local transaction has not aborted.</summary>
        XACT_S_LOCALLY_OK                = 0x0004D00AL,
        /// <summary>The resource manager has requested to be the coordinator (last resource manager) for the transaction.</summary>
        XACT_S_LASTRESOURCEMANAGER       = 0x0004D010L,
        /// <summary>The root transaction wanted to commit, but transaction aborted</summary>
        CONTEXT_E_ABORTED                = 0x8004E002L,
        /// <summary>You made a method call on a COM+ component that has a transaction that has already aborted or in the process of aborting.</summary>
        CONTEXT_E_ABORTING               = 0x8004E003L,
        /// <summary>There is no MTS object context</summary>
        CONTEXT_E_NOCONTEXT              = 0x8004E004L,
        /// <summary>The component is configured to use synchronization and this method call would cause a deadlock to occur.</summary>
        CONTEXT_E_WOULD_DEADLOCK         = 0x8004E005L,
        /// <summary>The component is configured to use synchronization and a thread has timed out waiting to enter the context.</summary>
        CONTEXT_E_SYNCH_TIMEOUT          = 0x8004E006L,
        /// <summary>You made a method call on a COM+ component that has a transaction that has already committed or aborted.</summary>
        CONTEXT_E_OLDREF                 = 0x8004E007L,
        /// <summary>The specified role was not configured for the application</summary>
        CONTEXT_E_ROLENOTFOUND           = 0x8004E00CL,
        /// <summary>COM+ was unable to talk to the Microsoft Distributed Transaction Coordinator</summary>
        CONTEXT_E_TMNOTAVAILABLE         = 0x8004E00FL,
        /// <summary>An unexpected error occurred during COM+ Activation.</summary>
        CO_E_ACTIVATIONFAILED            = 0x8004E021L,
        /// <summary>COM+ Activation failed. Check the event log for more information</summary>
        CO_E_ACTIVATIONFAILED_EVENTLOGGED = 0x8004E022L,
        /// <summary>COM+ Activation failed due to a catalog or configuration error.</summary>
        CO_E_ACTIVATIONFAILED_CATALOGERROR = 0x8004E023L,
        /// <summary>COM+ activation failed because the activation could not be completed in the specified amount of time.</summary>
        CO_E_ACTIVATIONFAILED_TIMEOUT    = 0x8004E024L,
        /// <summary>COM+ Activation failed because an initialization function failed. Check the event log for more information.</summary>
        CO_E_INITIALIZATIONFAILED        = 0x8004E025L,
        /// <summary>The requested operation requires that JIT be in the current context and it is not</summary>
        CONTEXT_E_NOJIT                  = 0x8004E026L,
        /// <summary>The requested operation requires that the current context have a Transaction, and it does not</summary>
        CONTEXT_E_NOTRANSACTION          = 0x8004E027L,
        /// <summary>The components threading model has changed after install into a COM+ Application. Please re-install component.</summary>
        CO_E_THREADINGMODEL_CHANGED      = 0x8004E028L,
        /// <summary>IIS intrinsics not available. Start your work with IIS.</summary>
        CO_E_NOIISINTRINSICS             = 0x8004E029L,
        /// <summary>An attempt to write a cookie failed.</summary>
        CO_E_NOCOOKIES                   = 0x8004E02AL,
        /// <summary>An attempt to use a database generated a database specific error.</summary>
        CO_E_DBERROR                     = 0x8004E02BL,
        /// <summary>The COM+ component you created must use object pooling to work.</summary>
        CO_E_NOTPOOLED                   = 0x8004E02CL,
        /// <summary>The COM+ component you created must use object construction to work correctly.</summary>
        CO_E_NOTCONSTRUCTED              = 0x8004E02DL,
        /// <summary>The COM+ component requires synchronization, and it is not configured for it.</summary>
        CO_E_NOSYNCHRONIZATION           = 0x8004E02EL,
        /// <summary>The TxIsolation Level property for the COM+ component being created is stronger than the TxIsolationLevel for the "root" component for the transaction. The creation failed.</summary>
        CO_E_ISOLEVELMISMATCH            = 0x8004E02FL,
        /// <summary>The component attempted to make a cross-context call between invocations of EnterTransactionScopeand ExitTransactionScope. This is not allowed. Cross-context calls cannot be made while inside of a transaction scope.</summary>
        CO_E_CALL_OUT_OF_TX_SCOPE_NOT_ALLOWED = 0x8004E030L,
        /// <summary>The component made a call to EnterTransactionScope, but did not make a corresponding call to ExitTransactionScope before returning.</summary>
        CO_E_EXIT_TRANSACTION_SCOPE_NOT_CALLED = 0x8004E031L,
        /// <summary>Use the registry database to provide the requested information</summary>
        OLE_S_USEREG                     = 0x00040000L,
        /// <summary>Success, but static</summary>
        OLE_S_STATIC                     = 0x00040001L,
        /// <summary>Macintosh clipboard format</summary>
        OLE_S_MAC_CLIPFORMAT             = 0x00040002L,
        /// <summary>Successful drop took place</summary>
        DRAGDROP_S_DROP                  = 0x00040100L,
        /// <summary>Drag-drop operation canceled</summary>
        DRAGDROP_S_CANCEL                = 0x00040101L,
        /// <summary>Use the default cursor</summary>
        DRAGDROP_S_USEDEFAULTCURSORS     = 0x00040102L,
        /// <summary>Data has same FORMATETC</summary>
        DATA_S_SAMEFORMATETC             = 0x00040130L,
        /// <summary>View is already frozen</summary>
        VIEW_S_ALREADY_FROZEN            = 0x00040140L,
        /// <summary>FORMATETC not supported</summary>
        CACHE_S_FORMATETC_NOTSUPPORTED   = 0x00040170L,
        /// <summary>Same cache</summary>
        CACHE_S_SAMECACHE                = 0x00040171L,
        /// <summary>Some cache(s) not updated</summary>
        CACHE_S_SOMECACHES_NOTUPDATED    = 0x00040172L,
        /// <summary>Invalid verb for OLE object</summary>
        OLEOBJ_S_INVALIDVERB             = 0x00040180L,
        /// <summary>Verb number is valid but verb cannot be done now</summary>
        OLEOBJ_S_CANNOT_DOVERB_NOW       = 0x00040181L,
        /// <summary>Invalid window handle passed</summary>
        OLEOBJ_S_INVALIDHWND             = 0x00040182L,
        /// <summary>Message is too long; some of it had to be truncated before displaying</summary>
        INPLACE_S_TRUNCATED              = 0x000401A0L,
        /// <summary>Unable to convert OLESTREAM to IStorage</summary>
        CONVERT10_S_NO_PRESENTATION      = 0x000401C0L,
        /// <summary>Moniker reduced to itself</summary>
        MK_S_REDUCED_TO_SELF             = 0x000401E2L,
        /// <summary>Common prefix is this moniker</summary>
        MK_S_ME                          = 0x000401E4L,
        /// <summary>Common prefix is input moniker</summary>
        MK_S_HIM                         = 0x000401E5L,
        /// <summary>Common prefix is both monikers</summary>
        MK_S_US                          = 0x000401E6L,
        /// <summary>Moniker is already registered in running object table</summary>
        MK_S_MONIKERALREADYREGISTERED    = 0x000401E7L,
        /// <summary>The task is ready to run at its next scheduled time.</summary>
        SCHED_S_TASK_READY               = 0x00041300L,
        /// <summary>The task is currently running.</summary>
        SCHED_S_TASK_RUNNING             = 0x00041301L,
        /// <summary>The task will not run at the scheduled times because it has been disabled.</summary>
        SCHED_S_TASK_DISABLED            = 0x00041302L,
        /// <summary>The task has not yet run.</summary>
        SCHED_S_TASK_HAS_NOT_RUN         = 0x00041303L,
        /// <summary>There are no more runs scheduled for this task.</summary>
        SCHED_S_TASK_NO_MORE_RUNS        = 0x00041304L,
        /// <summary>One or more of the properties that are needed to run this task on a schedule have not been set.</summary>
        SCHED_S_TASK_NOT_SCHEDULED       = 0x00041305L,
        /// <summary>The last run of the task was terminated by the user.</summary>
        SCHED_S_TASK_TERMINATED          = 0x00041306L,
        /// <summary>Either the task has no triggers or the existing triggers are disabled or not set.</summary>
        SCHED_S_TASK_NO_VALID_TRIGGERS   = 0x00041307L,
        /// <summary>Event triggers don't have set run times.</summary>
        SCHED_S_EVENT_TRIGGER            = 0x00041308L,
        /// <summary>Trigger not found.</summary>
        SCHED_E_TRIGGER_NOT_FOUND        = 0x80041309L,
        /// <summary>One or more of the properties that are needed to run this task have not been set.</summary>
        SCHED_E_TASK_NOT_READY           = 0x8004130AL,
        /// <summary>There is no running instance of the task.</summary>
        SCHED_E_TASK_NOT_RUNNING         = 0x8004130BL,
        /// <summary>The Task Scheduler Service is not installed on this computer.</summary>
        SCHED_E_SERVICE_NOT_INSTALLED    = 0x8004130CL,
        /// <summary>The task object could not be opened.</summary>
        SCHED_E_CANNOT_OPEN_TASK         = 0x8004130DL,
        /// <summary>The object is either an invalid task object or is not a task object.</summary>
        SCHED_E_INVALID_TASK             = 0x8004130EL,
        /// <summary>No account information could be found in the Task Scheduler security database for the task indicated.</summary>
        SCHED_E_ACCOUNT_INFORMATION_NOT_SET = 0x8004130FL,
        /// <summary>Unable to establish existence of the account specified.</summary>
        SCHED_E_ACCOUNT_NAME_NOT_FOUND   = 0x80041310L,
        /// <summary>Corruption was detected in the Task Scheduler security database; the database has been reset.</summary>
        SCHED_E_ACCOUNT_DBASE_CORRUPT    = 0x80041311L,
        /// <summary>Task Scheduler security services are available only on Windows NT.</summary>
        SCHED_E_NO_SECURITY_SERVICES     = 0x80041312L,
        /// <summary>The task object version is either unsupported or invalid.</summary>
        SCHED_E_UNKNOWN_OBJECT_VERSION   = 0x80041313L,
        /// <summary>The task has been configured with an unsupported combination of account settings and run time options.</summary>
        SCHED_E_UNSUPPORTED_ACCOUNT_OPTION = 0x80041314L,
        /// <summary>The Task Scheduler Service is not running.</summary>
        SCHED_E_SERVICE_NOT_RUNNING      = 0x80041315L,
        /// <summary>The task XML contains an unexpected node.</summary>
        SCHED_E_UNEXPECTEDNODE           = 0x80041316L,
        /// <summary>The task XML contains an element or attribute from an unexpected namespace.</summary>
        SCHED_E_NAMESPACE                = 0x80041317L,
        /// <summary>The task XML contains a value which is incorrectly formatted or out of range.</summary>
        SCHED_E_INVALIDVALUE             = 0x80041318L,
        /// <summary>The task XML is missing a required element or attribute.</summary>
        SCHED_E_MISSINGNODE              = 0x80041319L,
        /// <summary>The task XML is malformed.</summary>
        SCHED_E_MALFORMEDXML             = 0x8004131AL,
        /// <summary>The task is registered, but not all specified triggers will start the task, check task scheduler event log for detailed information.</summary>
        SCHED_S_SOME_TRIGGERS_FAILED     = 0x0004131BL,
        /// <summary>The task is registered, but may fail to start. Batch logon privilege needs to be enabled for the task principal.</summary>
        SCHED_S_BATCH_LOGON_PROBLEM      = 0x0004131CL,
        /// <summary>The task XML contains too many nodes of the same type.</summary>
        SCHED_E_TOO_MANY_NODES           = 0x8004131DL,
        /// <summary>The task cannot be started after the trigger's end boundary.</summary>
        SCHED_E_PAST_END_BOUNDARY        = 0x8004131EL,
        /// <summary>An instance of this task is already running.</summary>
        SCHED_E_ALREADY_RUNNING          = 0x8004131FL,
        /// <summary>The task will not run because the user is not logged on.</summary>
        SCHED_E_USER_NOT_LOGGED_ON       = 0x80041320L,
        /// <summary>The task image is corrupt or has been tampered with.</summary>
        SCHED_E_INVALID_TASK_HASH        = 0x80041321L,
        /// <summary>The Task Scheduler service is not available.</summary>
        SCHED_E_SERVICE_NOT_AVAILABLE    = 0x80041322L,
        /// <summary>The Task Scheduler service is too busy to handle your request. Please try again later.</summary>
        SCHED_E_SERVICE_TOO_BUSY         = 0x80041323L,
        /// <summary>The Task Scheduler service attempted to run the task, but the task did not run due to one of the constraints in the task definition.</summary>
        SCHED_E_TASK_ATTEMPTED           = 0x80041324L,
        /// <summary>The Task Scheduler service has asked the task to run.</summary>
        SCHED_S_TASK_QUEUED              = 0x00041325L,
        /// <summary>The task is disabled.</summary>
        SCHED_E_TASK_DISABLED            = 0x80041326L,
        /// <summary>The task has properties that are not compatible with previous versions of Windows.</summary>
        SCHED_E_TASK_NOT_V1_COMPAT       = 0x80041327L,
        /// <summary>The task settings do not allow the task to start on demand.</summary>
        SCHED_E_START_ON_DEMAND          = 0x80041328L,
        /// <summary>The combination of properties that task is using is not compatible with the scheduling engine.</summary>
        SCHED_E_TASK_NOT_UBPM_COMPAT     = 0x80041329L,
        /// <summary>The task definition uses a deprecated feature.</summary>
        SCHED_E_DEPRECATED_FEATURE_USED  = 0x80041330L,
        /// <summary>Attempt to create a class object failed</summary>
        CO_E_CLASS_CREATE_FAILED         = 0x80080001L,
        /// <summary>OLE service could not bind object</summary>
        CO_E_SCM_ERROR                   = 0x80080002L,
        /// <summary>RPC communication failed with OLE service</summary>
        CO_E_SCM_RPC_FAILURE             = 0x80080003L,
        /// <summary>Bad path to object</summary>
        CO_E_BAD_PATH                    = 0x80080004L,
        /// <summary>Server execution failed</summary>
        CO_E_SERVER_EXEC_FAILURE         = 0x80080005L,
        /// <summary>OLE service could not communicate with the object server</summary>
        CO_E_OBJSRV_RPC_FAILURE          = 0x80080006L,
        /// <summary>Moniker path could not be normalized</summary>
        MK_E_NO_NORMALIZED               = 0x80080007L,
        /// <summary>Object server is stopping when OLE service contacts it</summary>
        CO_E_SERVER_STOPPING             = 0x80080008L,
        /// <summary>An invalid root block pointer was specified</summary>
        MEM_E_INVALID_ROOT               = 0x80080009L,
        /// <summary>An allocation chain contained an invalid link pointer</summary>
        MEM_E_INVALID_LINK               = 0x80080010L,
        /// <summary>The requested allocation size was too large</summary>
        MEM_E_INVALID_SIZE               = 0x80080011L,
        /// <summary>Not all the requested interfaces were available</summary>
        CO_S_NOTALLINTERFACES            = 0x00080012L,
        /// <summary>The specified machine name was not found in the cache.</summary>
        CO_S_MACHINENAMENOTFOUND         = 0x00080013L,
        /// <summary>The activation requires a display name to be present under the CLSID key.</summary>
        CO_E_MISSING_DISPLAYNAME         = 0x80080015L,
        /// <summary>The activation requires that the RunAs value for the application is Activate As Activator.</summary>
        CO_E_RUNAS_VALUE_MUST_BE_AAA     = 0x80080016L,
        /// <summary>The class is not configured to support Elevated activation.</summary>
        CO_E_ELEVATION_DISABLED          = 0x80080017L,
        /// <summary>Appx packaging API has encountered an internal error.</summary>
        APPX_E_PACKAGING_INTERNAL        = 0x80080200L,
        /// <summary>The file is not a valid Appx package because its contents are interleaved.</summary>
        APPX_E_INTERLEAVING_NOT_ALLOWED  = 0x80080201L,
        /// <summary>The file is not a valid Appx package because it contains OPC relationships.</summary>
        APPX_E_RELATIONSHIPS_NOT_ALLOWED = 0x80080202L,
        /// <summary>The file is not a valid Appx package because it is missing a manifest or block map, or missing a signature file when the code integrity file is present.</summary>
        APPX_E_MISSING_REQUIRED_FILE     = 0x80080203L,
        /// <summary>The Appx package's manifest is invalid.</summary>
        APPX_E_INVALID_MANIFEST          = 0x80080204L,
        /// <summary>The Appx package's block map is invalid.</summary>
        APPX_E_INVALID_BLOCKMAP          = 0x80080205L,
        /// <summary>The Appx package's content cannot be read because it is corrupt.</summary>
        APPX_E_CORRUPT_CONTENT           = 0x80080206L,
        /// <summary>The computed hash value of the block does not match the one stored in the block map.</summary>
        APPX_E_BLOCK_HASH_INVALID        = 0x80080207L,
        /// <summary>The requested byte range is over 4GB when translated to byte range of blocks.</summary>
        APPX_E_REQUESTED_RANGE_TOO_LARGE = 0x80080208L,
        /// <summary>The SIP_SUBJECTINFO structure used to sign the package didn't contain the required data.</summary>
        APPX_E_INVALID_SIP_CLIENT_DATA   = 0x80080209L,
        /// <summary>The APPX_KEY_INFO structure used to encrypt or decrypt the package contains invalid data.</summary>
        APPX_E_INVALID_KEY_INFO          = 0x8008020AL,
        /// <summary>The background task activation is spurious.</summary>
        BT_E_SPURIOUS_ACTIVATION         = 0x80080300L,
        /// <summary>Unknown interface.</summary>
        DISP_E_UNKNOWNINTERFACE          = 0x80020001L,
        /// <summary>Member not found.</summary>
        DISP_E_MEMBERNOTFOUND            = 0x80020003L,
        /// <summary>Parameter not found.</summary>
        DISP_E_PARAMNOTFOUND             = 0x80020004L,
        /// <summary>Type mismatch.</summary>
        DISP_E_TYPEMISMATCH              = 0x80020005L,
        /// <summary>Unknown name.</summary>
        DISP_E_UNKNOWNNAME               = 0x80020006L,
        /// <summary>No named arguments.</summary>
        DISP_E_NONAMEDARGS               = 0x80020007L,
        /// <summary>Bad variable type.</summary>
        DISP_E_BADVARTYPE                = 0x80020008L,
        /// <summary>Exception occurred.</summary>
        DISP_E_EXCEPTION                 = 0x80020009L,
        /// <summary>Out of present range.</summary>
        DISP_E_OVERFLOW                  = 0x8002000AL,
        /// <summary>Invalid index.</summary>
        DISP_E_BADINDEX                  = 0x8002000BL,
        /// <summary>Unknown language.</summary>
        DISP_E_UNKNOWNLCID               = 0x8002000CL,
        /// <summary>Memory is locked.</summary>
        DISP_E_ARRAYISLOCKED             = 0x8002000DL,
        /// <summary>Invalid number of parameters.</summary>
        DISP_E_BADPARAMCOUNT             = 0x8002000EL,
        /// <summary>Parameter not optional.</summary>
        DISP_E_PARAMNOTOPTIONAL          = 0x8002000FL,
        /// <summary>Invalid callee.</summary>
        DISP_E_BADCALLEE                 = 0x80020010L,
        /// <summary>Does not support a collection.</summary>
        DISP_E_NOTACOLLECTION            = 0x80020011L,
        /// <summary>Division by zero.</summary>
        DISP_E_DIVBYZERO                 = 0x80020012L,
        /// <summary>Buffer too small</summary>
        DISP_E_BUFFERTOOSMALL            = 0x80020013L,
        /// <summary>Buffer too small.</summary>
        TYPE_E_BUFFERTOOSMALL            = 0x80028016L,
        /// <summary>Field name not defined in the record.</summary>
        TYPE_E_FIELDNOTFOUND             = 0x80028017L,
        /// <summary>Old format or invalid type library.</summary>
        TYPE_E_INVDATAREAD               = 0x80028018L,
        /// <summary>Old format or invalid type library.</summary>
        TYPE_E_UNSUPFORMAT               = 0x80028019L,
        /// <summary>Error accessing the OLE registry.</summary>
        TYPE_E_REGISTRYACCESS            = 0x8002801CL,
        /// <summary>Library not registered.</summary>
        TYPE_E_LIBNOTREGISTERED          = 0x8002801DL,
        /// <summary>Bound to unknown type.</summary>
        TYPE_E_UNDEFINEDTYPE             = 0x80028027L,
        /// <summary>Qualified name disallowed.</summary>
        TYPE_E_QUALIFIEDNAMEDISALLOWED   = 0x80028028L,
        /// <summary>Invalid forward reference, or reference to uncompiled type.</summary>
        TYPE_E_INVALIDSTATE              = 0x80028029L,
        /// <summary>Type mismatch.</summary>
        TYPE_E_WRONGTYPEKIND             = 0x8002802AL,
        /// <summary>Element not found.</summary>
        TYPE_E_ELEMENTNOTFOUND           = 0x8002802BL,
        /// <summary>Ambiguous name.</summary>
        TYPE_E_AMBIGUOUSNAME             = 0x8002802CL,
        /// <summary>Name already exists in the library.</summary>
        TYPE_E_NAMECONFLICT              = 0x8002802DL,
        /// <summary>Unknown LCID.</summary>
        TYPE_E_UNKNOWNLCID               = 0x8002802EL,
        /// <summary>Function not defined in specified DLL.</summary>
        TYPE_E_DLLFUNCTIONNOTFOUND       = 0x8002802FL,
        /// <summary>Wrong module kind for the operation.</summary>
        TYPE_E_BADMODULEKIND             = 0x800288BDL,
        /// <summary>Size may not exceed 64K.</summary>
        TYPE_E_SIZETOOBIG                = 0x800288C5L,
        /// <summary>Duplicate ID in inheritance hierarchy.</summary>
        TYPE_E_DUPLICATEID               = 0x800288C6L,
        /// <summary>Incorrect inheritance depth in standard OLE hmember.</summary>
        TYPE_E_INVALIDID                 = 0x800288CFL,
        /// <summary>Type mismatch.</summary>
        TYPE_E_TYPEMISMATCH              = 0x80028CA0L,
        /// <summary>Invalid number of arguments.</summary>
        TYPE_E_OUTOFBOUNDS               = 0x80028CA1L,
        /// <summary>I/O Error.</summary>
        TYPE_E_IOERROR                   = 0x80028CA2L,
        /// <summary>Error creating unique tmp file.</summary>
        TYPE_E_CANTCREATETMPFILE         = 0x80028CA3L,
        /// <summary>Error loading type library/DLL.</summary>
        TYPE_E_CANTLOADLIBRARY           = 0x80029C4AL,
        /// <summary>Inconsistent property functions.</summary>
        TYPE_E_INCONSISTENTPROPFUNCS     = 0x80029C83L,
        /// <summary>Circular dependency between types/modules.</summary>
        TYPE_E_CIRCULARTYPE              = 0x80029C84L,
        /// <summary>Unable to perform requested operation.</summary>
        STG_E_INVALIDFUNCTION            = 0x80030001L,
        /// <summary>%1 could not be found.</summary>
        STG_E_FILENOTFOUND               = 0x80030002L,
        /// <summary>The path %1 could not be found.</summary>
        STG_E_PATHNOTFOUND               = 0x80030003L,
        /// <summary>There are insufficient resources to open another file.</summary>
        STG_E_TOOMANYOPENFILES           = 0x80030004L,
        /// <summary>Access Denied.</summary>
        STG_E_ACCESSDENIED               = 0x80030005L,
        /// <summary>Attempted an operation on an invalid object.</summary>
        STG_E_INVALIDHANDLE              = 0x80030006L,
        /// <summary>There is insufficient memory available to complete operation.</summary>
        STG_E_INSUFFICIENTMEMORY         = 0x80030008L,
        /// <summary>Invalid pointer error.</summary>
        STG_E_INVALIDPOINTER             = 0x80030009L,
        /// <summary>There are no more entries to return.</summary>
        STG_E_NOMOREFILES                = 0x80030012L,
        /// <summary>Disk is write-protected.</summary>
        STG_E_DISKISWRITEPROTECTED       = 0x80030013L,
        /// <summary>An error occurred during a seek operation.</summary>
        STG_E_SEEKERROR                  = 0x80030019L,
        /// <summary>A disk error occurred during a write operation.</summary>
        STG_E_WRITEFAULT                 = 0x8003001DL,
        /// <summary>A disk error occurred during a read operation.</summary>
        STG_E_READFAULT                  = 0x8003001EL,
        /// <summary>A share violation has occurred.</summary>
        STG_E_SHAREVIOLATION             = 0x80030020L,
        /// <summary>A lock violation has occurred.</summary>
        STG_E_LOCKVIOLATION              = 0x80030021L,
        /// <summary>%1 already exists.</summary>
        STG_E_FILEALREADYEXISTS          = 0x80030050L,
        /// <summary>Invalid parameter error.</summary>
        STG_E_INVALIDPARAMETER           = 0x80030057L,
        /// <summary>There is insufficient disk space to complete operation.</summary>
        STG_E_MEDIUMFULL                 = 0x80030070L,
        /// <summary>Illegal write of non-simple property to simple property set.</summary>
        STG_E_PROPSETMISMATCHED          = 0x800300F0L,
        /// <summary>An API call exited abnormally.</summary>
        STG_E_ABNORMALAPIEXIT            = 0x800300FAL,
        /// <summary>The file %1 is not a valid compound file.</summary>
        STG_E_INVALIDHEADER              = 0x800300FBL,
        /// <summary>The name %1 is not valid.</summary>
        STG_E_INVALIDNAME                = 0x800300FCL,
        /// <summary>An unexpected error occurred.</summary>
        STG_E_UNKNOWN                    = 0x800300FDL,
        /// <summary>That function is not implemented.</summary>
        STG_E_UNIMPLEMENTEDFUNCTION      = 0x800300FEL,
        /// <summary>Invalid flag error.</summary>
        STG_E_INVALIDFLAG                = 0x800300FFL,
        /// <summary>Attempted to use an object that is busy.</summary>
        STG_E_INUSE                      = 0x80030100L,
        /// <summary>The storage has been changed since the last commit.</summary>
        STG_E_NOTCURRENT                 = 0x80030101L,
        /// <summary>Attempted to use an object that has ceased to exist.</summary>
        STG_E_REVERTED                   = 0x80030102L,
        /// <summary>Can't save.</summary>
        STG_E_CANTSAVE                   = 0x80030103L,
        /// <summary>The compound file %1 was produced with an incompatible version of storage.</summary>
        STG_E_OLDFORMAT                  = 0x80030104L,
        /// <summary>The compound file %1 was produced with a newer version of storage.</summary>
        STG_E_OLDDLL                     = 0x80030105L,
        /// <summary>Share.exe or equivalent is required for operation.</summary>
        STG_E_SHAREREQUIRED              = 0x80030106L,
        /// <summary>Illegal operation called on non-file based storage.</summary>
        STG_E_NOTFILEBASEDSTORAGE        = 0x80030107L,
        /// <summary>Illegal operation called on object with extant marshallings.</summary>
        STG_E_EXTANTMARSHALLINGS         = 0x80030108L,
        /// <summary>The docfile has been corrupted.</summary>
        STG_E_DOCFILECORRUPT             = 0x80030109L,
        /// <summary>OLE32.DLL has been loaded at the wrong address.</summary>
        STG_E_BADBASEADDRESS             = 0x80030110L,
        /// <summary>The compound file is too large for the current implementation</summary>
        STG_E_DOCFILETOOLARGE            = 0x80030111L,
        /// <summary>The compound file was not created with the STGM_SIMPLE flag</summary>
        STG_E_NOTSIMPLEFORMAT            = 0x80030112L,
        /// <summary>The file download was aborted abnormally. The file is incomplete.</summary>
        STG_E_INCOMPLETE                 = 0x80030201L,
        /// <summary>The file download has been terminated.</summary>
        STG_E_TERMINATED                 = 0x80030202L,
        /// <summary>The underlying file was converted to compound file format.</summary>
        STG_S_CONVERTED                  = 0x00030200L,
        /// <summary>The storage operation should block until more data is available.</summary>
        STG_S_BLOCK                      = 0x00030201L,
        /// <summary>The storage operation should retry immediately.</summary>
        STG_S_RETRYNOW                   = 0x00030202L,
        /// <summary>The notified event sink will not influence the storage operation.</summary>
        STG_S_MONITORING                 = 0x00030203L,
        /// <summary>Multiple opens prevent consolidated. (commit succeeded).</summary>
        STG_S_MULTIPLEOPENS              = 0x00030204L,
        /// <summary>Consolidation of the storage file failed. (commit succeeded).</summary>
        STG_S_CONSOLIDATIONFAILED        = 0x00030205L,
        /// <summary>Consolidation of the storage file is inappropriate. (commit succeeded).</summary>
        STG_S_CANNOTCONSOLIDATE          = 0x00030206L,
        /// <summary>The device needs to be power cycled. (commit succeeded).</summary>
        STG_S_POWER_CYCLE_REQUIRED       = 0x00030207L,
        /// <summary>The specified firmware slot is invalid.</summary>
        STG_E_FIRMWARE_SLOT_INVALID      = 0x80030208L,
        /// <summary>The specified firmware image is invalid.</summary>
        STG_E_FIRMWARE_IMAGE_INVALID     = 0x80030209L,
        /// <summary>The storage device is unresponsive.</summary>
        STG_E_DEVICE_UNRESPONSIVE        = 0x8003020AL,
        /// <summary>Generic Copy Protection Error.</summary>
        STG_E_STATUS_COPY_PROTECTION_FAILURE = 0x80030305L,
        /// <summary>Copy Protection Error - DVD CSS Authentication failed.</summary>
        STG_E_CSS_AUTHENTICATION_FAILURE = 0x80030306L,
        /// <summary>Copy Protection Error - The given sector does not have a valid CSS key.</summary>
        STG_E_CSS_KEY_NOT_PRESENT        = 0x80030307L,
        /// <summary>Copy Protection Error - DVD session key not established.</summary>
        STG_E_CSS_KEY_NOT_ESTABLISHED    = 0x80030308L,
        /// <summary>Copy Protection Error - The read failed because the sector is encrypted.</summary>
        STG_E_CSS_SCRAMBLED_SECTOR       = 0x80030309L,
        /// <summary>Copy Protection Error - The current DVD's region does not correspond to the region setting of the drive.</summary>
        STG_E_CSS_REGION_MISMATCH        = 0x8003030AL,
        /// <summary>Copy Protection Error - The drive's region setting may be permanent or the number of user resets has been exhausted.</summary>
        STG_E_RESETS_EXHAUSTED           = 0x8003030BL,
        /// <summary>Call was rejected by callee.</summary>
        RPC_E_CALL_REJECTED              = 0x80010001L,
        /// <summary>Call was canceled by the message filter.</summary>
        RPC_E_CALL_CANCELED              = 0x80010002L,
        /// <summary>The caller is dispatching an intertask SendMessage call and cannot call out via PostMessage.</summary>
        RPC_E_CANTPOST_INSENDCALL        = 0x80010003L,
        /// <summary>The caller is dispatching an asynchronous call and cannot make an outgoing call on behalf of this call.</summary>
        RPC_E_CANTCALLOUT_INASYNCCALL    = 0x80010004L,
        /// <summary>It is illegal to call out while inside message filter.</summary>
        RPC_E_CANTCALLOUT_INEXTERNALCALL = 0x80010005L,
        /// <summary>The connection terminated or is in a bogus state and cannot be used any more. Other connections are still valid.</summary>
        RPC_E_CONNECTION_TERMINATED      = 0x80010006L,
        /// <summary>The callee (server [not server application]) is not available and disappeared; all connections are invalid. The call may have executed.</summary>
        RPC_E_SERVER_DIED                = 0x80010007L,
        /// <summary>The caller (client) disappeared while the callee (server) was processing a call.</summary>
        RPC_E_CLIENT_DIED                = 0x80010008L,
        /// <summary>The data packet with the marshalled parameter data is incorrect.</summary>
        RPC_E_INVALID_DATAPACKET         = 0x80010009L,
        /// <summary>The call was not transmitted properly; the message queue was full and was not emptied after yielding.</summary>
        RPC_E_CANTTRANSMIT_CALL          = 0x8001000AL,
        /// <summary>The client (caller) cannot marshall the parameter data - low memory, etc.</summary>
        RPC_E_CLIENT_CANTMARSHAL_DATA    = 0x8001000BL,
        /// <summary>The client (caller) cannot unmarshall the return data - low memory, etc.</summary>
        RPC_E_CLIENT_CANTUNMARSHAL_DATA  = 0x8001000CL,
        /// <summary>The server (callee) cannot marshall the return data - low memory, etc.</summary>
        RPC_E_SERVER_CANTMARSHAL_DATA    = 0x8001000DL,
        /// <summary>The server (callee) cannot unmarshall the parameter data - low memory, etc.</summary>
        RPC_E_SERVER_CANTUNMARSHAL_DATA  = 0x8001000EL,
        /// <summary>Received data is invalid; could be server or client data.</summary>
        RPC_E_INVALID_DATA               = 0x8001000FL,
        /// <summary>A particular parameter is invalid and cannot be (un)marshalled.</summary>
        RPC_E_INVALID_PARAMETER          = 0x80010010L,
        /// <summary>There is no second outgoing call on same channel in DDE conversation.</summary>
        RPC_E_CANTCALLOUT_AGAIN          = 0x80010011L,
        /// <summary>The callee (server [not server application]) is not available and disappeared; all connections are invalid. The call did not execute.</summary>
        RPC_E_SERVER_DIED_DNE            = 0x80010012L,
        /// <summary>System call failed.</summary>
        RPC_E_SYS_CALL_FAILED            = 0x80010100L,
        /// <summary>Could not allocate some required resource (memory, events, ...)</summary>
        RPC_E_OUT_OF_RESOURCES           = 0x80010101L,
        /// <summary>Attempted to make calls on more than one thread in single threaded mode.</summary>
        RPC_E_ATTEMPTED_MULTITHREAD      = 0x80010102L,
        /// <summary>The requested interface is not registered on the server object.</summary>
        RPC_E_NOT_REGISTERED             = 0x80010103L,
        /// <summary>RPC could not call the server or could not return the results of calling the server.</summary>
        RPC_E_FAULT                      = 0x80010104L,
        /// <summary>The server threw an exception.</summary>
        RPC_E_SERVERFAULT                = 0x80010105L,
        /// <summary>Cannot change thread mode after it is set.</summary>
        RPC_E_CHANGED_MODE               = 0x80010106L,
        /// <summary>The method called does not exist on the server.</summary>
        RPC_E_INVALIDMETHOD              = 0x80010107L,
        /// <summary>The object invoked has disconnected from its clients.</summary>
        RPC_E_DISCONNECTED               = 0x80010108L,
        /// <summary>The object invoked chose not to process the call now. Try again later.</summary>
        RPC_E_RETRY                      = 0x80010109L,
        /// <summary>The message filter indicated that the application is busy.</summary>
        RPC_E_SERVERCALL_RETRYLATER      = 0x8001010AL,
        /// <summary>The message filter rejected the call.</summary>
        RPC_E_SERVERCALL_REJECTED        = 0x8001010BL,
        /// <summary>A call control interfaces was called with invalid data.</summary>
        RPC_E_INVALID_CALLDATA           = 0x8001010CL,
        /// <summary>An outgoing call cannot be made since the application is dispatching an input-synchronous call.</summary>
        RPC_E_CANTCALLOUT_ININPUTSYNCCALL = 0x8001010DL,
        /// <summary>The application called an interface that was marshalled for a different thread.</summary>
        RPC_E_WRONG_THREAD               = 0x8001010EL,
        /// <summary>CoInitialize has not been called on the current thread.</summary>
        RPC_E_THREAD_NOT_INIT            = 0x8001010FL,
        /// <summary>The version of OLE on the client and server machines does not match.</summary>
        RPC_E_VERSION_MISMATCH           = 0x80010110L,
        /// <summary>OLE received a packet with an invalid header.</summary>
        RPC_E_INVALID_HEADER             = 0x80010111L,
        /// <summary>OLE received a packet with an invalid extension.</summary>
        RPC_E_INVALID_EXTENSION          = 0x80010112L,
        /// <summary>The requested object or interface does not exist.</summary>
        RPC_E_INVALID_IPID               = 0x80010113L,
        /// <summary>The requested object does not exist.</summary>
        RPC_E_INVALID_OBJECT             = 0x80010114L,
        /// <summary>OLE has sent a request and is waiting for a reply.</summary>
        RPC_S_CALLPENDING                = 0x80010115L,
        /// <summary>OLE is waiting before retrying a request.</summary>
        RPC_S_WAITONTIMER                = 0x80010116L,
        /// <summary>Call context cannot be accessed after call completed.</summary>
        RPC_E_CALL_COMPLETE              = 0x80010117L,
        /// <summary>Impersonate on unsecure calls is not supported.</summary>
        RPC_E_UNSECURE_CALL              = 0x80010118L,
        /// <summary>Security must be initialized before any interfaces are marshalled or unmarshalled. It cannot be changed once initialized.</summary>
        RPC_E_TOO_LATE                   = 0x80010119L,
        /// <summary>No security packages are installed on this machine or the user is not logged on or there are no compatible security packages between the client and server.</summary>
        RPC_E_NO_GOOD_SECURITY_PACKAGES  = 0x8001011AL,
        /// <summary>Access is denied.</summary>
        RPC_E_ACCESS_DENIED              = 0x8001011BL,
        /// <summary>Remote calls are not allowed for this process.</summary>
        RPC_E_REMOTE_DISABLED            = 0x8001011CL,
        /// <summary>The marshaled interface data packet (OBJREF) has an invalid or unknown format.</summary>
        RPC_E_INVALID_OBJREF             = 0x8001011DL,
        /// <summary>No context is associated with this call. This happens for some custom marshalled calls and on the client side of the call.</summary>
        RPC_E_NO_CONTEXT                 = 0x8001011EL,
        /// <summary>This operation returned because the timeout period expired.</summary>
        RPC_E_TIMEOUT                    = 0x8001011FL,
        /// <summary>There are no synchronize objects to wait on.</summary>
        RPC_E_NO_SYNC                    = 0x80010120L,
        /// <summary>Full subject issuer chain SSL principal name expected from the server.</summary>
        RPC_E_FULLSIC_REQUIRED           = 0x80010121L,
        /// <summary>Principal name is not a valid MSSTD name.</summary>
        RPC_E_INVALID_STD_NAME           = 0x80010122L,
        /// <summary>Unable to impersonate DCOM client</summary>
        CO_E_FAILEDTOIMPERSONATE         = 0x80010123L,
        /// <summary>Unable to obtain server's security context</summary>
        CO_E_FAILEDTOGETSECCTX           = 0x80010124L,
        /// <summary>Unable to open the access token of the current thread</summary>
        CO_E_FAILEDTOOPENTHREADTOKEN     = 0x80010125L,
        /// <summary>Unable to obtain user info from an access token</summary>
        CO_E_FAILEDTOGETTOKENINFO        = 0x80010126L,
        /// <summary>The client who called IAccessControl::IsAccessPermitted was not the trustee provided to the method</summary>
        CO_E_TRUSTEEDOESNTMATCHCLIENT    = 0x80010127L,
        /// <summary>Unable to obtain the client's security blanket</summary>
        CO_E_FAILEDTOQUERYCLIENTBLANKET  = 0x80010128L,
        /// <summary>Unable to set a discretionary ACL into a security descriptor</summary>
        CO_E_FAILEDTOSETDACL             = 0x80010129L,
        /// <summary>The system function, AccessCheck, returned false</summary>
        CO_E_ACCESSCHECKFAILED           = 0x8001012AL,
        /// <summary>Either NetAccessDel or NetAccessAdd returned an error code.</summary>
        CO_E_NETACCESSAPIFAILED          = 0x8001012BL,
        /// <summary>One of the trustee strings provided by the user did not conform to the <Domain>\<Name> syntax and it was not the "*" string</summary>
        CO_E_WRONGTRUSTEENAMESYNTAX      = 0x8001012CL,
        /// <summary>One of the security identifiers provided by the user was invalid</summary>
        CO_E_INVALIDSID                  = 0x8001012DL,
        /// <summary>Unable to convert a wide character trustee string to a multibyte trustee string</summary>
        CO_E_CONVERSIONFAILED            = 0x8001012EL,
        /// <summary>Unable to find a security identifier that corresponds to a trustee string provided by the user</summary>
        CO_E_NOMATCHINGSIDFOUND          = 0x8001012FL,
        /// <summary>The system function, LookupAccountSID, failed</summary>
        CO_E_LOOKUPACCSIDFAILED          = 0x80010130L,
        /// <summary>Unable to find a trustee name that corresponds to a security identifier provided by the user</summary>
        CO_E_NOMATCHINGNAMEFOUND         = 0x80010131L,
        /// <summary>The system function, LookupAccountName, failed</summary>
        CO_E_LOOKUPACCNAMEFAILED         = 0x80010132L,
        /// <summary>Unable to set or reset a serialization handle</summary>
        CO_E_SETSERLHNDLFAILED           = 0x80010133L,
        /// <summary>Unable to obtain the Windows directory</summary>
        CO_E_FAILEDTOGETWINDIR           = 0x80010134L,
        /// <summary>Path too long</summary>
        CO_E_PATHTOOLONG                 = 0x80010135L,
        /// <summary>Unable to generate a uuid.</summary>
        CO_E_FAILEDTOGENUUID             = 0x80010136L,
        /// <summary>Unable to create file</summary>
        CO_E_FAILEDTOCREATEFILE          = 0x80010137L,
        /// <summary>Unable to close a serialization handle or a file handle.</summary>
        CO_E_FAILEDTOCLOSEHANDLE         = 0x80010138L,
        /// <summary>The number of ACEs in an ACL exceeds the system limit.</summary>
        CO_E_EXCEEDSYSACLLIMIT           = 0x80010139L,
        /// <summary>Not all the DENY_ACCESS ACEs are arranged in front of the GRANT_ACCESS ACEs in the stream.</summary>
        CO_E_ACESINWRONGORDER            = 0x8001013AL,
        /// <summary>The version of ACL format in the stream is not supported by this implementation of IAccessControl</summary>
        CO_E_INCOMPATIBLESTREAMVERSION   = 0x8001013BL,
        /// <summary>Unable to open the access token of the server process</summary>
        CO_E_FAILEDTOOPENPROCESSTOKEN    = 0x8001013CL,
        /// <summary>Unable to decode the ACL in the stream provided by the user</summary>
        CO_E_DECODEFAILED                = 0x8001013DL,
        /// <summary>The COM IAccessControl object is not initialized</summary>
        CO_E_ACNOTINITIALIZED            = 0x8001013FL,
        /// <summary>Call Cancellation is disabled</summary>
        CO_E_CANCEL_DISABLED             = 0x80010140L,
        /// <summary>An internal error occurred.</summary>
        RPC_E_UNEXPECTED                 = 0x8001FFFFL,
        /// <summary>The specified event is currently not being audited.</summary>
        ERROR_AUDITING_DISABLED          = 0xC0090001L,
        /// <summary>The SID filtering operation removed all SIDs.</summary>
        ERROR_ALL_SIDS_FILTERED          = 0xC0090002L,
        /// <summary>Business rule scripts are disabled for the calling application.</summary>
        ERROR_BIZRULES_NOT_ENABLED       = 0xC0090003L,
        /// <summary>Bad UID.</summary>
        NTE_BAD_UID                      = 0x80090001L,
        /// <summary>Bad Hash.</summary>
        NTE_BAD_HASH                     = 0x80090002L,
        /// <summary>Bad Key.</summary>
        NTE_BAD_KEY                      = 0x80090003L,
        /// <summary>Bad Length.</summary>
        NTE_BAD_LEN                      = 0x80090004L,
        /// <summary>Bad Data.</summary>
        NTE_BAD_DATA                     = 0x80090005L,
        /// <summary>Invalid Signature.</summary>
        NTE_BAD_SIGNATURE                = 0x80090006L,
        /// <summary>Bad Version of provider.</summary>
        NTE_BAD_VER                      = 0x80090007L,
        /// <summary>Invalid algorithm specified.</summary>
        NTE_BAD_ALGID                    = 0x80090008L,
        /// <summary>Invalid flags specified.</summary>
        NTE_BAD_FLAGS                    = 0x80090009L,
        /// <summary>Invalid type specified.</summary>
        NTE_BAD_TYPE                     = 0x8009000AL,
        /// <summary>Key not valid for use in specified state.</summary>
        NTE_BAD_KEY_STATE                = 0x8009000BL,
        /// <summary>Hash not valid for use in specified state.</summary>
        NTE_BAD_HASH_STATE               = 0x8009000CL,
        /// <summary>Key does not exist.</summary>
        NTE_NO_KEY                       = 0x8009000DL,
        /// <summary>Insufficient memory available for the operation.</summary>
        NTE_NO_MEMORY                    = 0x8009000EL,
        /// <summary>Object already exists.</summary>
        NTE_EXISTS                       = 0x8009000FL,
        /// <summary>Access denied.</summary>
        NTE_PERM                         = 0x80090010L,
        /// <summary>Object was not found.</summary>
        NTE_NOT_FOUND                    = 0x80090011L,
        /// <summary>Data already encrypted.</summary>
        NTE_DOUBLE_ENCRYPT               = 0x80090012L,
        /// <summary>Invalid provider specified.</summary>
        NTE_BAD_PROVIDER                 = 0x80090013L,
        /// <summary>Invalid provider type specified.</summary>
        NTE_BAD_PROV_TYPE                = 0x80090014L,
        /// <summary>Provider's public key is invalid.</summary>
        NTE_BAD_PUBLIC_KEY               = 0x80090015L,
        /// <summary>Keyset does not exist</summary>
        NTE_BAD_KEYSET                   = 0x80090016L,
        /// <summary>Provider type not defined.</summary>
        NTE_PROV_TYPE_NOT_DEF            = 0x80090017L,
        /// <summary>Provider type as registered is invalid.</summary>
        NTE_PROV_TYPE_ENTRY_BAD          = 0x80090018L,
        /// <summary>The keyset is not defined.</summary>
        NTE_KEYSET_NOT_DEF               = 0x80090019L,
        /// <summary>Keyset as registered is invalid.</summary>
        NTE_KEYSET_ENTRY_BAD             = 0x8009001AL,
        /// <summary>Provider type does not match registered value.</summary>
        NTE_PROV_TYPE_NO_MATCH           = 0x8009001BL,
        /// <summary>The digital signature file is corrupt.</summary>
        NTE_SIGNATURE_FILE_BAD           = 0x8009001CL,
        /// <summary>Provider DLL failed to initialize correctly.</summary>
        NTE_PROVIDER_DLL_FAIL            = 0x8009001DL,
        /// <summary>Provider DLL could not be found.</summary>
        NTE_PROV_DLL_NOT_FOUND           = 0x8009001EL,
        /// <summary>The Keyset parameter is invalid.</summary>
        NTE_BAD_KEYSET_PARAM             = 0x8009001FL,
        /// <summary>An internal error occurred.</summary>
        NTE_FAIL                         = 0x80090020L,
        /// <summary>A base error occurred.</summary>
        NTE_SYS_ERR                      = 0x80090021L,
        /// <summary>Provider could not perform the action since the context was acquired as silent.</summary>
        NTE_SILENT_CONTEXT               = 0x80090022L,
        /// <summary>The security token does not have storage space available for an additional container.</summary>
        NTE_TOKEN_KEYSET_STORAGE_FULL    = 0x80090023L,
        /// <summary>The profile for the user is a temporary profile.</summary>
        NTE_TEMPORARY_PROFILE            = 0x80090024L,
        /// <summary>The key parameters could not be set because the CSP uses fixed parameters.</summary>
        NTE_FIXEDPARAMETER               = 0x80090025L,
        /// <summary>The supplied handle is invalid.</summary>
        NTE_INVALID_HANDLE               = 0x80090026L,
        /// <summary>The parameter is incorrect.</summary>
        NTE_INVALID_PARAMETER            = 0x80090027L,
        /// <summary>The buffer supplied to a function was too small.</summary>
        NTE_BUFFER_TOO_SMALL             = 0x80090028L,
        /// <summary>The requested operation is not supported.</summary>
        NTE_NOT_SUPPORTED                = 0x80090029L,
        /// <summary>No more data is available.</summary>
        NTE_NO_MORE_ITEMS                = 0x8009002AL,
        /// <summary>The supplied buffers overlap incorrectly.</summary>
        NTE_BUFFERS_OVERLAP              = 0x8009002BL,
        /// <summary>The specified data could not be decrypted.</summary>
        NTE_DECRYPTION_FAILURE           = 0x8009002CL,
        /// <summary>An internal consistency check failed.</summary>
        NTE_INTERNAL_ERROR               = 0x8009002DL,
        /// <summary>This operation requires input from the user.</summary>
        NTE_UI_REQUIRED                  = 0x8009002EL,
        /// <summary>The cryptographic provider does not support HMAC.</summary>
        NTE_HMAC_NOT_SUPPORTED           = 0x8009002FL,
        /// <summary>The device that is required by this cryptographic provider is not ready for use.</summary>
        NTE_DEVICE_NOT_READY             = 0x80090030L,
        /// <summary>The dictionary attack mitigation is triggered and the provided authorization was ignored by the provider.</summary>
        NTE_AUTHENTICATION_IGNORED       = 0x80090031L,
        /// <summary>The validation of the provided data failed the integrity or signature validation.</summary>
        NTE_VALIDATION_FAILED            = 0x80090032L,
        /// <summary>Incorrect password.</summary>
        NTE_INCORRECT_PASSWORD           = 0x80090033L,
        /// <summary>Encryption failed.</summary>
        NTE_ENCRYPTION_FAILURE           = 0x80090034L,
        /// <summary>The device that is required by this cryptographic provider is not found on this platform.</summary>
        NTE_DEVICE_NOT_FOUND             = 0x80090035L,
        /// <summary>The action was cancelled by the user.</summary>
        NTE_USER_CANCELLED               = 0x80090036L,
        /// <summary>The password is no longer valid and must be changed.</summary>
        NTE_PASSWORD_CHANGE_REQUIRED     = 0x80090037L,
        /// <summary>The operation cannot be completed from Terminal Server client sessions.</summary>
        NTE_NOT_ACTIVE_CONSOLE           = 0x80090038L,
        /// <summary>Not enough memory is available to complete this request</summary>
        SEC_E_INSUFFICIENT_MEMORY        = 0x80090300L,
        /// <summary>The handle specified is invalid</summary>
        SEC_E_INVALID_HANDLE             = 0x80090301L,
        /// <summary>The function requested is not supported</summary>
        SEC_E_UNSUPPORTED_FUNCTION       = 0x80090302L,
        /// <summary>The specified target is unknown or unreachable</summary>
        SEC_E_TARGET_UNKNOWN             = 0x80090303L,
        /// <summary>The Local Security Authority cannot be contacted</summary>
        SEC_E_INTERNAL_ERROR             = 0x80090304L,
        /// <summary>The requested security package does not exist</summary>
        SEC_E_SECPKG_NOT_FOUND           = 0x80090305L,
        /// <summary>The caller is not the owner of the desired credentials</summary>
        SEC_E_NOT_OWNER                  = 0x80090306L,
        /// <summary>The security package failed to initialize, and cannot be installed</summary>
        SEC_E_CANNOT_INSTALL             = 0x80090307L,
        /// <summary>The token supplied to the function is invalid</summary>
        SEC_E_INVALID_TOKEN              = 0x80090308L,
        /// <summary>The security package is not able to marshall the logon buffer, so the logon attempt has failed</summary>
        SEC_E_CANNOT_PACK                = 0x80090309L,
        /// <summary>The per-message Quality of Protection is not supported by the security package</summary>
        SEC_E_QOP_NOT_SUPPORTED          = 0x8009030AL,
        /// <summary>The security context does not allow impersonation of the client</summary>
        SEC_E_NO_IMPERSONATION           = 0x8009030BL,
        /// <summary>The logon attempt failed</summary>
        SEC_E_LOGON_DENIED               = 0x8009030CL,
        /// <summary>The credentials supplied to the package were not recognized</summary>
        SEC_E_UNKNOWN_CREDENTIALS        = 0x8009030DL,
        /// <summary>No credentials are available in the security package</summary>
        SEC_E_NO_CREDENTIALS             = 0x8009030EL,
        /// <summary>The message or signature supplied for verification has been altered</summary>
        SEC_E_MESSAGE_ALTERED            = 0x8009030FL,
        /// <summary>The message supplied for verification is out of sequence</summary>
        SEC_E_OUT_OF_SEQUENCE            = 0x80090310L,
        /// <summary>No authority could be contacted for authentication.</summary>
        SEC_E_NO_AUTHENTICATING_AUTHORITY = 0x80090311L,
        /// <summary>The function completed successfully, but must be called again to complete the context</summary>
        SEC_I_CONTINUE_NEEDED            = 0x00090312L,
        /// <summary>The function completed successfully, but CompleteToken must be called</summary>
        SEC_I_COMPLETE_NEEDED            = 0x00090313L,
        /// <summary>The function completed successfully, but both CompleteToken and this function must be called to complete the context</summary>
        SEC_I_COMPLETE_AND_CONTINUE      = 0x00090314L,
        /// <summary>The logon was completed, but no network authority was available. The logon was made using locally known information</summary>
        SEC_I_LOCAL_LOGON                = 0x00090315L,
        /// <summary>The requested security package does not exist</summary>
        SEC_E_BAD_PKGID                  = 0x80090316L,
        /// <summary>The context has expired and can no longer be used.</summary>
        SEC_E_CONTEXT_EXPIRED            = 0x80090317L,
        /// <summary>The context has expired and can no longer be used.</summary>
        SEC_I_CONTEXT_EXPIRED            = 0x00090317L,
        /// <summary>The supplied message is incomplete. The signature was not verified.</summary>
        SEC_E_INCOMPLETE_MESSAGE         = 0x80090318L,
        /// <summary>The credentials supplied were not complete, and could not be verified. The context could not be initialized.</summary>
        SEC_E_INCOMPLETE_CREDENTIALS     = 0x80090320L,
        /// <summary>The buffers supplied to a function was too small.</summary>
        SEC_E_BUFFER_TOO_SMALL           = 0x80090321L,
        /// <summary>The credentials supplied were not complete, and could not be verified. Additional information can be returned from the context.</summary>
        SEC_I_INCOMPLETE_CREDENTIALS     = 0x00090320L,
        /// <summary>The context data must be renegotiated with the peer.</summary>
        SEC_I_RENEGOTIATE                = 0x00090321L,
        /// <summary>The target principal name is incorrect.</summary>
        SEC_E_WRONG_PRINCIPAL            = 0x80090322L,
        /// <summary>There is no LSA mode context associated with this context.</summary>
        SEC_I_NO_LSA_CONTEXT             = 0x00090323L,
        /// <summary>The clocks on the client and server machines are skewed.</summary>
        SEC_E_TIME_SKEW                  = 0x80090324L,
        /// <summary>The certificate chain was issued by an authority that is not trusted.</summary>
        SEC_E_UNTRUSTED_ROOT             = 0x80090325L,
        /// <summary>The message received was unexpected or badly formatted.</summary>
        SEC_E_ILLEGAL_MESSAGE            = 0x80090326L,
        /// <summary>An unknown error occurred while processing the certificate.</summary>
        SEC_E_CERT_UNKNOWN               = 0x80090327L,
        /// <summary>The received certificate has expired.</summary>
        SEC_E_CERT_EXPIRED               = 0x80090328L,
        /// <summary>The specified data could not be encrypted.</summary>
        SEC_E_ENCRYPT_FAILURE            = 0x80090329L,
        /// <summary>The specified data could not be decrypted.</summary>
        SEC_E_DECRYPT_FAILURE            = 0x80090330L,
        /// <summary>The client and server cannot communicate, because they do not possess a common algorithm.</summary>
        SEC_E_ALGORITHM_MISMATCH         = 0x80090331L,
        /// <summary>The security context could not be established due to a failure in the requested quality of service (e.g. mutual authentication or delegation).</summary>
        SEC_E_SECURITY_QOS_FAILED        = 0x80090332L,
        /// <summary>A security context was deleted before the context was completed. This is considered a logon failure.</summary>
        SEC_E_UNFINISHED_CONTEXT_DELETED = 0x80090333L,
        /// <summary>The client is trying to negotiate a context and the server requires user-to-user but didn't send a TGT reply.</summary>
        SEC_E_NO_TGT_REPLY               = 0x80090334L,
        /// <summary>Unable to accomplish the requested task because the local machine does not have any IP addresses.</summary>
        SEC_E_NO_IP_ADDRESSES            = 0x80090335L,
        /// <summary>The supplied credential handle does not match the credential associated with the security context.</summary>
        SEC_E_WRONG_CREDENTIAL_HANDLE    = 0x80090336L,
        /// <summary>The crypto system or checksum function is invalid because a required function is unavailable.</summary>
        SEC_E_CRYPTO_SYSTEM_INVALID      = 0x80090337L,
        /// <summary>The number of maximum ticket referrals has been exceeded.</summary>
        SEC_E_MAX_REFERRALS_EXCEEDED     = 0x80090338L,
        /// <summary>The local machine must be a Kerberos KDC (domain controller) and it is not.</summary>
        SEC_E_MUST_BE_KDC                = 0x80090339L,
        /// <summary>The other end of the security negotiation is requires strong crypto but it is not supported on the local machine.</summary>
        SEC_E_STRONG_CRYPTO_NOT_SUPPORTED = 0x8009033AL,
        /// <summary>The KDC reply contained more than one principal name.</summary>
        SEC_E_TOO_MANY_PRINCIPALS        = 0x8009033BL,
        /// <summary>Expected to find PA data for a hint of what etype to use, but it was not found.</summary>
        SEC_E_NO_PA_DATA                 = 0x8009033CL,
        /// <summary>The client certificate does not contain a valid UPN, or does not match the client name in the logon request. Please contact your administrator.</summary>
        SEC_E_PKINIT_NAME_MISMATCH       = 0x8009033DL,
        /// <summary>Smartcard logon is required and was not used.</summary>
        SEC_E_SMARTCARD_LOGON_REQUIRED   = 0x8009033EL,
        /// <summary>A system shutdown is in progress.</summary>
        SEC_E_SHUTDOWN_IN_PROGRESS       = 0x8009033FL,
        /// <summary>An invalid request was sent to the KDC.</summary>
        SEC_E_KDC_INVALID_REQUEST        = 0x80090340L,
        /// <summary>The KDC was unable to generate a referral for the service requested.</summary>
        SEC_E_KDC_UNABLE_TO_REFER        = 0x80090341L,
        /// <summary>The encryption type requested is not supported by the KDC.</summary>
        SEC_E_KDC_UNKNOWN_ETYPE          = 0x80090342L,
        /// <summary>An unsupported preauthentication mechanism was presented to the Kerberos package.</summary>
        SEC_E_UNSUPPORTED_PREAUTH        = 0x80090343L,
        /// <summary>The requested operation cannot be completed. The computer must be trusted for delegation and the current user account must be configured to allow delegation.</summary>
        SEC_E_DELEGATION_REQUIRED        = 0x80090345L,
        /// <summary>Client's supplied SSPI channel bindings were incorrect.</summary>
        SEC_E_BAD_BINDINGS               = 0x80090346L,
        /// <summary>The received certificate was mapped to multiple accounts.</summary>
        SEC_E_MULTIPLE_ACCOUNTS          = 0x80090347L,
        /// <summary> SEC_E_NO_KERB_KEY</summary>
        SEC_E_NO_KERB_KEY                = 0x80090348L,
        /// <summary>The certificate is not valid for the requested usage.</summary>
        SEC_E_CERT_WRONG_USAGE           = 0x80090349L,
        /// <summary>The system cannot contact a domain controller to service the authentication request. Please try again later.</summary>
        SEC_E_DOWNGRADE_DETECTED         = 0x80090350L,
        /// <summary>The smartcard certificate used for authentication has been revoked. Please contact your system administrator. There may be additional information in the event log.</summary>
        SEC_E_SMARTCARD_CERT_REVOKED     = 0x80090351L,
        /// <summary>An untrusted certificate authority was detected while processing the smartcard certificate used for authentication. Please contact your system administrator.</summary>
        SEC_E_ISSUING_CA_UNTRUSTED       = 0x80090352L,
        /// <summary>The revocation status of the smartcard certificate used for authentication could not be determined. Please contact your system administrator.</summary>
        SEC_E_REVOCATION_OFFLINE_C       = 0x80090353L,
        /// <summary>The smartcard certificate used for authentication was not trusted. Please contact your system administrator.</summary>
        SEC_E_PKINIT_CLIENT_FAILURE      = 0x80090354L,
        /// <summary>The smartcard certificate used for authentication has expired. Please contact your system administrator.</summary>
        SEC_E_SMARTCARD_CERT_EXPIRED     = 0x80090355L,
        /// <summary>The Kerberos subsystem encountered an error. A service for user protocol request was made against a domain controller which does not support service for user.</summary>
        SEC_E_NO_S4U_PROT_SUPPORT        = 0x80090356L,
        /// <summary>An attempt was made by this server to make a Kerberos constrained delegation request for a target outside of the server's realm. This is not supported, and indicates a misconfiguration on this server's allowed to delegate to list. Please contact your administrator.</summary>
        SEC_E_CROSSREALM_DELEGATION_FAILURE = 0x80090357L,
        /// <summary>The revocation status of the domain controller certificate used for smartcard authentication could not be determined. There is additional information in the system event log. Please contact your system administrator.</summary>
        SEC_E_REVOCATION_OFFLINE_KDC     = 0x80090358L,
        /// <summary>An untrusted certificate authority was detected while processing the domain controller certificate used for authentication. There is additional information in the system event log. Please contact your system administrator.</summary>
        SEC_E_ISSUING_CA_UNTRUSTED_KDC   = 0x80090359L,
        /// <summary>The domain controller certificate used for smartcard logon has expired. Please contact your system administrator with the contents of your system event log.</summary>
        SEC_E_KDC_CERT_EXPIRED           = 0x8009035AL,
        /// <summary>The domain controller certificate used for smartcard logon has been revoked. Please contact your system administrator with the contents of your system event log.</summary>
        SEC_E_KDC_CERT_REVOKED           = 0x8009035BL,
        /// <summary>A signature operation must be performed before the user can authenticate.</summary>
        SEC_I_SIGNATURE_NEEDED           = 0x0009035CL,
        /// <summary>One or more of the parameters passed to the function was invalid.</summary>
        SEC_E_INVALID_PARAMETER          = 0x8009035DL,
        /// <summary>Client policy does not allow credential delegation to target server.</summary>
        SEC_E_DELEGATION_POLICY          = 0x8009035EL,
        /// <summary>Client policy does not allow credential delegation to target server with NLTM only authentication.</summary>
        SEC_E_POLICY_NLTM_ONLY           = 0x8009035FL,
        /// <summary>The recipient rejected the renegotiation request.</summary>
        SEC_I_NO_RENEGOTIATION           = 0x00090360L,
        /// <summary>The required security context does not exist.</summary>
        SEC_E_NO_CONTEXT                 = 0x80090361L,
        /// <summary>The PKU2U protocol encountered an error while attempting to utilize the associated certificates.</summary>
        SEC_E_PKU2U_CERT_FAILURE         = 0x80090362L,
        /// <summary>The identity of the server computer could not be verified.</summary>
        SEC_E_MUTUAL_AUTH_FAILED         = 0x80090363L,
        /// <summary>The returned buffer is only a fragment of the message.  More fragments need to be returned.</summary>
        SEC_I_MESSAGE_FRAGMENT           = 0x00090364L,
        /// <summary>Only https scheme is allowed.</summary>
        SEC_E_ONLY_HTTPS_ALLOWED         = 0x80090365L,
        /// <summary>The function completed successfully, but must be called again to complete the context.  Early start can be used.</summary>
        SEC_I_CONTINUE_NEEDED_MESSAGE_OK = 0x00090366L,
        /// <summary>No common application protocol exists between the client and the server. Application protocol negotiation failed.</summary>
        SEC_E_APPLICATION_PROTOCOL_MISMATCH = 0x80090367L,
        /// <summary>An asynchronous SSPI routine has been called and the work is pending completion.</summary>
        SEC_I_ASYNC_CALL_PENDING         = 0x00090368L,
        /// <summary>You can't sign in with a user ID in this format. Try using your email address instead.</summary>
        SEC_E_INVALID_UPN_NAME           = 0x80090369L,
        /// <summary>An error occurred while performing an operation on a cryptographic message.</summary>
        CRYPT_E_MSG_ERROR                = 0x80091001L,
        /// <summary>Unknown cryptographic algorithm.</summary>
        CRYPT_E_UNKNOWN_ALGO             = 0x80091002L,
        /// <summary>The object identifier is poorly formatted.</summary>
        CRYPT_E_OID_FORMAT               = 0x80091003L,
        /// <summary>Invalid cryptographic message type.</summary>
        CRYPT_E_INVALID_MSG_TYPE         = 0x80091004L,
        /// <summary>Unexpected cryptographic message encoding.</summary>
        CRYPT_E_UNEXPECTED_ENCODING      = 0x80091005L,
        /// <summary>The cryptographic message does not contain an expected authenticated attribute.</summary>
        CRYPT_E_AUTH_ATTR_MISSING        = 0x80091006L,
        /// <summary>The hash value is not correct.</summary>
        CRYPT_E_HASH_VALUE               = 0x80091007L,
        /// <summary>The index value is not valid.</summary>
        CRYPT_E_INVALID_INDEX            = 0x80091008L,
        /// <summary>The content of the cryptographic message has already been decrypted.</summary>
        CRYPT_E_ALREADY_DECRYPTED        = 0x80091009L,
        /// <summary>The content of the cryptographic message has not been decrypted yet.</summary>
        CRYPT_E_NOT_DECRYPTED            = 0x8009100AL,
        /// <summary>The enveloped-data message does not contain the specified recipient.</summary>
        CRYPT_E_RECIPIENT_NOT_FOUND      = 0x8009100BL,
        /// <summary>Invalid control type.</summary>
        CRYPT_E_CONTROL_TYPE             = 0x8009100CL,
        /// <summary>Invalid issuer and/or serial number.</summary>
        CRYPT_E_ISSUER_SERIALNUMBER      = 0x8009100DL,
        /// <summary>Cannot find the original signer.</summary>
        CRYPT_E_SIGNER_NOT_FOUND         = 0x8009100EL,
        /// <summary>The cryptographic message does not contain all of the requested attributes.</summary>
        CRYPT_E_ATTRIBUTES_MISSING       = 0x8009100FL,
        /// <summary>The streamed cryptographic message is not ready to return data.</summary>
        CRYPT_E_STREAM_MSG_NOT_READY     = 0x80091010L,
        /// <summary>The streamed cryptographic message requires more data to complete the decode operation.</summary>
        CRYPT_E_STREAM_INSUFFICIENT_DATA = 0x80091011L,
        /// <summary>The protected data needs to be re-protected.</summary>
        CRYPT_I_NEW_PROTECTION_REQUIRED  = 0x00091012L,
        /// <summary>The length specified for the output data was insufficient.</summary>
        CRYPT_E_BAD_LEN                  = 0x80092001L,
        /// <summary>An error occurred during encode or decode operation.</summary>
        CRYPT_E_BAD_ENCODE               = 0x80092002L,
        /// <summary>An error occurred while reading or writing to a file.</summary>
        CRYPT_E_FILE_ERROR               = 0x80092003L,
        /// <summary>Cannot find object or property.</summary>
        CRYPT_E_NOT_FOUND                = 0x80092004L,
        /// <summary>The object or property already exists.</summary>
        CRYPT_E_EXISTS                   = 0x80092005L,
        /// <summary>No provider was specified for the store or object.</summary>
        CRYPT_E_NO_PROVIDER              = 0x80092006L,
        /// <summary>The specified certificate is self signed.</summary>
        CRYPT_E_SELF_SIGNED              = 0x80092007L,
        /// <summary>The previous certificate or CRL context was deleted.</summary>
        CRYPT_E_DELETED_PREV             = 0x80092008L,
        /// <summary>Cannot find the requested object.</summary>
        CRYPT_E_NO_MATCH                 = 0x80092009L,
        /// <summary>The certificate does not have a property that references a private key.</summary>
        CRYPT_E_UNEXPECTED_MSG_TYPE      = 0x8009200AL,
        /// <summary>Cannot find the certificate and private key for decryption.</summary>
        CRYPT_E_NO_KEY_PROPERTY          = 0x8009200BL,
        /// <summary>Cannot find the certificate and private key to use for decryption.</summary>
        CRYPT_E_NO_DECRYPT_CERT          = 0x8009200CL,
        /// <summary>Not a cryptographic message or the cryptographic message is not formatted correctly.</summary>
        CRYPT_E_BAD_MSG                  = 0x8009200DL,
        /// <summary>The signed cryptographic message does not have a signer for the specified signer index.</summary>
        CRYPT_E_NO_SIGNER                = 0x8009200EL,
        /// <summary>Final closure is pending until additional frees or closes.</summary>
        CRYPT_E_PENDING_CLOSE            = 0x8009200FL,
        /// <summary>The certificate is revoked.</summary>
        CRYPT_E_REVOKED                  = 0x80092010L,
        /// <summary>No Dll or exported function was found to verify revocation.</summary>
        CRYPT_E_NO_REVOCATION_DLL        = 0x80092011L,
        /// <summary>The revocation function was unable to check revocation for the certificate.</summary>
        CRYPT_E_NO_REVOCATION_CHECK      = 0x80092012L,
        /// <summary>The revocation function was unable to check revocation because the revocation server was offline.</summary>
        CRYPT_E_REVOCATION_OFFLINE       = 0x80092013L,
        /// <summary>The certificate is not in the revocation server's database.</summary>
        CRYPT_E_NOT_IN_REVOCATION_DATABASE = 0x80092014L,
        /// <summary>The string contains a non-numeric character.</summary>
        CRYPT_E_INVALID_NUMERIC_STRING   = 0x80092020L,
        /// <summary>The string contains a non-printable character.</summary>
        CRYPT_E_INVALID_PRINTABLE_STRING = 0x80092021L,
        /// <summary>The string contains a character not in the 7 bit ASCII character set.</summary>
        CRYPT_E_INVALID_IA5_STRING       = 0x80092022L,
        /// <summary>The string contains an invalid X500 name attribute key, oid, value or delimiter.</summary>
        CRYPT_E_INVALID_X500_STRING      = 0x80092023L,
        /// <summary>The dwValueType for the CERT_NAME_VALUE is not one of the character strings. Most likely it is either a CERT_RDN_ENCODED_BLOB or CERT_RDN_OCTET_STRING.</summary>
        CRYPT_E_NOT_CHAR_STRING          = 0x80092024L,
        /// <summary>The Put operation cannot continue. The file needs to be resized. However, there is already a signature present. A complete signing operation must be done.</summary>
        CRYPT_E_FILERESIZED              = 0x80092025L,
        /// <summary>The cryptographic operation failed due to a local security option setting.</summary>
        CRYPT_E_SECURITY_SETTINGS        = 0x80092026L,
        /// <summary>No DLL or exported function was found to verify subject usage.</summary>
        CRYPT_E_NO_VERIFY_USAGE_DLL      = 0x80092027L,
        /// <summary>The called function was unable to do a usage check on the subject.</summary>
        CRYPT_E_NO_VERIFY_USAGE_CHECK    = 0x80092028L,
        /// <summary>Since the server was offline, the called function was unable to complete the usage check.</summary>
        CRYPT_E_VERIFY_USAGE_OFFLINE     = 0x80092029L,
        /// <summary>The subject was not found in a Certificate Trust List (CTL).</summary>
        CRYPT_E_NOT_IN_CTL               = 0x8009202AL,
        /// <summary>None of the signers of the cryptographic message or certificate trust list is trusted.</summary>
        CRYPT_E_NO_TRUSTED_SIGNER        = 0x8009202BL,
        /// <summary>The public key's algorithm parameters are missing.</summary>
        CRYPT_E_MISSING_PUBKEY_PARA      = 0x8009202CL,
        /// <summary>An object could not be located using the object locator infrastructure with the given name.</summary>
        CRYPT_E_OBJECT_LOCATOR_OBJECT_NOT_FOUND = 0x8009202DL,
        /// <summary>OSS Certificate encode/decode error code base See asn1code.h for a definition of the OSS runtime errors. The OSS error values are offset by CRYPT_E_OSS_ERROR.</summary>
        CRYPT_E_OSS_ERROR                = 0x80093000L,
        /// <summary>OSS ASN.1 Error: Output Buffer is too small.</summary>
        OSS_MORE_BUF                     = 0x80093001L,
        /// <summary>OSS ASN.1 Error: Signed integer is encoded as a unsigned integer.</summary>
        OSS_NEGATIVE_UINTEGER            = 0x80093002L,
        /// <summary>OSS ASN.1 Error: Unknown ASN.1 data type.</summary>
        OSS_PDU_RANGE                    = 0x80093003L,
        /// <summary>OSS ASN.1 Error: Output buffer is too small, the decoded data has been truncated.</summary>
        OSS_MORE_INPUT                   = 0x80093004L,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_DATA_ERROR                   = 0x80093005L,
        /// <summary>OSS ASN.1 Error: Invalid argument.</summary>
        OSS_BAD_ARG                      = 0x80093006L,
        /// <summary>OSS ASN.1 Error: Encode/Decode version mismatch.</summary>
        OSS_BAD_VERSION                  = 0x80093007L,
        /// <summary>OSS ASN.1 Error: Out of memory.</summary>
        OSS_OUT_MEMORY                   = 0x80093008L,
        /// <summary>OSS ASN.1 Error: Encode/Decode Error.</summary>
        OSS_PDU_MISMATCH                 = 0x80093009L,
        /// <summary>OSS ASN.1 Error: Internal Error.</summary>
        OSS_LIMITED                      = 0x8009300AL,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_BAD_PTR                      = 0x8009300BL,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_BAD_TIME                     = 0x8009300CL,
        /// <summary>OSS ASN.1 Error: Unsupported BER indefinite-length encoding.</summary>
        OSS_INDEFINITE_NOT_SUPPORTED     = 0x8009300DL,
        /// <summary>OSS ASN.1 Error: Access violation.</summary>
        OSS_MEM_ERROR                    = 0x8009300EL,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_BAD_TABLE                    = 0x8009300FL,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_TOO_LONG                     = 0x80093010L,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_CONSTRAINT_VIOLATED          = 0x80093011L,
        /// <summary>OSS ASN.1 Error: Internal Error.</summary>
        OSS_FATAL_ERROR                  = 0x80093012L,
        /// <summary>OSS ASN.1 Error: Multi-threading conflict.</summary>
        OSS_ACCESS_SERIALIZATION_ERROR   = 0x80093013L,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_NULL_TBL                     = 0x80093014L,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_NULL_FCN                     = 0x80093015L,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_BAD_ENCRULES                 = 0x80093016L,
        /// <summary>OSS ASN.1 Error: Encode/Decode function not implemented.</summary>
        OSS_UNAVAIL_ENCRULES             = 0x80093017L,
        /// <summary>OSS ASN.1 Error: Trace file error.</summary>
        OSS_CANT_OPEN_TRACE_WINDOW       = 0x80093018L,
        /// <summary>OSS ASN.1 Error: Function not implemented.</summary>
        OSS_UNIMPLEMENTED                = 0x80093019L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_OID_DLL_NOT_LINKED           = 0x8009301AL,
        /// <summary>OSS ASN.1 Error: Trace file error.</summary>
        OSS_CANT_OPEN_TRACE_FILE         = 0x8009301BL,
        /// <summary>OSS ASN.1 Error: Trace file error.</summary>
        OSS_TRACE_FILE_ALREADY_OPEN      = 0x8009301CL,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_TABLE_MISMATCH               = 0x8009301DL,
        /// <summary>OSS ASN.1 Error: Invalid data.</summary>
        OSS_TYPE_NOT_SUPPORTED           = 0x8009301EL,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_REAL_DLL_NOT_LINKED          = 0x8009301FL,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_REAL_CODE_NOT_LINKED         = 0x80093020L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_OUT_OF_RANGE                 = 0x80093021L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_COPIER_DLL_NOT_LINKED        = 0x80093022L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_CONSTRAINT_DLL_NOT_LINKED    = 0x80093023L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_COMPARATOR_DLL_NOT_LINKED    = 0x80093024L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_COMPARATOR_CODE_NOT_LINKED   = 0x80093025L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_MEM_MGR_DLL_NOT_LINKED       = 0x80093026L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_PDV_DLL_NOT_LINKED           = 0x80093027L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_PDV_CODE_NOT_LINKED          = 0x80093028L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_API_DLL_NOT_LINKED           = 0x80093029L,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_BERDER_DLL_NOT_LINKED        = 0x8009302AL,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_PER_DLL_NOT_LINKED           = 0x8009302BL,
        /// <summary>OSS ASN.1 Error: Program link error.</summary>
        OSS_OPEN_TYPE_ERROR              = 0x8009302CL,
        /// <summary>OSS ASN.1 Error: System resource error.</summary>
        OSS_MUTEX_NOT_CREATED            = 0x8009302DL,
        /// <summary>OSS ASN.1 Error: Trace file error.</summary>
        OSS_CANT_CLOSE_TRACE_FILE        = 0x8009302EL,
        /// <summary>ASN1 Certificate encode/decode error code base. The ASN1 error values are offset by CRYPT_E_ASN1_ERROR.</summary>
        CRYPT_E_ASN1_ERROR               = 0x80093100L,
        /// <summary>ASN1 internal encode or decode error.</summary>
        CRYPT_E_ASN1_INTERNAL            = 0x80093101L,
        /// <summary>ASN1 unexpected end of data.</summary>
        CRYPT_E_ASN1_EOD                 = 0x80093102L,
        /// <summary>ASN1 corrupted data.</summary>
        CRYPT_E_ASN1_CORRUPT             = 0x80093103L,
        /// <summary>ASN1 value too large.</summary>
        CRYPT_E_ASN1_LARGE               = 0x80093104L,
        /// <summary>ASN1 constraint violated.</summary>
        CRYPT_E_ASN1_CONSTRAINT          = 0x80093105L,
        /// <summary>ASN1 out of memory.</summary>
        CRYPT_E_ASN1_MEMORY              = 0x80093106L,
        /// <summary>ASN1 buffer overflow.</summary>
        CRYPT_E_ASN1_OVERFLOW            = 0x80093107L,
        /// <summary>ASN1 function not supported for this PDU.</summary>
        CRYPT_E_ASN1_BADPDU              = 0x80093108L,
        /// <summary>ASN1 bad arguments to function call.</summary>
        CRYPT_E_ASN1_BADARGS             = 0x80093109L,
        /// <summary>ASN1 bad real value.</summary>
        CRYPT_E_ASN1_BADREAL             = 0x8009310AL,
        /// <summary>ASN1 bad tag value met.</summary>
        CRYPT_E_ASN1_BADTAG              = 0x8009310BL,
        /// <summary>ASN1 bad choice value.</summary>
        CRYPT_E_ASN1_CHOICE              = 0x8009310CL,
        /// <summary>ASN1 bad encoding rule.</summary>
        CRYPT_E_ASN1_RULE                = 0x8009310DL,
        /// <summary>ASN1 bad unicode (UTF8).</summary>
        CRYPT_E_ASN1_UTF8                = 0x8009310EL,
        /// <summary>ASN1 bad PDU type.</summary>
        CRYPT_E_ASN1_PDU_TYPE            = 0x80093133L,
        /// <summary>ASN1 not yet implemented.</summary>
        CRYPT_E_ASN1_NYI                 = 0x80093134L,
        /// <summary>ASN1 skipped unknown extension(s).</summary>
        CRYPT_E_ASN1_EXTENDED            = 0x80093201L,
        /// <summary>ASN1 end of data expected</summary>
        CRYPT_E_ASN1_NOEOD               = 0x80093202L,
        /// <summary>The request subject name is invalid or too long.</summary>
        CERTSRV_E_BAD_REQUESTSUBJECT     = 0x80094001L,
        /// <summary>The request does not exist.</summary>
        CERTSRV_E_NO_REQUEST             = 0x80094002L,
        /// <summary>The request's current status does not allow this operation.</summary>
        CERTSRV_E_BAD_REQUESTSTATUS      = 0x80094003L,
        /// <summary>The requested property value is empty.</summary>
        CERTSRV_E_PROPERTY_EMPTY         = 0x80094004L,
        /// <summary>The certification authority's certificate contains invalid data.</summary>
        CERTSRV_E_INVALID_CA_CERTIFICATE = 0x80094005L,
        /// <summary>Certificate service has been suspended for a database restore operation.</summary>
        CERTSRV_E_SERVER_SUSPENDED       = 0x80094006L,
        /// <summary>The certificate contains an encoded length that is potentially incompatible with older enrollment software.</summary>
        CERTSRV_E_ENCODING_LENGTH        = 0x80094007L,
        /// <summary>The operation is denied. The user has multiple roles assigned and the certification authority is configured to enforce role separation.</summary>
        CERTSRV_E_ROLECONFLICT           = 0x80094008L,
        /// <summary>The operation is denied. It can only be performed by a certificate manager that is allowed to manage certificates for the current requester.</summary>
        CERTSRV_E_RESTRICTEDOFFICER      = 0x80094009L,
        /// <summary>Cannot archive private key. The certification authority is not configured for key archival.</summary>
        CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED = 0x8009400AL,
        /// <summary>Cannot archive private key. The certification authority could not verify one or more key recovery certificates.</summary>
        CERTSRV_E_NO_VALID_KRA           = 0x8009400BL,
        /// <summary>The request is incorrectly formatted. The encrypted private key must be in an unauthenticated attribute in an outermost signature.</summary>
        CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL = 0x8009400CL,
        /// <summary>At least one security principal must have the permission to manage this CA.</summary>
        CERTSRV_E_NO_CAADMIN_DEFINED     = 0x8009400DL,
        /// <summary>The request contains an invalid renewal certificate attribute.</summary>
        CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE = 0x8009400EL,
        /// <summary>An attempt was made to open a Certification Authority database session, but there are already too many active sessions. The server may need to be configured to allow additional sessions.</summary>
        CERTSRV_E_NO_DB_SESSIONS         = 0x8009400FL,
        /// <summary>A memory reference caused a data alignment fault.</summary>
        CERTSRV_E_ALIGNMENT_FAULT        = 0x80094010L,
        /// <summary>The permissions on this certification authority do not allow the current user to enroll for certificates.</summary>
        CERTSRV_E_ENROLL_DENIED          = 0x80094011L,
        /// <summary>The permissions on the certificate template do not allow the current user to enroll for this type of certificate.</summary>
        CERTSRV_E_TEMPLATE_DENIED        = 0x80094012L,
        /// <summary>The contacted domain controller cannot support signed LDAP traffic. Update the domain controller or configure Certificate Services to use SSL for Active Directory access.</summary>
        CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE = 0x80094013L,
        /// <summary>The request was denied by a certificate manager or CA administrator.</summary>
        CERTSRV_E_ADMIN_DENIED_REQUEST   = 0x80094014L,
        /// <summary>An enrollment policy server cannot be located.</summary>
        CERTSRV_E_NO_POLICY_SERVER       = 0x80094015L,
        /// <summary>A signature algorithm or public key length does not meet the system's minimum required strength.</summary>
        CERTSRV_E_WEAK_SIGNATURE_OR_KEY  = 0x80094016L,
        /// <summary>Failed to create an attested key.  This computer or the cryptographic provider may not meet the hardware requirements to support key attestation.</summary>
        CERTSRV_E_KEY_ATTESTATION_NOT_SUPPORTED = 0x80094017L,
        /// <summary>No encryption certificate was specified.</summary>
        CERTSRV_E_ENCRYPTION_CERT_REQUIRED = 0x80094018L,
        /// <summary>The requested certificate template is not supported by this CA.</summary>
        CERTSRV_E_UNSUPPORTED_CERT_TYPE  = 0x80094800L,
        /// <summary>The request contains no certificate template information.</summary>
        CERTSRV_E_NO_CERT_TYPE           = 0x80094801L,
        /// <summary>The request contains conflicting template information.</summary>
        CERTSRV_E_TEMPLATE_CONFLICT      = 0x80094802L,
        /// <summary>The request is missing a required Subject Alternate name extension.</summary>
        CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED = 0x80094803L,
        /// <summary>The request is missing a required private key for archival by the server.</summary>
        CERTSRV_E_ARCHIVED_KEY_REQUIRED  = 0x80094804L,
        /// <summary>The request is missing a required SMIME capabilities extension.</summary>
        CERTSRV_E_SMIME_REQUIRED         = 0x80094805L,
        /// <summary>The request was made on behalf of a subject other than the caller. The certificate template must be configured to require at least one signature to authorize the request.</summary>
        CERTSRV_E_BAD_RENEWAL_SUBJECT    = 0x80094806L,
        /// <summary>The request template version is newer than the supported template version.</summary>
        CERTSRV_E_BAD_TEMPLATE_VERSION   = 0x80094807L,
        /// <summary>The template is missing a required signature policy attribute.</summary>
        CERTSRV_E_TEMPLATE_POLICY_REQUIRED = 0x80094808L,
        /// <summary>The request is missing required signature policy information.</summary>
        CERTSRV_E_SIGNATURE_POLICY_REQUIRED = 0x80094809L,
        /// <summary>The request is missing one or more required signatures.</summary>
        CERTSRV_E_SIGNATURE_COUNT        = 0x8009480AL,
        /// <summary>One or more signatures did not include the required application or issuance policies. The request is missing one or more required valid signatures.</summary>
        CERTSRV_E_SIGNATURE_REJECTED     = 0x8009480BL,
        /// <summary>The request is missing one or more required signature issuance policies.</summary>
        CERTSRV_E_ISSUANCE_POLICY_REQUIRED = 0x8009480CL,
        /// <summary>The UPN is unavailable and cannot be added to the Subject Alternate name.</summary>
        CERTSRV_E_SUBJECT_UPN_REQUIRED   = 0x8009480DL,
        /// <summary>The Active Directory GUID is unavailable and cannot be added to the Subject Alternate name.</summary>
        CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED = 0x8009480EL,
        /// <summary>The DNS name is unavailable and cannot be added to the Subject Alternate name.</summary>
        CERTSRV_E_SUBJECT_DNS_REQUIRED   = 0x8009480FL,
        /// <summary>The request includes a private key for archival by the server, but key archival is not enabled for the specified certificate template.</summary>
        CERTSRV_E_ARCHIVED_KEY_UNEXPECTED = 0x80094810L,
        /// <summary>The public key does not meet the minimum size required by the specified certificate template.</summary>
        CERTSRV_E_KEY_LENGTH             = 0x80094811L,
        /// <summary>The EMail name is unavailable and cannot be added to the Subject or Subject Alternate name.</summary>
        CERTSRV_E_SUBJECT_EMAIL_REQUIRED = 0x80094812L,
        /// <summary>One or more certificate templates to be enabled on this certification authority could not be found.</summary>
        CERTSRV_E_UNKNOWN_CERT_TYPE      = 0x80094813L,
        /// <summary>The certificate template renewal period is longer than the certificate validity period. The template should be reconfigured or the CA certificate renewed.</summary>
        CERTSRV_E_CERT_TYPE_OVERLAP      = 0x80094814L,
        /// <summary>The certificate template requires too many RA signatures. Only one RA signature is allowed.</summary>
        CERTSRV_E_TOO_MANY_SIGNATURES    = 0x80094815L,
        /// <summary>The certificate template requires renewal with the same public key, but the request uses a different public key.</summary>
        CERTSRV_E_RENEWAL_BAD_PUBLIC_KEY = 0x80094816L,
        /// <summary>The certification authority cannot interpret or verify the endorsement key information supplied in the request, or the information is inconsistent.</summary>
        CERTSRV_E_INVALID_EK             = 0x80094817L,
        /// <summary>The certification authority cannot validate the Attestation Identity Key Id Binding.</summary>
        CERTSRV_E_INVALID_IDBINDING      = 0x80094818L,
        /// <summary>The certification authority cannot validate the private key attestation data.</summary>
        CERTSRV_E_INVALID_ATTESTATION    = 0x80094819L,
        /// <summary>The request does not support private key attestation as defined in the certificate template.</summary>
        CERTSRV_E_KEY_ATTESTATION        = 0x8009481AL,
        /// <summary>The request public key is not consistent with the private key attestation data.</summary>
        CERTSRV_E_CORRUPT_KEY_ATTESTATION = 0x8009481BL,
        /// <summary>The private key attestation challenge cannot be validated because the encryption certificate has expired, or the certificate or key is unavailable.</summary>
        CERTSRV_E_EXPIRED_CHALLENGE      = 0x8009481CL,
        /// <summary>The attestation response could not be validated. It is either unexpected or incorrect.</summary>
        CERTSRV_E_INVALID_RESPONSE       = 0x8009481DL,
        /// <summary>A valid Request ID was not detected in the request attributes, or an invalid one was submitted.</summary>
        CERTSRV_E_INVALID_REQUESTID      = 0x8009481EL,
        /// <summary>The key is not exportable.</summary>
        XENROLL_E_KEY_NOT_EXPORTABLE     = 0x80095000L,
        /// <summary>You cannot add the root CA certificate into your local store.</summary>
        XENROLL_E_CANNOT_ADD_ROOT_CERT   = 0x80095001L,
        /// <summary>The key archival hash attribute was not found in the response.</summary>
        XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND = 0x80095002L,
        /// <summary>An unexpected key archival hash attribute was found in the response.</summary>
        XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH = 0x80095003L,
        /// <summary>There is a key archival hash mismatch between the request and the response.</summary>
        XENROLL_E_RESPONSE_KA_HASH_MISMATCH = 0x80095004L,
        /// <summary>Signing certificate cannot include SMIME extension.</summary>
        XENROLL_E_KEYSPEC_SMIME_MISMATCH = 0x80095005L,
        /// <summary>A system-level error occurred while verifying trust.</summary>
        TRUST_E_SYSTEM_ERROR             = 0x80096001L,
        /// <summary>The certificate for the signer of the message is invalid or not found.</summary>
        TRUST_E_NO_SIGNER_CERT           = 0x80096002L,
        /// <summary>One of the counter signatures was invalid.</summary>
        TRUST_E_COUNTER_SIGNER           = 0x80096003L,
        /// <summary>The signature of the certificate cannot be verified.</summary>
        TRUST_E_CERT_SIGNATURE           = 0x80096004L,
        /// <summary>The timestamp signature and/or certificate could not be verified or is malformed.</summary>
        TRUST_E_TIME_STAMP               = 0x80096005L,
        /// <summary>The digital signature of the object did not verify.</summary>
        TRUST_E_BAD_DIGEST               = 0x80096010L,
        /// <summary>The digital signature of the object is malformed. For technical detail, see security bulletin MS13-098.</summary>
        TRUST_E_MALFORMED_SIGNATURE      = 0x80096011L,
        /// <summary>A certificate's basic constraint extension has not been observed.</summary>
        TRUST_E_BASIC_CONSTRAINTS        = 0x80096019L,
        /// <summary>The certificate does not meet or contain the Authenticode(tm) financial extensions.</summary>
        TRUST_E_FINANCIAL_CRITERIA       = 0x8009601EL,
        /// <summary>Tried to reference a part of the file outside the proper range.</summary>
        MSSIPOTF_E_OUTOFMEMRANGE         = 0x80097001L,
        /// <summary>Could not retrieve an object from the file.</summary>
        MSSIPOTF_E_CANTGETOBJECT         = 0x80097002L,
        /// <summary>Could not find the head table in the file.</summary>
        MSSIPOTF_E_NOHEADTABLE           = 0x80097003L,
        /// <summary>The magic number in the head table is incorrect.</summary>
        MSSIPOTF_E_BAD_MAGICNUMBER       = 0x80097004L,
        /// <summary>The offset table has incorrect values.</summary>
        MSSIPOTF_E_BAD_OFFSET_TABLE      = 0x80097005L,
        /// <summary>Duplicate table tags or tags out of alphabetical order.</summary>
        MSSIPOTF_E_TABLE_TAGORDER        = 0x80097006L,
        /// <summary>A table does not start on a long word boundary.</summary>
        MSSIPOTF_E_TABLE_LONGWORD        = 0x80097007L,
        /// <summary>First table does not appear after header information.</summary>
        MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT = 0x80097008L,
        /// <summary>Two or more tables overlap.</summary>
        MSSIPOTF_E_TABLES_OVERLAP        = 0x80097009L,
        /// <summary>Too many pad bytes between tables or pad bytes are not 0.</summary>
        MSSIPOTF_E_TABLE_PADBYTES        = 0x8009700AL,
        /// <summary>File is too small to contain the last table.</summary>
        MSSIPOTF_E_FILETOOSMALL          = 0x8009700BL,
        /// <summary>A table checksum is incorrect.</summary>
        MSSIPOTF_E_TABLE_CHECKSUM        = 0x8009700CL,
        /// <summary>The file checksum is incorrect.</summary>
        MSSIPOTF_E_FILE_CHECKSUM         = 0x8009700DL,
        /// <summary>The signature does not have the correct attributes for the policy.</summary>
        MSSIPOTF_E_FAILED_POLICY         = 0x80097010L,
        /// <summary>The file did not pass the hints check.</summary>
        MSSIPOTF_E_FAILED_HINTS_CHECK    = 0x80097011L,
        /// <summary>The file is not an OpenType file.</summary>
        MSSIPOTF_E_NOT_OPENTYPE          = 0x80097012L,
        /// <summary>Failed on a file operation (open, map, read, write).</summary>
        MSSIPOTF_E_FILE                  = 0x80097013L,
        /// <summary>A call to a CryptoAPI function failed.</summary>
        MSSIPOTF_E_CRYPT                 = 0x80097014L,
        /// <summary>There is a bad version number in the file.</summary>
        MSSIPOTF_E_BADVERSION            = 0x80097015L,
        /// <summary>The structure of the DSIG table is incorrect.</summary>
        MSSIPOTF_E_DSIG_STRUCTURE        = 0x80097016L,
        /// <summary>A check failed in a partially constant table.</summary>
        MSSIPOTF_E_PCONST_CHECK          = 0x80097017L,
        /// <summary>Some kind of structural error.</summary>
        MSSIPOTF_E_STRUCTURE             = 0x80097018L,
        /// <summary>The requested credential requires confirmation.</summary>
        ERROR_CRED_REQUIRES_CONFIRMATION = 0x80097019L,
        /// <summary>Unknown trust provider.</summary>
        TRUST_E_PROVIDER_UNKNOWN         = 0x800B0001L,
        /// <summary>The trust verification action specified is not supported by the specified trust provider.</summary>
        TRUST_E_ACTION_UNKNOWN           = 0x800B0002L,
        /// <summary>The form specified for the subject is not one supported or known by the specified trust provider.</summary>
        TRUST_E_SUBJECT_FORM_UNKNOWN     = 0x800B0003L,
        /// <summary>The subject is not trusted for the specified action.</summary>
        TRUST_E_SUBJECT_NOT_TRUSTED      = 0x800B0004L,
        /// <summary>Error due to problem in ASN.1 encoding process.</summary>
        DIGSIG_E_ENCODE                  = 0x800B0005L,
        /// <summary>Error due to problem in ASN.1 decoding process.</summary>
        DIGSIG_E_DECODE                  = 0x800B0006L,
        /// <summary>Reading / writing Extensions where Attributes are appropriate, and vice versa.</summary>
        DIGSIG_E_EXTENSIBILITY           = 0x800B0007L,
        /// <summary>Unspecified cryptographic failure.</summary>
        DIGSIG_E_CRYPTO                  = 0x800B0008L,
        /// <summary>The size of the data could not be determined.</summary>
        PERSIST_E_SIZEDEFINITE           = 0x800B0009L,
        /// <summary>The size of the indefinite-sized data could not be determined.</summary>
        PERSIST_E_SIZEINDEFINITE         = 0x800B000AL,
        /// <summary>This object does not read and write self-sizing data.</summary>
        PERSIST_E_NOTSELFSIZING          = 0x800B000BL,
        /// <summary>No signature was present in the subject.</summary>
        TRUST_E_NOSIGNATURE              = 0x800B0100L,
        /// <summary>A required certificate is not within its validity period when verifying against the current system clock or the timestamp in the signed file.</summary>
        CERT_E_EXPIRED                   = 0x800B0101L,
        /// <summary>The validity periods of the certification chain do not nest correctly.</summary>
        CERT_E_VALIDITYPERIODNESTING     = 0x800B0102L,
        /// <summary>A certificate that can only be used as an end-entity is being used as a CA or vice versa.</summary>
        CERT_E_ROLE                      = 0x800B0103L,
        /// <summary>A path length constraint in the certification chain has been violated.</summary>
        CERT_E_PATHLENCONST              = 0x800B0104L,
        /// <summary>A certificate contains an unknown extension that is marked 'critical'.</summary>
        CERT_E_CRITICAL                  = 0x800B0105L,
        /// <summary>A certificate being used for a purpose other than the ones specified by its CA.</summary>
        CERT_E_PURPOSE                   = 0x800B0106L,
        /// <summary>A parent of a given certificate in fact did not issue that child certificate.</summary>
        CERT_E_ISSUERCHAINING            = 0x800B0107L,
        /// <summary>A certificate is missing or has an empty value for an important field, such as a subject or issuer name.</summary>
        CERT_E_MALFORMED                 = 0x800B0108L,
        /// <summary>A certificate chain processed, but terminated in a root certificate which is not trusted by the trust provider.</summary>
        CERT_E_UNTRUSTEDROOT             = 0x800B0109L,
        /// <summary>A certificate chain could not be built to a trusted root authority.</summary>
        CERT_E_CHAINING                  = 0x800B010AL,
        /// <summary>Generic trust failure.</summary>
        TRUST_E_FAIL                     = 0x800B010BL,
        /// <summary>A certificate was explicitly revoked by its issuer.</summary>
        CERT_E_REVOKED                   = 0x800B010CL,
        /// <summary>The certification path terminates with the test root which is not trusted with the current policy settings.</summary>
        CERT_E_UNTRUSTEDTESTROOT         = 0x800B010DL,
        /// <summary>The revocation process could not continue - the certificate(s) could not be checked.</summary>
        CERT_E_REVOCATION_FAILURE        = 0x800B010EL,
        /// <summary>The certificate's CN name does not match the passed value.</summary>
        CERT_E_CN_NO_MATCH               = 0x800B010FL,
        /// <summary>The certificate is not valid for the requested usage.</summary>
        CERT_E_WRONG_USAGE               = 0x800B0110L,
        /// <summary>The certificate was explicitly marked as untrusted by the user.</summary>
        TRUST_E_EXPLICIT_DISTRUST        = 0x800B0111L,
        /// <summary>A certification chain processed correctly, but one of the CA certificates is not trusted by the policy provider.</summary>
        CERT_E_UNTRUSTEDCA               = 0x800B0112L,
        /// <summary>The certificate has invalid policy.</summary>
        CERT_E_INVALID_POLICY            = 0x800B0113L,
        /// <summary>The certificate has an invalid name. The name is not included in the permitted list or is explicitly excluded.</summary>
        CERT_E_INVALID_NAME              = 0x800B0114L,
        /// <summary>A non-empty line was encountered in the INF before the start of a section.</summary>
        SPAPI_E_EXPECTED_SECTION_NAME    = 0x800F0000L,
        /// <summary>A section name marker in the INF is not complete, or does not exist on a line by itself.</summary>
        SPAPI_E_BAD_SECTION_NAME_LINE    = 0x800F0001L,
        /// <summary>An INF section was encountered whose name exceeds the maximum section name length.</summary>
        SPAPI_E_SECTION_NAME_TOO_LONG    = 0x800F0002L,
        /// <summary>The syntax of the INF is invalid.</summary>
        SPAPI_E_GENERAL_SYNTAX           = 0x800F0003L,
        /// <summary>The style of the INF is different than what was requested.</summary>
        SPAPI_E_WRONG_INF_STYLE          = 0x800F0100L,
        /// <summary>The required section was not found in the INF.</summary>
        SPAPI_E_SECTION_NOT_FOUND        = 0x800F0101L,
        /// <summary>The required line was not found in the INF.</summary>
        SPAPI_E_LINE_NOT_FOUND           = 0x800F0102L,
        /// <summary>The files affected by the installation of this file queue have not been backed up for uninstall.</summary>
        SPAPI_E_NO_BACKUP                = 0x800F0103L,
        /// <summary>The INF or the device information set or element does not have an associated install class.</summary>
        SPAPI_E_NO_ASSOCIATED_CLASS      = 0x800F0200L,
        /// <summary>The INF or the device information set or element does not match the specified install class.</summary>
        SPAPI_E_CLASS_MISMATCH           = 0x800F0201L,
        /// <summary>An existing device was found that is a duplicate of the device being manually installed.</summary>
        SPAPI_E_DUPLICATE_FOUND          = 0x800F0202L,
        /// <summary>There is no driver selected for the device information set or element.</summary>
        SPAPI_E_NO_DRIVER_SELECTED       = 0x800F0203L,
        /// <summary>The requested device registry key does not exist.</summary>
        SPAPI_E_KEY_DOES_NOT_EXIST       = 0x800F0204L,
        /// <summary>The device instance name is invalid.</summary>
        SPAPI_E_INVALID_DEVINST_NAME     = 0x800F0205L,
        /// <summary>The install class is not present or is invalid.</summary>
        SPAPI_E_INVALID_CLASS            = 0x800F0206L,
        /// <summary>The device instance cannot be created because it already exists.</summary>
        SPAPI_E_DEVINST_ALREADY_EXISTS   = 0x800F0207L,
        /// <summary>The operation cannot be performed on a device information element that has not been registered.</summary>
        SPAPI_E_DEVINFO_NOT_REGISTERED   = 0x800F0208L,
        /// <summary>The device property code is invalid.</summary>
        SPAPI_E_INVALID_REG_PROPERTY     = 0x800F0209L,
        /// <summary>The INF from which a driver list is to be built does not exist.</summary>
        SPAPI_E_NO_INF                   = 0x800F020AL,
        /// <summary>The device instance does not exist in the hardware tree.</summary>
        SPAPI_E_NO_SUCH_DEVINST          = 0x800F020BL,
        /// <summary>The icon representing this install class cannot be loaded.</summary>
        SPAPI_E_CANT_LOAD_CLASS_ICON     = 0x800F020CL,
        /// <summary>The class installer registry entry is invalid.</summary>
        SPAPI_E_INVALID_CLASS_INSTALLER  = 0x800F020DL,
        /// <summary>The class installer has indicated that the default action should be performed for this installation request.</summary>
        SPAPI_E_DI_DO_DEFAULT            = 0x800F020EL,
        /// <summary>The operation does not require any files to be copied.</summary>
        SPAPI_E_DI_NOFILECOPY            = 0x800F020FL,
        /// <summary>The specified hardware profile does not exist.</summary>
        SPAPI_E_INVALID_HWPROFILE        = 0x800F0210L,
        /// <summary>There is no device information element currently selected for this device information set.</summary>
        SPAPI_E_NO_DEVICE_SELECTED       = 0x800F0211L,
        /// <summary>The operation cannot be performed because the device information set is locked.</summary>
        SPAPI_E_DEVINFO_LIST_LOCKED      = 0x800F0212L,
        /// <summary>The operation cannot be performed because the device information element is locked.</summary>
        SPAPI_E_DEVINFO_DATA_LOCKED      = 0x800F0213L,
        /// <summary>The specified path does not contain any applicable device INFs.</summary>
        SPAPI_E_DI_BAD_PATH              = 0x800F0214L,
        /// <summary>No class installer parameters have been set for the device information set or element.</summary>
        SPAPI_E_NO_CLASSINSTALL_PARAMS   = 0x800F0215L,
        /// <summary>The operation cannot be performed because the file queue is locked.</summary>
        SPAPI_E_FILEQUEUE_LOCKED         = 0x800F0216L,
        /// <summary>A service installation section in this INF is invalid.</summary>
        SPAPI_E_BAD_SERVICE_INSTALLSECT  = 0x800F0217L,
        /// <summary>There is no class driver list for the device information element.</summary>
        SPAPI_E_NO_CLASS_DRIVER_LIST     = 0x800F0218L,
        /// <summary>The installation failed because a function driver was not specified for this device instance.</summary>
        SPAPI_E_NO_ASSOCIATED_SERVICE    = 0x800F0219L,
        /// <summary>There is presently no default device interface designated for this interface class.</summary>
        SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE = 0x800F021AL,
        /// <summary>The operation cannot be performed because the device interface is currently active.</summary>
        SPAPI_E_DEVICE_INTERFACE_ACTIVE  = 0x800F021BL,
        /// <summary>The operation cannot be performed because the device interface has been removed from the system.</summary>
        SPAPI_E_DEVICE_INTERFACE_REMOVED = 0x800F021CL,
        /// <summary>An interface installation section in this INF is invalid.</summary>
        SPAPI_E_BAD_INTERFACE_INSTALLSECT = 0x800F021DL,
        /// <summary>This interface class does not exist in the system.</summary>
        SPAPI_E_NO_SUCH_INTERFACE_CLASS  = 0x800F021EL,
        /// <summary>The reference string supplied for this interface device is invalid.</summary>
        SPAPI_E_INVALID_REFERENCE_STRING = 0x800F021FL,
        /// <summary>The specified machine name does not conform to UNC naming conventions.</summary>
        SPAPI_E_INVALID_MACHINENAME      = 0x800F0220L,
        /// <summary>A general remote communication error occurred.</summary>
        SPAPI_E_REMOTE_COMM_FAILURE      = 0x800F0221L,
        /// <summary>The machine selected for remote communication is not available at this time.</summary>
        SPAPI_E_MACHINE_UNAVAILABLE      = 0x800F0222L,
        /// <summary>The Plug and Play service is not available on the remote machine.</summary>
        SPAPI_E_NO_CONFIGMGR_SERVICES    = 0x800F0223L,
        /// <summary>The property page provider registry entry is invalid.</summary>
        SPAPI_E_INVALID_PROPPAGE_PROVIDER = 0x800F0224L,
        /// <summary>The requested device interface is not present in the system.</summary>
        SPAPI_E_NO_SUCH_DEVICE_INTERFACE = 0x800F0225L,
        /// <summary>The device's co-installer has additional work to perform after installation is complete.</summary>
        SPAPI_E_DI_POSTPROCESSING_REQUIRED = 0x800F0226L,
        /// <summary>The device's co-installer is invalid.</summary>
        SPAPI_E_INVALID_COINSTALLER      = 0x800F0227L,
        /// <summary>There are no compatible drivers for this device.</summary>
        SPAPI_E_NO_COMPAT_DRIVERS        = 0x800F0228L,
        /// <summary>There is no icon that represents this device or device type.</summary>
        SPAPI_E_NO_DEVICE_ICON           = 0x800F0229L,
        /// <summary>A logical configuration specified in this INF is invalid.</summary>
        SPAPI_E_INVALID_INF_LOGCONFIG    = 0x800F022AL,
        /// <summary>The class installer has denied the request to install or upgrade this device.</summary>
        SPAPI_E_DI_DONT_INSTALL          = 0x800F022BL,
        /// <summary>One of the filter drivers installed for this device is invalid.</summary>
        SPAPI_E_INVALID_FILTER_DRIVER    = 0x800F022CL,
        /// <summary>The driver selected for this device does not support this version of Windows.</summary>
        SPAPI_E_NON_WINDOWS_NT_DRIVER    = 0x800F022DL,
        /// <summary>The driver selected for this device does not support Windows.</summary>
        SPAPI_E_NON_WINDOWS_DRIVER       = 0x800F022EL,
        /// <summary>The third-party INF does not contain digital signature information.</summary>
        SPAPI_E_NO_CATALOG_FOR_OEM_INF   = 0x800F022FL,
        /// <summary>An invalid attempt was made to use a device installation file queue for verification of digital signatures relative to other platforms.</summary>
        SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE = 0x800F0230L,
        /// <summary>The device cannot be disabled.</summary>
        SPAPI_E_NOT_DISABLEABLE          = 0x800F0231L,
        /// <summary>The device could not be dynamically removed.</summary>
        SPAPI_E_CANT_REMOVE_DEVINST      = 0x800F0232L,
        /// <summary>Cannot copy to specified target.</summary>
        SPAPI_E_INVALID_TARGET           = 0x800F0233L,
        /// <summary>Driver is not intended for this platform.</summary>
        SPAPI_E_DRIVER_NONNATIVE         = 0x800F0234L,
        /// <summary>Operation not allowed in WOW64.</summary>
        SPAPI_E_IN_WOW64                 = 0x800F0235L,
        /// <summary>The operation involving unsigned file copying was rolled back, so that a system restore point could be set.</summary>
        SPAPI_E_SET_SYSTEM_RESTORE_POINT = 0x800F0236L,
        /// <summary>An INF was copied into the Windows INF directory in an improper manner.</summary>
        SPAPI_E_INCORRECTLY_COPIED_INF   = 0x800F0237L,
        /// <summary>The Security Configuration Editor (SCE) APIs have been disabled on this Embedded product.</summary>
        SPAPI_E_SCE_DISABLED             = 0x800F0238L,
        /// <summary>An unknown exception was encountered.</summary>
        SPAPI_E_UNKNOWN_EXCEPTION        = 0x800F0239L,
        /// <summary>A problem was encountered when accessing the Plug and Play registry database.</summary>
        SPAPI_E_PNP_REGISTRY_ERROR       = 0x800F023AL,
        /// <summary>The requested operation is not supported for a remote machine.</summary>
        SPAPI_E_REMOTE_REQUEST_UNSUPPORTED = 0x800F023BL,
        /// <summary>The specified file is not an installed OEM INF.</summary>
        SPAPI_E_NOT_AN_INSTALLED_OEM_INF = 0x800F023CL,
        /// <summary>One or more devices are presently installed using the specified INF.</summary>
        SPAPI_E_INF_IN_USE_BY_DEVICES    = 0x800F023DL,
        /// <summary>The requested device install operation is obsolete.</summary>
        SPAPI_E_DI_FUNCTION_OBSOLETE     = 0x800F023EL,
        /// <summary>A file could not be verified because it does not have an associated catalog signed via Authenticode(tm).</summary>
        SPAPI_E_NO_AUTHENTICODE_CATALOG  = 0x800F023FL,
        /// <summary>Authenticode(tm) signature verification is not supported for the specified INF.</summary>
        SPAPI_E_AUTHENTICODE_DISALLOWED  = 0x800F0240L,
        /// <summary>The INF was signed with an Authenticode(tm) catalog from a trusted publisher.</summary>
        SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER = 0x800F0241L,
        /// <summary>The publisher of an Authenticode(tm) signed catalog has not yet been established as trusted.</summary>
        SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED = 0x800F0242L,
        /// <summary>The publisher of an Authenticode(tm) signed catalog was not established as trusted.</summary>
        SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = 0x800F0243L,
        /// <summary>The software was tested for compliance with Windows Logo requirements on a different version of Windows, and may not be compatible with this version.</summary>
        SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH = 0x800F0244L,
        /// <summary>The file may only be validated by a catalog signed via Authenticode(tm).</summary>
        SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE = 0x800F0245L,
        /// <summary>One of the installers for this device cannot perform the installation at this time.</summary>
        SPAPI_E_DEVICE_INSTALLER_NOT_READY = 0x800F0246L,
        /// <summary>A problem was encountered while attempting to add the driver to the store.</summary>
        SPAPI_E_DRIVER_STORE_ADD_FAILED  = 0x800F0247L,
        /// <summary>The installation of this device is forbidden by system policy. Contact your system administrator.</summary>
        SPAPI_E_DEVICE_INSTALL_BLOCKED   = 0x800F0248L,
        /// <summary>The installation of this driver is forbidden by system policy. Contact your system administrator.</summary>
        SPAPI_E_DRIVER_INSTALL_BLOCKED   = 0x800F0249L,
        /// <summary>The specified INF is the wrong type for this operation.</summary>
        SPAPI_E_WRONG_INF_TYPE           = 0x800F024AL,
        /// <summary>The hash for the file is not present in the specified catalog file. The file is likely corrupt or the victim of tampering.</summary>
        SPAPI_E_FILE_HASH_NOT_IN_CATALOG = 0x800F024BL,
        /// <summary>A problem was encountered while attempting to delete the driver from the store.</summary>
        SPAPI_E_DRIVER_STORE_DELETE_FAILED = 0x800F024CL,
        /// <summary>An unrecoverable stack overflow was encountered.</summary>
        SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW = 0x800F0300L,
        /// <summary>No installed components were detected.</summary>
        SPAPI_E_ERROR_NOT_INSTALLED      = 0x800F1000L,
        /// <summary>An internal consistency check failed.</summary>
        SCARD_F_INTERNAL_ERROR           = 0x80100001L,
        /// <summary>The action was cancelled by an SCardCancel request.</summary>
        SCARD_E_CANCELLED                = 0x80100002L,
        /// <summary>The supplied handle was invalid.</summary>
        SCARD_E_INVALID_HANDLE           = 0x80100003L,
        /// <summary>One or more of the supplied parameters could not be properly interpreted.</summary>
        SCARD_E_INVALID_PARAMETER        = 0x80100004L,
        /// <summary>Registry startup information is missing or invalid.</summary>
        SCARD_E_INVALID_TARGET           = 0x80100005L,
        /// <summary>Not enough memory available to complete this command.</summary>
        SCARD_E_NO_MEMORY                = 0x80100006L,
        /// <summary>An internal consistency timer has expired.</summary>
        SCARD_F_WAITED_TOO_LONG          = 0x80100007L,
        /// <summary>The data buffer to receive returned data is too small for the returned data.</summary>
        SCARD_E_INSUFFICIENT_BUFFER      = 0x80100008L,
        /// <summary>The specified reader name is not recognized.</summary>
        SCARD_E_UNKNOWN_READER           = 0x80100009L,
        /// <summary>The user-specified timeout value has expired.</summary>
        SCARD_E_TIMEOUT                  = 0x8010000AL,
        /// <summary>The smart card cannot be accessed because of other connections outstanding.</summary>
        SCARD_E_SHARING_VIOLATION        = 0x8010000BL,
        /// <summary>The operation requires a smart card, but no smart card is currently in the device.</summary>
        SCARD_E_NO_SMARTCARD             = 0x8010000CL,
        /// <summary>The specified smart card name is not recognized.</summary>
        SCARD_E_UNKNOWN_CARD             = 0x8010000DL,
        /// <summary>The system could not dispose of the media in the requested manner.</summary>
        SCARD_E_CANT_DISPOSE             = 0x8010000EL,
        /// <summary>The requested protocols are incompatible with the protocol currently in use with the smart card.</summary>
        SCARD_E_PROTO_MISMATCH           = 0x8010000FL,
        /// <summary>The reader or smart card is not ready to accept commands.</summary>
        SCARD_E_NOT_READY                = 0x80100010L,
        /// <summary>One or more of the supplied parameters values could not be properly interpreted.</summary>
        SCARD_E_INVALID_VALUE            = 0x80100011L,
        /// <summary>The action was cancelled by the system, presumably to log off or shut down.</summary>
        SCARD_E_SYSTEM_CANCELLED         = 0x80100012L,
        /// <summary>An internal communications error has been detected.</summary>
        SCARD_F_COMM_ERROR               = 0x80100013L,
        /// <summary>An internal error has been detected, but the source is unknown.</summary>
        SCARD_F_UNKNOWN_ERROR            = 0x80100014L,
        /// <summary>An ATR obtained from the registry is not a valid ATR string.</summary>
        SCARD_E_INVALID_ATR              = 0x80100015L,
        /// <summary>An attempt was made to end a non-existent transaction.</summary>
        SCARD_E_NOT_TRANSACTED           = 0x80100016L,
        /// <summary>The specified reader is not currently available for use.</summary>
        SCARD_E_READER_UNAVAILABLE       = 0x80100017L,
        /// <summary>The operation has been aborted to allow the server application to exit.</summary>
        SCARD_P_SHUTDOWN                 = 0x80100018L,
        /// <summary>The PCI Receive buffer was too small.</summary>
        SCARD_E_PCI_TOO_SMALL            = 0x80100019L,
        /// <summary>The reader driver does not meet minimal requirements for support.</summary>
        SCARD_E_READER_UNSUPPORTED       = 0x8010001AL,
        /// <summary>The reader driver did not produce a unique reader name.</summary>
        SCARD_E_DUPLICATE_READER         = 0x8010001BL,
        /// <summary>The smart card does not meet minimal requirements for support.</summary>
        SCARD_E_CARD_UNSUPPORTED         = 0x8010001CL,
        /// <summary>The Smart Card Resource Manager is not running.</summary>
        SCARD_E_NO_SERVICE               = 0x8010001DL,
        /// <summary>The Smart Card Resource Manager has shut down.</summary>
        SCARD_E_SERVICE_STOPPED          = 0x8010001EL,
        /// <summary>An unexpected card error has occurred.</summary>
        SCARD_E_UNEXPECTED               = 0x8010001FL,
        /// <summary>No Primary Provider can be found for the smart card.</summary>
        SCARD_E_ICC_INSTALLATION         = 0x80100020L,
        /// <summary>The requested order of object creation is not supported.</summary>
        SCARD_E_ICC_CREATEORDER          = 0x80100021L,
        /// <summary>This smart card does not support the requested feature.</summary>
        SCARD_E_UNSUPPORTED_FEATURE      = 0x80100022L,
        /// <summary>The identified directory does not exist in the smart card.</summary>
        SCARD_E_DIR_NOT_FOUND            = 0x80100023L,
        /// <summary>The identified file does not exist in the smart card.</summary>
        SCARD_E_FILE_NOT_FOUND           = 0x80100024L,
        /// <summary>The supplied path does not represent a smart card directory.</summary>
        SCARD_E_NO_DIR                   = 0x80100025L,
        /// <summary>The supplied path does not represent a smart card file.</summary>
        SCARD_E_NO_FILE                  = 0x80100026L,
        /// <summary>Access is denied to this file.</summary>
        SCARD_E_NO_ACCESS                = 0x80100027L,
        /// <summary>The smart card does not have enough memory to store the information.</summary>
        SCARD_E_WRITE_TOO_MANY           = 0x80100028L,
        /// <summary>There was an error trying to set the smart card file object pointer.</summary>
        SCARD_E_BAD_SEEK                 = 0x80100029L,
        /// <summary>The supplied PIN is incorrect.</summary>
        SCARD_E_INVALID_CHV              = 0x8010002AL,
        /// <summary>An unrecognized error code was returned from a layered component.</summary>
        SCARD_E_UNKNOWN_RES_MNG          = 0x8010002BL,
        /// <summary>The requested certificate does not exist.</summary>
        SCARD_E_NO_SUCH_CERTIFICATE      = 0x8010002CL,
        /// <summary>The requested certificate could not be obtained.</summary>
        SCARD_E_CERTIFICATE_UNAVAILABLE  = 0x8010002DL,
        /// <summary>Cannot find a smart card reader.</summary>
        SCARD_E_NO_READERS_AVAILABLE     = 0x8010002EL,
        /// <summary>A communications error with the smart card has been detected. Retry the operation.</summary>
        SCARD_E_COMM_DATA_LOST           = 0x8010002FL,
        /// <summary>The requested key container does not exist on the smart card.</summary>
        SCARD_E_NO_KEY_CONTAINER         = 0x80100030L,
        /// <summary>The Smart Card Resource Manager is too busy to complete this operation.</summary>
        SCARD_E_SERVER_TOO_BUSY          = 0x80100031L,
        /// <summary>The smart card PIN cache has expired.</summary>
        SCARD_E_PIN_CACHE_EXPIRED        = 0x80100032L,
        /// <summary>The smart card PIN cannot be cached.</summary>
        SCARD_E_NO_PIN_CACHE             = 0x80100033L,
        /// <summary>The smart card is read only and cannot be written to.</summary>
        SCARD_E_READ_ONLY_CARD           = 0x80100034L,
        /// <summary>The reader cannot communicate with the smart card, due to ATR configuration conflicts.</summary>
        SCARD_W_UNSUPPORTED_CARD         = 0x80100065L,
        /// <summary>The smart card is not responding to a reset.</summary>
        SCARD_W_UNRESPONSIVE_CARD        = 0x80100066L,
        /// <summary>Power has been removed from the smart card, so that further communication is not possible.</summary>
        SCARD_W_UNPOWERED_CARD           = 0x80100067L,
        /// <summary>The smart card has been reset, so any shared state information is invalid.</summary>
        SCARD_W_RESET_CARD               = 0x80100068L,
        /// <summary>The smart card has been removed, so that further communication is not possible.</summary>
        SCARD_W_REMOVED_CARD             = 0x80100069L,
        /// <summary>Access was denied because of a security violation.</summary>
        SCARD_W_SECURITY_VIOLATION       = 0x8010006AL,
        /// <summary>The card cannot be accessed because the wrong PIN was presented.</summary>
        SCARD_W_WRONG_CHV                = 0x8010006BL,
        /// <summary>The card cannot be accessed because the maximum number of PIN entry attempts has been reached.</summary>
        SCARD_W_CHV_BLOCKED              = 0x8010006CL,
        /// <summary>The end of the smart card file has been reached.</summary>
        SCARD_W_EOF                      = 0x8010006DL,
        /// <summary>The action was cancelled by the user.</summary>
        SCARD_W_CANCELLED_BY_USER        = 0x8010006EL,
        /// <summary>No PIN was presented to the smart card.</summary>
        SCARD_W_CARD_NOT_AUTHENTICATED   = 0x8010006FL,
        /// <summary>The requested item could not be found in the cache.</summary>
        SCARD_W_CACHE_ITEM_NOT_FOUND     = 0x80100070L,
        /// <summary>The requested cache item is too old and was deleted from the cache.</summary>
        SCARD_W_CACHE_ITEM_STALE         = 0x80100071L,
        /// <summary>The new cache item exceeds the maximum per-item size defined for the cache.</summary>
        SCARD_W_CACHE_ITEM_TOO_BIG       = 0x80100072L,
        /// <summary>Errors occurred accessing one or more objects - the ErrorInfo collection may have more detail</summary>
        COMADMIN_E_OBJECTERRORS          = 0x80110401L,
        /// <summary>One or more of the object's properties are missing or invalid</summary>
        COMADMIN_E_OBJECTINVALID         = 0x80110402L,
        /// <summary>The object was not found in the catalog</summary>
        COMADMIN_E_KEYMISSING            = 0x80110403L,
        /// <summary>The object is already registered</summary>
        COMADMIN_E_ALREADYINSTALLED      = 0x80110404L,
        /// <summary>Error occurred writing to the application file</summary>
        COMADMIN_E_APP_FILE_WRITEFAIL    = 0x80110407L,
        /// <summary>Error occurred reading the application file</summary>
        COMADMIN_E_APP_FILE_READFAIL     = 0x80110408L,
        /// <summary>Invalid version number in application file</summary>
        COMADMIN_E_APP_FILE_VERSION      = 0x80110409L,
        /// <summary>The file path is invalid</summary>
        COMADMIN_E_BADPATH               = 0x8011040AL,
        /// <summary>The application is already installed</summary>
        COMADMIN_E_APPLICATIONEXISTS     = 0x8011040BL,
        /// <summary>The role already exists</summary>
        COMADMIN_E_ROLEEXISTS            = 0x8011040CL,
        /// <summary>An error occurred copying the file</summary>
        COMADMIN_E_CANTCOPYFILE          = 0x8011040DL,
        /// <summary>One or more users are not valid</summary>
        COMADMIN_E_NOUSER                = 0x8011040FL,
        /// <summary>One or more users in the application file are not valid</summary>
        COMADMIN_E_INVALIDUSERIDS        = 0x80110410L,
        /// <summary>The component's CLSID is missing or corrupt</summary>
        COMADMIN_E_NOREGISTRYCLSID       = 0x80110411L,
        /// <summary>The component's progID is missing or corrupt</summary>
        COMADMIN_E_BADREGISTRYPROGID     = 0x80110412L,
        /// <summary>Unable to set required authentication level for update request</summary>
        COMADMIN_E_AUTHENTICATIONLEVEL   = 0x80110413L,
        /// <summary>The identity or password set on the application is not valid</summary>
        COMADMIN_E_USERPASSWDNOTVALID    = 0x80110414L,
        /// <summary>Application file CLSIDs or IIDs do not match corresponding DLLs</summary>
        COMADMIN_E_CLSIDORIIDMISMATCH    = 0x80110418L,
        /// <summary>Interface information is either missing or changed</summary>
        COMADMIN_E_REMOTEINTERFACE       = 0x80110419L,
        /// <summary>DllRegisterServer failed on component install</summary>
        COMADMIN_E_DLLREGISTERSERVER     = 0x8011041AL,
        /// <summary>No server file share available</summary>
        COMADMIN_E_NOSERVERSHARE         = 0x8011041BL,
        /// <summary>DLL could not be loaded</summary>
        COMADMIN_E_DLLLOADFAILED         = 0x8011041DL,
        /// <summary>The registered TypeLib ID is not valid</summary>
        COMADMIN_E_BADREGISTRYLIBID      = 0x8011041EL,
        /// <summary>Application install directory not found</summary>
        COMADMIN_E_APPDIRNOTFOUND        = 0x8011041FL,
        /// <summary>Errors occurred while in the component registrar</summary>
        COMADMIN_E_REGISTRARFAILED       = 0x80110423L,
        /// <summary>The file does not exist</summary>
        COMADMIN_E_COMPFILE_DOESNOTEXIST = 0x80110424L,
        /// <summary>The DLL could not be loaded</summary>
        COMADMIN_E_COMPFILE_LOADDLLFAIL  = 0x80110425L,
        /// <summary>GetClassObject failed in the DLL</summary>
        COMADMIN_E_COMPFILE_GETCLASSOBJ  = 0x80110426L,
        /// <summary>The DLL does not support the components listed in the TypeLib</summary>
        COMADMIN_E_COMPFILE_CLASSNOTAVAIL = 0x80110427L,
        /// <summary>The TypeLib could not be loaded</summary>
        COMADMIN_E_COMPFILE_BADTLB       = 0x80110428L,
        /// <summary>The file does not contain components or component information</summary>
        COMADMIN_E_COMPFILE_NOTINSTALLABLE = 0x80110429L,
        /// <summary>Changes to this object and its sub-objects have been disabled</summary>
        COMADMIN_E_NOTCHANGEABLE         = 0x8011042AL,
        /// <summary>The delete function has been disabled for this object</summary>
        COMADMIN_E_NOTDELETEABLE         = 0x8011042BL,
        /// <summary>The server catalog version is not supported</summary>
        COMADMIN_E_SESSION               = 0x8011042CL,
        /// <summary>The component move was disallowed, because the source or destination application is either a system application or currently locked against changes</summary>
        COMADMIN_E_COMP_MOVE_LOCKED      = 0x8011042DL,
        /// <summary>The component move failed because the destination application no longer exists</summary>
        COMADMIN_E_COMP_MOVE_BAD_DEST    = 0x8011042EL,
        /// <summary>The system was unable to register the TypeLib</summary>
        COMADMIN_E_REGISTERTLB           = 0x80110430L,
        /// <summary>This operation cannot be performed on the system application</summary>
        COMADMIN_E_SYSTEMAPP             = 0x80110433L,
        /// <summary>The component registrar referenced in this file is not available</summary>
        COMADMIN_E_COMPFILE_NOREGISTRAR  = 0x80110434L,
        /// <summary>A component in the same DLL is already installed</summary>
        COMADMIN_E_COREQCOMPINSTALLED    = 0x80110435L,
        /// <summary>The service is not installed</summary>
        COMADMIN_E_SERVICENOTINSTALLED   = 0x80110436L,
        /// <summary>One or more property settings are either invalid or in conflict with each other</summary>
        COMADMIN_E_PROPERTYSAVEFAILED    = 0x80110437L,
        /// <summary>The object you are attempting to add or rename already exists</summary>
        COMADMIN_E_OBJECTEXISTS          = 0x80110438L,
        /// <summary>The component already exists</summary>
        COMADMIN_E_COMPONENTEXISTS       = 0x80110439L,
        /// <summary>The registration file is corrupt</summary>
        COMADMIN_E_REGFILE_CORRUPT       = 0x8011043BL,
        /// <summary>The property value is too large</summary>
        COMADMIN_E_PROPERTY_OVERFLOW     = 0x8011043CL,
        /// <summary>Object was not found in registry</summary>
        COMADMIN_E_NOTINREGISTRY         = 0x8011043EL,
        /// <summary>This object is not poolable</summary>
        COMADMIN_E_OBJECTNOTPOOLABLE     = 0x8011043FL,
        /// <summary>A CLSID with the same GUID as the new application ID is already installed on this machine</summary>
        COMADMIN_E_APPLID_MATCHES_CLSID  = 0x80110446L,
        /// <summary>A role assigned to a component, interface, or method did not exist in the application</summary>
        COMADMIN_E_ROLE_DOES_NOT_EXIST   = 0x80110447L,
        /// <summary>You must have components in an application in order to start the application</summary>
        COMADMIN_E_START_APP_NEEDS_COMPONENTS = 0x80110448L,
        /// <summary>This operation is not enabled on this platform</summary>
        COMADMIN_E_REQUIRES_DIFFERENT_PLATFORM = 0x80110449L,
        /// <summary>Application Proxy is not exportable</summary>
        COMADMIN_E_CAN_NOT_EXPORT_APP_PROXY = 0x8011044AL,
        /// <summary>Failed to start application because it is either a library application or an application proxy</summary>
        COMADMIN_E_CAN_NOT_START_APP     = 0x8011044BL,
        /// <summary>System application is not exportable</summary>
        COMADMIN_E_CAN_NOT_EXPORT_SYS_APP = 0x8011044CL,
        /// <summary>Cannot subscribe to this component (the component may have been imported)</summary>
        COMADMIN_E_CANT_SUBSCRIBE_TO_COMPONENT = 0x8011044DL,
        /// <summary>An event class cannot also be a subscriber component</summary>
        COMADMIN_E_EVENTCLASS_CANT_BE_SUBSCRIBER = 0x8011044EL,
        /// <summary>Library applications and application proxies are incompatible</summary>
        COMADMIN_E_LIB_APP_PROXY_INCOMPATIBLE = 0x8011044FL,
        /// <summary>This function is valid for the base partition only</summary>
        COMADMIN_E_BASE_PARTITION_ONLY   = 0x80110450L,
        /// <summary>You cannot start an application that has been disabled</summary>
        COMADMIN_E_START_APP_DISABLED    = 0x80110451L,
        /// <summary>The specified partition name is already in use on this computer</summary>
        COMADMIN_E_CAT_DUPLICATE_PARTITION_NAME = 0x80110457L,
        /// <summary>The specified partition name is invalid. Check that the name contains at least one visible character</summary>
        COMADMIN_E_CAT_INVALID_PARTITION_NAME = 0x80110458L,
        /// <summary>The partition cannot be deleted because it is the default partition for one or more users</summary>
        COMADMIN_E_CAT_PARTITION_IN_USE  = 0x80110459L,
        /// <summary>The partition cannot be exported, because one or more components in the partition have the same file name</summary>
        COMADMIN_E_FILE_PARTITION_DUPLICATE_FILES = 0x8011045AL,
        /// <summary>Applications that contain one or more imported components cannot be installed into a non-base partition</summary>
        COMADMIN_E_CAT_IMPORTED_COMPONENTS_NOT_ALLOWED = 0x8011045BL,
        /// <summary>The application name is not unique and cannot be resolved to an application id</summary>
        COMADMIN_E_AMBIGUOUS_APPLICATION_NAME = 0x8011045CL,
        /// <summary>The partition name is not unique and cannot be resolved to a partition id</summary>
        COMADMIN_E_AMBIGUOUS_PARTITION_NAME = 0x8011045DL,
        /// <summary>The COM+ registry database has not been initialized</summary>
        COMADMIN_E_REGDB_NOTINITIALIZED  = 0x80110472L,
        /// <summary>The COM+ registry database is not open</summary>
        COMADMIN_E_REGDB_NOTOPEN         = 0x80110473L,
        /// <summary>The COM+ registry database detected a system error</summary>
        COMADMIN_E_REGDB_SYSTEMERR       = 0x80110474L,
        /// <summary>The COM+ registry database is already running</summary>
        COMADMIN_E_REGDB_ALREADYRUNNING  = 0x80110475L,
        /// <summary>This version of the COM+ registry database cannot be migrated</summary>
        COMADMIN_E_MIG_VERSIONNOTSUPPORTED = 0x80110480L,
        /// <summary>The schema version to be migrated could not be found in the COM+ registry database</summary>
        COMADMIN_E_MIG_SCHEMANOTFOUND    = 0x80110481L,
        /// <summary>There was a type mismatch between binaries</summary>
        COMADMIN_E_CAT_BITNESSMISMATCH   = 0x80110482L,
        /// <summary>A binary of unknown or invalid type was provided</summary>
        COMADMIN_E_CAT_UNACCEPTABLEBITNESS = 0x80110483L,
        /// <summary>There was a type mismatch between a binary and an application</summary>
        COMADMIN_E_CAT_WRONGAPPBITNESS   = 0x80110484L,
        /// <summary>The application cannot be paused or resumed</summary>
        COMADMIN_E_CAT_PAUSE_RESUME_NOT_SUPPORTED = 0x80110485L,
        /// <summary>The COM+ Catalog Server threw an exception during execution</summary>
        COMADMIN_E_CAT_SERVERFAULT       = 0x80110486L,
        /// <summary>Only COM+ Applications marked "queued" can be invoked using the "queue" moniker</summary>
        COMQC_E_APPLICATION_NOT_QUEUED   = 0x80110600L,
        /// <summary>At least one interface must be marked "queued" in order to create a queued component instance with the "queue" moniker</summary>
        COMQC_E_NO_QUEUEABLE_INTERFACES  = 0x80110601L,
        /// <summary>MSMQ is required for the requested operation and is not installed</summary>
        COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE = 0x80110602L,
        /// <summary>Unable to marshal an interface that does not support IPersistStream</summary>
        COMQC_E_NO_IPERSISTSTREAM        = 0x80110603L,
        /// <summary>The message is improperly formatted or was damaged in transit</summary>
        COMQC_E_BAD_MESSAGE              = 0x80110604L,
        /// <summary>An unauthenticated message was received by an application that accepts only authenticated messages</summary>
        COMQC_E_UNAUTHENTICATED          = 0x80110605L,
        /// <summary>The message was requeued or moved by a user not in the "QC Trusted User" role</summary>
        COMQC_E_UNTRUSTED_ENQUEUER       = 0x80110606L,
        /// <summary>Cannot create a duplicate resource of type Distributed Transaction Coordinator</summary>
        MSDTC_E_DUPLICATE_RESOURCE       = 0x80110701L,
        /// <summary>One of the objects being inserted or updated does not belong to a valid parent collection</summary>
        COMADMIN_E_OBJECT_PARENT_MISSING = 0x80110808L,
        /// <summary>One of the specified objects cannot be found</summary>
        COMADMIN_E_OBJECT_DOES_NOT_EXIST = 0x80110809L,
        /// <summary>The specified application is not currently running</summary>
        COMADMIN_E_APP_NOT_RUNNING       = 0x8011080AL,
        /// <summary>The partition(s) specified are not valid.</summary>
        COMADMIN_E_INVALID_PARTITION     = 0x8011080BL,
        /// <summary>COM+ applications that run as NT service may not be pooled or recycled</summary>
        COMADMIN_E_SVCAPP_NOT_POOLABLE_OR_RECYCLABLE = 0x8011080DL,
        /// <summary>One or more users are already assigned to a local partition set.</summary>
        COMADMIN_E_USER_IN_SET           = 0x8011080EL,
        /// <summary>Library applications may not be recycled.</summary>
        COMADMIN_E_CANTRECYCLELIBRARYAPPS = 0x8011080FL,
        /// <summary>Applications running as NT services may not be recycled.</summary>
        COMADMIN_E_CANTRECYCLESERVICEAPPS = 0x80110811L,
        /// <summary>The process has already been recycled.</summary>
        COMADMIN_E_PROCESSALREADYRECYCLED = 0x80110812L,
        /// <summary>A paused process may not be recycled.</summary>
        COMADMIN_E_PAUSEDPROCESSMAYNOTBERECYCLED = 0x80110813L,
        /// <summary>Library applications may not be NT services.</summary>
        COMADMIN_E_CANTMAKEINPROCSERVICE = 0x80110814L,
        /// <summary>The ProgID provided to the copy operation is invalid. The ProgID is in use by another registered CLSID.</summary>
        COMADMIN_E_PROGIDINUSEBYCLSID    = 0x80110815L,
        /// <summary>The partition specified as default is not a member of the partition set.</summary>
        COMADMIN_E_DEFAULT_PARTITION_NOT_IN_SET = 0x80110816L,
        /// <summary>A recycled process may not be paused.</summary>
        COMADMIN_E_RECYCLEDPROCESSMAYNOTBEPAUSED = 0x80110817L,
        /// <summary>Access to the specified partition is denied.</summary>
        COMADMIN_E_PARTITION_ACCESSDENIED = 0x80110818L,
        /// <summary>Only Application Files (*.MSI files) can be installed into partitions.</summary>
        COMADMIN_E_PARTITION_MSI_ONLY    = 0x80110819L,
        /// <summary>Applications containing one or more legacy components may not be exported to 1.0 format.</summary>
        COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_1_0_FORMAT = 0x8011081AL,
        /// <summary>Legacy components may not exist in non-base partitions.</summary>
        COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_NONBASE_PARTITIONS = 0x8011081BL,
        /// <summary>A component cannot be moved (or copied) from the System Application, an application proxy or a non-changeable application</summary>
        COMADMIN_E_COMP_MOVE_SOURCE      = 0x8011081CL,
        /// <summary>A component cannot be moved (or copied) to the System Application, an application proxy or a non-changeable application</summary>
        COMADMIN_E_COMP_MOVE_DEST        = 0x8011081DL,
        /// <summary>A private component cannot be moved (or copied) to a library application or to the base partition</summary>
        COMADMIN_E_COMP_MOVE_PRIVATE     = 0x8011081EL,
        /// <summary>The Base Application Partition exists in all partition sets and cannot be removed.</summary>
        COMADMIN_E_BASEPARTITION_REQUIRED_IN_SET = 0x8011081FL,
        /// <summary>Alas, Event Class components cannot be aliased.</summary>
        COMADMIN_E_CANNOT_ALIAS_EVENTCLASS = 0x80110820L,
        /// <summary>Access is denied because the component is private.</summary>
        COMADMIN_E_PRIVATE_ACCESSDENIED  = 0x80110821L,
        /// <summary>The specified SAFER level is invalid.</summary>
        COMADMIN_E_SAFERINVALID          = 0x80110822L,
        /// <summary>The specified user cannot write to the system registry</summary>
        COMADMIN_E_REGISTRY_ACCESSDENIED = 0x80110823L,
        /// <summary>COM+ partitions are currently disabled.</summary>
        COMADMIN_E_PARTITIONS_DISABLED   = 0x80110824L,
        /// <summary>Debugger was attached.</summary>
        WER_S_REPORT_DEBUG               = 0x001B0000L,
        /// <summary>Report was uploaded.</summary>
        WER_S_REPORT_UPLOADED            = 0x001B0001L,
        /// <summary>Report was queued.</summary>
        WER_S_REPORT_QUEUED              = 0x001B0002L,
        /// <summary>Reporting was disabled.</summary>
        WER_S_DISABLED                   = 0x001B0003L,
        /// <summary>Reporting was temporarily suspended.</summary>
        WER_S_SUSPENDED_UPLOAD           = 0x001B0004L,
        /// <summary>Report was not queued to queueing being disabled.</summary>
        WER_S_DISABLED_QUEUE             = 0x001B0005L,
        /// <summary>Report was uploaded, but not archived due to archiving being disabled.</summary>
        WER_S_DISABLED_ARCHIVE           = 0x001B0006L,
        /// <summary>Reporting was successfully spun off as an asynchronous operation.</summary>
        WER_S_REPORT_ASYNC               = 0x001B0007L,
        /// <summary>The assertion was handled.</summary>
        WER_S_IGNORE_ASSERT_INSTANCE     = 0x001B0008L,
        /// <summary>The assertion was handled and added to a permanent ignore list.</summary>
        WER_S_IGNORE_ALL_ASSERTS         = 0x001B0009L,
        /// <summary>The assertion was resumed as unhandled.</summary>
        WER_S_ASSERT_CONTINUE            = 0x001B000AL,
        /// <summary>Report was throttled.</summary>
        WER_S_THROTTLED                  = 0x001B000BL,
        /// <summary>Report was uploaded with cab.</summary>
        WER_S_REPORT_UPLOADED_CAB        = 0x001B000CL,
        /// <summary>Crash reporting failed.</summary>
        WER_E_CRASH_FAILURE              = 0x801B8000L,
        /// <summary>Report aborted due to user cancelation.</summary>
        WER_E_CANCELED                   = 0x801B8001L,
        /// <summary>Report aborted due to network failure.</summary>
        WER_E_NETWORK_FAILURE            = 0x801B8002L,
        /// <summary>Report not initialized.</summary>
        WER_E_NOT_INITIALIZED            = 0x801B8003L,
        /// <summary>Reporting is already in progress for the specified process.</summary>
        WER_E_ALREADY_REPORTING          = 0x801B8004L,
        /// <summary>Dump not generated due to a throttle.</summary>
        WER_E_DUMP_THROTTLED             = 0x801B8005L,
        /// <summary>Operation failed due to insufficient user consent.</summary>
        WER_E_INSUFFICIENT_CONSENT       = 0x801B8006L,
        /// <summary>The IO was completed by a filter.</summary>
        ERROR_FLT_IO_COMPLETE            = 0x001F0001L,
        /// <summary>A handler was not defined by the filter for this operation.</summary>
        ERROR_FLT_NO_HANDLER_DEFINED     = 0x801F0001L,
        /// <summary>A context is already defined for this object.</summary>
        ERROR_FLT_CONTEXT_ALREADY_DEFINED = 0x801F0002L,
        /// <summary>Asynchronous requests are not valid for this operation.</summary>
        ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST = 0x801F0003L,
        /// <summary>Disallow the Fast IO path for this operation.</summary>
        ERROR_FLT_DISALLOW_FAST_IO       = 0x801F0004L,
        /// <summary>An invalid name request was made. The name requested cannot be retrieved at this time.</summary>
        ERROR_FLT_INVALID_NAME_REQUEST   = 0x801F0005L,
        /// <summary>Posting this operation to a worker thread for further processing is not safe at this time because it could lead to a system deadlock.</summary>
        ERROR_FLT_NOT_SAFE_TO_POST_OPERATION = 0x801F0006L,
        /// <summary>The Filter Manager was not initialized when a filter tried to register. Make sure that the Filter Manager is getting loaded as a driver.</summary>
        ERROR_FLT_NOT_INITIALIZED        = 0x801F0007L,
        /// <summary>The filter is not ready for attachment to volumes because it has not finished initializing (FltStartFiltering has not been called).</summary>
        ERROR_FLT_FILTER_NOT_READY       = 0x801F0008L,
        /// <summary>The filter must cleanup any operation specific context at this time because it is being removed from the system before the operation is completed by the lower drivers.</summary>
        ERROR_FLT_POST_OPERATION_CLEANUP = 0x801F0009L,
        /// <summary>The Filter Manager had an internal error from which it cannot recover, therefore the operation has been failed. This is usually the result of a filter returning an invalid value from a pre-operation callback.</summary>
        ERROR_FLT_INTERNAL_ERROR         = 0x801F000AL,
        /// <summary>The object specified for this action is in the process of being deleted, therefore the action requested cannot be completed at this time.</summary>
        ERROR_FLT_DELETING_OBJECT        = 0x801F000BL,
        /// <summary>Non-paged pool must be used for this type of context.</summary>
        ERROR_FLT_MUST_BE_NONPAGED_POOL  = 0x801F000CL,
        /// <summary>A duplicate handler definition has been provided for an operation.</summary>
        ERROR_FLT_DUPLICATE_ENTRY        = 0x801F000DL,
        /// <summary>The callback data queue has been disabled.</summary>
        ERROR_FLT_CBDQ_DISABLED          = 0x801F000EL,
        /// <summary>Do not attach the filter to the volume at this time.</summary>
        ERROR_FLT_DO_NOT_ATTACH          = 0x801F000FL,
        /// <summary>Do not detach the filter from the volume at this time.</summary>
        ERROR_FLT_DO_NOT_DETACH          = 0x801F0010L,
        /// <summary>An instance already exists at this altitude on the volume specified.</summary>
        ERROR_FLT_INSTANCE_ALTITUDE_COLLISION = 0x801F0011L,
        /// <summary>An instance already exists with this name on the volume specified.</summary>
        ERROR_FLT_INSTANCE_NAME_COLLISION = 0x801F0012L,
        /// <summary>The system could not find the filter specified.</summary>
        ERROR_FLT_FILTER_NOT_FOUND       = 0x801F0013L,
        /// <summary>The system could not find the volume specified.</summary>
        ERROR_FLT_VOLUME_NOT_FOUND       = 0x801F0014L,
        /// <summary>The system could not find the instance specified.</summary>
        ERROR_FLT_INSTANCE_NOT_FOUND     = 0x801F0015L,
        /// <summary>No registered context allocation definition was found for the given request.</summary>
        ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND = 0x801F0016L,
        /// <summary>An invalid parameter was specified during context registration.</summary>
        ERROR_FLT_INVALID_CONTEXT_REGISTRATION = 0x801F0017L,
        /// <summary>The name requested was not found in Filter Manager's name cache and could not be retrieved from the file system.</summary>
        ERROR_FLT_NAME_CACHE_MISS        = 0x801F0018L,
        /// <summary>The requested device object does not exist for the given volume.</summary>
        ERROR_FLT_NO_DEVICE_OBJECT       = 0x801F0019L,
        /// <summary>The specified volume is already mounted.</summary>
        ERROR_FLT_VOLUME_ALREADY_MOUNTED = 0x801F001AL,
        /// <summary>The specified Transaction Context is already enlisted in a transaction</summary>
        ERROR_FLT_ALREADY_ENLISTED       = 0x801F001BL,
        /// <summary>The specifiec context is already attached to another object</summary>
        ERROR_FLT_CONTEXT_ALREADY_LINKED = 0x801F001CL,
        /// <summary>No waiter is present for the filter's reply to this message.</summary>
        ERROR_FLT_NO_WAITER_FOR_REPLY    = 0x801F0020L,
        /// <summary>The filesystem database resource is in use. Registration cannot complete at this time.</summary>
        ERROR_FLT_REGISTRATION_BUSY      = 0x801F0023L,
        /// <summary>{Display Driver Stopped Responding} The %hs display driver has stopped working normally. Save your work and reboot the system to restore full display functionality. The next time you reboot the machine a dialog will be displayed giving you a chance to report this failure to Microsoft.</summary>
        ERROR_HUNG_DISPLAY_DRIVER_THREAD = 0x80260001L,
        /// <summary>{Desktop composition is disabled} The operation could not be completed because desktop composition is disabled.</summary>
        DWM_E_COMPOSITIONDISABLED        = 0x80263001L,
        /// <summary>{Some desktop composition APIs are not supported while remoting} The operation is not supported while running in a remote session.</summary>
        DWM_E_REMOTING_NOT_SUPPORTED     = 0x80263002L,
        /// <summary>{No DWM redirection surface is available} The DWM was unable to provide a redireciton surface to complete the DirectX present.</summary>
        DWM_E_NO_REDIRECTION_SURFACE_AVAILABLE = 0x80263003L,
        /// <summary>{DWM is not queuing presents for the specified window} The window specified is not currently using queued presents.</summary>
        DWM_E_NOT_QUEUING_PRESENTS       = 0x80263004L,
        /// <summary>{The adapter specified by the LUID is not found} DWM can not find the adapter specified by the LUID.</summary>
        DWM_E_ADAPTER_NOT_FOUND          = 0x80263005L,
        /// <summary>{GDI redirection surface was returned} GDI redirection surface of the top level window was returned.</summary>
        DWM_S_GDI_REDIRECTION_SURFACE    = 0x00263005L,
        /// <summary>{Redirection surface can not be created.  The size of the surface is larger than what is supported on this machine} Redirection surface can not be created.  The size of the surface is larger than what is supported on this machine.</summary>
        DWM_E_TEXTURE_TOO_LARGE          = 0x80263007L,
        /// <summary>{GDI redirection surface is either on a different adapter or in system memory. Perform blt via GDI} GDI redirection surface is either on a different adapter or in system memory. Perform blt via GDI.</summary>
        DWM_S_GDI_REDIRECTION_SURFACE_BLT_VIA_GDI = 0x00263008L,
        /// <summary>Monitor descriptor could not be obtained.</summary>
        ERROR_MONITOR_NO_DESCRIPTOR      = 0x00261001L,
        /// <summary>Format of the obtained monitor descriptor is not supported by this release.</summary>
        ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT = 0x00261002L,
        /// <summary>Checksum of the obtained monitor descriptor is invalid.</summary>
        ERROR_MONITOR_INVALID_DESCRIPTOR_CHECKSUM = 0xC0261003L,
        /// <summary>Monitor descriptor contains an invalid standard timing block.</summary>
        ERROR_MONITOR_INVALID_STANDARD_TIMING_BLOCK = 0xC0261004L,
        /// <summary>WMI data block registration failed for one of the MSMonitorClass WMI subclasses.</summary>
        ERROR_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED = 0xC0261005L,
        /// <summary>Provided monitor descriptor block is either corrupted or does not contain monitor's detailed serial number.</summary>
        ERROR_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK = 0xC0261006L,
        /// <summary>Provided monitor descriptor block is either corrupted or does not contain monitor's user friendly name.</summary>
        ERROR_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK = 0xC0261007L,
        /// <summary>There is no monitor descriptor data at the specified (offset, size) region.</summary>
        ERROR_MONITOR_NO_MORE_DESCRIPTOR_DATA = 0xC0261008L,
        /// <summary>Monitor descriptor contains an invalid detailed timing block.</summary>
        ERROR_MONITOR_INVALID_DETAILED_TIMING_BLOCK = 0xC0261009L,
        /// <summary>Monitor descriptor contains invalid manufacture date.</summary>
        ERROR_MONITOR_INVALID_MANUFACTURE_DATE = 0xC026100AL,
        /// <summary>Exclusive mode ownership is needed to create unmanaged primary allocation.</summary>
        ERROR_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER = 0xC0262000L,
        /// <summary>The driver needs more DMA buffer space in order to complete the requested operation.</summary>
        ERROR_GRAPHICS_INSUFFICIENT_DMA_BUFFER = 0xC0262001L,
        /// <summary>Specified display adapter handle is invalid.</summary>
        ERROR_GRAPHICS_INVALID_DISPLAY_ADAPTER = 0xC0262002L,
        /// <summary>Specified display adapter and all of its state has been reset.</summary>
        ERROR_GRAPHICS_ADAPTER_WAS_RESET = 0xC0262003L,
        /// <summary>The driver stack doesn't match the expected driver model.</summary>
        ERROR_GRAPHICS_INVALID_DRIVER_MODEL = 0xC0262004L,
        /// <summary>Present happened but ended up into the changed desktop mode</summary>
        ERROR_GRAPHICS_PRESENT_MODE_CHANGED = 0xC0262005L,
        /// <summary>Nothing to present due to desktop occlusion</summary>
        ERROR_GRAPHICS_PRESENT_OCCLUDED  = 0xC0262006L,
        /// <summary>Not able to present due to denial of desktop access</summary>
        ERROR_GRAPHICS_PRESENT_DENIED    = 0xC0262007L,
        /// <summary>Not able to present with color convertion</summary>
        ERROR_GRAPHICS_CANNOTCOLORCONVERT = 0xC0262008L,
        /// <summary>The kernel driver detected a version mismatch between it and the user mode driver.</summary>
        ERROR_GRAPHICS_DRIVER_MISMATCH   = 0xC0262009L,
        /// <summary>Specified buffer is not big enough to contain entire requested dataset. Partial data populated up to the size of the buffer. Caller needs to provide buffer of size as specified in the partially populated buffer's content (interface specific).</summary>
        ERROR_GRAPHICS_PARTIAL_DATA_POPULATED = 0x4026200AL,
        /// <summary>Present redirection is disabled (desktop windowing management subsystem is off).</summary>
        ERROR_GRAPHICS_PRESENT_REDIRECTION_DISABLED = 0xC026200BL,
        /// <summary>Previous exclusive VidPn source owner has released its ownership</summary>
        ERROR_GRAPHICS_PRESENT_UNOCCLUDED = 0xC026200CL,
        /// <summary>Window DC is not available for presentation</summary>
        ERROR_GRAPHICS_WINDOWDC_NOT_AVAILABLE = 0xC026200DL,
        /// <summary>Windowless present is disabled (desktop windowing management subsystem is off).</summary>
        ERROR_GRAPHICS_WINDOWLESS_PRESENT_DISABLED = 0xC026200EL,
        /// <summary>Not enough video memory available to complete the operation.</summary>
        ERROR_GRAPHICS_NO_VIDEO_MEMORY   = 0xC0262100L,
        /// <summary>Couldn't probe and lock the underlying memory of an allocation.</summary>
        ERROR_GRAPHICS_CANT_LOCK_MEMORY  = 0xC0262101L,
        /// <summary>The allocation is currently busy.</summary>
        ERROR_GRAPHICS_ALLOCATION_BUSY   = 0xC0262102L,
        /// <summary>An object being referenced has reach the maximum reference count already and can't be reference further.</summary>
        ERROR_GRAPHICS_TOO_MANY_REFERENCES = 0xC0262103L,
        /// <summary>A problem couldn't be solved due to some currently existing condition. The problem should be tried again later.</summary>
        ERROR_GRAPHICS_TRY_AGAIN_LATER   = 0xC0262104L,
        /// <summary>A problem couldn't be solved due to some currently existing condition. The problem should be tried again immediately.</summary>
        ERROR_GRAPHICS_TRY_AGAIN_NOW     = 0xC0262105L,
        /// <summary>The allocation is invalid.</summary>
        ERROR_GRAPHICS_ALLOCATION_INVALID = 0xC0262106L,
        /// <summary>No more unswizzling aperture are currently available.</summary>
        ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE = 0xC0262107L,
        /// <summary>The current allocation can't be unswizzled by an aperture.</summary>
        ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED = 0xC0262108L,
        /// <summary>The request failed because a pinned allocation can't be evicted.</summary>
        ERROR_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION = 0xC0262109L,
        /// <summary>The allocation can't be used from its current segment location for the specified operation.</summary>
        ERROR_GRAPHICS_INVALID_ALLOCATION_USAGE = 0xC0262110L,
        /// <summary>A locked allocation can't be used in the current command buffer.</summary>
        ERROR_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION = 0xC0262111L,
        /// <summary>The allocation being referenced has been closed permanently.</summary>
        ERROR_GRAPHICS_ALLOCATION_CLOSED = 0xC0262112L,
        /// <summary>An invalid allocation instance is being referenced.</summary>
        ERROR_GRAPHICS_INVALID_ALLOCATION_INSTANCE = 0xC0262113L,
        /// <summary>An invalid allocation handle is being referenced.</summary>
        ERROR_GRAPHICS_INVALID_ALLOCATION_HANDLE = 0xC0262114L,
        /// <summary>The allocation being referenced doesn't belong to the current device.</summary>
        ERROR_GRAPHICS_WRONG_ALLOCATION_DEVICE = 0xC0262115L,
        /// <summary>The specified allocation lost its content.</summary>
        ERROR_GRAPHICS_ALLOCATION_CONTENT_LOST = 0xC0262116L,
        /// <summary>GPU exception is detected on the given device. The device is not able to be scheduled.</summary>
        ERROR_GRAPHICS_GPU_EXCEPTION_ON_DEVICE = 0xC0262200L,
        /// <summary>Skip preparation of allocations referenced by the DMA buffer.</summary>
        ERROR_GRAPHICS_SKIP_ALLOCATION_PREPARATION = 0x40262201L,
        /// <summary>Specified VidPN topology is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY = 0xC0262300L,
        /// <summary>Specified VidPN topology is valid but is not supported by this model of the display adapter.</summary>
        ERROR_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED = 0xC0262301L,
        /// <summary>Specified VidPN topology is valid but is not supported by the display adapter at this time, due to current allocation of its resources.</summary>
        ERROR_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED = 0xC0262302L,
        /// <summary>Specified VidPN handle is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDPN     = 0xC0262303L,
        /// <summary>Specified video present source is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE = 0xC0262304L,
        /// <summary>Specified video present target is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET = 0xC0262305L,
        /// <summary>Specified VidPN modality is not supported (e.g. at least two of the pinned modes are not cofunctional).</summary>
        ERROR_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED = 0xC0262306L,
        /// <summary>No mode is pinned on the specified VidPN source/target.</summary>
        ERROR_GRAPHICS_MODE_NOT_PINNED   = 0x00262307L,
        /// <summary>Specified VidPN source mode set is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDPN_SOURCEMODESET = 0xC0262308L,
        /// <summary>Specified VidPN target mode set is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDPN_TARGETMODESET = 0xC0262309L,
        /// <summary>Specified video signal frequency is invalid.</summary>
        ERROR_GRAPHICS_INVALID_FREQUENCY = 0xC026230AL,
        /// <summary>Specified video signal active region is invalid.</summary>
        ERROR_GRAPHICS_INVALID_ACTIVE_REGION = 0xC026230BL,
        /// <summary>Specified video signal total region is invalid.</summary>
        ERROR_GRAPHICS_INVALID_TOTAL_REGION = 0xC026230CL,
        /// <summary>Specified video present source mode is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE = 0xC0262310L,
        /// <summary>Specified video present target mode is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE = 0xC0262311L,
        /// <summary>Pinned mode must remain in the set on VidPN's cofunctional modality enumeration.</summary>
        ERROR_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET = 0xC0262312L,
        /// <summary>Specified video present path is already in VidPN's topology.</summary>
        ERROR_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY = 0xC0262313L,
        /// <summary>Specified mode is already in the mode set.</summary>
        ERROR_GRAPHICS_MODE_ALREADY_IN_MODESET = 0xC0262314L,
        /// <summary>Specified video present source set is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET = 0xC0262315L,
        /// <summary>Specified video present target set is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET = 0xC0262316L,
        /// <summary>Specified video present source is already in the video present source set.</summary>
        ERROR_GRAPHICS_SOURCE_ALREADY_IN_SET = 0xC0262317L,
        /// <summary>Specified video present target is already in the video present target set.</summary>
        ERROR_GRAPHICS_TARGET_ALREADY_IN_SET = 0xC0262318L,
        /// <summary>Specified VidPN present path is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDPN_PRESENT_PATH = 0xC0262319L,
        /// <summary>Miniport has no recommendation for augmentation of the specified VidPN's topology.</summary>
        ERROR_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY = 0xC026231AL,
        /// <summary>Specified monitor frequency range set is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET = 0xC026231BL,
        /// <summary>Specified monitor frequency range is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE = 0xC026231CL,
        /// <summary>Specified frequency range is not in the specified monitor frequency range set.</summary>
        ERROR_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET = 0xC026231DL,
        /// <summary>Specified mode set does not specify preference for one of its modes.</summary>
        ERROR_GRAPHICS_NO_PREFERRED_MODE = 0x0026231EL,
        /// <summary>Specified frequency range is already in the specified monitor frequency range set.</summary>
        ERROR_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET = 0xC026231FL,
        /// <summary>Specified mode set is stale. Please reacquire the new mode set.</summary>
        ERROR_GRAPHICS_STALE_MODESET     = 0xC0262320L,
        /// <summary>Specified monitor source mode set is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITOR_SOURCEMODESET = 0xC0262321L,
        /// <summary>Specified monitor source mode is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITOR_SOURCE_MODE = 0xC0262322L,
        /// <summary>Miniport does not have any recommendation regarding the request to provide a functional VidPN given the current display adapter configuration.</summary>
        ERROR_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN = 0xC0262323L,
        /// <summary>ID of the specified mode is already used by another mode in the set.</summary>
        ERROR_GRAPHICS_MODE_ID_MUST_BE_UNIQUE = 0xC0262324L,
        /// <summary>System failed to determine a mode that is supported by both the display adapter and the monitor connected to it.</summary>
        ERROR_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION = 0xC0262325L,
        /// <summary>Number of video present targets must be greater than or equal to the number of video present sources.</summary>
        ERROR_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES = 0xC0262326L,
        /// <summary>Specified present path is not in VidPN's topology.</summary>
        ERROR_GRAPHICS_PATH_NOT_IN_TOPOLOGY = 0xC0262327L,
        /// <summary>Display adapter must have at least one video present source.</summary>
        ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE = 0xC0262328L,
        /// <summary>Display adapter must have at least one video present target.</summary>
        ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET = 0xC0262329L,
        /// <summary>Specified monitor descriptor set is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITORDESCRIPTORSET = 0xC026232AL,
        /// <summary>Specified monitor descriptor is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITORDESCRIPTOR = 0xC026232BL,
        /// <summary>Specified descriptor is not in the specified monitor descriptor set.</summary>
        ERROR_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET = 0xC026232CL,
        /// <summary>Specified descriptor is already in the specified monitor descriptor set.</summary>
        ERROR_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET = 0xC026232DL,
        /// <summary>ID of the specified monitor descriptor is already used by another descriptor in the set.</summary>
        ERROR_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE = 0xC026232EL,
        /// <summary>Specified video present target subset type is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE = 0xC026232FL,
        /// <summary>Two or more of the specified resources are not related to each other, as defined by the interface semantics.</summary>
        ERROR_GRAPHICS_RESOURCES_NOT_RELATED = 0xC0262330L,
        /// <summary>ID of the specified video present source is already used by another source in the set.</summary>
        ERROR_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE = 0xC0262331L,
        /// <summary>ID of the specified video present target is already used by another target in the set.</summary>
        ERROR_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE = 0xC0262332L,
        /// <summary>Specified VidPN source cannot be used because there is no available VidPN target to connect it to.</summary>
        ERROR_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET = 0xC0262333L,
        /// <summary>Newly arrived monitor could not be associated with a display adapter.</summary>
        ERROR_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER = 0xC0262334L,
        /// <summary>Display adapter in question does not have an associated VidPN manager.</summary>
        ERROR_GRAPHICS_NO_VIDPNMGR       = 0xC0262335L,
        /// <summary>VidPN manager of the display adapter in question does not have an active VidPN.</summary>
        ERROR_GRAPHICS_NO_ACTIVE_VIDPN   = 0xC0262336L,
        /// <summary>Specified VidPN topology is stale. Please reacquire the new topology.</summary>
        ERROR_GRAPHICS_STALE_VIDPN_TOPOLOGY = 0xC0262337L,
        /// <summary>There is no monitor connected on the specified video present target.</summary>
        ERROR_GRAPHICS_MONITOR_NOT_CONNECTED = 0xC0262338L,
        /// <summary>Specified source is not part of the specified VidPN's topology.</summary>
        ERROR_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY = 0xC0262339L,
        /// <summary>Specified primary surface size is invalid.</summary>
        ERROR_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE = 0xC026233AL,
        /// <summary>Specified visible region size is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VISIBLEREGION_SIZE = 0xC026233BL,
        /// <summary>Specified stride is invalid.</summary>
        ERROR_GRAPHICS_INVALID_STRIDE    = 0xC026233CL,
        /// <summary>Specified pixel format is invalid.</summary>
        ERROR_GRAPHICS_INVALID_PIXELFORMAT = 0xC026233DL,
        /// <summary>Specified color basis is invalid.</summary>
        ERROR_GRAPHICS_INVALID_COLORBASIS = 0xC026233EL,
        /// <summary>Specified pixel value access mode is invalid.</summary>
        ERROR_GRAPHICS_INVALID_PIXELVALUEACCESSMODE = 0xC026233FL,
        /// <summary>Specified target is not part of the specified VidPN's topology.</summary>
        ERROR_GRAPHICS_TARGET_NOT_IN_TOPOLOGY = 0xC0262340L,
        /// <summary>Failed to acquire display mode management interface.</summary>
        ERROR_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT = 0xC0262341L,
        /// <summary>Specified VidPN source is already owned by a DMM client and cannot be used until that client releases it.</summary>
        ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = 0xC0262342L,
        /// <summary>Specified VidPN is active and cannot be accessed.</summary>
        ERROR_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN = 0xC0262343L,
        /// <summary>Specified VidPN present path importance ordinal is invalid.</summary>
        ERROR_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL = 0xC0262344L,
        /// <summary>Specified VidPN present path content geometry transformation is invalid.</summary>
        ERROR_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION = 0xC0262345L,
        /// <summary>Specified content geometry transformation is not supported on the respective VidPN present path.</summary>
        ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED = 0xC0262346L,
        /// <summary>Specified gamma ramp is invalid.</summary>
        ERROR_GRAPHICS_INVALID_GAMMA_RAMP = 0xC0262347L,
        /// <summary>Specified gamma ramp is not supported on the respective VidPN present path.</summary>
        ERROR_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED = 0xC0262348L,
        /// <summary>Multi-sampling is not supported on the respective VidPN present path.</summary>
        ERROR_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED = 0xC0262349L,
        /// <summary>Specified mode is not in the specified mode set.</summary>
        ERROR_GRAPHICS_MODE_NOT_IN_MODESET = 0xC026234AL,
        /// <summary>Specified data set (e.g. mode set, frequency range set, descriptor set, topology, etc.) is empty.</summary>
        ERROR_GRAPHICS_DATASET_IS_EMPTY  = 0x0026234BL,
        /// <summary>Specified data set (e.g. mode set, frequency range set, descriptor set, topology, etc.) does not contain any more elements.</summary>
        ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET = 0x0026234CL,
        /// <summary>Specified VidPN topology recommendation reason is invalid.</summary>
        ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON = 0xC026234DL,
        /// <summary>Specified VidPN present path content type is invalid.</summary>
        ERROR_GRAPHICS_INVALID_PATH_CONTENT_TYPE = 0xC026234EL,
        /// <summary>Specified VidPN present path copy protection type is invalid.</summary>
        ERROR_GRAPHICS_INVALID_COPYPROTECTION_TYPE = 0xC026234FL,
        /// <summary>No more than one unassigned mode set can exist at any given time for a given VidPN source/target.</summary>
        ERROR_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS = 0xC0262350L,
        /// <summary>Specified content transformation is not pinned on the specified VidPN present path.</summary>
        ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED = 0x00262351L,
        /// <summary>Specified scanline ordering type is invalid.</summary>
        ERROR_GRAPHICS_INVALID_SCANLINE_ORDERING = 0xC0262352L,
        /// <summary>Topology changes are not allowed for the specified VidPN.</summary>
        ERROR_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED = 0xC0262353L,
        /// <summary>All available importance ordinals are already used in specified topology.</summary>
        ERROR_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS = 0xC0262354L,
        /// <summary>Specified primary surface has a different private format attribute than the current primary surface</summary>
        ERROR_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT = 0xC0262355L,
        /// <summary>Specified mode pruning algorithm is invalid</summary>
        ERROR_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM = 0xC0262356L,
        /// <summary>Specified monitor capability origin is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN = 0xC0262357L,
        /// <summary>Specified monitor frequency range constraint is invalid.</summary>
        ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT = 0xC0262358L,
        /// <summary>Maximum supported number of present paths has been reached.</summary>
        ERROR_GRAPHICS_MAX_NUM_PATHS_REACHED = 0xC0262359L,
        /// <summary>Miniport requested that augmentation be cancelled for the specified source of the specified VidPN's topology.</summary>
        ERROR_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION = 0xC026235AL,
        /// <summary>Specified client type was not recognized.</summary>
        ERROR_GRAPHICS_INVALID_CLIENT_TYPE = 0xC026235BL,
        /// <summary>Client VidPN is not set on this adapter (e.g. no user mode initiated mode changes took place on this adapter yet).</summary>
        ERROR_GRAPHICS_CLIENTVIDPN_NOT_SET = 0xC026235CL,
        /// <summary>Specified display adapter child device already has an external device connected to it.</summary>
        ERROR_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED = 0xC0262400L,    
        /// <summary>Specified display adapter child device does not support descriptor exposure.</summary>
        ERROR_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED = 0xC0262401L,    
        /// <summary>Child device presence was not reliably detected.</summary>
        ERROR_GRAPHICS_UNKNOWN_CHILD_STATUS = 0x4026242FL,
        /// <summary>The display adapter is not linked to any other adapters.</summary>
        ERROR_GRAPHICS_NOT_A_LINKED_ADAPTER = 0xC0262430L,
        /// <summary>Lead adapter in a linked configuration was not enumerated yet.</summary>
        ERROR_GRAPHICS_LEADLINK_NOT_ENUMERATED = 0xC0262431L,
        /// <summary>Some chain adapters in a linked configuration were not enumerated yet.</summary>
        ERROR_GRAPHICS_CHAINLINKS_NOT_ENUMERATED = 0xC0262432L,
        /// <summary>The chain of linked adapters is not ready to start because of an unknown failure.</summary>
        ERROR_GRAPHICS_ADAPTER_CHAIN_NOT_READY = 0xC0262433L,
        /// <summary>An attempt was made to start a lead link display adapter when the chain links were not started yet.</summary>
        ERROR_GRAPHICS_CHAINLINKS_NOT_STARTED = 0xC0262434L,
        /// <summary>An attempt was made to power up a lead link display adapter when the chain links were powered down.</summary>
        ERROR_GRAPHICS_CHAINLINKS_NOT_POWERED_ON = 0xC0262435L,
        /// <summary>The adapter link was found to be in an inconsistent state. Not all adapters are in an expected PNP/Power state.</summary>
        ERROR_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE = 0xC0262436L,
        /// <summary>Starting the leadlink adapter has been deferred temporarily.</summary>
        ERROR_GRAPHICS_LEADLINK_START_DEFERRED = 0x40262437L,
        /// <summary>The driver trying to start is not the same as the driver for the POSTed display adapter.</summary>
        ERROR_GRAPHICS_NOT_POST_DEVICE_DRIVER = 0xC0262438L,
        /// <summary>The display adapter is being polled for children too frequently at the same polling level.</summary>
        ERROR_GRAPHICS_POLLING_TOO_FREQUENTLY = 0x40262439L,
        /// <summary>Starting the adapter has been deferred temporarily.</summary>
        ERROR_GRAPHICS_START_DEFERRED    = 0x4026243AL,
        /// <summary>An operation is being attempted that requires the display adapter to be in a quiescent state.</summary>
        ERROR_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED = 0xC026243BL,
        /// <summary>We can depend on the child device presence returned by the driver.</summary>
        ERROR_GRAPHICS_DEPENDABLE_CHILD_STATUS = 0x4026243CL,
        /// <summary>The driver does not support OPM.</summary>
        ERROR_GRAPHICS_OPM_NOT_SUPPORTED = 0xC0262500L,    
        /// <summary>The driver does not support COPP.</summary>
        ERROR_GRAPHICS_COPP_NOT_SUPPORTED = 0xC0262501L,    
        /// <summary>The driver does not support UAB.</summary>
        ERROR_GRAPHICS_UAB_NOT_SUPPORTED = 0xC0262502L,    
        /// <summary>The specified encrypted parameters are invalid.</summary>
        ERROR_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS = 0xC0262503L,    
        /// <summary>The GDI display device passed to this function does not have any active video outputs.</summary>
        ERROR_GRAPHICS_OPM_NO_VIDEO_OUTPUTS_EXIST = 0xC0262505L,
        /// <summary>An internal error caused this operation to fail.</summary>
        ERROR_GRAPHICS_OPM_INTERNAL_ERROR = 0xC026250BL,
        /// <summary>The function failed because the caller passed in an invalid OPM user mode handle.</summary>
        ERROR_GRAPHICS_OPM_INVALID_HANDLE = 0xC026250CL,
        /// <summary>A certificate could not be returned because the certificate buffer passed to the function was too small.</summary>
        ERROR_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH = 0xC026250EL,
        /// <summary>A video output could not be created because the frame buffer is in spanning mode.</summary>
        ERROR_GRAPHICS_OPM_SPANNING_MODE_ENABLED = 0xC026250FL,
        /// <summary>A video output could not be created because the frame buffer is in theater mode.</summary>
        ERROR_GRAPHICS_OPM_THEATER_MODE_ENABLED = 0xC0262510L,
        /// <summary>The function failed because the display adapter's Hardware Functionality Scan failed to validate the graphics hardware.</summary>
        ERROR_GRAPHICS_PVP_HFS_FAILED    = 0xC0262511L,
        /// <summary>The HDCP System Renewability Message passed to this function did not comply with section 5 of the HDCP 1.1 specification.</summary>
        ERROR_GRAPHICS_OPM_INVALID_SRM   = 0xC0262512L,
        /// <summary>The video output cannot enable the High-bandwidth Digital Content Protection (HDCP) System because it does not support HDCP.</summary>
        ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP = 0xC0262513L,
        /// <summary>The video output cannot enable Analogue Copy Protection (ACP) because it does not support ACP.</summary>
        ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP = 0xC0262514L,
        /// <summary>The video output cannot enable the Content Generation Management System Analogue (CGMS-A) protection technology because it does not support CGMS-A.</summary>
        ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA = 0xC0262515L,
        /// <summary>The IOPMVideoOutput::GetInformation method cannot return the version of the SRM being used because the application never successfully passed an SRM to the video output.</summary>
        ERROR_GRAPHICS_OPM_HDCP_SRM_NEVER_SET = 0xC0262516L,
        /// <summary>The IOPMVideoOutput::Configure method cannot enable the specified output protection technology because the output's screen resolution is too high.</summary>
        ERROR_GRAPHICS_OPM_RESOLUTION_TOO_HIGH = 0xC0262517L,
        /// <summary>The IOPMVideoOutput::Configure method cannot enable HDCP because the display adapter's HDCP hardware is already being used by other physical outputs.</summary>
        ERROR_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE = 0xC0262518L,
        /// <summary>The operating system asynchronously destroyed this OPM video output because the operating system's state changed. This error typically occurs because the monitor PDO associated with this video output was removed, the monitor PDO associated with this video output was stopped, the video output's session became a non-console session or the video output's desktop became an inactive desktop.</summary>
        ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_NO_LONGER_EXISTS = 0xC026251AL,
        /// <summary>The method failed because the session is changing its type. No IOPMVideoOutput methods can be called when a session is changing its type. There are currently three types of sessions: console, disconnected and remote.</summary>
        ERROR_GRAPHICS_OPM_SESSION_TYPE_CHANGE_IN_PROGRESS = 0xC026251BL,
        /// <summary>Either the IOPMVideoOutput::COPPCompatibleGetInformation, IOPMVideoOutput::GetInformation, or IOPMVideoOutput::Configure method failed. This error is returned when the caller tries to use a COPP specific command while the video output has OPM semantics only.</summary>
        ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS = 0xC026251CL,
        /// <summary>The IOPMVideoOutput::GetInformation and IOPMVideoOutput::COPPCompatibleGetInformation methods return this error if the passed in sequence number is not the expected sequence number or the passed in OMAC value is invalid.</summary>
        ERROR_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST = 0xC026251DL,
        /// <summary>The method failed because an unexpected error occurred inside of a display driver.</summary>
        ERROR_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR = 0xC026251EL,
        /// <summary>Either the IOPMVideoOutput::COPPCompatibleGetInformation, IOPMVideoOutput::GetInformation, or IOPMVideoOutput::Configure method failed. This error is returned when the caller tries to use an OPM specific command while the video output has COPP semantics only.</summary>
        ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS = 0xC026251FL,
        /// <summary>The IOPMVideoOutput::COPPCompatibleGetInformation or IOPMVideoOutput::Configure method failed because the display driver does not support the OPM_GET_ACP_AND_CGMSA_SIGNALING and OPM_SET_ACP_AND_CGMSA_SIGNALING GUIDs.</summary>
        ERROR_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED = 0xC0262520L,
        /// <summary>The IOPMVideoOutput::Configure function returns this error code if the passed in sequence number is not the expected sequence number or the passed in OMAC value is invalid.</summary>
        ERROR_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST = 0xC0262521L,
        /// <summary>The monitor connected to the specified video output does not have an I2C bus.</summary>
        ERROR_GRAPHICS_I2C_NOT_SUPPORTED = 0xC0262580L,    
        /// <summary>No device on the I2C bus has the specified address.</summary>
        ERROR_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST = 0xC0262581L,    
        /// <summary>An error occurred while transmitting data to the device on the I2C bus.</summary>
        ERROR_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA = 0xC0262582L,    
        /// <summary>An error occurred while receiving data from the device on the I2C bus.</summary>
        ERROR_GRAPHICS_I2C_ERROR_RECEIVING_DATA = 0xC0262583L,    
        /// <summary>The monitor does not support the specified VCP code.</summary>
        ERROR_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED = 0xC0262584L,    
        /// <summary>The data received from the monitor is invalid.</summary>
        ERROR_GRAPHICS_DDCCI_INVALID_DATA = 0xC0262585L,    
        /// <summary>The function failed because a monitor returned an invalid Timing Status byte when the operating system used the DDC/CI Get Timing Report & Timing Message command to get a timing report from a monitor.</summary>
        ERROR_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE = 0xC0262586L,
        /// <summary>The monitor returned a DDC/CI capabilities string which did not comply with the ACCESS.bus 3.0, DDC/CI 1.1, or MCCS 2 Revision 1 specification.</summary>
        ERROR_GRAPHICS_MCA_INVALID_CAPABILITIES_STRING = 0xC0262587L,
        /// <summary>An internal Monitor Configuration API error occurred.</summary>
        ERROR_GRAPHICS_MCA_INTERNAL_ERROR = 0xC0262588L,
        /// <summary>An operation failed because a DDC/CI message had an invalid value in its command field.</summary>
        ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND = 0xC0262589L,
        /// <summary>An error occurred because the field length of a DDC/CI message contained an invalid value.</summary>
        ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH = 0xC026258AL,
        /// <summary>An error occurred because the checksum field in a DDC/CI message did not match the message's computed checksum value. This error implies that the data was corrupted while it was being transmitted from a monitor to a computer.</summary>
        ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM = 0xC026258BL,
        /// <summary>This function failed because an invalid monitor handle was passed to it.</summary>
        ERROR_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE = 0xC026258CL,
        /// <summary>The operating system asynchronously destroyed the monitor which corresponds to this handle because the operating system's state changed. This error typically occurs because the monitor PDO associated with this handle was removed, the monitor PDO associated with this handle was stopped, or a display mode change occurred. A display mode change occurs when windows sends a WM_DISPLAYCHANGE windows message to applications.</summary>
        ERROR_GRAPHICS_MONITOR_NO_LONGER_EXISTS = 0xC026258DL,
        /// <summary>A continuous VCP code's current value is greater than its maximum value. This error code indicates that a monitor returned an invalid value.</summary>
        ERROR_GRAPHICS_DDCCI_CURRENT_CURRENT_VALUE_GREATER_THAN_MAXIMUM_VALUE = 0xC02625D8L,
        /// <summary>The monitor's VCP Version (0xDF) VCP code returned an invalid version value.</summary>
        ERROR_GRAPHICS_MCA_INVALID_VCP_VERSION = 0xC02625D9L,
        /// <summary>The monitor does not comply with the MCCS specification it claims to support.</summary>
        ERROR_GRAPHICS_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION = 0xC02625DAL,
        /// <summary>The MCCS version in a monitor's mccs_ver capability does not match the MCCS version the monitor reports when the VCP Version (0xDF) VCP code is used.</summary>
        ERROR_GRAPHICS_MCA_MCCS_VERSION_MISMATCH = 0xC02625DBL,
        /// <summary>The Monitor Configuration API only works with monitors which support the MCCS 1.0 specification, MCCS 2.0 specification or the MCCS 2.0 Revision 1 specification.</summary>
        ERROR_GRAPHICS_MCA_UNSUPPORTED_MCCS_VERSION = 0xC02625DCL,
        /// <summary>The monitor returned an invalid monitor technology type. CRT, Plasma and LCD (TFT) are examples of monitor technology types. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.</summary>
        ERROR_GRAPHICS_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED = 0xC02625DEL,
        /// <summary>SetMonitorColorTemperature()'s caller passed a color temperature to it which the current monitor did not support. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.</summary>
        ERROR_GRAPHICS_MCA_UNSUPPORTED_COLOR_TEMPERATURE = 0xC02625DFL,
        /// <summary>This function can only be used if a program is running in the local console session. It cannot be used if the program is running on a remote desktop session or on a terminal server session.</summary>
        ERROR_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED = 0xC02625E0L,
        /// <summary>This function cannot find an actual GDI display device which corresponds to the specified GDI display device name.</summary>
        ERROR_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME = 0xC02625E1L,
        /// <summary>The function failed because the specified GDI display device was not attached to the Windows desktop.</summary>
        ERROR_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP = 0xC02625E2L,
        /// <summary>This function does not support GDI mirroring display devices because GDI mirroring display devices do not have any physical monitors associated with them.</summary>
        ERROR_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED = 0xC02625E3L,
        /// <summary>The function failed because an invalid pointer parameter was passed to it. A pointer parameter is invalid if it is NULL, points to an invalid address, points to a kernel mode address, or is not correctly aligned.</summary>
        ERROR_GRAPHICS_INVALID_POINTER   = 0xC02625E4L,
        /// <summary>The function failed because the specified GDI device did not have any monitors associated with it.</summary>
        ERROR_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE = 0xC02625E5L,
        /// <summary>An array passed to the function cannot hold all of the data that the function must copy into the array.</summary>
        ERROR_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL = 0xC02625E6L,
        /// <summary>An internal error caused an operation to fail.</summary>
        ERROR_GRAPHICS_INTERNAL_ERROR    = 0xC02625E7L,
        /// <summary>The function failed because the current session is changing its type. This function cannot be called when the current session is changing its type. There are currently three types of sessions: console, disconnected and remote.</summary>
        ERROR_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS = 0xC02605E8L,
        /// <summary>The NAP SoH packet is invalid.</summary>
        NAP_E_INVALID_PACKET             = 0x80270001L,
        /// <summary>An SoH was missing from the NAP packet.</summary>
        NAP_E_MISSING_SOH                = 0x80270002L,
        /// <summary>The entity ID conflicts with an already registered id.</summary>
        NAP_E_CONFLICTING_ID             = 0x80270003L,
        /// <summary>No cached SoH is present.</summary>
        NAP_E_NO_CACHED_SOH              = 0x80270004L,
        /// <summary>The entity is still bound to the NAP system.</summary>
        NAP_E_STILL_BOUND                = 0x80270005L,
        /// <summary>The entity is not registered with the NAP system.</summary>
        NAP_E_NOT_REGISTERED             = 0x80270006L,
        /// <summary>The entity is not initialized with the NAP system.</summary>
        NAP_E_NOT_INITIALIZED            = 0x80270007L,
        /// <summary>The correlation id in the SoH-Request and SoH-Response do not match up.</summary>
        NAP_E_MISMATCHED_ID              = 0x80270008L,
        /// <summary>Completion was indicated on a request that is not currently pending.</summary>
        NAP_E_NOT_PENDING                = 0x80270009L,
        /// <summary>The NAP component's id was not found.</summary>
        NAP_E_ID_NOT_FOUND               = 0x8027000AL,
        /// <summary>The maximum size of the connection is too small for an SoH packet.</summary>
        NAP_E_MAXSIZE_TOO_SMALL          = 0x8027000BL,
        /// <summary>The NapAgent service is not running.</summary>
        NAP_E_SERVICE_NOT_RUNNING        = 0x8027000CL,
        /// <summary>A certificate is already present in the cert store.</summary>
        NAP_S_CERT_ALREADY_PRESENT       = 0x0027000DL,
        /// <summary>The entity is disabled with the NapAgent service.</summary>
        NAP_E_ENTITY_DISABLED            = 0x8027000EL,
        /// <summary>Group Policy is not configured.</summary>
        NAP_E_NETSH_GROUPPOLICY_ERROR    = 0x8027000FL,
        /// <summary>Too many simultaneous calls.</summary>
        NAP_E_TOO_MANY_CALLS             = 0x80270010L,
        /// <summary>SHV configuration already existed.</summary>
        NAP_E_SHV_CONFIG_EXISTED         = 0x80270011L,
        /// <summary>SHV configuration is not found.</summary>
        NAP_E_SHV_CONFIG_NOT_FOUND       = 0x80270012L,
        /// <summary>SHV timed out on the request.</summary>
        NAP_E_SHV_TIMEOUT                = 0x80270013L,
        /// <summary>This is an error mask to convert TPM hardware errors to win errors.</summary>
        TPM_E_ERROR_MASK                 = 0x80280000L,
        /// <summary>Authentication failed.</summary>
        TPM_E_AUTHFAIL                   = 0x80280001L,
        /// <summary>The index to a PCR, DIR or other register is incorrect.</summary>
        TPM_E_BADINDEX                   = 0x80280002L,
        /// <summary>One or more parameter is bad.</summary>
        TPM_E_BAD_PARAMETER              = 0x80280003L,
        /// <summary>An operation completed successfully but the auditing of that operation failed.</summary>
        TPM_E_AUDITFAILURE               = 0x80280004L,
        /// <summary>The clear disable flag is set and all clear operations now require physical access.</summary>
        TPM_E_CLEAR_DISABLED             = 0x80280005L,
        /// <summary>Activate the Trusted Platform Module (TPM).</summary>
        TPM_E_DEACTIVATED                = 0x80280006L,
        /// <summary>Enable the Trusted Platform Module (TPM).</summary>
        TPM_E_DISABLED                   = 0x80280007L,
        /// <summary>The target command has been disabled.</summary>
        TPM_E_DISABLED_CMD               = 0x80280008L,
        /// <summary>The operation failed.</summary>
        TPM_E_FAIL                       = 0x80280009L,
        /// <summary>The ordinal was unknown or inconsistent.</summary>
        TPM_E_BAD_ORDINAL                = 0x8028000AL,
        /// <summary>The ability to install an owner is disabled.</summary>
        TPM_E_INSTALL_DISABLED           = 0x8028000BL,
        /// <summary>The key handle cannot be interpreted.</summary>
        TPM_E_INVALID_KEYHANDLE          = 0x8028000CL,
        /// <summary>The key handle points to an invalid key.</summary>
        TPM_E_KEYNOTFOUND                = 0x8028000DL,
        /// <summary>Unacceptable encryption scheme.</summary>
        TPM_E_INAPPROPRIATE_ENC          = 0x8028000EL,
        /// <summary>Migration authorization failed.</summary>
        TPM_E_MIGRATEFAIL                = 0x8028000FL,
        /// <summary>PCR information could not be interpreted.</summary>
        TPM_E_INVALID_PCR_INFO           = 0x80280010L,
        /// <summary>No room to load key.</summary>
        TPM_E_NOSPACE                    = 0x80280011L,
        /// <summary>There is no Storage Root Key (SRK) set.</summary>
        TPM_E_NOSRK                      = 0x80280012L,
        /// <summary>An encrypted blob is invalid or was not created by this TPM.</summary>
        TPM_E_NOTSEALED_BLOB             = 0x80280013L,
        /// <summary>The Trusted Platform Module (TPM) already has an owner.</summary>
        TPM_E_OWNER_SET                  = 0x80280014L,
        /// <summary>The TPM has insufficient internal resources to perform the requested action.</summary>
        TPM_E_RESOURCES                  = 0x80280015L,
        /// <summary>A random string was too short.</summary>
        TPM_E_SHORTRANDOM                = 0x80280016L,
        /// <summary>The TPM does not have the space to perform the operation.</summary>
        TPM_E_SIZE                       = 0x80280017L,
        /// <summary>The named PCR value does not match the current PCR value.</summary>
        TPM_E_WRONGPCRVAL                = 0x80280018L,
        /// <summary>The paramSize argument to the command has the incorrect value .</summary>
        TPM_E_BAD_PARAM_SIZE             = 0x80280019L,
        /// <summary>There is no existing SHA-1 thread.</summary>
        TPM_E_SHA_THREAD                 = 0x8028001AL,
        /// <summary>The calculation is unable to proceed because the existing SHA-1 thread has already encountered an error.</summary>
        TPM_E_SHA_ERROR                  = 0x8028001BL,
        /// <summary>The TPM hardware device reported a failure during its internal self test. Try restarting the computer to resolve the problem. If the problem continues, check for the latest BIOS or firmware update for your TPM hardware. Consult the computer manufacturer's documentation for instructions.</summary>
        TPM_E_FAILEDSELFTEST             = 0x8028001CL,
        /// <summary>The authorization for the second key in a 2 key function failed authorization.</summary>
        TPM_E_AUTH2FAIL                  = 0x8028001DL,
        /// <summary>The tag value sent to for a command is invalid.</summary>
        TPM_E_BADTAG                     = 0x8028001EL,
        /// <summary>An IO error occurred transmitting information to the TPM.</summary>
        TPM_E_IOERROR                    = 0x8028001FL,
        /// <summary>The encryption process had a problem.</summary>
        TPM_E_ENCRYPT_ERROR              = 0x80280020L,
        /// <summary>The decryption process did not complete.</summary>
        TPM_E_DECRYPT_ERROR              = 0x80280021L,
        /// <summary>An invalid handle was used.</summary>
        TPM_E_INVALID_AUTHHANDLE         = 0x80280022L,
        /// <summary>The TPM does not have an Endorsement Key (EK) installed.</summary>
        TPM_E_NO_ENDORSEMENT             = 0x80280023L,
        /// <summary>The usage of a key is not allowed.</summary>
        TPM_E_INVALID_KEYUSAGE           = 0x80280024L,
        /// <summary>The submitted entity type is not allowed.</summary>
        TPM_E_WRONG_ENTITYTYPE           = 0x80280025L,
        /// <summary>The command was received in the wrong sequence relative to TPM_Init and a subsequent TPM_Startup.</summary>
        TPM_E_INVALID_POSTINIT           = 0x80280026L,
        /// <summary>Signed data cannot include additional DER information.</summary>
        TPM_E_INAPPROPRIATE_SIG          = 0x80280027L,
        /// <summary>The key properties in TPM_KEY_PARMs are not supported by this TPM.</summary>
        TPM_E_BAD_KEY_PROPERTY           = 0x80280028L,
        /// <summary>The migration properties of this key are incorrect.</summary>
        TPM_E_BAD_MIGRATION              = 0x80280029L,
        /// <summary>The signature or encryption scheme for this key is incorrect or not permitted in this situation.</summary>
        TPM_E_BAD_SCHEME                 = 0x8028002AL,
        /// <summary>The size of the data (or blob) parameter is bad or inconsistent with the referenced key.</summary>
        TPM_E_BAD_DATASIZE               = 0x8028002BL,
        /// <summary>A mode parameter is bad, such as capArea or subCapArea for TPM_GetCapability, phsicalPresence parameter for TPM_PhysicalPresence, or migrationType for TPM_CreateMigrationBlob.</summary>
        TPM_E_BAD_MODE                   = 0x8028002CL,
        /// <summary>Either the physicalPresence or physicalPresenceLock bits have the wrong value.</summary>
        TPM_E_BAD_PRESENCE               = 0x8028002DL,
        /// <summary>The TPM cannot perform this version of the capability.</summary>
        TPM_E_BAD_VERSION                = 0x8028002EL,
        /// <summary>The TPM does not allow for wrapped transport sessions.</summary>
        TPM_E_NO_WRAP_TRANSPORT          = 0x8028002FL,
        /// <summary>TPM audit construction failed and the underlying command was returning a failure code also.</summary>
        TPM_E_AUDITFAIL_UNSUCCESSFUL     = 0x80280030L,
        /// <summary>TPM audit construction failed and the underlying command was returning success.</summary>
        TPM_E_AUDITFAIL_SUCCESSFUL       = 0x80280031L,
        /// <summary>Attempt to reset a PCR register that does not have the resettable attribute.</summary>
        TPM_E_NOTRESETABLE               = 0x80280032L,
        /// <summary>Attempt to reset a PCR register that requires locality and locality modifier not part of command transport.</summary>
        TPM_E_NOTLOCAL                   = 0x80280033L,
        /// <summary>Make identity blob not properly typed.</summary>
        TPM_E_BAD_TYPE                   = 0x80280034L,
        /// <summary>When saving context identified resource type does not match actual resource.</summary>
        TPM_E_INVALID_RESOURCE           = 0x80280035L,
        /// <summary>The TPM is attempting to execute a command only available when in FIPS mode.</summary>
        TPM_E_NOTFIPS                    = 0x80280036L,
        /// <summary>The command is attempting to use an invalid family ID.</summary>
        TPM_E_INVALID_FAMILY             = 0x80280037L,
        /// <summary>The permission to manipulate the NV storage is not available.</summary>
        TPM_E_NO_NV_PERMISSION           = 0x80280038L,
        /// <summary>The operation requires a signed command.</summary>
        TPM_E_REQUIRES_SIGN              = 0x80280039L,
        /// <summary>Wrong operation to load an NV key.</summary>
        TPM_E_KEY_NOTSUPPORTED           = 0x8028003AL,
        /// <summary>NV_LoadKey blob requires both owner and blob authorization.</summary>
        TPM_E_AUTH_CONFLICT              = 0x8028003BL,
        /// <summary>The NV area is locked and not writtable.</summary>
        TPM_E_AREA_LOCKED                = 0x8028003CL,
        /// <summary>The locality is incorrect for the attempted operation.</summary>
        TPM_E_BAD_LOCALITY               = 0x8028003DL,
        /// <summary>The NV area is read only and can't be written to.</summary>
        TPM_E_READ_ONLY                  = 0x8028003EL,
        /// <summary>There is no protection on the write to the NV area.</summary>
        TPM_E_PER_NOWRITE                = 0x8028003FL,
        /// <summary>The family count value does not match.</summary>
        TPM_E_FAMILYCOUNT                = 0x80280040L,
        /// <summary>The NV area has already been written to.</summary>
        TPM_E_WRITE_LOCKED               = 0x80280041L,
        /// <summary>The NV area attributes conflict.</summary>
        TPM_E_BAD_ATTRIBUTES             = 0x80280042L,
        /// <summary>The structure tag and version are invalid or inconsistent.</summary>
        TPM_E_INVALID_STRUCTURE          = 0x80280043L,
        /// <summary>The key is under control of the TPM Owner and can only be evicted by the TPM Owner.</summary>
        TPM_E_KEY_OWNER_CONTROL          = 0x80280044L,
        /// <summary>The counter handle is incorrect.</summary>
        TPM_E_BAD_COUNTER                = 0x80280045L,
        /// <summary>The write is not a complete write of the area.</summary>
        TPM_E_NOT_FULLWRITE              = 0x80280046L,
        /// <summary>The gap between saved context counts is too large.</summary>
        TPM_E_CONTEXT_GAP                = 0x80280047L,
        /// <summary>The maximum number of NV writes without an owner has been exceeded.</summary>
        TPM_E_MAXNVWRITES                = 0x80280048L,
        /// <summary>No operator AuthData value is set.</summary>
        TPM_E_NOOPERATOR                 = 0x80280049L,
        /// <summary>The resource pointed to by context is not loaded.</summary>
        TPM_E_RESOURCEMISSING            = 0x8028004AL,
        /// <summary>The delegate administration is locked.</summary>
        TPM_E_DELEGATE_LOCK              = 0x8028004BL,
        /// <summary>Attempt to manage a family other then the delegated family.</summary>
        TPM_E_DELEGATE_FAMILY            = 0x8028004CL,
        /// <summary>Delegation table management not enabled.</summary>
        TPM_E_DELEGATE_ADMIN             = 0x8028004DL,
        /// <summary>There was a command executed outside of an exclusive transport session.</summary>
        TPM_E_TRANSPORT_NOTEXCLUSIVE     = 0x8028004EL,
        /// <summary>Attempt to context save a owner evict controlled key.</summary>
        TPM_E_OWNER_CONTROL              = 0x8028004FL,
        /// <summary>The DAA command has no resources availble to execute the command.</summary>
        TPM_E_DAA_RESOURCES              = 0x80280050L,
        /// <summary>The consistency check on DAA parameter inputData0 has failed.</summary>
        TPM_E_DAA_INPUT_DATA0            = 0x80280051L,
        /// <summary>The consistency check on DAA parameter inputData1 has failed.</summary>
        TPM_E_DAA_INPUT_DATA1            = 0x80280052L,
        /// <summary>The consistency check on DAA_issuerSettings has failed.</summary>
        TPM_E_DAA_ISSUER_SETTINGS        = 0x80280053L,
        /// <summary>The consistency check on DAA_tpmSpecific has failed.</summary>
        TPM_E_DAA_TPM_SETTINGS           = 0x80280054L,
        /// <summary>The atomic process indicated by the submitted DAA command is not the expected process.</summary>
        TPM_E_DAA_STAGE                  = 0x80280055L,
        /// <summary>The issuer's validity check has detected an inconsistency.</summary>
        TPM_E_DAA_ISSUER_VALIDITY        = 0x80280056L,
        /// <summary>The consistency check on w has failed.</summary>
        TPM_E_DAA_WRONG_W                = 0x80280057L,
        /// <summary>The handle is incorrect.</summary>
        TPM_E_BAD_HANDLE                 = 0x80280058L,
        /// <summary>Delegation is not correct.</summary>
        TPM_E_BAD_DELEGATE               = 0x80280059L,
        /// <summary>The context blob is invalid.</summary>
        TPM_E_BADCONTEXT                 = 0x8028005AL,
        /// <summary>Too many contexts held by the TPM.</summary>
        TPM_E_TOOMANYCONTEXTS            = 0x8028005BL,
        /// <summary>Migration authority signature validation failure.</summary>
        TPM_E_MA_TICKET_SIGNATURE        = 0x8028005CL,
        /// <summary>Migration destination not authenticated.</summary>
        TPM_E_MA_DESTINATION             = 0x8028005DL,
        /// <summary>Migration source incorrect.</summary>
        TPM_E_MA_SOURCE                  = 0x8028005EL,
        /// <summary>Incorrect migration authority.</summary>
        TPM_E_MA_AUTHORITY               = 0x8028005FL,
        /// <summary>Attempt to revoke the EK and the EK is not revocable.</summary>
        TPM_E_PERMANENTEK                = 0x80280061L,
        /// <summary>Bad signature of CMK ticket.</summary>
        TPM_E_BAD_SIGNATURE              = 0x80280062L,
        /// <summary>There is no room in the context list for additional contexts.</summary>
        TPM_E_NOCONTEXTSPACE             = 0x80280063L,
        /// <summary>The command was blocked.</summary>
        TPM_E_COMMAND_BLOCKED            = 0x80280400L,
        /// <summary>The specified handle was not found.</summary>
        TPM_E_INVALID_HANDLE             = 0x80280401L,
        /// <summary>The TPM returned a duplicate handle and the command needs to be resubmitted.</summary>
        TPM_E_DUPLICATE_VHANDLE          = 0x80280402L,
        /// <summary>The command within the transport was blocked.</summary>
        TPM_E_EMBEDDED_COMMAND_BLOCKED   = 0x80280403L,
        /// <summary>The command within the transport is not supported.</summary>
        TPM_E_EMBEDDED_COMMAND_UNSUPPORTED = 0x80280404L,
        /// <summary>The TPM is too busy to respond to the command immediately, but the command could be resubmitted at a later time.</summary>
        TPM_E_RETRY                      = 0x80280800L,
        /// <summary>SelfTestFull has not been run.</summary>
        TPM_E_NEEDS_SELFTEST             = 0x80280801L,
        /// <summary>The TPM is currently executing a full selftest.</summary>
        TPM_E_DOING_SELFTEST             = 0x80280802L,
        /// <summary>The TPM is defending against dictionary attacks and is in a time-out period.</summary>
        TPM_E_DEFEND_LOCK_RUNNING        = 0x80280803L,
        /// <summary>An internal error has occurred within the Trusted Platform Module support program.</summary>
        TBS_E_INTERNAL_ERROR             = 0x80284001L,
        /// <summary>One or more input parameters is bad.</summary>
        TBS_E_BAD_PARAMETER              = 0x80284002L,
        /// <summary>A specified output pointer is bad.</summary>
        TBS_E_INVALID_OUTPUT_POINTER     = 0x80284003L,
        /// <summary>The specified context handle does not refer to a valid context.</summary>
        TBS_E_INVALID_CONTEXT            = 0x80284004L,
        /// <summary>A specified output buffer is too small.</summary>
        TBS_E_INSUFFICIENT_BUFFER        = 0x80284005L,
        /// <summary>An error occurred while communicating with the TPM.</summary>
        TBS_E_IOERROR                    = 0x80284006L,
        /// <summary>One or more context parameters is invalid.</summary>
        TBS_E_INVALID_CONTEXT_PARAM      = 0x80284007L,
        /// <summary>The TBS service is not running and could not be started.</summary>
        TBS_E_SERVICE_NOT_RUNNING        = 0x80284008L,
        /// <summary>A new context could not be created because there are too many open contexts.</summary>
        TBS_E_TOO_MANY_TBS_CONTEXTS      = 0x80284009L,
        /// <summary>A new virtual resource could not be created because there are too many open virtual resources.</summary>
        TBS_E_TOO_MANY_RESOURCES         = 0x8028400AL,
        /// <summary>The TBS service has been started but is not yet running.</summary>
        TBS_E_SERVICE_START_PENDING      = 0x8028400BL,
        /// <summary>The physical presence interface is not supported.</summary>
        TBS_E_PPI_NOT_SUPPORTED          = 0x8028400CL,
        /// <summary>The command was canceled.</summary>
        TBS_E_COMMAND_CANCELED           = 0x8028400DL,
        /// <summary>The input or output buffer is too large.</summary>
        TBS_E_BUFFER_TOO_LARGE           = 0x8028400EL,
        /// <summary>A compatible Trusted Platform Module (TPM) Security Device cannot be found on this computer.</summary>
        TBS_E_TPM_NOT_FOUND              = 0x8028400FL,
        /// <summary>The TBS service has been disabled.</summary>
        TBS_E_SERVICE_DISABLED           = 0x80284010L,
        /// <summary>No TCG event log is available.</summary>
        TBS_E_NO_EVENT_LOG               = 0x80284011L,
        /// <summary>The caller does not have the appropriate rights to perform the requested operation.</summary>
        TBS_E_ACCESS_DENIED              = 0x80284012L,
        /// <summary>The TPM provisioning action is not allowed by the specified flags.  For provisioning to be successful, one of several actions may be required.  The TPM management console (tpm.msc) action to make the TPM Ready may help.  For further information, see the documentation for the Win32_Tpm WMI method 'Provision'.  (The actions that may be required include importing the TPM Owner Authorization value into the system, calling the Win32_Tpm WMI method for provisioning the TPM and specifying TRUE for either 'ForceClear_Allowed' or 'PhysicalPresencePrompts_Allowed' (as indicated by the value returned in the Additional Information), or enabling the TPM in the system BIOS.)</summary>
        TBS_E_PROVISIONING_NOT_ALLOWED   = 0x80284013L,
        /// <summary>The Physical Presence Interface of this firmware does not support the requested method.</summary>
        TBS_E_PPI_FUNCTION_UNSUPPORTED   = 0x80284014L,
        /// <summary>The requested TPM OwnerAuth value was not found.</summary>
        TBS_E_OWNERAUTH_NOT_FOUND        = 0x80284015L,
        /// <summary>The TPM provisioning did not complete.  For more information on completing the provisioning, call the Win32_Tpm WMI method for provisioning the TPM ('Provision') and check the returned Information.</summary>
        TBS_E_PROVISIONING_INCOMPLETE    = 0x80284016L,
        /// <summary>The command buffer is not in the correct state.</summary>
        TPMAPI_E_INVALID_STATE           = 0x80290100L,
        /// <summary>The command buffer does not contain enough data to satisfy the request.</summary>
        TPMAPI_E_NOT_ENOUGH_DATA         = 0x80290101L,
        /// <summary>The command buffer cannot contain any more data.</summary>
        TPMAPI_E_TOO_MUCH_DATA           = 0x80290102L,
        /// <summary>One or more output parameters was NULL or invalid.</summary>
        TPMAPI_E_INVALID_OUTPUT_POINTER  = 0x80290103L,
        /// <summary>One or more input parameters is invalid.</summary>
        TPMAPI_E_INVALID_PARAMETER       = 0x80290104L,
        /// <summary>Not enough memory was available to satisfy the request.</summary>
        TPMAPI_E_OUT_OF_MEMORY           = 0x80290105L,
        /// <summary>The specified buffer was too small.</summary>
        TPMAPI_E_BUFFER_TOO_SMALL        = 0x80290106L,
        /// <summary>An internal error was detected.</summary>
        TPMAPI_E_INTERNAL_ERROR          = 0x80290107L,
        /// <summary>The caller does not have the appropriate rights to perform the requested operation.</summary>
        TPMAPI_E_ACCESS_DENIED           = 0x80290108L,
        /// <summary>The specified authorization information was invalid.</summary>
        TPMAPI_E_AUTHORIZATION_FAILED    = 0x80290109L,
        /// <summary>The specified context handle was not valid.</summary>
        TPMAPI_E_INVALID_CONTEXT_HANDLE  = 0x8029010AL,
        /// <summary>An error occurred while communicating with the TBS.</summary>
        TPMAPI_E_TBS_COMMUNICATION_ERROR = 0x8029010BL,
        /// <summary>The TPM returned an unexpected result.</summary>
        TPMAPI_E_TPM_COMMAND_ERROR       = 0x8029010CL,
        /// <summary>The message was too large for the encoding scheme.</summary>
        TPMAPI_E_MESSAGE_TOO_LARGE       = 0x8029010DL,
        /// <summary>The encoding in the blob was not recognized.</summary>
        TPMAPI_E_INVALID_ENCODING        = 0x8029010EL,
        /// <summary>The key size is not valid.</summary>
        TPMAPI_E_INVALID_KEY_SIZE        = 0x8029010FL,
        /// <summary>The encryption operation failed.</summary>
        TPMAPI_E_ENCRYPTION_FAILED       = 0x80290110L,
        /// <summary>The key parameters structure was not valid</summary>
        TPMAPI_E_INVALID_KEY_PARAMS      = 0x80290111L,
        /// <summary>The requested supplied data does not appear to be a valid migration authorization blob.</summary>
        TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB = 0x80290112L,
        /// <summary>The specified PCR index was invalid</summary>
        TPMAPI_E_INVALID_PCR_INDEX       = 0x80290113L,
        /// <summary>The data given does not appear to be a valid delegate blob.</summary>
        TPMAPI_E_INVALID_DELEGATE_BLOB   = 0x80290114L,
        /// <summary>One or more of the specified context parameters was not valid.</summary>
        TPMAPI_E_INVALID_CONTEXT_PARAMS  = 0x80290115L,
        /// <summary>The data given does not appear to be a valid key blob</summary>
        TPMAPI_E_INVALID_KEY_BLOB        = 0x80290116L,
        /// <summary>The specified PCR data was invalid.</summary>
        TPMAPI_E_INVALID_PCR_DATA        = 0x80290117L,
        /// <summary>The format of the owner auth data was invalid.</summary>
        TPMAPI_E_INVALID_OWNER_AUTH      = 0x80290118L,
        /// <summary>The random number generated did not pass FIPS RNG check.</summary>
        TPMAPI_E_FIPS_RNG_CHECK_FAILED   = 0x80290119L,
        /// <summary>The TCG Event Log does not contain any data.</summary>
        TPMAPI_E_EMPTY_TCG_LOG           = 0x8029011AL,
        /// <summary>An entry in the TCG Event Log was invalid.</summary>
        TPMAPI_E_INVALID_TCG_LOG_ENTRY   = 0x8029011BL,
        /// <summary>A TCG Separator was not found.</summary>
        TPMAPI_E_TCG_SEPARATOR_ABSENT    = 0x8029011CL,
        /// <summary>A digest value in a TCG Log entry did not match hashed data.</summary>
        TPMAPI_E_TCG_INVALID_DIGEST_ENTRY = 0x8029011DL,
        /// <summary>The requested operation was blocked by current TPM policy. Please contact your system administrator for assistance.</summary>
        TPMAPI_E_POLICY_DENIES_OPERATION = 0x8029011EL,
        /// <summary>The specified buffer was too small.</summary>
        TBSIMP_E_BUFFER_TOO_SMALL        = 0x80290200L,
        /// <summary>The context could not be cleaned up.</summary>
        TBSIMP_E_CLEANUP_FAILED          = 0x80290201L,
        /// <summary>The specified context handle is invalid.</summary>
        TBSIMP_E_INVALID_CONTEXT_HANDLE  = 0x80290202L,
        /// <summary>An invalid context parameter was specified.</summary>
        TBSIMP_E_INVALID_CONTEXT_PARAM   = 0x80290203L,
        /// <summary>An error occurred while communicating with the TPM</summary>
        TBSIMP_E_TPM_ERROR               = 0x80290204L,
        /// <summary>No entry with the specified key was found.</summary>
        TBSIMP_E_HASH_BAD_KEY            = 0x80290205L,
        /// <summary>The specified virtual handle matches a virtual handle already in use.</summary>
        TBSIMP_E_DUPLICATE_VHANDLE       = 0x80290206L,
        /// <summary>The pointer to the returned handle location was NULL or invalid</summary>
        TBSIMP_E_INVALID_OUTPUT_POINTER  = 0x80290207L,
        /// <summary>One or more parameters is invalid</summary>
        TBSIMP_E_INVALID_PARAMETER       = 0x80290208L,
        /// <summary>The RPC subsystem could not be initialized.</summary>
        TBSIMP_E_RPC_INIT_FAILED         = 0x80290209L,
        /// <summary>The TBS scheduler is not running.</summary>
        TBSIMP_E_SCHEDULER_NOT_RUNNING   = 0x8029020AL,
        /// <summary>The command was canceled.</summary>
        TBSIMP_E_COMMAND_CANCELED        = 0x8029020BL,
        /// <summary>There was not enough memory to fulfill the request</summary>
        TBSIMP_E_OUT_OF_MEMORY           = 0x8029020CL,
        /// <summary>The specified list is empty, or the iteration has reached the end of the list.</summary>
        TBSIMP_E_LIST_NO_MORE_ITEMS      = 0x8029020DL,
        /// <summary>The specified item was not found in the list.</summary>
        TBSIMP_E_LIST_NOT_FOUND          = 0x8029020EL,
        /// <summary>The TPM does not have enough space to load the requested resource.</summary>
        TBSIMP_E_NOT_ENOUGH_SPACE        = 0x8029020FL,
        /// <summary>There are too many TPM contexts in use.</summary>
        TBSIMP_E_NOT_ENOUGH_TPM_CONTEXTS = 0x80290210L,
        /// <summary>The TPM command failed.</summary>
        TBSIMP_E_COMMAND_FAILED          = 0x80290211L,
        /// <summary>The TBS does not recognize the specified ordinal.</summary>
        TBSIMP_E_UNKNOWN_ORDINAL         = 0x80290212L,
        /// <summary>The requested resource is no longer available.</summary>
        TBSIMP_E_RESOURCE_EXPIRED        = 0x80290213L,
        /// <summary>The resource type did not match.</summary>
        TBSIMP_E_INVALID_RESOURCE        = 0x80290214L,
        /// <summary>No resources can be unloaded.</summary>
        TBSIMP_E_NOTHING_TO_UNLOAD       = 0x80290215L,
        /// <summary>No new entries can be added to the hash table.</summary>
        TBSIMP_E_HASH_TABLE_FULL         = 0x80290216L,
        /// <summary>A new TBS context could not be created because there are too many open contexts.</summary>
        TBSIMP_E_TOO_MANY_TBS_CONTEXTS   = 0x80290217L,
        /// <summary>A new virtual resource could not be created because there are too many open virtual resources.</summary>
        TBSIMP_E_TOO_MANY_RESOURCES      = 0x80290218L,
        /// <summary>The physical presence interface is not supported.</summary>
        TBSIMP_E_PPI_NOT_SUPPORTED       = 0x80290219L,
        /// <summary>TBS is not compatible with the version of TPM found on the system.</summary>
        TBSIMP_E_TPM_INCOMPATIBLE        = 0x8029021AL,
        /// <summary>No TCG event log is available.</summary>
        TBSIMP_E_NO_EVENT_LOG            = 0x8029021BL,
        /// <summary>A general error was detected when attempting to acquire the BIOS's response to a Physical Presence command.</summary>
        TPM_E_PPI_ACPI_FAILURE           = 0x80290300L,
        /// <summary>The user failed to confirm the TPM operation request.</summary>
        TPM_E_PPI_USER_ABORT             = 0x80290301L,
        /// <summary>The BIOS failure prevented the successful execution of the requested TPM operation (e.g. invalid TPM operation request, BIOS communication error with the TPM).</summary>
        TPM_E_PPI_BIOS_FAILURE           = 0x80290302L,
        /// <summary>The BIOS does not support the physical presence interface.</summary>
        TPM_E_PPI_NOT_SUPPORTED          = 0x80290303L,
        /// <summary>The Physical Presence command was blocked by current BIOS settings. The system owner may be able to reconfigure the BIOS settings to allow the command.</summary>
        TPM_E_PPI_BLOCKED_IN_BIOS        = 0x80290304L,
        /// <summary>This is an error mask to convert Platform Crypto Provider errors to win errors.</summary>
        TPM_E_PCP_ERROR_MASK             = 0x80290400L,
        /// <summary>The Platform Crypto Device is currently not ready. It needs to be fully provisioned to be operational.</summary>
        TPM_E_PCP_DEVICE_NOT_READY       = 0x80290401L,
        /// <summary>The handle provided to the Platform Crypto Provider is invalid.</summary>
        TPM_E_PCP_INVALID_HANDLE         = 0x80290402L,
        /// <summary>A parameter provided to the Platform Crypto Provider is invalid.</summary>
        TPM_E_PCP_INVALID_PARAMETER      = 0x80290403L,
        /// <summary>A provided flag to the Platform Crypto Provider is not supported.</summary>
        TPM_E_PCP_FLAG_NOT_SUPPORTED     = 0x80290404L,
        /// <summary>The requested operation is not supported by this Platform Crypto Provider.</summary>
        TPM_E_PCP_NOT_SUPPORTED          = 0x80290405L,
        /// <summary>The buffer is too small to contain all data. No information has been written to the buffer.</summary>
        TPM_E_PCP_BUFFER_TOO_SMALL       = 0x80290406L,
        /// <summary>An unexpected internal error has occurred in the Platform Crypto Provider.</summary>
        TPM_E_PCP_INTERNAL_ERROR         = 0x80290407L,
        /// <summary>The authorization to use a provider object has failed.</summary>
        TPM_E_PCP_AUTHENTICATION_FAILED  = 0x80290408L,
        /// <summary>The Platform Crypto Device has ignored the authorization for the provider object, to mitigate against a dictionary attack.</summary>
        TPM_E_PCP_AUTHENTICATION_IGNORED = 0x80290409L,
        /// <summary>The referenced policy was not found.</summary>
        TPM_E_PCP_POLICY_NOT_FOUND       = 0x8029040AL,
        /// <summary>The referenced profile was not found.</summary>
        TPM_E_PCP_PROFILE_NOT_FOUND      = 0x8029040BL,
        /// <summary>The validation was not succesful.</summary>
        TPM_E_PCP_VALIDATION_FAILED      = 0x8029040CL,
        /// <summary>Data Collector Set was not found.</summary>
        PLA_E_DCS_NOT_FOUND              = 0x80300002L,
        /// <summary>The Data Collector Set or one of its dependencies is already in use.</summary>
        PLA_E_DCS_IN_USE                 = 0x803000AAL,
        /// <summary>Unable to start Data Collector Set because there are too many folders.</summary>
        PLA_E_TOO_MANY_FOLDERS           = 0x80300045L,
        /// <summary>Not enough free disk space to start Data Collector Set.</summary>
        PLA_E_NO_MIN_DISK                = 0x80300070L,
        /// <summary>Data Collector Set already exists.</summary>
        PLA_E_DCS_ALREADY_EXISTS         = 0x803000B7L,
        /// <summary>Property value will be ignored.</summary>
        PLA_S_PROPERTY_IGNORED           = 0x00300100L,
        /// <summary>Property value conflict.</summary>
        PLA_E_PROPERTY_CONFLICT          = 0x80300101L,
        /// <summary>The current configuration for this Data Collector Set requires that it contain exactly one Data Collector.</summary>
        PLA_E_DCS_SINGLETON_REQUIRED     = 0x80300102L,
        /// <summary>A user account is required in order to commit the current Data Collector Set properties.</summary>
        PLA_E_CREDENTIALS_REQUIRED       = 0x80300103L,
        /// <summary>Data Collector Set is not running.</summary>
        PLA_E_DCS_NOT_RUNNING            = 0x80300104L,
        /// <summary>A conflict was detected in the list of include/exclude APIs. Do not specify the same API in both the include list and the exclude list.</summary>
        PLA_E_CONFLICT_INCL_EXCL_API     = 0x80300105L,
        /// <summary>The executable path you have specified refers to a network share or UNC path.</summary>
        PLA_E_NETWORK_EXE_NOT_VALID      = 0x80300106L,
        /// <summary>The executable path you have specified is already configured for API tracing.</summary>
        PLA_E_EXE_ALREADY_CONFIGURED     = 0x80300107L,
        /// <summary>The executable path you have specified does not exist. Verify that the specified path is correct.</summary>
        PLA_E_EXE_PATH_NOT_VALID         = 0x80300108L,
        /// <summary>Data Collector already exists.</summary>
        PLA_E_DC_ALREADY_EXISTS          = 0x80300109L,
        /// <summary>The wait for the Data Collector Set start notification has timed out.</summary>
        PLA_E_DCS_START_WAIT_TIMEOUT     = 0x8030010AL,
        /// <summary>The wait for the Data Collector to start has timed out.</summary>
        PLA_E_DC_START_WAIT_TIMEOUT      = 0x8030010BL,
        /// <summary>The wait for the report generation tool to finish has timed out.</summary>
        PLA_E_REPORT_WAIT_TIMEOUT        = 0x8030010CL,
        /// <summary>Duplicate items are not allowed.</summary>
        PLA_E_NO_DUPLICATES              = 0x8030010DL,
        /// <summary>When specifying the executable that you want to trace, you must specify a full path to the executable and not just a filename.</summary>
        PLA_E_EXE_FULL_PATH_REQUIRED     = 0x8030010EL,
        /// <summary>The session name provided is invalid.</summary>
        PLA_E_INVALID_SESSION_NAME       = 0x8030010FL,
        /// <summary>The Event Log channel Microsoft-Windows-Diagnosis-PLA/Operational must be enabled to perform this operation.</summary>
        PLA_E_PLA_CHANNEL_NOT_ENABLED    = 0x80300110L,
        /// <summary>The Event Log channel Microsoft-Windows-TaskScheduler must be enabled to perform this operation.</summary>
        PLA_E_TASKSCHED_CHANNEL_NOT_ENABLED = 0x80300111L,
        /// <summary>The execution of the Rules Manager failed.</summary>
        PLA_E_RULES_MANAGER_FAILED       = 0x80300112L,
        /// <summary>An error occurred while attempting to compress or extract the data.</summary>
        PLA_E_CABAPI_FAILURE             = 0x80300113L,
        /// <summary>This drive is locked by BitLocker Drive Encryption. You must unlock this drive from Control Panel.</summary>
        FVE_E_LOCKED_VOLUME              = 0x80310000L,
        /// <summary>This drive is not encrypted.</summary>
        FVE_E_NOT_ENCRYPTED              = 0x80310001L,
        /// <summary>The BIOS did not correctly communicate with the Trusted Platform Module (TPM). Contact the computer manufacturer for BIOS upgrade instructions.</summary>
        FVE_E_NO_TPM_BIOS                = 0x80310002L,
        /// <summary>The BIOS did not correctly communicate with the master boot record (MBR). Contact the computer manufacturer for BIOS upgrade instructions.</summary>
        FVE_E_NO_MBR_METRIC              = 0x80310003L,
        /// <summary>A required TPM measurement is missing. If there is a bootable CD or DVD in your computer, remove it, restart the computer, and turn on BitLocker again. If the problem persists, ensure the master boot record is up to date.</summary>
        FVE_E_NO_BOOTSECTOR_METRIC       = 0x80310004L,
        /// <summary>The boot sector of this drive is not compatible with BitLocker Drive Encryption. Use the Bootrec.exe tool in the Windows Recovery Environment to update or repair the boot manager (BOOTMGR).</summary>
        FVE_E_NO_BOOTMGR_METRIC          = 0x80310005L,
        /// <summary>The boot manager of this operating system is not compatible with BitLocker Drive Encryption. Use the Bootrec.exe tool in the Windows Recovery Environment to update or repair the boot manager (BOOTMGR).</summary>
        FVE_E_WRONG_BOOTMGR              = 0x80310006L,
        /// <summary>At least one secure key protector is required for this operation to be performed.</summary>
        FVE_E_SECURE_KEY_REQUIRED        = 0x80310007L,
        /// <summary>BitLocker Drive Encryption is not enabled on this drive. Turn on BitLocker.</summary>
        FVE_E_NOT_ACTIVATED              = 0x80310008L,
        /// <summary>BitLocker Drive Encryption cannot perform the requested action. This condition may occur when two requests are issued at the same time. Wait a few moments and then try the action again.</summary>
        FVE_E_ACTION_NOT_ALLOWED         = 0x80310009L,
        /// <summary>The Active Directory Domain Services forest does not contain the required attributes and classes to host BitLocker Drive Encryption or Trusted Platform Module information. Contact your domain administrator to verify that any required BitLocker Active Directory schema extensions have been installed.</summary>
        FVE_E_AD_SCHEMA_NOT_INSTALLED    = 0x8031000AL,
        /// <summary>The type of the data obtained from Active Directory was not expected. The BitLocker recovery information may be missing or corrupted.</summary>
        FVE_E_AD_INVALID_DATATYPE        = 0x8031000BL,
        /// <summary>The size of the data obtained from Active Directory was not expected. The BitLocker recovery information may be missing or corrupted.</summary>
        FVE_E_AD_INVALID_DATASIZE        = 0x8031000CL,
        /// <summary>The attribute read from Active Directory does not contain any values. The BitLocker recovery information may be missing or corrupted.</summary>
        FVE_E_AD_NO_VALUES               = 0x8031000DL,
        /// <summary>The attribute was not set. Verify that you are logged on with a domain account that has the ability to write information to Active Directory objects.</summary>
        FVE_E_AD_ATTR_NOT_SET            = 0x8031000EL,
        /// <summary>The specified attribute cannot be found in Active Directory Domain Services. Contact your domain administrator to verify that any required BitLocker Active Directory schema extensions have been installed.</summary>
        FVE_E_AD_GUID_NOT_FOUND          = 0x8031000FL,
        /// <summary>The BitLocker metadata for the encrypted drive is not valid. You can attempt to repair the drive to restore access.</summary>
        FVE_E_BAD_INFORMATION            = 0x80310010L,
        /// <summary>The drive cannot be encrypted because it does not have enough free space. Delete any unnecessary data on the drive to create additional free space and then try again.</summary>
        FVE_E_TOO_SMALL                  = 0x80310011L,
        /// <summary>The drive cannot be encrypted because it contains system boot information. Create a separate partition for use as the system drive that contains the boot information and a second partition for use as the operating system drive and then encrypt the operating system drive.</summary>
        FVE_E_SYSTEM_VOLUME              = 0x80310012L,
        /// <summary>The drive cannot be encrypted because the file system is not supported.</summary>
        FVE_E_FAILED_WRONG_FS            = 0x80310013L,
        /// <summary>The file system size is larger than the partition size in the partition table. This drive may be corrupt or may have been tampered with. To use it with BitLocker, you must reformat the partition.</summary>
        FVE_E_BAD_PARTITION_SIZE         = 0x80310014L,
        /// <summary>This drive cannot be encrypted.</summary>
        FVE_E_NOT_SUPPORTED              = 0x80310015L,
        /// <summary>The data is not valid.</summary>
        FVE_E_BAD_DATA                   = 0x80310016L,
        /// <summary>The data drive specified is not set to automatically unlock on the current computer and cannot be unlocked automatically.</summary>
        FVE_E_VOLUME_NOT_BOUND           = 0x80310017L,
        /// <summary>You must initialize the Trusted Platform Module (TPM) before you can use BitLocker Drive Encryption.</summary>
        FVE_E_TPM_NOT_OWNED              = 0x80310018L,
        /// <summary>The operation attempted cannot be performed on an operating system drive.</summary>
        FVE_E_NOT_DATA_VOLUME            = 0x80310019L,
        /// <summary>The buffer supplied to a function was insufficient to contain the returned data. Increase the buffer size before running the function again.</summary>
        FVE_E_AD_INSUFFICIENT_BUFFER     = 0x8031001AL,
        /// <summary>A read operation failed while converting the drive. The drive was not converted. Please re-enable BitLocker.</summary>
        FVE_E_CONV_READ                  = 0x8031001BL,
        /// <summary>A write operation failed while converting the drive. The drive was not converted. Please re-enable BitLocker.</summary>
        FVE_E_CONV_WRITE                 = 0x8031001CL,
        /// <summary>One or more BitLocker key protectors are required. You cannot delete the last key on this drive.</summary>
        FVE_E_KEY_REQUIRED               = 0x8031001DL,
        /// <summary>Cluster configurations are not supported by BitLocker Drive Encryption.</summary>
        FVE_E_CLUSTERING_NOT_SUPPORTED   = 0x8031001EL,
        /// <summary>The drive specified is already configured to be automatically unlocked on the current computer.</summary>
        FVE_E_VOLUME_BOUND_ALREADY       = 0x8031001FL,
        /// <summary>The operating system drive is not protected by BitLocker Drive Encryption.</summary>
        FVE_E_OS_NOT_PROTECTED           = 0x80310020L,
        /// <summary>BitLocker Drive Encryption has been suspended on this drive. All BitLocker key protectors configured for this drive are effectively disabled, and the drive will be automatically unlocked using an unencrypted (clear) key.</summary>
        FVE_E_PROTECTION_DISABLED        = 0x80310021L,
        /// <summary>The drive you are attempting to lock does not have any key protectors available for encryption because BitLocker protection is currently suspended. Re-enable BitLocker to lock this drive.</summary>
        FVE_E_RECOVERY_KEY_REQUIRED      = 0x80310022L,
        /// <summary>BitLocker cannot use the Trusted Platform Module (TPM) to protect a data drive. TPM protection can only be used with the operating system drive.</summary>
        FVE_E_FOREIGN_VOLUME             = 0x80310023L,
        /// <summary>The BitLocker metadata for the encrypted drive cannot be updated because it was locked for updating by another process. Please try this process again.</summary>
        FVE_E_OVERLAPPED_UPDATE          = 0x80310024L,
        /// <summary>The authorization data for the storage root key (SRK) of the Trusted Platform Module (TPM) is not zero and is therefore incompatible with BitLocker. Please initialize the TPM before attempting to use it with BitLocker.</summary>
        FVE_E_TPM_SRK_AUTH_NOT_ZERO      = 0x80310025L,
        /// <summary>The drive encryption algorithm cannot be used on this sector size.</summary>
        FVE_E_FAILED_SECTOR_SIZE         = 0x80310026L,
        /// <summary>The drive cannot be unlocked with the key provided. Confirm that you have provided the correct key and try again.</summary>
        FVE_E_FAILED_AUTHENTICATION      = 0x80310027L,
        /// <summary>The drive specified is not the operating system drive.</summary>
        FVE_E_NOT_OS_VOLUME              = 0x80310028L,
        /// <summary>BitLocker Drive Encryption cannot be turned off on the operating system drive until the auto unlock feature has been disabled for the fixed data drives and removable data drives associated with this computer.</summary>
        FVE_E_AUTOUNLOCK_ENABLED         = 0x80310029L,
        /// <summary>The system partition boot sector does not perform Trusted Platform Module (TPM) measurements. Use the Bootrec.exe tool in the Windows Recovery Environment to update or repair the boot sector.</summary>
        FVE_E_WRONG_BOOTSECTOR           = 0x8031002AL,
        /// <summary>BitLocker Drive Encryption operating system drives must be formatted with the NTFS file system in order to be encrypted. Convert the drive to NTFS, and then turn on BitLocker.</summary>
        FVE_E_WRONG_SYSTEM_FS            = 0x8031002BL,
        /// <summary>Group Policy settings require that a recovery password be specified before encrypting the drive.</summary>
        FVE_E_POLICY_PASSWORD_REQUIRED   = 0x8031002CL,
        /// <summary>The drive encryption algorithm and key cannot be set on a previously encrypted drive. To encrypt this drive with BitLocker Drive Encryption, remove the previous encryption and then turn on BitLocker.</summary>
        FVE_E_CANNOT_SET_FVEK_ENCRYPTED  = 0x8031002DL,
        /// <summary>BitLocker Drive Encryption cannot encrypt the specified drive because an encryption key is not available. Add a key protector to encrypt this drive.</summary>
        FVE_E_CANNOT_ENCRYPT_NO_KEY      = 0x8031002EL,
        /// <summary>BitLocker Drive Encryption detected bootable media (CD or DVD) in the computer. Remove the media and restart the computer before configuring BitLocker.</summary>
        FVE_E_BOOTABLE_CDDVD             = 0x80310030L,
        /// <summary>This key protector cannot be added. Only one key protector of this type is allowed for this drive.</summary>
        FVE_E_PROTECTOR_EXISTS           = 0x80310031L,
        /// <summary>The recovery password file was not found because a relative path was specified. Recovery passwords must be saved to a fully qualified path. Environment variables configured on the computer can be used in the path.</summary>
        FVE_E_RELATIVE_PATH              = 0x80310032L,
        /// <summary>The specified key protector was not found on the drive. Try another key protector.</summary>
        FVE_E_PROTECTOR_NOT_FOUND        = 0x80310033L,
        /// <summary>The recovery key provided is corrupt and cannot be used to access the drive. An alternative recovery method, such as recovery password, a data recovery agent, or a backup version of the recovery key must be used to recover access to the drive.</summary>
        FVE_E_INVALID_KEY_FORMAT         = 0x80310034L,
        /// <summary>The format of the recovery password provided is invalid. BitLocker recovery passwords are 48 digits. Verify that the recovery password is in the correct format and then try again.</summary>
        FVE_E_INVALID_PASSWORD_FORMAT    = 0x80310035L,
        /// <summary>The random number generator check test failed.</summary>
        FVE_E_FIPS_RNG_CHECK_FAILED      = 0x80310036L,
        /// <summary>The Group Policy setting requiring FIPS compliance prevents a local recovery password from being generated or used by BitLocker Drive Encryption. When operating in FIPS-compliant mode, BitLocker recovery options can be either a recovery key stored on a USB drive or recovery through a data recovery agent.</summary>
        FVE_E_FIPS_PREVENTS_RECOVERY_PASSWORD = 0x80310037L,
        /// <summary>The Group Policy setting requiring FIPS compliance prevents the recovery password from being saved to Active Directory. When operating in FIPS-compliant mode, BitLocker recovery options can be either a recovery key stored on a USB drive or recovery through a data recovery agent. Check your Group Policy settings configuration.</summary>
        FVE_E_FIPS_PREVENTS_EXTERNAL_KEY_EXPORT = 0x80310038L,
        /// <summary>The drive must be fully decrypted to complete this operation.</summary>
        FVE_E_NOT_DECRYPTED              = 0x80310039L,
        /// <summary>The key protector specified cannot be used for this operation.</summary>
        FVE_E_INVALID_PROTECTOR_TYPE     = 0x8031003AL,
        /// <summary>No key protectors exist on the drive to perform the hardware test.</summary>
        FVE_E_NO_PROTECTORS_TO_TEST      = 0x8031003BL,
        /// <summary>The BitLocker startup key or recovery password cannot be found on the USB device. Verify that you have the correct USB device, that the USB device is plugged into the computer on an active USB port, restart the computer, and then try again. If the problem persists, contact the computer manufacturer for BIOS upgrade instructions.</summary>
        FVE_E_KEYFILE_NOT_FOUND          = 0x8031003CL,
        /// <summary>The BitLocker startup key or recovery password file provided is corrupt or invalid. Verify that you have the correct startup key or recovery password file and try again.</summary>
        FVE_E_KEYFILE_INVALID            = 0x8031003DL,
        /// <summary>The BitLocker encryption key cannot be obtained from the startup key or recovery password. Verify that you have the correct startup key or recovery password and try again.</summary>
        FVE_E_KEYFILE_NO_VMK             = 0x8031003EL,
        /// <summary>The Trusted Platform Module (TPM) is disabled. The TPM must be enabled, initialized, and have valid ownership before it can be used with BitLocker Drive Encryption.</summary>
        FVE_E_TPM_DISABLED               = 0x8031003FL,
        /// <summary>The BitLocker configuration of the specified drive cannot be managed because this computer is currently operating in Safe Mode. While in Safe Mode, BitLocker Drive Encryption can only be used for recovery purposes.</summary>
        FVE_E_NOT_ALLOWED_IN_SAFE_MODE   = 0x80310040L,
        /// <summary>The Trusted Platform Module (TPM) was unable to unlock the drive. Either the system boot information changed after choosing BitLocker settings or the PIN did not match. If the problem persists after several tries, there may be a hardware or firmware problem.</summary>
        FVE_E_TPM_INVALID_PCR            = 0x80310041L,
        /// <summary>The BitLocker encryption key cannot be obtained from the Trusted Platform Module (TPM).</summary>
        FVE_E_TPM_NO_VMK                 = 0x80310042L,
        /// <summary>The BitLocker encryption key cannot be obtained from the Trusted Platform Module (TPM) and PIN.</summary>
        FVE_E_PIN_INVALID                = 0x80310043L,
        /// <summary>A boot application has changed since BitLocker Drive Encryption was enabled.</summary>
        FVE_E_AUTH_INVALID_APPLICATION   = 0x80310044L,
        /// <summary>The Boot Configuration Data (BCD) settings have changed since BitLocker Drive Encryption was enabled.</summary>
        FVE_E_AUTH_INVALID_CONFIG        = 0x80310045L,
        /// <summary>The Group Policy setting requiring FIPS compliance prohibits the use of unencrypted keys, which prevents BitLocker from being suspended on this drive. Please contact your domain administrator for more information.</summary>
        FVE_E_FIPS_DISABLE_PROTECTION_NOT_ALLOWED = 0x80310046L,
        /// <summary>This drive cannot be encrypted by BitLocker Drive Encryption because the file system does not extend to the end of the drive. Repartition this drive and then try again.</summary>
        FVE_E_FS_NOT_EXTENDED            = 0x80310047L,
        /// <summary>BitLocker Drive Encryption cannot be enabled on the operating system drive. Contact the computer manufacturer for BIOS upgrade instructions.</summary>
        FVE_E_FIRMWARE_TYPE_NOT_SUPPORTED = 0x80310048L,
        /// <summary>This version of Windows does not include BitLocker Drive Encryption. To use BitLocker Drive Encryption, please upgrade the operating system.</summary>
        FVE_E_NO_LICENSE                 = 0x80310049L,
        /// <summary>BitLocker Drive Encryption cannot be used because critical BitLocker system files are missing or corrupted. Use Windows Startup Repair to restore these files to your computer.</summary>
        FVE_E_NOT_ON_STACK               = 0x8031004AL,
        /// <summary>The drive cannot be locked when the drive is in use.</summary>
        FVE_E_FS_MOUNTED                 = 0x8031004BL,
        /// <summary>The access token associated with the current thread is not an impersonated token.</summary>
        FVE_E_TOKEN_NOT_IMPERSONATED     = 0x8031004CL,
        /// <summary>The BitLocker encryption key cannot be obtained. Verify that the Trusted Platform Module (TPM) is enabled and ownership has been taken. If this computer does not have a TPM, verify that the USB drive is inserted and available.</summary>
        FVE_E_DRY_RUN_FAILED             = 0x8031004DL,
        /// <summary>You must restart your computer before continuing with BitLocker Drive Encryption.</summary>
        FVE_E_REBOOT_REQUIRED            = 0x8031004EL,
        /// <summary>Drive encryption cannot occur while boot debugging is enabled. Use the bcdedit command-line tool to turn off boot debugging.</summary>
        FVE_E_DEBUGGER_ENABLED           = 0x8031004FL,
        /// <summary>No action was taken as BitLocker Drive Encryption is in raw access mode.</summary>
        FVE_E_RAW_ACCESS                 = 0x80310050L,
        /// <summary>BitLocker Drive Encryption cannot enter raw access mode for this drive because the drive is currently in use.</summary>
        FVE_E_RAW_BLOCKED                = 0x80310051L,
        /// <summary>The path specified in the Boot Configuration Data (BCD) for a BitLocker Drive Encryption integrity-protected application is incorrect. Please verify and correct your BCD settings and try again.</summary>
        FVE_E_BCD_APPLICATIONS_PATH_INCORRECT = 0x80310052L,
        /// <summary>BitLocker Drive Encryption can only be used for limited provisioning or recovery purposes when the computer is running in pre-installation or recovery environments.</summary>
        FVE_E_NOT_ALLOWED_IN_VERSION     = 0x80310053L,
        /// <summary>The auto-unlock master key was not available from the operating system drive.</summary>
        FVE_E_NO_AUTOUNLOCK_MASTER_KEY   = 0x80310054L,
        /// <summary>The system firmware failed to enable clearing of system memory when the computer was restarted.</summary>
        FVE_E_MOR_FAILED                 = 0x80310055L,
        /// <summary>The hidden drive cannot be encrypted.</summary>
        FVE_E_HIDDEN_VOLUME              = 0x80310056L,
        /// <summary>BitLocker encryption keys were ignored because the drive was in a transient state.</summary>
        FVE_E_TRANSIENT_STATE            = 0x80310057L,
        /// <summary>Public key based protectors are not allowed on this drive.</summary>
        FVE_E_PUBKEY_NOT_ALLOWED         = 0x80310058L,
        /// <summary>BitLocker Drive Encryption is already performing an operation on this drive. Please complete all operations before continuing.</summary>
        FVE_E_VOLUME_HANDLE_OPEN         = 0x80310059L,
        /// <summary>This version of Windows does not support this feature of BitLocker Drive Encryption. To use this feature, upgrade the operating system.</summary>
        FVE_E_NO_FEATURE_LICENSE         = 0x8031005AL,
        /// <summary>The Group Policy settings for BitLocker startup options are in conflict and cannot be applied. Contact your system administrator for more information.</summary>
        FVE_E_INVALID_STARTUP_OPTIONS    = 0x8031005BL,
        /// <summary>Group Policy settings do not permit the creation of a recovery password.</summary>
        FVE_E_POLICY_RECOVERY_PASSWORD_NOT_ALLOWED = 0x8031005CL,
        /// <summary>Group Policy settings require the creation of a recovery password.</summary>
        FVE_E_POLICY_RECOVERY_PASSWORD_REQUIRED = 0x8031005DL,
        /// <summary>Group Policy settings do not permit the creation of a recovery key.</summary>
        FVE_E_POLICY_RECOVERY_KEY_NOT_ALLOWED = 0x8031005EL,
        /// <summary>Group Policy settings require the creation of a recovery key.</summary>
        FVE_E_POLICY_RECOVERY_KEY_REQUIRED = 0x8031005FL,
        /// <summary>Group Policy settings do not permit the use of a PIN at startup. Please choose a different BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_PIN_NOT_ALLOWED = 0x80310060L,
        /// <summary>Group Policy settings require the use of a PIN at startup. Please choose this BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_PIN_REQUIRED = 0x80310061L,
        /// <summary>Group Policy settings do not permit the use of a startup key. Please choose a different BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_KEY_NOT_ALLOWED = 0x80310062L,
        /// <summary>Group Policy settings require the use of a startup key. Please choose this BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_KEY_REQUIRED = 0x80310063L,
        /// <summary>Group Policy settings do not permit the use of a startup key and PIN. Please choose a different BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_PIN_KEY_NOT_ALLOWED = 0x80310064L,
        /// <summary>Group Policy settings require the use of a startup key and PIN. Please choose this BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_PIN_KEY_REQUIRED = 0x80310065L,
        /// <summary>Group policy does not permit the use of TPM-only at startup. Please choose a different BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_TPM_NOT_ALLOWED = 0x80310066L,
        /// <summary>Group Policy settings require the use of TPM-only at startup. Please choose this BitLocker startup option.</summary>
        FVE_E_POLICY_STARTUP_TPM_REQUIRED = 0x80310067L,
        /// <summary>The PIN provided does not meet minimum or maximum length requirements.</summary>
        FVE_E_POLICY_INVALID_PIN_LENGTH  = 0x80310068L,
        /// <summary>The key protector is not supported by the version of BitLocker Drive Encryption currently on the drive. Upgrade the drive to add the key protector.</summary>
        FVE_E_KEY_PROTECTOR_NOT_SUPPORTED = 0x80310069L,
        /// <summary>Group Policy settings do not permit the creation of a password.</summary>
        FVE_E_POLICY_PASSPHRASE_NOT_ALLOWED = 0x8031006AL,
        /// <summary>Group Policy settings require the creation of a password.</summary>
        FVE_E_POLICY_PASSPHRASE_REQUIRED = 0x8031006BL,
        /// <summary>The Group Policy setting requiring FIPS compliance prevents passwords from being generated or used. Please contact your system administrator for more information.</summary>
        FVE_E_FIPS_PREVENTS_PASSPHRASE   = 0x8031006CL,
        /// <summary>A password cannot be added to the operating system drive.</summary>
        FVE_E_OS_VOLUME_PASSPHRASE_NOT_ALLOWED = 0x8031006DL,
        /// <summary>The BitLocker object identifier (OID) on the drive appears to be invalid or corrupt. Use manage-BDE to reset the OID on this drive.</summary>
        FVE_E_INVALID_BITLOCKER_OID      = 0x8031006EL,
        /// <summary>The drive is too small to be protected using BitLocker Drive Encryption.</summary>
        FVE_E_VOLUME_TOO_SMALL           = 0x8031006FL,
        /// <summary>The selected discovery drive type is incompatible with the file system on the drive. BitLocker To Go discovery drives must be created on FAT formatted drives.</summary>
        FVE_E_DV_NOT_SUPPORTED_ON_FS     = 0x80310070L,
        /// <summary>The selected discovery drive type is not allowed by the computer's Group Policy settings. Verify that Group Policy settings allow the creation of discovery drives for use with BitLocker To Go.</summary>
        FVE_E_DV_NOT_ALLOWED_BY_GP       = 0x80310071L,
        /// <summary>Group Policy settings do not permit user certificates such as smart cards to be used with BitLocker Drive Encryption.</summary>
        FVE_E_POLICY_USER_CERTIFICATE_NOT_ALLOWED = 0x80310072L,
        /// <summary>Group Policy settings require that you have a valid user certificate, such as a smart card, to be used with BitLocker Drive Encryption.</summary>
        FVE_E_POLICY_USER_CERTIFICATE_REQUIRED = 0x80310073L,
        /// <summary>Group Policy settings requires that you use a smart card-based key protector with BitLocker Drive Encryption.</summary>
        FVE_E_POLICY_USER_CERT_MUST_BE_HW = 0x80310074L,
        /// <summary>Group Policy settings do not permit BitLocker-protected fixed data drives to be automatically unlocked.</summary>
        FVE_E_POLICY_USER_CONFIGURE_FDV_AUTOUNLOCK_NOT_ALLOWED = 0x80310075L,
        /// <summary>Group Policy settings do not permit BitLocker-protected removable data drives to be automatically unlocked.</summary>
        FVE_E_POLICY_USER_CONFIGURE_RDV_AUTOUNLOCK_NOT_ALLOWED = 0x80310076L,
        /// <summary>Group Policy settings do not permit you to configure BitLocker Drive Encryption on removable data drives.</summary>
        FVE_E_POLICY_USER_CONFIGURE_RDV_NOT_ALLOWED = 0x80310077L,
        /// <summary>Group Policy settings do not permit you to turn on BitLocker Drive Encryption on removable data drives. Please contact your system administrator if you need to turn on BitLocker.</summary>
        FVE_E_POLICY_USER_ENABLE_RDV_NOT_ALLOWED = 0x80310078L,
        /// <summary>Group Policy settings do not permit turning off BitLocker Drive Encryption on removable data drives. Please contact your system administrator if you need to turn off BitLocker.</summary>
        FVE_E_POLICY_USER_DISABLE_RDV_NOT_ALLOWED = 0x80310079L,
        /// <summary>Your password does not meet minimum password length requirements. By default, passwords must be at least 8 characters in length. Check with your system administrator for the password length requirement in your organization.</summary>
        FVE_E_POLICY_INVALID_PASSPHRASE_LENGTH = 0x80310080L,
        /// <summary>Your password does not meet the complexity requirements set by your system administrator. Try adding upper and lowercase characters, numbers, and symbols.</summary>
        FVE_E_POLICY_PASSPHRASE_TOO_SIMPLE = 0x80310081L,
        /// <summary>This drive cannot be encrypted because it is reserved for Windows System Recovery Options.</summary>
        FVE_E_RECOVERY_PARTITION         = 0x80310082L,
        /// <summary>BitLocker Drive Encryption cannot be applied to this drive because of conflicting Group Policy settings. BitLocker cannot be configured to automatically unlock fixed data drives when user recovery options are disabled. If you want BitLocker-protected fixed data drives to be automatically unlocked after key validation has occurred, please ask your system administrator to resolve the settings conflict before enabling BitLocker.</summary>
        FVE_E_POLICY_CONFLICT_FDV_RK_OFF_AUK_ON = 0x80310083L,
        /// <summary>BitLocker Drive Encryption cannot be applied to this drive because of conflicting Group Policy settings. BitLocker cannot be configured to automatically unlock removable data drives when user recovery option are disabled. If you want BitLocker-protected removable data drives to be automatically unlocked after key validation has occurred, please ask your system administrator to resolve the settings conflict before enabling BitLocker.</summary>
        FVE_E_POLICY_CONFLICT_RDV_RK_OFF_AUK_ON = 0x80310084L,
        /// <summary>The Enhanced Key Usage (EKU) attribute of the specified certificate does not permit it to be used for BitLocker Drive Encryption. BitLocker does not require that a certificate have an EKU attribute, but if one is configured it must be set to an object identifier (OID) that matches the OID configured for BitLocker.</summary>
        FVE_E_NON_BITLOCKER_OID          = 0x80310085L,
        /// <summary>BitLocker Drive Encryption cannot be applied to this drive as currently configured because of Group Policy settings. The certificate you provided for drive encryption is self-signed. Current Group Policy settings do not permit the use of self-signed certificates. Obtain a new certificate from your certification authority before attempting to enable BitLocker.</summary>
        FVE_E_POLICY_PROHIBITS_SELFSIGNED = 0x80310086L,
        /// <summary>BitLocker Encryption cannot be applied to this drive because of conflicting Group Policy settings. When write access to drives not protected by BitLocker is denied, the use of a USB startup key cannot be required. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.</summary>
        FVE_E_POLICY_CONFLICT_RO_AND_STARTUP_KEY_REQUIRED = 0x80310087L,
        /// <summary>BitLocker Drive Encryption failed to recover from an abruptly terminated conversion. This could be due to either all conversion logs being corrupted or the media being write-protected.</summary>
        FVE_E_CONV_RECOVERY_FAILED       = 0x80310088L,
        /// <summary>The requested virtualization size is too big.</summary>
        FVE_E_VIRTUALIZED_SPACE_TOO_BIG  = 0x80310089L,
        /// <summary>BitLocker Drive Encryption cannot be applied to this drive because there are conflicting Group Policy settings for recovery options on operating system drives. Storing recovery information to Active Directory Domain Services cannot be required when the generation of recovery passwords is not permitted. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.</summary>
        FVE_E_POLICY_CONFLICT_OSV_RP_OFF_ADB_ON = 0x80310090L,
        /// <summary>BitLocker Drive Encryption cannot be applied to this drive because there are conflicting Group Policy settings for recovery options on fixed data drives. Storing recovery information to Active Directory Domain Services cannot be required when the generation of recovery passwords is not permitted. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.</summary>
        FVE_E_POLICY_CONFLICT_FDV_RP_OFF_ADB_ON = 0x80310091L,
        /// <summary>BitLocker Drive Encryption cannot be applied to this drive because there are conflicting Group Policy settings for recovery options on removable data drives. Storing recovery information to Active Directory Domain Services cannot be required when the generation of recovery passwords is not permitted. Please have your system administrator resolve these policy conflicts before attempting to enable BitLocker.</summary>
        FVE_E_POLICY_CONFLICT_RDV_RP_OFF_ADB_ON = 0x80310092L,
        /// <summary>The Key Usage (KU) attribute of the specified certificate does not permit it to be used for BitLocker Drive Encryption. BitLocker does not require that a certificate have a KU attribute, but if one is configured it must be set to either Key Encipherment or Key Agreement.</summary>
        FVE_E_NON_BITLOCKER_KU           = 0x80310093L,
        /// <summary>The private key associated with the specified certificate cannot be authorized. The private key authorization was either not provided or the provided authorization was invalid.</summary>
        FVE_E_PRIVATEKEY_AUTH_FAILED     = 0x80310094L,
        /// <summary>Removal of the data recovery agent certificate must be done using the Certificates snap-in.</summary>
        FVE_E_REMOVAL_OF_DRA_FAILED      = 0x80310095L,
        /// <summary>This drive was encrypted using the version of BitLocker Drive Encryption included with Windows Vista and Windows Server 2008 which does not support organizational identifiers. To specify organizational identifiers for this drive upgrade the drive encryption to the latest version using the "manage-bde -upgrade" command.</summary>
        FVE_E_OPERATION_NOT_SUPPORTED_ON_VISTA_VOLUME = 0x80310096L,
        /// <summary>The drive cannot be locked because it is automatically unlocked on this computer.  Remove the automatic unlock protector to lock this drive.</summary>
        FVE_E_CANT_LOCK_AUTOUNLOCK_ENABLED_VOLUME = 0x80310097L,
        /// <summary>The default BitLocker Key Derivation Function SP800-56A for ECC smart cards is not supported by your smart card. The Group Policy setting requiring FIPS-compliance prevents BitLocker from using any other key derivation function for encryption. You have to use a FIPS compliant smart card in FIPS restricted environments.</summary>
        FVE_E_FIPS_HASH_KDF_NOT_ALLOWED  = 0x80310098L,
        /// <summary>The BitLocker encryption key could not be obtained from the Trusted Platform Module (TPM) and enhanced PIN. Try using a PIN containing only numerals.</summary>
        FVE_E_ENH_PIN_INVALID            = 0x80310099L,
        /// <summary>The requested TPM PIN contains invalid characters.</summary>
        FVE_E_INVALID_PIN_CHARS          = 0x8031009AL,
        /// <summary>The management information stored on the drive contained an unknown type. If you are using an old version of Windows, try accessing the drive from the latest version.</summary>
        FVE_E_INVALID_DATUM_TYPE         = 0x8031009BL,
        /// <summary>The feature is only supported on EFI systems.</summary>
        FVE_E_EFI_ONLY                   = 0x8031009CL,
        /// <summary>More than one Network Key Protector certificate has been found on the system.</summary>
        FVE_E_MULTIPLE_NKP_CERTS         = 0x8031009DL,
        /// <summary>Removal of the Network Key Protector certificate must be done using the Certificates snap-in.</summary>
        FVE_E_REMOVAL_OF_NKP_FAILED      = 0x8031009EL,
        /// <summary>An invalid certificate has been found in the Network Key Protector certificate store.</summary>
        FVE_E_INVALID_NKP_CERT           = 0x8031009FL,
        /// <summary>This drive isn't protected with a PIN.</summary>
        FVE_E_NO_EXISTING_PIN            = 0x803100A0L,
        /// <summary>Please enter the correct current PIN.</summary>
        FVE_E_PROTECTOR_CHANGE_PIN_MISMATCH = 0x803100A1L,
        /// <summary>You must be logged on with an administrator account to change the PIN. Click the link to reset the PIN as an administrator.</summary>
        FVE_E_PIN_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = 0x803100A2L,
        /// <summary>BitLocker has disabled PIN changes after too many failed requests. Click the link to reset the PIN as an administrator.</summary>
        FVE_E_PROTECTOR_CHANGE_MAX_PIN_CHANGE_ATTEMPTS_REACHED = 0x803100A3L,
        /// <summary>Your system administrator requires that passwords contain only printable ASCII characters. This includes unaccented letters (A-Z, a-z), numbers (0-9), space, arithmetic signs, common punctuation, separators, and the following symbols: # $ & @ ^ _ ~ .</summary>
        FVE_E_POLICY_PASSPHRASE_REQUIRES_ASCII = 0x803100A4L,
        /// <summary>BitLocker Drive Encryption only supports Used Space Only encryption on thin provisioned storage.</summary>
        FVE_E_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE = 0x803100A5L,
        /// <summary>BitLocker Drive Encryption does not support wiping free space on thin provisioned storage.</summary>
        FVE_E_WIPE_NOT_ALLOWED_ON_TP_STORAGE = 0x803100A6L,
        /// <summary>The required authentication key length is not supported by the drive.</summary>
        FVE_E_KEY_LENGTH_NOT_SUPPORTED_BY_EDRIVE = 0x803100A7L,
        /// <summary>This drive isn't protected with a password.</summary>
        FVE_E_NO_EXISTING_PASSPHRASE     = 0x803100A8L,
        /// <summary>Please enter the correct current password.</summary>
        FVE_E_PROTECTOR_CHANGE_PASSPHRASE_MISMATCH = 0x803100A9L,
        /// <summary>The password cannot exceed 256 characters.</summary>
        FVE_E_PASSPHRASE_TOO_LONG        = 0x803100AAL,
        /// <summary>A password key protector cannot be added because a TPM protector exists on the drive.</summary>
        FVE_E_NO_PASSPHRASE_WITH_TPM     = 0x803100ABL,
        /// <summary>A TPM key protector cannot be added because a password protector exists on the drive.</summary>
        FVE_E_NO_TPM_WITH_PASSPHRASE     = 0x803100ACL,
        /// <summary>This command can only be performed from the coordinator node for the specified CSV volume.</summary>
        FVE_E_NOT_ALLOWED_ON_CSV_STACK   = 0x803100ADL,
        /// <summary>This command cannot be performed on a volume when it is part of a cluster.</summary>
        FVE_E_NOT_ALLOWED_ON_CLUSTER     = 0x803100AEL,
        /// <summary>BitLocker did not revert to using BitLocker software encryption due to group policy configuration.</summary>
        FVE_E_EDRIVE_NO_FAILOVER_TO_SW   = 0x803100AFL,
        /// <summary>The drive cannot be managed by BitLocker because the drive's hardware encryption feature is already in use.</summary>
        FVE_E_EDRIVE_BAND_IN_USE         = 0x803100B0L,
        /// <summary>Group Policy settings do not allow the use of hardware-based encryption.</summary>
        FVE_E_EDRIVE_DISALLOWED_BY_GP    = 0x803100B1L,
        /// <summary>The drive specified does not support hardware-based encryption.</summary>
        FVE_E_EDRIVE_INCOMPATIBLE_VOLUME = 0x803100B2L,
        /// <summary>BitLocker cannot be upgraded during disk encryption or decryption.</summary>
        FVE_E_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING = 0x803100B3L,
        /// <summary>Discovery Volumes are not supported for volumes using hardware encryption.</summary>
        FVE_E_EDRIVE_DV_NOT_SUPPORTED    = 0x803100B4L,
        /// <summary>No pre-boot keyboard detected. The user may not be able to provide required input to unlock the volume.</summary>
        FVE_E_NO_PREBOOT_KEYBOARD_DETECTED = 0x803100B5L,
        /// <summary>No pre-boot keyboard or Windows Recovery Environment detected. The user may not be able to provide required input to unlock the volume.</summary>
        FVE_E_NO_PREBOOT_KEYBOARD_OR_WINRE_DETECTED = 0x803100B6L,
        /// <summary>Group Policy settings require the creation of a startup PIN, but a pre-boot keyboard is not available on this device. The user may not be able to provide required input to unlock the volume.</summary>
        FVE_E_POLICY_REQUIRES_STARTUP_PIN_ON_TOUCH_DEVICE = 0x803100B7L,
        /// <summary>Group Policy settings require the creation of a recovery password, but neither a pre-boot keyboard nor Windows Recovery Environment is available on this device. The user may not be able to provide required input to unlock the volume.</summary>
        FVE_E_POLICY_REQUIRES_RECOVERY_PASSWORD_ON_TOUCH_DEVICE = 0x803100B8L,
        /// <summary>Wipe of free space is not currently taking place.</summary>
        FVE_E_WIPE_CANCEL_NOT_APPLICABLE = 0x803100B9L,
        /// <summary>BitLocker cannot use Secure Boot for platform integrity because Secure Boot has been disabled.</summary>
        FVE_E_SECUREBOOT_DISABLED        = 0x803100BAL,
        /// <summary>BitLocker cannot use Secure Boot for platform integrity because the Secure Boot configuration does not meet the requirements for BitLocker.</summary>
        FVE_E_SECUREBOOT_CONFIGURATION_INVALID = 0x803100BBL,
        /// <summary>Your computer doesn't support BitLocker hardware-based encryption. Check with your computer manufacturer for firmware updates.</summary>
        FVE_E_EDRIVE_DRY_RUN_FAILED      = 0x803100BCL,
        /// <summary>BitLocker cannot be enabled on the volume because it contains a Volume Shadow Copy. Remove all Volume Shadow Copies before encrypting the volume.</summary>
        FVE_E_SHADOW_COPY_PRESENT        = 0x803100BDL,
        /// <summary>BitLocker Drive Encryption cannot be applied to this drive because the Group Policy setting for Enhanced Boot Configuration Data contains invalid data. Please have your system administrator resolve this invalid configuration before attempting to enable BitLocker.</summary>
        FVE_E_POLICY_INVALID_ENHANCED_BCD_SETTINGS = 0x803100BEL,
        /// <summary>This PC's firmware is not capable of supporting hardware encryption.</summary>
        FVE_E_EDRIVE_INCOMPATIBLE_FIRMWARE = 0x803100BFL,
        /// <summary>BitLocker has disabled password changes after too many failed requests. Click the link to reset the password as an administrator.</summary>
        FVE_E_PROTECTOR_CHANGE_MAX_PASSPHRASE_CHANGE_ATTEMPTS_REACHED = 0x803100C0L,
        /// <summary>You must be logged on with an administrator account to change the password. Click the link to reset the password as an administrator.</summary>
        FVE_E_PASSPHRASE_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = 0x803100C1L,
        /// <summary>BitLocker cannot save the recovery password because the specified Microsoft account is Suspended.</summary>
        FVE_E_LIVEID_ACCOUNT_SUSPENDED   = 0x803100C2L,
        /// <summary>BitLocker cannot save the recovery password because the specified Microsoft account is Blocked.</summary>
        FVE_E_LIVEID_ACCOUNT_BLOCKED     = 0x803100C3L,
        /// <summary>This PC is not provisioned to support device encryption. Please enable BitLocker on all volumes to comply with device encryption policy.</summary>
        FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES = 0x803100C4L,
        /// <summary>This PC cannot support device encryption because unencrypted fixed data volumes are present.</summary>
        FVE_E_DE_FIXED_DATA_NOT_SUPPORTED = 0x803100C5L,
        /// <summary>This PC does not meet the hardware requirements to support device encryption.</summary>
        FVE_E_DE_HARDWARE_NOT_COMPLIANT  = 0x803100C6L,
        /// <summary>This PC cannot support device encryption because WinRE is not properly configured.</summary>
        FVE_E_DE_WINRE_NOT_CONFIGURED    = 0x803100C7L,
        /// <summary>Protection is enabled on the volume but has been suspended. This is likely to have happened due to an update being applied to your system. Please try again after a reboot.</summary>
        FVE_E_DE_PROTECTION_SUSPENDED    = 0x803100C8L,
        /// <summary>This PC is not provisioned to support device encryption.</summary>
        FVE_E_DE_OS_VOLUME_NOT_PROTECTED = 0x803100C9L,
        /// <summary>Device Lock has been triggered due to too many incorrect password attempts.</summary>
        FVE_E_DE_DEVICE_LOCKEDOUT        = 0x803100CAL,
        /// <summary>Protection has not been enabled on the volume. Enabling protection requires a connected account. If you already have a connected account and are seeing this error, please refer to the event log for more information.</summary>
        FVE_E_DE_PROTECTION_NOT_YET_ENABLED = 0x803100CBL,
        /// <summary>Your PIN can only contain numbers from 0 to 9.</summary>
        FVE_E_INVALID_PIN_CHARS_DETAILED = 0x803100CCL,
        /// <summary>BitLocker cannot use hardware replay protection because no counter is available on your PC.</summary>
        FVE_E_DEVICE_LOCKOUT_COUNTER_UNAVAILABLE = 0x803100CDL,
        /// <summary>Device Lockout state validation failed due to counter mismatch.</summary>
        FVE_E_DEVICELOCKOUT_COUNTER_MISMATCH = 0x803100CEL,
        /// <summary>The input buffer is too large.</summary>
        FVE_E_BUFFER_TOO_LARGE           = 0x803100CFL,
        /// <summary>The target of an invocation does not support requested capability.</summary>
        FVE_E_NO_SUCH_CAPABILITY_ON_TARGET = 0x803100D0L,
        /// <summary>Device encryption is currently blocked by this PC's configuration.</summary>
        FVE_E_DE_PREVENTED_FOR_OS        = 0x803100D1L,
        /// <summary>This drive has been opted out of device encryption.</summary>
        FVE_E_DE_VOLUME_OPTED_OUT        = 0x803100D2L,
        /// <summary>Device encryption isn't available for this drive.</summary>
        FVE_E_DE_VOLUME_NOT_SUPPORTED    = 0x803100D3L,
        /// <summary>The encrypt on write mode for BitLocker is not supported in this version of Windows. You can turn on BitLocker without using the encrypt on write mode.</summary>
        FVE_E_EOW_NOT_SUPPORTED_IN_VERSION = 0x803100D4L,
        /// <summary>Group policy prevents you from backing up your recovery password to Active Directory for this drive type. For more info, contact your system administrator.</summary>
        FVE_E_ADBACKUP_NOT_ENABLED       = 0x803100D5L,
        /// <summary>Device encryption can't be turned off while this drive is being encrypted. Please try again later.</summary>
        FVE_E_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT = 0x803100D6L,
        /// <summary>This action isn't supported because this drive isn't automatically managed with device encryption.</summary>
        FVE_E_NOT_DE_VOLUME              = 0x803100D7L,
        /// <summary>BitLocker can't be suspended on this drive until the next restart.</summary>
        FVE_E_PROTECTION_CANNOT_BE_DISABLED = 0x803100D8L,
        /// <summary>The callout does not exist.</summary>
        FWP_E_CALLOUT_NOT_FOUND          = 0x80320001L,
        /// <summary>The filter condition does not exist.</summary>
        FWP_E_CONDITION_NOT_FOUND        = 0x80320002L,
        /// <summary>The filter does not exist.</summary>
        FWP_E_FILTER_NOT_FOUND           = 0x80320003L,
        /// <summary>The layer does not exist.</summary>
        FWP_E_LAYER_NOT_FOUND            = 0x80320004L,
        /// <summary>The provider does not exist.</summary>
        FWP_E_PROVIDER_NOT_FOUND         = 0x80320005L,
        /// <summary>The provider context does not exist.</summary>
        FWP_E_PROVIDER_CONTEXT_NOT_FOUND = 0x80320006L,
        /// <summary>The sublayer does not exist.</summary>
        FWP_E_SUBLAYER_NOT_FOUND         = 0x80320007L,
        /// <summary>The object does not exist.</summary>
        FWP_E_NOT_FOUND                  = 0x80320008L,
        /// <summary>An object with that GUID or LUID already exists.</summary>
        FWP_E_ALREADY_EXISTS             = 0x80320009L,
        /// <summary>The object is referenced by other objects so cannot be deleted.</summary>
        FWP_E_IN_USE                     = 0x8032000AL,
        /// <summary>The call is not allowed from within a dynamic session.</summary>
        FWP_E_DYNAMIC_SESSION_IN_PROGRESS = 0x8032000BL,
        /// <summary>The call was made from the wrong session so cannot be completed.</summary>
        FWP_E_WRONG_SESSION              = 0x8032000CL,
        /// <summary>The call must be made from within an explicit transaction.</summary>
        FWP_E_NO_TXN_IN_PROGRESS         = 0x8032000DL,
        /// <summary>The call is not allowed from within an explicit transaction.</summary>
        FWP_E_TXN_IN_PROGRESS            = 0x8032000EL,
        /// <summary>The explicit transaction has been forcibly cancelled.</summary>
        FWP_E_TXN_ABORTED                = 0x8032000FL,
        /// <summary>The session has been cancelled.</summary>
        FWP_E_SESSION_ABORTED            = 0x80320010L,
        /// <summary>The call is not allowed from within a read-only transaction.</summary>
        FWP_E_INCOMPATIBLE_TXN           = 0x80320011L,
        /// <summary>The call timed out while waiting to acquire the transaction lock.</summary>
        FWP_E_TIMEOUT                    = 0x80320012L,
        /// <summary>Collection of network diagnostic events is disabled.</summary>
        FWP_E_NET_EVENTS_DISABLED        = 0x80320013L,
        /// <summary>The operation is not supported by the specified layer.</summary>
        FWP_E_INCOMPATIBLE_LAYER         = 0x80320014L,
        /// <summary>The call is allowed for kernel-mode callers only.</summary>
        FWP_E_KM_CLIENTS_ONLY            = 0x80320015L,
        /// <summary>The call tried to associate two objects with incompatible lifetimes.</summary>
        FWP_E_LIFETIME_MISMATCH          = 0x80320016L,
        /// <summary>The object is built in so cannot be deleted.</summary>
        FWP_E_BUILTIN_OBJECT             = 0x80320017L,
        /// <summary>The maximum number of callouts has been reached.</summary>
        FWP_E_TOO_MANY_CALLOUTS          = 0x80320018L,
        /// <summary>A notification could not be delivered because a message queue is at its maximum capacity.</summary>
        FWP_E_NOTIFICATION_DROPPED       = 0x80320019L,
        /// <summary>The traffic parameters do not match those for the security association context.</summary>
        FWP_E_TRAFFIC_MISMATCH           = 0x8032001AL,
        /// <summary>The call is not allowed for the current security association state.</summary>
        FWP_E_INCOMPATIBLE_SA_STATE      = 0x8032001BL,
        /// <summary>A required pointer is null.</summary>
        FWP_E_NULL_POINTER               = 0x8032001CL,
        /// <summary>An enumerator is not valid.</summary>
        FWP_E_INVALID_ENUMERATOR         = 0x8032001DL,
        /// <summary>The flags field contains an invalid value.</summary>
        FWP_E_INVALID_FLAGS              = 0x8032001EL,
        /// <summary>A network mask is not valid.</summary>
        FWP_E_INVALID_NET_MASK           = 0x8032001FL,
        /// <summary>An FWP_RANGE is not valid.</summary>
        FWP_E_INVALID_RANGE              = 0x80320020L,
        /// <summary>The time interval is not valid.</summary>
        FWP_E_INVALID_INTERVAL           = 0x80320021L,
        /// <summary>An array that must contain at least one element is zero length.</summary>
        FWP_E_ZERO_LENGTH_ARRAY          = 0x80320022L,
        /// <summary>The displayData.name field cannot be null.</summary>
        FWP_E_NULL_DISPLAY_NAME          = 0x80320023L,
        /// <summary>The action type is not one of the allowed action types for a filter.</summary>
        FWP_E_INVALID_ACTION_TYPE        = 0x80320024L,
        /// <summary>The filter weight is not valid.</summary>
        FWP_E_INVALID_WEIGHT             = 0x80320025L,
        /// <summary>A filter condition contains a match type that is not compatible with the operands.</summary>
        FWP_E_MATCH_TYPE_MISMATCH        = 0x80320026L,
        /// <summary>An FWP_VALUE or FWPM_CONDITION_VALUE is of the wrong type.</summary>
        FWP_E_TYPE_MISMATCH              = 0x80320027L,
        /// <summary>An integer value is outside the allowed range.</summary>
        FWP_E_OUT_OF_BOUNDS              = 0x80320028L,
        /// <summary>A reserved field is non-zero.</summary>
        FWP_E_RESERVED                   = 0x80320029L,
        /// <summary>A filter cannot contain multiple conditions operating on a single field.</summary>
        FWP_E_DUPLICATE_CONDITION        = 0x8032002AL,
        /// <summary>A policy cannot contain the same keying module more than once.</summary>
        FWP_E_DUPLICATE_KEYMOD           = 0x8032002BL,
        /// <summary>The action type is not compatible with the layer.</summary>
        FWP_E_ACTION_INCOMPATIBLE_WITH_LAYER = 0x8032002CL,
        /// <summary>The action type is not compatible with the sublayer.</summary>
        FWP_E_ACTION_INCOMPATIBLE_WITH_SUBLAYER = 0x8032002DL,
        /// <summary>The raw context or the provider context is not compatible with the layer.</summary>
        FWP_E_CONTEXT_INCOMPATIBLE_WITH_LAYER = 0x8032002EL,
        /// <summary>The raw context or the provider context is not compatible with the callout.</summary>
        FWP_E_CONTEXT_INCOMPATIBLE_WITH_CALLOUT = 0x8032002FL,
        /// <summary>The authentication method is not compatible with the policy type.</summary>
        FWP_E_INCOMPATIBLE_AUTH_METHOD   = 0x80320030L,
        /// <summary>The Diffie-Hellman group is not compatible with the policy type.</summary>
        FWP_E_INCOMPATIBLE_DH_GROUP      = 0x80320031L,
        /// <summary>An IKE policy cannot contain an Extended Mode policy.</summary>
        FWP_E_EM_NOT_SUPPORTED           = 0x80320032L,
        /// <summary>The enumeration template or subscription will never match any objects.</summary>
        FWP_E_NEVER_MATCH                = 0x80320033L,
        /// <summary>The provider context is of the wrong type.</summary>
        FWP_E_PROVIDER_CONTEXT_MISMATCH  = 0x80320034L,
        /// <summary>The parameter is incorrect.</summary>
        FWP_E_INVALID_PARAMETER          = 0x80320035L,
        /// <summary>The maximum number of sublayers has been reached.</summary>
        FWP_E_TOO_MANY_SUBLAYERS         = 0x80320036L,
        /// <summary>The notification function for a callout returned an error.</summary>
        FWP_E_CALLOUT_NOTIFICATION_FAILED = 0x80320037L,
        /// <summary>The IPsec authentication transform is not valid.</summary>
        FWP_E_INVALID_AUTH_TRANSFORM     = 0x80320038L,
        /// <summary>The IPsec cipher transform is not valid.</summary>
        FWP_E_INVALID_CIPHER_TRANSFORM   = 0x80320039L,
        /// <summary>The IPsec cipher transform is not compatible with the policy.</summary>
        FWP_E_INCOMPATIBLE_CIPHER_TRANSFORM = 0x8032003AL,
        /// <summary>The combination of IPsec transform types is not valid.</summary>
        FWP_E_INVALID_TRANSFORM_COMBINATION = 0x8032003BL,
        /// <summary>A policy cannot contain the same auth method more than once.</summary>
        FWP_E_DUPLICATE_AUTH_METHOD      = 0x8032003CL,
        /// <summary>A tunnel endpoint configuration is invalid.</summary>
        FWP_E_INVALID_TUNNEL_ENDPOINT    = 0x8032003DL,
        /// <summary>The WFP MAC Layers are not ready.</summary>
        FWP_E_L2_DRIVER_NOT_READY        = 0x8032003EL,
        /// <summary>A key manager capable of key dictation is already registered</summary>
        FWP_E_KEY_DICTATOR_ALREADY_REGISTERED = 0x8032003FL,
        /// <summary>A key manager dictated invalid keys</summary>
        FWP_E_KEY_DICTATION_INVALID_KEYING_MATERIAL = 0x80320040L,
        /// <summary>The BFE IPsec Connection Tracking is disabled.</summary>
        FWP_E_CONNECTIONS_DISABLED       = 0x80320041L,
        /// <summary>The DNS name is invalid.</summary>
        FWP_E_INVALID_DNS_NAME           = 0x80320042L,
        /// <summary>The engine option is still enabled due to other configuration settings.</summary>
        FWP_E_STILL_ON                   = 0x80320043L,
        /// <summary>The IKEEXT service is not running.  This service only runs when there is IPsec policy applied to the machine.</summary>
        FWP_E_IKEEXT_NOT_RUNNING         = 0x80320044L,
        /// <summary>The packet should be dropped, no ICMP should be sent.</summary>
        FWP_E_DROP_NOICMP                = 0x80320104L,
        /// <summary>The function call is completing asynchronously.</summary>
        WS_S_ASYNC                       = 0x003D0000L,
        /// <summary>There are no more messages available on the channel.</summary>
        WS_S_END                         = 0x003D0001L,
        /// <summary>The input data was not in the expected format or did not have the expected value.</summary>
        WS_E_INVALID_FORMAT              = 0x803D0000L,
        /// <summary>The operation could not be completed because the object is in a faulted state due to a previous error.</summary>
        WS_E_OBJECT_FAULTED              = 0x803D0001L,
        /// <summary>The operation could not be completed because it would lead to numeric overflow.</summary>
        WS_E_NUMERIC_OVERFLOW            = 0x803D0002L,
        /// <summary>The operation is not allowed due to the current state of the object.</summary>
        WS_E_INVALID_OPERATION           = 0x803D0003L,
        /// <summary>The operation was aborted.</summary>
        WS_E_OPERATION_ABORTED           = 0x803D0004L,
        /// <summary>Access was denied by the remote endpoint.</summary>
        WS_E_ENDPOINT_ACCESS_DENIED      = 0x803D0005L,
        /// <summary>The operation did not complete within the time allotted.</summary>
        WS_E_OPERATION_TIMED_OUT         = 0x803D0006L,
        /// <summary>The operation was abandoned.</summary>
        WS_E_OPERATION_ABANDONED         = 0x803D0007L,
        /// <summary>A quota was exceeded.</summary>
        WS_E_QUOTA_EXCEEDED              = 0x803D0008L,
        /// <summary>The information was not available in the specified language.</summary>
        WS_E_NO_TRANSLATION_AVAILABLE    = 0x803D0009L,
        /// <summary>Security verification was not successful for the received data.</summary>
        WS_E_SECURITY_VERIFICATION_FAILURE = 0x803D000AL,
        /// <summary>The address is already being used.</summary>
        WS_E_ADDRESS_IN_USE              = 0x803D000BL,
        /// <summary>The address is not valid for this context.</summary>
        WS_E_ADDRESS_NOT_AVAILABLE       = 0x803D000CL,
        /// <summary>The remote endpoint does not exist or could not be located.</summary>
        WS_E_ENDPOINT_NOT_FOUND          = 0x803D000DL,
        /// <summary>The remote endpoint is not currently in service at this location.</summary>
        WS_E_ENDPOINT_NOT_AVAILABLE      = 0x803D000EL,
        /// <summary>The remote endpoint could not process the request.</summary>
        WS_E_ENDPOINT_FAILURE            = 0x803D000FL,
        /// <summary>The remote endpoint was not reachable.</summary>
        WS_E_ENDPOINT_UNREACHABLE        = 0x803D0010L,
        /// <summary>The operation was not supported by the remote endpoint.</summary>
        WS_E_ENDPOINT_ACTION_NOT_SUPPORTED = 0x803D0011L,
        /// <summary>The remote endpoint is unable to process the request due to being overloaded.</summary>
        WS_E_ENDPOINT_TOO_BUSY           = 0x803D0012L,
        /// <summary>A message containing a fault was received from the remote endpoint.</summary>
        WS_E_ENDPOINT_FAULT_RECEIVED     = 0x803D0013L,
        /// <summary>The connection with the remote endpoint was terminated.</summary>
        WS_E_ENDPOINT_DISCONNECTED       = 0x803D0014L,
        /// <summary>The HTTP proxy server could not process the request.</summary>
        WS_E_PROXY_FAILURE               = 0x803D0015L,
        /// <summary>Access was denied by the HTTP proxy server.</summary>
        WS_E_PROXY_ACCESS_DENIED         = 0x803D0016L,
        /// <summary>The requested feature is not available on this platform.</summary>
        WS_E_NOT_SUPPORTED               = 0x803D0017L,
        /// <summary>The HTTP proxy server requires HTTP authentication scheme 'basic'.</summary>
        WS_E_PROXY_REQUIRES_BASIC_AUTH   = 0x803D0018L,
        /// <summary>The HTTP proxy server requires HTTP authentication scheme 'digest'.</summary>
        WS_E_PROXY_REQUIRES_DIGEST_AUTH  = 0x803D0019L,
        /// <summary>The HTTP proxy server requires HTTP authentication scheme 'NTLM'.</summary>
        WS_E_PROXY_REQUIRES_NTLM_AUTH    = 0x803D001AL,
        /// <summary>The HTTP proxy server requires HTTP authentication scheme 'negotiate'.</summary>
        WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH = 0x803D001BL,
        /// <summary>The remote endpoint requires HTTP authentication scheme 'basic'.</summary>
        WS_E_SERVER_REQUIRES_BASIC_AUTH  = 0x803D001CL,
        /// <summary>The remote endpoint requires HTTP authentication scheme 'digest'.</summary>
        WS_E_SERVER_REQUIRES_DIGEST_AUTH = 0x803D001DL,
        /// <summary>The remote endpoint requires HTTP authentication scheme 'NTLM'.</summary>
        WS_E_SERVER_REQUIRES_NTLM_AUTH   = 0x803D001EL,
        /// <summary>The remote endpoint requires HTTP authentication scheme 'negotiate'.</summary>
        WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH = 0x803D001FL,
        /// <summary>The endpoint address URL is invalid.</summary>
        WS_E_INVALID_ENDPOINT_URL        = 0x803D0020L,
        /// <summary>Unrecognized error occurred in the Windows Web Services framework.</summary>
        WS_E_OTHER                       = 0x803D0021L,
        /// <summary>A security token was rejected by the server because it has expired.</summary>
        WS_E_SECURITY_TOKEN_EXPIRED      = 0x803D0022L,
        /// <summary>A security operation failed in the Windows Web Services framework.</summary>
        WS_E_SECURITY_SYSTEM_FAILURE     = 0x803D0023L,
        /// <summary>The binding to the network interface is being closed.</summary>
        ERROR_NDIS_INTERFACE_CLOSING     = 0x80340002L,
        /// <summary>An invalid version was specified.</summary>
        ERROR_NDIS_BAD_VERSION           = 0x80340004L,
        /// <summary>An invalid characteristics table was used.</summary>
        ERROR_NDIS_BAD_CHARACTERISTICS   = 0x80340005L,
        /// <summary>Failed to find the network interface or network interface is not ready.</summary>
        ERROR_NDIS_ADAPTER_NOT_FOUND     = 0x80340006L,
        /// <summary>Failed to open the network interface.</summary>
        ERROR_NDIS_OPEN_FAILED           = 0x80340007L,
        /// <summary>Network interface has encountered an internal unrecoverable failure.</summary>
        ERROR_NDIS_DEVICE_FAILED         = 0x80340008L,
        /// <summary>The multicast list on the network interface is full.</summary>
        ERROR_NDIS_MULTICAST_FULL        = 0x80340009L,
        /// <summary>An attempt was made to add a duplicate multicast address to the list.</summary>
        ERROR_NDIS_MULTICAST_EXISTS      = 0x8034000AL,
        /// <summary>At attempt was made to remove a multicast address that was never added.</summary>
        ERROR_NDIS_MULTICAST_NOT_FOUND   = 0x8034000BL,
        /// <summary>Netowork interface aborted the request.</summary>
        ERROR_NDIS_REQUEST_ABORTED       = 0x8034000CL,
        /// <summary>Network interface can not process the request because it is being reset.</summary>
        ERROR_NDIS_RESET_IN_PROGRESS     = 0x8034000DL,
        /// <summary>Netword interface does not support this request.</summary>
        ERROR_NDIS_NOT_SUPPORTED         = 0x803400BBL,
        /// <summary>An attempt was made to send an invalid packet on a network interface.</summary>
        ERROR_NDIS_INVALID_PACKET        = 0x8034000FL,
        /// <summary>Network interface is not ready to complete this operation.</summary>
        ERROR_NDIS_ADAPTER_NOT_READY     = 0x80340011L,
        /// <summary>The length of the buffer submitted for this operation is not valid.</summary>
        ERROR_NDIS_INVALID_LENGTH        = 0x80340014L,
        /// <summary>The data used for this operation is not valid.</summary>
        ERROR_NDIS_INVALID_DATA          = 0x80340015L,
        /// <summary>The length of buffer submitted for this operation is too small.</summary>
        ERROR_NDIS_BUFFER_TOO_SHORT      = 0x80340016L,
        /// <summary>Network interface does not support this OID (Object Identifier)</summary>
        ERROR_NDIS_INVALID_OID           = 0x80340017L,
        /// <summary>The network interface has been removed.</summary>
        ERROR_NDIS_ADAPTER_REMOVED       = 0x80340018L,
        /// <summary>Network interface does not support this media type.</summary>
        ERROR_NDIS_UNSUPPORTED_MEDIA     = 0x80340019L,
        /// <summary>An attempt was made to remove a token ring group address that is in use by other components.</summary>
        ERROR_NDIS_GROUP_ADDRESS_IN_USE  = 0x8034001AL,
        /// <summary>An attempt was made to map a file that can not be found.</summary>
        ERROR_NDIS_FILE_NOT_FOUND        = 0x8034001BL,
        /// <summary>An error occurred while NDIS tried to map the file.</summary>
        ERROR_NDIS_ERROR_READING_FILE    = 0x8034001CL,
        /// <summary>An attempt was made to map a file that is alreay mapped.</summary>
        ERROR_NDIS_ALREADY_MAPPED        = 0x8034001DL,
        /// <summary>An attempt to allocate a hardware resource failed because the resource is used by another component.</summary>
        ERROR_NDIS_RESOURCE_CONFLICT     = 0x8034001EL,
        /// <summary>The I/O operation failed because network media is disconnected or wireless access point is out of range.</summary>
        ERROR_NDIS_MEDIA_DISCONNECTED    = 0x8034001FL,
        /// <summary>The network address used in the request is invalid.</summary>
        ERROR_NDIS_INVALID_ADDRESS       = 0x80340022L,
        /// <summary>The specified request is not a valid operation for the target device.</summary>
        ERROR_NDIS_INVALID_DEVICE_REQUEST = 0x80340010L,
        /// <summary>The offload operation on the network interface has been paused.</summary>
        ERROR_NDIS_PAUSED                = 0x8034002AL,
        /// <summary>Network interface was not found.</summary>
        ERROR_NDIS_INTERFACE_NOT_FOUND   = 0x8034002BL,
        /// <summary>The revision number specified in the structure is not supported.</summary>
        ERROR_NDIS_UNSUPPORTED_REVISION  = 0x8034002CL,
        /// <summary>The specified port does not exist on this network interface.</summary>
        ERROR_NDIS_INVALID_PORT          = 0x8034002DL,
        /// <summary>The current state of the specified port on this network interface does not support the requested operation.</summary>
        ERROR_NDIS_INVALID_PORT_STATE    = 0x8034002EL,
        /// <summary>The miniport adapter is in low power state.</summary>
        ERROR_NDIS_LOW_POWER_STATE       = 0x8034002FL,
        /// <summary>This operation requires the miniport adapter to be reinitialized.</summary>
        ERROR_NDIS_REINIT_REQUIRED       = 0x80340030L,
        /// <summary>The wireless local area network interface is in auto configuration mode and doesn't support the requested parameter change operation.</summary>
        ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED = 0x80342000L,
        /// <summary>The wireless local area network interface is busy and can not perform the requested operation.</summary>
        ERROR_NDIS_DOT11_MEDIA_IN_USE    = 0x80342001L,
        /// <summary>The wireless local area network interface is powered down and doesn't support the requested operation.</summary>
        ERROR_NDIS_DOT11_POWER_STATE_INVALID = 0x80342002L,
        /// <summary>The list of wake on LAN patterns is full.</summary>
        ERROR_NDIS_PM_WOL_PATTERN_LIST_FULL = 0x80342003L,
        /// <summary>The list of low power protocol offloads is full.</summary>
        ERROR_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL = 0x80342004L,
        /// <summary>The wireless local area network interface cannot start an AP on the specified channel right now.</summary>
        ERROR_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE = 0x80342005L,
        /// <summary>The wireless local area network interface cannot start an AP on the specified band right now.</summary>
        ERROR_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE = 0x80342006L,
        /// <summary>The wireless local area network interface cannot start an AP on this channel due to regulatory reasons.</summary>
        ERROR_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED = 0x80342007L,
        /// <summary>The wireless local area network interface cannot start an AP on this band due to regulatory reasons.</summary>
        ERROR_NDIS_DOT11_AP_BAND_NOT_ALLOWED = 0x80342008L,
        /// <summary>The request will be completed later by NDIS status indication.</summary>
        ERROR_NDIS_INDICATION_REQUIRED   = 0x00340001L,
        /// <summary>The TCP connection is not offloadable because of a local policy setting.</summary>
        ERROR_NDIS_OFFLOAD_POLICY        = 0xC034100FL,
        /// <summary>The TCP connection is not offloadable by the Chimney Offload target.</summary>
        ERROR_NDIS_OFFLOAD_CONNECTION_REJECTED = 0xC0341012L,
        /// <summary>The IP Path object is not in an offloadable state.</summary>
        ERROR_NDIS_OFFLOAD_PATH_REJECTED = 0xC0341013L,
        /// <summary>The hypervisor does not support the operation because the specified hypercall code is not supported.</summary>
        ERROR_HV_INVALID_HYPERCALL_CODE  = 0xC0350002L,
        /// <summary>The hypervisor does not support the operation because the encoding for the hypercall input register is not supported.</summary>
        ERROR_HV_INVALID_HYPERCALL_INPUT = 0xC0350003L,
        /// <summary>The hypervisor could not perform the operation because a parameter has an invalid alignment.</summary>
        ERROR_HV_INVALID_ALIGNMENT       = 0xC0350004L,
        /// <summary>The hypervisor could not perform the operation because an invalid parameter was specified.</summary>
        ERROR_HV_INVALID_PARAMETER       = 0xC0350005L,
        /// <summary>Access to the specified object was denied.</summary>
        ERROR_HV_ACCESS_DENIED           = 0xC0350006L,
        /// <summary>The hypervisor could not perform the operation because the partition is entering or in an invalid state.</summary>
        ERROR_HV_INVALID_PARTITION_STATE = 0xC0350007L,
        /// <summary>The operation is not allowed in the current state.</summary>
        ERROR_HV_OPERATION_DENIED        = 0xC0350008L,
        /// <summary>The hypervisor does not recognize the specified partition property.</summary>
        ERROR_HV_UNKNOWN_PROPERTY        = 0xC0350009L,
        /// <summary>The specified value of a partition property is out of range or violates an invariant.</summary>
        ERROR_HV_PROPERTY_VALUE_OUT_OF_RANGE = 0xC035000AL,
        /// <summary>There is not enough memory in the hypervisor pool to complete the operation.</summary>
        ERROR_HV_INSUFFICIENT_MEMORY     = 0xC035000BL,
        /// <summary>The maximum partition depth has been exceeded for the partition hierarchy.</summary>
        ERROR_HV_PARTITION_TOO_DEEP      = 0xC035000CL,
        /// <summary>A partition with the specified partition Id does not exist.</summary>
        ERROR_HV_INVALID_PARTITION_ID    = 0xC035000DL,
        /// <summary>The hypervisor could not perform the operation because the specified VP index is invalid.</summary>
        ERROR_HV_INVALID_VP_INDEX        = 0xC035000EL,
        /// <summary>The hypervisor could not perform the operation because the specified port identifier is invalid.</summary>
        ERROR_HV_INVALID_PORT_ID         = 0xC0350011L,
        /// <summary>The hypervisor could not perform the operation because the specified connection identifier is invalid.</summary>
        ERROR_HV_INVALID_CONNECTION_ID   = 0xC0350012L,
        /// <summary>Not enough buffers were supplied to send a message.</summary>
        ERROR_HV_INSUFFICIENT_BUFFERS    = 0xC0350013L,
        /// <summary>The previous virtual interrupt has not been acknowledged.</summary>
        ERROR_HV_NOT_ACKNOWLEDGED        = 0xC0350014L,
        /// <summary>A virtual processor is not in the correct state for the indicated operation.</summary>
        ERROR_HV_INVALID_VP_STATE        = 0xC0350015L,
        /// <summary>The previous virtual interrupt has already been acknowledged.</summary>
        ERROR_HV_ACKNOWLEDGED            = 0xC0350016L,
        /// <summary>The indicated partition is not in a valid state for saving or restoring.</summary>
        ERROR_HV_INVALID_SAVE_RESTORE_STATE = 0xC0350017L,
        /// <summary>The hypervisor could not complete the operation because a required feature of the synthetic interrupt controller (SynIC) was disabled.</summary>
        ERROR_HV_INVALID_SYNIC_STATE     = 0xC0350018L,
        /// <summary>The hypervisor could not perform the operation because the object or value was either already in use or being used for a purpose that would not permit completing the operation.</summary>
        ERROR_HV_OBJECT_IN_USE           = 0xC0350019L,
        /// <summary>The proximity domain information is invalid.</summary>
        ERROR_HV_INVALID_PROXIMITY_DOMAIN_INFO = 0xC035001AL,
        /// <summary>An attempt to retrieve debugging data failed because none was available.</summary>
        ERROR_HV_NO_DATA                 = 0xC035001BL,
        /// <summary>The physical connection being used for debuggging has not recorded any receive activity since the last operation.</summary>
        ERROR_HV_INACTIVE                = 0xC035001CL,
        /// <summary>There are not enough resources to complete the operation.</summary>
        ERROR_HV_NO_RESOURCES            = 0xC035001DL,
        /// <summary>A hypervisor feature is not available to the user.</summary>
        ERROR_HV_FEATURE_UNAVAILABLE     = 0xC035001EL,
        /// <summary>The specified buffer was too small to contain all of the requested data.</summary>
        ERROR_HV_INSUFFICIENT_BUFFER     = 0xC0350033L,
        /// <summary>The maximum number of domains supported by the platform I/O remapping hardware is currently in use. No domains are available to assign this device to this partition.</summary>
        ERROR_HV_INSUFFICIENT_DEVICE_DOMAINS = 0xC0350038L,
        /// <summary>Validation of CPUID data of the processor failed.</summary>
        ERROR_HV_CPUID_FEATURE_VALIDATION = 0xC035003CL,
        /// <summary>Validation of XSAVE CPUID data of the processor failed.</summary>
        ERROR_HV_CPUID_XSAVE_FEATURE_VALIDATION = 0xC035003DL,
        /// <summary>Processor did not respond within the timeout period.</summary>
        ERROR_HV_PROCESSOR_STARTUP_TIMEOUT = 0xC035003EL,
        /// <summary>SMX has been enabled in the BIOS.</summary>
        ERROR_HV_SMX_ENABLED             = 0xC035003FL,
        /// <summary>The hypervisor could not perform the operation because the specified LP index is invalid.</summary>
        ERROR_HV_INVALID_LP_INDEX        = 0xC0350041L,
        /// <summary>The supplied register value is invalid.</summary>
        ERROR_HV_INVALID_REGISTER_VALUE  = 0xC0350050L,
        /// <summary>The supplied virtual trust level is not in the correct state to perform the requested operation.</summary>
        ERROR_HV_INVALID_VTL_STATE       = 0xC0350051L,
        /// <summary>No execute feature (NX) is not present or not enabled in the BIOS.</summary>
        ERROR_HV_NX_NOT_DETECTED         = 0xC0350055L,
        /// <summary>The supplied device ID is invalid.</summary>
        ERROR_HV_INVALID_DEVICE_ID       = 0xC0350057L,
        /// <summary>The operation is not allowed in the current device state.</summary>
        ERROR_HV_INVALID_DEVICE_STATE    = 0xC0350058L,
        /// <summary>The device had pending page requests which were discarded.</summary>
        ERROR_HV_PENDING_PAGE_REQUESTS   = 0x00350059L,
        /// <summary>The supplied page request specifies a memory access that the guest does not have permissions to perform.</summary>
        ERROR_HV_PAGE_REQUEST_INVALID    = 0xC0350060L,
        /// <summary>A CPU group with the specified CPU group Id does not exist.</summary>
        ERROR_HV_INVALID_CPU_GROUP_ID    = 0xC035006FL,
        /// <summary>The hypervisor could not perform the operation because the CPU group is entering or in an invalid state.</summary>
        ERROR_HV_INVALID_CPU_GROUP_STATE = 0xC0350070L,
        /// <summary>The hypervisor could not perform the operation because it is not allowed with nested virtualization active.</summary>
        ERROR_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE = 0xC0350071L,
        /// <summary>No hypervisor is present on this system.</summary>
        ERROR_HV_NOT_PRESENT             = 0xC0351000L,
        /// <summary>The handler for the virtualization infrastructure driver is already registered. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_DUPLICATE_HANDLER      = 0xC0370001L,
        /// <summary>The number of registered handlers for the virtualization infrastructure driver exceeded the maximum. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_TOO_MANY_HANDLERS      = 0xC0370002L,
        /// <summary>The message queue for the virtualization infrastructure driver is full and cannot accept new messages. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_QUEUE_FULL             = 0xC0370003L,
        /// <summary>No handler exists to handle the message for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_HANDLER_NOT_PRESENT    = 0xC0370004L,
        /// <summary>The name of the partition or message queue for the virtualization infrastructure driver is invalid. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_INVALID_OBJECT_NAME    = 0xC0370005L,
        /// <summary>The partition name of the virtualization infrastructure driver exceeds the maximum.</summary>
        ERROR_VID_PARTITION_NAME_TOO_LONG = 0xC0370006L,
        /// <summary>The message queue name of the virtualization infrastructure driver exceeds the maximum.</summary>
        ERROR_VID_MESSAGE_QUEUE_NAME_TOO_LONG = 0xC0370007L,
        /// <summary>Cannot create the partition for the virtualization infrastructure driver because another partition with the same name already exists.</summary>
        ERROR_VID_PARTITION_ALREADY_EXISTS = 0xC0370008L,
        /// <summary>The virtualization infrastructure driver has encountered an error. The requested partition does not exist. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_PARTITION_DOES_NOT_EXIST = 0xC0370009L,
        /// <summary>The virtualization infrastructure driver has encountered an error. Could not find the requested partition. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_PARTITION_NAME_NOT_FOUND = 0xC037000AL,
        /// <summary>A message queue with the same name already exists for the virtualization infrastructure driver.</summary>
        ERROR_VID_MESSAGE_QUEUE_ALREADY_EXISTS = 0xC037000BL,
        /// <summary>The memory block page for the virtualization infrastructure driver cannot be mapped because the page map limit has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT = 0xC037000CL,
        /// <summary>The memory block for the virtualization infrastructure driver is still being used and cannot be destroyed.</summary>
        ERROR_VID_MB_STILL_REFERENCED    = 0xC037000DL,
        /// <summary>Cannot unlock the page array for the guest operating system memory address because it does not match a previous lock request. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_CHILD_GPA_PAGE_SET_CORRUPTED = 0xC037000EL,
        /// <summary>The non-uniform memory access (NUMA) node settings do not match the system NUMA topology. In order to start the virtual machine, you will need to modify the NUMA configuration.</summary>
        ERROR_VID_INVALID_NUMA_SETTINGS  = 0xC037000FL,
        /// <summary>The non-uniform memory access (NUMA) node index does not match a valid index in the system NUMA topology.</summary>
        ERROR_VID_INVALID_NUMA_NODE_INDEX = 0xC0370010L,
        /// <summary>The memory block for the virtualization infrastructure driver is already associated with a message queue.</summary>
        ERROR_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED = 0xC0370011L,
        /// <summary>The handle is not a valid memory block handle for the virtualization infrastructure driver.</summary>
        ERROR_VID_INVALID_MEMORY_BLOCK_HANDLE = 0xC0370012L,
        /// <summary>The request exceeded the memory block page limit for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_PAGE_RANGE_OVERFLOW    = 0xC0370013L,
        /// <summary>The handle is not a valid message queue handle for the virtualization infrastructure driver.</summary>
        ERROR_VID_INVALID_MESSAGE_QUEUE_HANDLE = 0xC0370014L,
        /// <summary>The handle is not a valid page range handle for the virtualization infrastructure driver.</summary>
        ERROR_VID_INVALID_GPA_RANGE_HANDLE = 0xC0370015L,
        /// <summary>Cannot install client notifications because no message queue for the virtualization infrastructure driver is associated with the memory block.</summary>
        ERROR_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE = 0xC0370016L,
        /// <summary>The request to lock or map a memory block page failed because the virtualization infrastructure driver memory block limit has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED = 0xC0370017L,
        /// <summary>The handle is not a valid parent partition mapping handle for the virtualization infrastructure driver.</summary>
        ERROR_VID_INVALID_PPM_HANDLE     = 0xC0370018L,
        /// <summary>Notifications cannot be created on the memory block because it is use.</summary>
        ERROR_VID_MBPS_ARE_LOCKED        = 0xC0370019L,
        /// <summary>The message queue for the virtualization infrastructure driver has been closed. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_MESSAGE_QUEUE_CLOSED   = 0xC037001AL,
        /// <summary>Cannot add a virtual processor to the partition because the maximum has been reached.</summary>
        ERROR_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED = 0xC037001BL,
        /// <summary>Cannot stop the virtual processor immediately because of a pending intercept.</summary>
        ERROR_VID_STOP_PENDING           = 0xC037001CL,
        /// <summary>Invalid state for the virtual processor. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_INVALID_PROCESSOR_STATE = 0xC037001DL,
        /// <summary>The maximum number of kernel mode clients for the virtualization infrastructure driver has been reached. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT = 0xC037001EL,
        /// <summary>This kernel mode interface for the virtualization infrastructure driver has already been initialized. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_KM_INTERFACE_ALREADY_INITIALIZED = 0xC037001FL,
        /// <summary>Cannot set or reset the memory block property more than once for the virtualization infrastructure driver. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_MB_PROPERTY_ALREADY_SET_RESET = 0xC0370020L,
        /// <summary>The memory mapped I/O for this page range no longer exists. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_MMIO_RANGE_DESTROYED   = 0xC0370021L,
        /// <summary>The lock or unlock request uses an invalid guest operating system memory address. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_INVALID_CHILD_GPA_PAGE_SET = 0xC0370022L,
        /// <summary>Cannot destroy or reuse the reserve page set for the virtualization infrastructure driver because it is in use. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_RESERVE_PAGE_SET_IS_BEING_USED = 0xC0370023L,
        /// <summary>The reserve page set for the virtualization infrastructure driver is too small to use in the lock request. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_RESERVE_PAGE_SET_TOO_SMALL = 0xC0370024L,
        /// <summary>Cannot lock or map the memory block page for the virtualization infrastructure driver because it has already been locked using a reserve page set page. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE = 0xC0370025L,
        /// <summary>Cannot create the memory block for the virtualization infrastructure driver because the requested number of pages exceeded the limit. Restarting the virtual machine may fix the problem. If the problem persists, try restarting the physical computer.</summary>
        ERROR_VID_MBP_COUNT_EXCEEDED_LIMIT = 0xC0370026L,
        /// <summary>Cannot restore this virtual machine because the saved state data cannot be read. Delete the saved state data and then try to start the virtual machine.</summary>
        ERROR_VID_SAVED_STATE_CORRUPT    = 0xC0370027L,
        /// <summary>Cannot restore this virtual machine because an item read from the saved state data is not recognized. Delete the saved state data and then try to start the virtual machine.</summary>
        ERROR_VID_SAVED_STATE_UNRECOGNIZED_ITEM = 0xC0370028L,
        /// <summary>Cannot restore this virtual machine to the saved state because of hypervisor incompatibility. Delete the saved state data and then try to start the virtual machine.</summary>
        ERROR_VID_SAVED_STATE_INCOMPATIBLE = 0xC0370029L,
        /// <summary>The specified VTL does not have the permission to access the resource.</summary>
        ERROR_VID_VTL_ACCESS_DENIED      = 0xC037002AL,
        /// <summary>The compute system unexpectedly terminated while starting.</summary>
        ERROR_VMCOMPUTE_TERMINATED_DURING_START = 0xC0370100L,
        /// <summary>The operating system of the container does not match the operating system of the host.</summary>
        ERROR_VMCOMPUTE_IMAGE_MISMATCH   = 0xC0370101L,
        /// <summary>A Virtual Machine could not be started because Hyper-V is not installed.</summary>
        ERROR_VMCOMPUTE_HYPERV_NOT_INSTALLED = 0xC0370102L,
        /// <summary>The call to start an asynchronous operation succeeded and the operation is performed in the background.</summary>
        ERROR_VMCOMPUTE_OPERATION_PENDING = 0xC0370103L,
        /// <summary>The supported number of notification callbacks has been exceeded.</summary>
        ERROR_VMCOMPUTE_TOO_MANY_NOTIFICATIONS = 0xC0370104L,
        /// <summary>The requested compute system operation is not valid in the current state.</summary>
        ERROR_VMCOMPUTE_INVALID_STATE    = 0xC0370105L,
        /// <summary>The compute system exited unexpectedly.</summary>
        ERROR_VMCOMPUTE_UNEXPECTED_EXIT  = 0xC0370106L,
        /// <summary>The compute system was forcefully terminated.</summary>
        ERROR_VMCOMPUTE_TERMINATED       = 0xC0370107L,
        /// <summary>A connection could not be established with the Virtual Machine hosting the Container.</summary>
        ERROR_VMCOMPUTE_CONNECT_FAILED   = 0xC0370108L,
        /// <summary>The operation timed out because a response was not received from the Virtual Machine hosting the Container.</summary>
        ERROR_VMCOMPUTE_TIMEOUT          = 0xC0370109L,
        /// <summary>The connection with the Virtual Machine hosting the container was closed.</summary>
        ERROR_VMCOMPUTE_CONNECTION_CLOSED = 0xC037010AL,
        /// <summary>An unknown internal message was received by the Hyper-V Compute Service.</summary>
        ERROR_VMCOMPUTE_UNKNOWN_MESSAGE  = 0xC037010BL,
        /// <summary>The communication protocol version between the Hyper-V Host and Guest Compute Services is not supported.</summary>
        ERROR_VMCOMPUTE_UNSUPPORTED_PROTOCOL_VERSION = 0xC037010CL,
        /// <summary>The JSON document is invalid.</summary>
        ERROR_VMCOMPUTE_INVALID_JSON     = 0xC037010DL,
        /// <summary>A Compute System with the specified identifier does not exist.</summary>
        ERROR_VMCOMPUTE_SYSTEM_NOT_FOUND = 0xC037010EL,
        /// <summary>A Compute System with the specified identifier already exists.</summary>
        ERROR_VMCOMPUTE_SYSTEM_ALREADY_EXISTS = 0xC037010FL,
        /// <summary>The Compute System with the specified identifier did already stop.</summary>
        ERROR_VMCOMPUTE_SYSTEM_ALREADY_STOPPED = 0xC0370110L,
        /// <summary>A virtual switch with the given name was not found.</summary>
        ERROR_VNET_VIRTUAL_SWITCH_NAME_NOT_FOUND = 0xC0370200L,
        /// <summary>A virtual machine is running with its memory allocated across multiple NUMA nodes. This does not indicate a problem unless the performance of your virtual machine is unusually slow. If you are experiencing performance problems, you may need to modify the NUMA configuration.</summary>
        ERROR_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED = 0x80370001L,
        /// <summary>The regeneration operation was not able to copy all data from the active plexes due to bad sectors.</summary>
        ERROR_VOLMGR_INCOMPLETE_REGENERATION = 0x80380001L,
        /// <summary>One or more disks were not fully migrated to the target pack. They may or may not require reimport after fixing the hardware problems.</summary>
        ERROR_VOLMGR_INCOMPLETE_DISK_MIGRATION = 0x80380002L,
        /// <summary>The configuration database is full.</summary>
        ERROR_VOLMGR_DATABASE_FULL       = 0xC0380001L,
        /// <summary>The configuration data on the disk is corrupted.</summary>
        ERROR_VOLMGR_DISK_CONFIGURATION_CORRUPTED = 0xC0380002L,
        /// <summary>The configuration on the disk is not insync with the in-memory configuration.</summary>
        ERROR_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC = 0xC0380003L,
        /// <summary>A majority of disks failed to be updated with the new configuration.</summary>
        ERROR_VOLMGR_PACK_CONFIG_UPDATE_FAILED = 0xC0380004L,
        /// <summary>The disk contains non-simple volumes.</summary>
        ERROR_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME = 0xC0380005L,
        /// <summary>The same disk was specified more than once in the migration list.</summary>
        ERROR_VOLMGR_DISK_DUPLICATE      = 0xC0380006L,
        /// <summary>The disk is already dynamic.</summary>
        ERROR_VOLMGR_DISK_DYNAMIC        = 0xC0380007L,
        /// <summary>The specified disk id is invalid. There are no disks with the specified disk id.</summary>
        ERROR_VOLMGR_DISK_ID_INVALID     = 0xC0380008L,
        /// <summary>The specified disk is an invalid disk. Operation cannot complete on an invalid disk.</summary>
        ERROR_VOLMGR_DISK_INVALID        = 0xC0380009L,
        /// <summary>The specified disk(s) cannot be removed since it is the last remaining voter.</summary>
        ERROR_VOLMGR_DISK_LAST_VOTER     = 0xC038000AL,
        /// <summary>The specified disk has an invalid disk layout.</summary>
        ERROR_VOLMGR_DISK_LAYOUT_INVALID = 0xC038000BL,
        /// <summary>The disk layout contains non-basic partitions which appear after basic paritions. This is an invalid disk layout.</summary>
        ERROR_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS = 0xC038000CL,
        /// <summary>The disk layout contains partitions which are not cylinder aligned.</summary>
        ERROR_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED = 0xC038000DL,
        /// <summary>The disk layout contains partitions which are samller than the minimum size.</summary>
        ERROR_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL = 0xC038000EL,
        /// <summary>The disk layout contains primary partitions in between logical drives. This is an invalid disk layout.</summary>
        ERROR_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS = 0xC038000FL,
        /// <summary>The disk layout contains more than the maximum number of supported partitions.</summary>
        ERROR_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS = 0xC0380010L,
        /// <summary>The specified disk is missing. The operation cannot complete on a missing disk.</summary>
        ERROR_VOLMGR_DISK_MISSING        = 0xC0380011L,
        /// <summary>The specified disk is not empty.</summary>
        ERROR_VOLMGR_DISK_NOT_EMPTY      = 0xC0380012L,
        /// <summary>There is not enough usable space for this operation.</summary>
        ERROR_VOLMGR_DISK_NOT_ENOUGH_SPACE = 0xC0380013L,
        /// <summary>The force revectoring of bad sectors failed.</summary>
        ERROR_VOLMGR_DISK_REVECTORING_FAILED = 0xC0380014L,
        /// <summary>The specified disk has an invalid sector size.</summary>
        ERROR_VOLMGR_DISK_SECTOR_SIZE_INVALID = 0xC0380015L,
        /// <summary>The specified disk set contains volumes which exist on disks outside of the set.</summary>
        ERROR_VOLMGR_DISK_SET_NOT_CONTAINED = 0xC0380016L,
        /// <summary>A disk in the volume layout provides extents to more than one member of a plex.</summary>
        ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS = 0xC0380017L,
        /// <summary>A disk in the volume layout provides extents to more than one plex.</summary>
        ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES = 0xC0380018L,
        /// <summary>Dynamic disks are not supported on this system.</summary>
        ERROR_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED = 0xC0380019L,
        /// <summary>The specified extent is already used by other volumes.</summary>
        ERROR_VOLMGR_EXTENT_ALREADY_USED = 0xC038001AL,
        /// <summary>The specified volume is retained and can only be extended into a contiguous extent. The specified extent to grow the volume is not contiguous with the specified volume.</summary>
        ERROR_VOLMGR_EXTENT_NOT_CONTIGUOUS = 0xC038001BL,
        /// <summary>The specified volume extent is not within the public region of the disk.</summary>
        ERROR_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION = 0xC038001CL,
        /// <summary>The specifed volume extent is not sector aligned.</summary>
        ERROR_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED = 0xC038001DL,
        /// <summary>The specified parition overlaps an EBR (the first track of an extended partition on a MBR disks).</summary>
        ERROR_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION = 0xC038001EL,
        /// <summary>The specified extent lengths cannot be used to construct a volume with specified length.</summary>
        ERROR_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH = 0xC038001FL,
        /// <summary>The system does not support fault tolerant volumes.</summary>
        ERROR_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED = 0xC0380020L,
        /// <summary>The specified interleave length is invalid.</summary>
        ERROR_VOLMGR_INTERLEAVE_LENGTH_INVALID = 0xC0380021L,
        /// <summary>There is already a maximum number of registered users.</summary>
        ERROR_VOLMGR_MAXIMUM_REGISTERED_USERS = 0xC0380022L,
        /// <summary>The specified member is already in-sync with the other active members. It does not need to be regenerated.</summary>
        ERROR_VOLMGR_MEMBER_IN_SYNC      = 0xC0380023L,
        /// <summary>The same member index was specified more than once.</summary>
        ERROR_VOLMGR_MEMBER_INDEX_DUPLICATE = 0xC0380024L,
        /// <summary>The specified member index is greater or equal than the number of members in the volume plex.</summary>
        ERROR_VOLMGR_MEMBER_INDEX_INVALID = 0xC0380025L,
        /// <summary>The specified member is missing. It cannot be regenerated.</summary>
        ERROR_VOLMGR_MEMBER_MISSING      = 0xC0380026L,
        /// <summary>The specified member is not detached. Cannot replace a member which is not detached.</summary>
        ERROR_VOLMGR_MEMBER_NOT_DETACHED = 0xC0380027L,
        /// <summary>The specified member is already regenerating.</summary>
        ERROR_VOLMGR_MEMBER_REGENERATING = 0xC0380028L,
        /// <summary>All disks belonging to the pack failed.</summary>
        ERROR_VOLMGR_ALL_DISKS_FAILED    = 0xC0380029L,
        /// <summary>There are currently no registered users for notifications. The task number is irrelevant unless there are registered users.</summary>
        ERROR_VOLMGR_NO_REGISTERED_USERS = 0xC038002AL,
        /// <summary>The specified notification user does not exist. Failed to unregister user for notifications.</summary>
        ERROR_VOLMGR_NO_SUCH_USER        = 0xC038002BL,
        /// <summary>The notifications have been reset. Notifications for the current user are invalid. Unregister and re-register for notifications.</summary>
        ERROR_VOLMGR_NOTIFICATION_RESET  = 0xC038002CL,
        /// <summary>The specified number of members is invalid.</summary>
        ERROR_VOLMGR_NUMBER_OF_MEMBERS_INVALID = 0xC038002DL,
        /// <summary>The specified number of plexes is invalid.</summary>
        ERROR_VOLMGR_NUMBER_OF_PLEXES_INVALID = 0xC038002EL,
        /// <summary>The specified source and target packs are identical.</summary>
        ERROR_VOLMGR_PACK_DUPLICATE      = 0xC038002FL,
        /// <summary>The specified pack id is invalid. There are no packs with the specified pack id.</summary>
        ERROR_VOLMGR_PACK_ID_INVALID     = 0xC0380030L,
        /// <summary>The specified pack is the invalid pack. The operation cannot complete with the invalid pack.</summary>
        ERROR_VOLMGR_PACK_INVALID        = 0xC0380031L,
        /// <summary>The specified pack name is invalid.</summary>
        ERROR_VOLMGR_PACK_NAME_INVALID   = 0xC0380032L,
        /// <summary>The specified pack is offline.</summary>
        ERROR_VOLMGR_PACK_OFFLINE        = 0xC0380033L,
        /// <summary>The specified pack already has a quorum of healthy disks.</summary>
        ERROR_VOLMGR_PACK_HAS_QUORUM     = 0xC0380034L,
        /// <summary>The pack does not have a quorum of healthy disks.</summary>
        ERROR_VOLMGR_PACK_WITHOUT_QUORUM = 0xC0380035L,
        /// <summary>The specified disk has an unsupported partition style. Only MBR and GPT partition styles are supported.</summary>
        ERROR_VOLMGR_PARTITION_STYLE_INVALID = 0xC0380036L,
        /// <summary>Failed to update the disk's partition layout.</summary>
        ERROR_VOLMGR_PARTITION_UPDATE_FAILED = 0xC0380037L,
        /// <summary>The specified plex is already in-sync with the other active plexes. It does not need to be regenerated.</summary>
        ERROR_VOLMGR_PLEX_IN_SYNC        = 0xC0380038L,
        /// <summary>The same plex index was specified more than once.</summary>
        ERROR_VOLMGR_PLEX_INDEX_DUPLICATE = 0xC0380039L,
        /// <summary>The specified plex index is greater or equal than the number of plexes in the volume.</summary>
        ERROR_VOLMGR_PLEX_INDEX_INVALID  = 0xC038003AL,
        /// <summary>The specified plex is the last active plex in the volume. The plex cannot be removed or else the volume will go offline.</summary>
        ERROR_VOLMGR_PLEX_LAST_ACTIVE    = 0xC038003BL,
        /// <summary>The specified plex is missing.</summary>
        ERROR_VOLMGR_PLEX_MISSING        = 0xC038003CL,
        /// <summary>The specified plex is currently regenerating.</summary>
        ERROR_VOLMGR_PLEX_REGENERATING   = 0xC038003DL,
        /// <summary>The specified plex type is invalid.</summary>
        ERROR_VOLMGR_PLEX_TYPE_INVALID   = 0xC038003EL,
        /// <summary>The operation is only supported on RAID-5 plexes.</summary>
        ERROR_VOLMGR_PLEX_NOT_RAID5      = 0xC038003FL,
        /// <summary>The operation is only supported on simple plexes.</summary>
        ERROR_VOLMGR_PLEX_NOT_SIMPLE     = 0xC0380040L,
        /// <summary>The Size fields in the VM_VOLUME_LAYOUT input structure are incorrectly set.</summary>
        ERROR_VOLMGR_STRUCTURE_SIZE_INVALID = 0xC0380041L,
        /// <summary>There is already a pending request for notifications. Wait for the existing request to return before requesting for more notifications.</summary>
        ERROR_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS = 0xC0380042L,
        /// <summary>There is currently a transaction in process.</summary>
        ERROR_VOLMGR_TRANSACTION_IN_PROGRESS = 0xC0380043L,
        /// <summary>An unexpected layout change occurred outside of the volume manager.</summary>
        ERROR_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE = 0xC0380044L,
        /// <summary>The specified volume contains a missing disk.</summary>
        ERROR_VOLMGR_VOLUME_CONTAINS_MISSING_DISK = 0xC0380045L,
        /// <summary>The specified volume id is invalid. There are no volumes with the specified volume id.</summary>
        ERROR_VOLMGR_VOLUME_ID_INVALID   = 0xC0380046L,
        /// <summary>The specified volume length is invalid.</summary>
        ERROR_VOLMGR_VOLUME_LENGTH_INVALID = 0xC0380047L,
        /// <summary>The specified size for the volume is not a multiple of the sector size.</summary>
        ERROR_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE = 0xC0380048L,
        /// <summary>The operation is only supported on mirrored volumes.</summary>
        ERROR_VOLMGR_VOLUME_NOT_MIRRORED = 0xC0380049L,
        /// <summary>The specified volume does not have a retain partition.</summary>
        ERROR_VOLMGR_VOLUME_NOT_RETAINED = 0xC038004AL,
        /// <summary>The specified volume is offline.</summary>
        ERROR_VOLMGR_VOLUME_OFFLINE      = 0xC038004BL,
        /// <summary>The specified volume already has a retain partition.</summary>
        ERROR_VOLMGR_VOLUME_RETAINED     = 0xC038004CL,
        /// <summary>The specified number of extents is invalid.</summary>
        ERROR_VOLMGR_NUMBER_OF_EXTENTS_INVALID = 0xC038004DL,
        /// <summary>All disks participating to the volume must have the same sector size.</summary>
        ERROR_VOLMGR_DIFFERENT_SECTOR_SIZE = 0xC038004EL,
        /// <summary>The boot disk experienced failures.</summary>
        ERROR_VOLMGR_BAD_BOOT_DISK       = 0xC038004FL,
        /// <summary>The configuration of the pack is offline.</summary>
        ERROR_VOLMGR_PACK_CONFIG_OFFLINE = 0xC0380050L,
        /// <summary>The configuration of the pack is online.</summary>
        ERROR_VOLMGR_PACK_CONFIG_ONLINE  = 0xC0380051L,
        /// <summary>The specified pack is not the primary pack.</summary>
        ERROR_VOLMGR_NOT_PRIMARY_PACK    = 0xC0380052L,
        /// <summary>All disks failed to be updated with the new content of the log.</summary>
        ERROR_VOLMGR_PACK_LOG_UPDATE_FAILED = 0xC0380053L,
        /// <summary>The specified number of disks in a plex is invalid.</summary>
        ERROR_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID = 0xC0380054L,
        /// <summary>The specified number of disks in a plex member is invalid.</summary>
        ERROR_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID = 0xC0380055L,
        /// <summary>The operation is not supported on mirrored volumes.</summary>
        ERROR_VOLMGR_VOLUME_MIRRORED     = 0xC0380056L,
        /// <summary>The operation is only supported on simple and spanned plexes.</summary>
        ERROR_VOLMGR_PLEX_NOT_SIMPLE_SPANNED = 0xC0380057L,
        /// <summary>The pack has no valid log copies.</summary>
        ERROR_VOLMGR_NO_VALID_LOG_COPIES = 0xC0380058L,
        /// <summary>A primary pack is already present.</summary>
        ERROR_VOLMGR_PRIMARY_PACK_PRESENT = 0xC0380059L,
        /// <summary>The specified number of disks is invalid.</summary>
        ERROR_VOLMGR_NUMBER_OF_DISKS_INVALID = 0xC038005AL,
        /// <summary>The system does not support mirrored volumes.</summary>
        ERROR_VOLMGR_MIRROR_NOT_SUPPORTED = 0xC038005BL,
        /// <summary>The system does not support RAID-5 volumes.</summary>
        ERROR_VOLMGR_RAID5_NOT_SUPPORTED = 0xC038005CL,
        /// <summary>Some BCD entries were not imported correctly from the BCD store.</summary>
        ERROR_BCD_NOT_ALL_ENTRIES_IMPORTED = 0x80390001L,
        /// <summary>Entries enumerated have exceeded the allowed threshold.</summary>
        ERROR_BCD_TOO_MANY_ELEMENTS      = 0xC0390002L,
        /// <summary>Some BCD entries were not synchronized correctly with the firmware.</summary>
        ERROR_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED = 0x80390003L,
        /// <summary>The virtual hard disk is corrupted. The virtual hard disk drive footer is missing.</summary>
        ERROR_VHD_DRIVE_FOOTER_MISSING   = 0xC03A0001L,
        /// <summary>The virtual hard disk is corrupted. The virtual hard disk drive footer checksum does not match the on-disk checksum.</summary>
        ERROR_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH = 0xC03A0002L,
        /// <summary>The virtual hard disk is corrupted. The virtual hard disk drive footer in the virtual hard disk is corrupted.</summary>
        ERROR_VHD_DRIVE_FOOTER_CORRUPT   = 0xC03A0003L,
        /// <summary>The system does not recognize the file format of this virtual hard disk.</summary>
        ERROR_VHD_FORMAT_UNKNOWN         = 0xC03A0004L,
        /// <summary>The version does not support this version of the file format.</summary>
        ERROR_VHD_FORMAT_UNSUPPORTED_VERSION = 0xC03A0005L,
        /// <summary>The virtual hard disk is corrupted. The sparse header checksum does not match the on-disk checksum.</summary>
        ERROR_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH = 0xC03A0006L,
        /// <summary>The system does not support this version of the virtual hard disk.This version of the sparse header is not supported.</summary>
        ERROR_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION = 0xC03A0007L,
        /// <summary>The virtual hard disk is corrupted. The sparse header in the virtual hard disk is corrupt.</summary>
        ERROR_VHD_SPARSE_HEADER_CORRUPT  = 0xC03A0008L,
        /// <summary>Failed to write to the virtual hard disk failed because the system failed to allocate a new block in the virtual hard disk.</summary>
        ERROR_VHD_BLOCK_ALLOCATION_FAILURE = 0xC03A0009L,
        /// <summary>The virtual hard disk is corrupted. The block allocation table in the virtual hard disk is corrupt.</summary>
        ERROR_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT = 0xC03A000AL,
        /// <summary>The system does not support this version of the virtual hard disk. The block size is invalid.</summary>
        ERROR_VHD_INVALID_BLOCK_SIZE     = 0xC03A000BL,
        /// <summary>The virtual hard disk is corrupted. The block bitmap does not match with the block data present in the virtual hard disk.</summary>
        ERROR_VHD_BITMAP_MISMATCH        = 0xC03A000CL,
        /// <summary>The chain of virtual hard disks is broken. The system cannot locate the parent virtual hard disk for the differencing disk.</summary>
        ERROR_VHD_PARENT_VHD_NOT_FOUND   = 0xC03A000DL,
        /// <summary>The chain of virtual hard disks is corrupted. There is a mismatch in the identifiers of the parent virtual hard disk and differencing disk.</summary>
        ERROR_VHD_CHILD_PARENT_ID_MISMATCH = 0xC03A000EL,
        /// <summary>The chain of virtual hard disks is corrupted. The time stamp of the parent virtual hard disk does not match the time stamp of the differencing disk.</summary>
        ERROR_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH = 0xC03A000FL,
        /// <summary>Failed to read the metadata of the virtual hard disk.</summary>
        ERROR_VHD_METADATA_READ_FAILURE  = 0xC03A0010L,
        /// <summary>Failed to write to the metadata of the virtual hard disk.</summary>
        ERROR_VHD_METADATA_WRITE_FAILURE = 0xC03A0011L,
        /// <summary>The size of the virtual hard disk is not valid.</summary>
        ERROR_VHD_INVALID_SIZE           = 0xC03A0012L,
        /// <summary>The file size of this virtual hard disk is not valid.</summary>
        ERROR_VHD_INVALID_FILE_SIZE      = 0xC03A0013L,
        /// <summary>A virtual disk support provider for the specified file was not found.</summary>
        ERROR_VIRTDISK_PROVIDER_NOT_FOUND = 0xC03A0014L,
        /// <summary>The specified disk is not a virtual disk.</summary>
        ERROR_VIRTDISK_NOT_VIRTUAL_DISK  = 0xC03A0015L,
        /// <summary>The chain of virtual hard disks is inaccessible. The process has not been granted access rights to the parent virtual hard disk for the differencing disk.</summary>
        ERROR_VHD_PARENT_VHD_ACCESS_DENIED = 0xC03A0016L,
        /// <summary>The chain of virtual hard disks is corrupted. There is a mismatch in the virtual sizes of the parent virtual hard disk and differencing disk.</summary>
        ERROR_VHD_CHILD_PARENT_SIZE_MISMATCH = 0xC03A0017L,
        /// <summary>The chain of virtual hard disks is corrupted. A differencing disk is indicated in its own parent chain.</summary>
        ERROR_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED = 0xC03A0018L,
        /// <summary>The chain of virtual hard disks is inaccessible. There was an error opening a virtual hard disk further up the chain.</summary>
        ERROR_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT = 0xC03A0019L,
        /// <summary>The requested operation could not be completed due to a virtual disk system limitation.  Virtual hard disk files must be uncompressed and unencrypted and must not be sparse.</summary>
        ERROR_VIRTUAL_DISK_LIMITATION    = 0xC03A001AL,
        /// <summary>The requested operation cannot be performed on a virtual disk of this type.</summary>
        ERROR_VHD_INVALID_TYPE           = 0xC03A001BL,
        /// <summary>The requested operation cannot be performed on the virtual disk in its current state.</summary>
        ERROR_VHD_INVALID_STATE          = 0xC03A001CL,
        /// <summary>The sector size of the physical disk on which the virtual disk resides is not supported.</summary>
        ERROR_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE = 0xC03A001DL,
        /// <summary>The disk is already owned by a different owner.</summary>
        ERROR_VIRTDISK_DISK_ALREADY_OWNED = 0xC03A001EL,
        /// <summary>The disk must be offline or read-only.</summary>
        ERROR_VIRTDISK_DISK_ONLINE_AND_WRITABLE = 0xC03A001FL,
        /// <summary>Change Tracking is not initialized for this virtual disk.</summary>
        ERROR_CTLOG_TRACKING_NOT_INITIALIZED = 0xC03A0020L,
        /// <summary>Size of change tracking file exceeded the maximum size limit.</summary>
        ERROR_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE = 0xC03A0021L,
        /// <summary>VHD file is changed due to compaction, expansion, or offline updates.</summary>
        ERROR_CTLOG_VHD_CHANGED_OFFLINE  = 0xC03A0022L,
        /// <summary>Change Tracking for the virtual disk is not in a valid state to perform this request.  Change tracking could be discontinued or already in the requested state.</summary>
        ERROR_CTLOG_INVALID_TRACKING_STATE = 0xC03A0023L,
        /// <summary>Change Tracking file for the virtual disk is not in a valid state.</summary>
        ERROR_CTLOG_INCONSISTENT_TRACKING_FILE = 0xC03A0024L,
        /// <summary>The requested resize operation could not be completed because it might truncate user data residing on the virtual disk.</summary>
        ERROR_VHD_RESIZE_WOULD_TRUNCATE_DATA = 0xC03A0025L,
        /// <summary>The requested operation could not be completed because the virtual disk's minimum safe size could not be determined. This may be due to a missing or corrupt partition table.</summary>
        ERROR_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE = 0xC03A0026L,
        /// <summary>The requested operation could not be completed because the virtual disk's size cannot be safely reduced further.</summary>
        ERROR_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE = 0xC03A0027L,
        /// <summary>There is not enough space in the virtual disk file for the provided metadata item.</summary>
        ERROR_VHD_METADATA_FULL          = 0xC03A0028L,
        /// <summary>The specified change tracking identifier is not valid.</summary>
        ERROR_VHD_INVALID_CHANGE_TRACKING_ID = 0xC03A0029L,
        /// <summary>Change tracking is disabled for the specified virtual hard disk, so no change tracking information is available.</summary>
        ERROR_VHD_CHANGE_TRACKING_DISABLED = 0xC03A002AL,
        /// <summary>There is no change tracking data available associated with the specified change tracking identifier.</summary>
        ERROR_VHD_MISSING_CHANGE_TRACKING_INFORMATION = 0xC03A0030L,
        /// <summary>The virtualization storage subsystem has generated an error.</summary>
        ERROR_QUERY_STORAGE_ERROR        = 0x803A0001L,
        /// <summary>The port is already allocated</summary>
        ERROR_HNS_PORT_ALLOCATED         = 0xC03B0001L,
        /// <summary>Port mapping is not supported on the given network</summary>
        ERROR_HNS_MAPPING_NOT_SUPPORTED  = 0xC03B0002L,
        /// <summary>The operation was cancelled.</summary>
        SDIAG_E_CANCELLED                = 0x803C0100L,
        /// <summary>An error occurred when running a PowerShell script.</summary>
        SDIAG_E_SCRIPT                   = 0x803C0101L,
        /// <summary>An error occurred when interacting with PowerShell runtime.</summary>
        SDIAG_E_POWERSHELL               = 0x803C0102L,
        /// <summary>An error occurred in the Scripted Diagnostic Managed Host.</summary>
        SDIAG_E_MANAGEDHOST              = 0x803C0103L,
        /// <summary>The troubleshooting pack does not contain a required verifier to complete the verification.</summary>
        SDIAG_E_NOVERIFIER               = 0x803C0104L,
        /// <summary>The troubleshooting pack cannot be executed on this system.</summary>
        SDIAG_S_CANNOTRUN                = 0x003C0105L,
        /// <summary>Scripted diagnostics is disabled by group policy.</summary>
        SDIAG_E_DISABLED                 = 0x803C0106L,
        /// <summary>Trust validation of the troubleshooting pack failed.</summary>
        SDIAG_E_TRUST                    = 0x803C0107L,
        /// <summary>The troubleshooting pack cannot be executed on this system.</summary>
        SDIAG_E_CANNOTRUN                = 0x803C0108L,
        /// <summary>This version of the troubleshooting pack is not supported.</summary>
        SDIAG_E_VERSION                  = 0x803C0109L,
        /// <summary>A required resource cannot be loaded.</summary>
        SDIAG_E_RESOURCE                 = 0x803C010AL,
        /// <summary>The troubleshooting pack reported information for a root cause without adding the root cause.</summary>
        SDIAG_E_ROOTCAUSE                = 0x803C010BL,
        /// <summary>The notification channel has already been closed.</summary>
        WPN_E_CHANNEL_CLOSED             = 0x803E0100L,
        /// <summary>The notification channel request did not complete successfully.</summary>
        WPN_E_CHANNEL_REQUEST_NOT_COMPLETE = 0x803E0101L,
        /// <summary>The application identifier provided is invalid.</summary>
        WPN_E_INVALID_APP                = 0x803E0102L,
        /// <summary>A notification channel request for the provided application identifier is in progress.</summary>
        WPN_E_OUTSTANDING_CHANNEL_REQUEST = 0x803E0103L,
        /// <summary>The channel identifier is already tied to another application endpoint.</summary>
        WPN_E_DUPLICATE_CHANNEL          = 0x803E0104L,
        /// <summary>The notification platform is unavailable.</summary>
        WPN_E_PLATFORM_UNAVAILABLE       = 0x803E0105L,
        /// <summary>The notification has already been posted.</summary>
        WPN_E_NOTIFICATION_POSTED        = 0x803E0106L,
        /// <summary>The notification has already been hidden.</summary>
        WPN_E_NOTIFICATION_HIDDEN        = 0x803E0107L,
        /// <summary>The notification cannot be hidden until it has been shown.</summary>
        WPN_E_NOTIFICATION_NOT_POSTED    = 0x803E0108L,
        /// <summary>Cloud notifications have been turned off.</summary>
        WPN_E_CLOUD_DISABLED             = 0x803E0109L,
        /// <summary>The application does not have the cloud notification capability.</summary>
        WPN_E_CLOUD_INCAPABLE            = 0x803E0110L,
        /// <summary>The notification platform is unable to retrieve the authentication credentials required to connect to the cloud notification service.</summary>
        WPN_E_CLOUD_AUTH_UNAVAILABLE     = 0x803E011AL,
        /// <summary>The notification platform is unable to connect to the cloud notification service.</summary>
        WPN_E_CLOUD_SERVICE_UNAVAILABLE  = 0x803E011BL,
        /// <summary>The notification platform is unable to initialize a callback for lock screen updates.</summary>
        WPN_E_FAILED_LOCK_SCREEN_UPDATE_INTIALIZATION = 0x803E011CL,
        /// <summary>Settings prevent the notification from being delivered.</summary>
        WPN_E_NOTIFICATION_DISABLED      = 0x803E0111L,
        /// <summary>Application capabilities prevent the notification from being delivered.</summary>
        WPN_E_NOTIFICATION_INCAPABLE     = 0x803E0112L,
        /// <summary>The application does not have the internet access capability.</summary>
        WPN_E_INTERNET_INCAPABLE         = 0x803E0113L,
        /// <summary>Settings prevent the notification type from being delivered.</summary>
        WPN_E_NOTIFICATION_TYPE_DISABLED = 0x803E0114L,
        /// <summary>The size of the notification content is too large.</summary>
        WPN_E_NOTIFICATION_SIZE          = 0x803E0115L,
        /// <summary>The size of the notification tag is too large.</summary>
        WPN_E_TAG_SIZE                   = 0x803E0116L,
        /// <summary>The notification platform doesn't have appropriate privilege on resources.</summary>
        WPN_E_ACCESS_DENIED              = 0x803E0117L,
        /// <summary>The notification platform found application is already registered.</summary>
        WPN_E_DUPLICATE_REGISTRATION     = 0x803E0118L,
        /// <summary>The application background task does not have the push notification capability.</summary>
        WPN_E_PUSH_NOTIFICATION_INCAPABLE = 0x803E0119L,
        /// <summary>The size of the developer id for scheduled notification is too large.</summary>
        WPN_E_DEV_ID_SIZE                = 0x803E0120L,
        /// <summary>The notification tag is not alphanumeric.</summary>
        WPN_E_TAG_ALPHANUMERIC           = 0x803E012AL,
        /// <summary>The notification platform has received invalid HTTP status code other than 2xx for polling.</summary>
        WPN_E_INVALID_HTTP_STATUS_CODE   = 0x803E012BL,
        /// <summary>The notification platform has run out of presentation layer sessions.</summary>
        WPN_E_OUT_OF_SESSION             = 0x803E0200L,
        /// <summary>The notification platform rejects image download request due to system in power save mode.</summary>
        WPN_E_POWER_SAVE                 = 0x803E0201L,
        /// <summary>The notification platform doesn't have the requested image in its cache.</summary>
        WPN_E_IMAGE_NOT_FOUND_IN_CACHE   = 0x803E0202L,
        /// <summary>The notification platform cannot complete all of requested image.</summary>
        WPN_E_ALL_URL_NOT_COMPLETED      = 0x803E0203L,
        /// <summary>A cloud image downloaded from the notification platform is invalid.</summary>
        WPN_E_INVALID_CLOUD_IMAGE        = 0x803E0204L,
        /// <summary>Notification Id provided as filter is matched with what the notification platform maintains.</summary>
        WPN_E_NOTIFICATION_ID_MATCHED    = 0x803E0205L,
        /// <summary>Notification callback interface is already registered.</summary>
        WPN_E_CALLBACK_ALREADY_REGISTERED = 0x803E0206L,
        /// <summary>Toast Notification was dropped without being displayed to the user.</summary>
        WPN_E_TOAST_NOTIFICATION_DROPPED = 0x803E0207L,
        /// <summary>The notification platform does not have the proper privileges to complete the request.</summary>
        WPN_E_STORAGE_LOCKED             = 0x803E0208L,
        /// <summary>The size of the notification group is too large.</summary>
        WPN_E_GROUP_SIZE                 = 0x803E0209L,
        /// <summary>The notification group is not alphanumeric.</summary>
        WPN_E_GROUP_ALPHANUMERIC         = 0x803E020AL,
        /// <summary>Cloud notifications have been disabled for the application due to a policy setting.</summary>
        WPN_E_CLOUD_DISABLED_FOR_APP     = 0x803E020BL,
        /// <summary>Context is not activated.</summary>
        E_MBN_CONTEXT_NOT_ACTIVATED      = 0x80548201L,
        /// <summary>Bad SIM is inserted.</summary>
        E_MBN_BAD_SIM                    = 0x80548202L,
        /// <summary>Requested data class is not avaialable.</summary>
        E_MBN_DATA_CLASS_NOT_AVAILABLE   = 0x80548203L,
        /// <summary>Access point name (APN) or Access string is incorrect.</summary>
        E_MBN_INVALID_ACCESS_STRING      = 0x80548204L,
        /// <summary>Max activated contexts have reached.</summary>
        E_MBN_MAX_ACTIVATED_CONTEXTS     = 0x80548205L,
        /// <summary>Device is in packet detach state.</summary>
        E_MBN_PACKET_SVC_DETACHED        = 0x80548206L,
        /// <summary>Provider is not visible.</summary>
        E_MBN_PROVIDER_NOT_VISIBLE       = 0x80548207L,
        /// <summary>Radio is powered off.</summary>
        E_MBN_RADIO_POWER_OFF            = 0x80548208L,
        /// <summary>MBN subscription is not activated.</summary>
        E_MBN_SERVICE_NOT_ACTIVATED      = 0x80548209L,
        /// <summary>SIM is not inserted.</summary>
        E_MBN_SIM_NOT_INSERTED           = 0x8054820AL,
        /// <summary>Voice call in progress.</summary>
        E_MBN_VOICE_CALL_IN_PROGRESS     = 0x8054820BL,
        /// <summary>Visible provider cache is invalid.</summary>
        E_MBN_INVALID_CACHE              = 0x8054820CL,
        /// <summary>Device is not registered.</summary>
        E_MBN_NOT_REGISTERED             = 0x8054820DL,
        /// <summary>Providers not found.</summary>
        E_MBN_PROVIDERS_NOT_FOUND        = 0x8054820EL,
        /// <summary>Pin is not supported.</summary>
        E_MBN_PIN_NOT_SUPPORTED          = 0x8054820FL,
        /// <summary>Pin is required.</summary>
        E_MBN_PIN_REQUIRED               = 0x80548210L,
        /// <summary>PIN is disabled.</summary>
        E_MBN_PIN_DISABLED               = 0x80548211L,
        /// <summary>Generic Failure.</summary>
        E_MBN_FAILURE                    = 0x80548212L,
        /// <summary>Profile is invalid.</summary>
        E_MBN_INVALID_PROFILE            = 0x80548218L,
        /// <summary>Default profile exist.</summary>
        E_MBN_DEFAULT_PROFILE_EXIST      = 0x80548219L,
        /// <summary>SMS encoding is not supported.</summary>
        E_MBN_SMS_ENCODING_NOT_SUPPORTED = 0x80548220L,
        /// <summary>SMS filter is not supported.</summary>
        E_MBN_SMS_FILTER_NOT_SUPPORTED   = 0x80548221L,
        /// <summary>Invalid SMS memory index is used.</summary>
        E_MBN_SMS_INVALID_MEMORY_INDEX   = 0x80548222L,
        /// <summary>SMS language is not supported.</summary>
        E_MBN_SMS_LANG_NOT_SUPPORTED     = 0x80548223L,
        /// <summary>SMS memory failure occurred.</summary>
        E_MBN_SMS_MEMORY_FAILURE         = 0x80548224L,
        /// <summary>SMS network timeout happened.</summary>
        E_MBN_SMS_NETWORK_TIMEOUT        = 0x80548225L,
        /// <summary>Unknown SMSC address is used.</summary>
        E_MBN_SMS_UNKNOWN_SMSC_ADDRESS   = 0x80548226L,
        /// <summary>SMS format is not supported.</summary>
        E_MBN_SMS_FORMAT_NOT_SUPPORTED   = 0x80548227L,
        /// <summary>SMS operation is not allowed.</summary>
        E_MBN_SMS_OPERATION_NOT_ALLOWED  = 0x80548228L,
        /// <summary>Device SMS memory is full.</summary>
        E_MBN_SMS_MEMORY_FULL            = 0x80548229L,
        /// <summary>The IPv6 protocol is not installed.</summary>
        PEER_E_IPV6_NOT_INSTALLED        = 0x80630001L,
        /// <summary>The compoment has not been initialized.</summary>
        PEER_E_NOT_INITIALIZED           = 0x80630002L,
        /// <summary>The required service canot be started.</summary>
        PEER_E_CANNOT_START_SERVICE      = 0x80630003L,
        /// <summary>The P2P protocol is not licensed to run on this OS.</summary>
        PEER_E_NOT_LICENSED              = 0x80630004L,
        /// <summary>The graph handle is invalid.</summary>
        PEER_E_INVALID_GRAPH             = 0x80630010L,
        /// <summary>The graph database name has changed.</summary>
        PEER_E_DBNAME_CHANGED            = 0x80630011L,
        /// <summary>A graph with the same ID already exists.</summary>
        PEER_E_DUPLICATE_GRAPH           = 0x80630012L,
        /// <summary>The graph is not ready.</summary>
        PEER_E_GRAPH_NOT_READY           = 0x80630013L,
        /// <summary>The graph is shutting down.</summary>
        PEER_E_GRAPH_SHUTTING_DOWN       = 0x80630014L,
        /// <summary>The graph is still in use.</summary>
        PEER_E_GRAPH_IN_USE              = 0x80630015L,
        /// <summary>The graph database is corrupt.</summary>
        PEER_E_INVALID_DATABASE          = 0x80630016L,
        /// <summary>Too many attributes have been used.</summary>
        PEER_E_TOO_MANY_ATTRIBUTES       = 0x80630017L,
        /// <summary>The connection can not be found.</summary>
        PEER_E_CONNECTION_NOT_FOUND      = 0x80630103L,
        /// <summary>The peer attempted to connect to itself.</summary>
        PEER_E_CONNECT_SELF              = 0x80630106L,
        /// <summary>The peer is already listening for connections.</summary>
        PEER_E_ALREADY_LISTENING         = 0x80630107L,
        /// <summary>The node was not found.</summary>
        PEER_E_NODE_NOT_FOUND            = 0x80630108L,
        /// <summary>The Connection attempt failed.</summary>
        PEER_E_CONNECTION_FAILED         = 0x80630109L,
        /// <summary>The peer connection could not be authenticated.</summary>
        PEER_E_CONNECTION_NOT_AUTHENTICATED = 0x8063010AL,
        /// <summary>The connection was refused.</summary>
        PEER_E_CONNECTION_REFUSED        = 0x8063010BL,
        /// <summary>The peer name classifier is too long.</summary>
        PEER_E_CLASSIFIER_TOO_LONG       = 0x80630201L,
        /// <summary>The maximum number of identities have been created.</summary>
        PEER_E_TOO_MANY_IDENTITIES       = 0x80630202L,
        /// <summary>Unable to access a key.</summary>
        PEER_E_NO_KEY_ACCESS             = 0x80630203L,
        /// <summary>The group already exists.</summary>
        PEER_E_GROUPS_EXIST              = 0x80630204L,
        /// <summary>The requested record could not be found.</summary>
        PEER_E_RECORD_NOT_FOUND          = 0x80630301L,
        /// <summary>Access to the database was denied.</summary>
        PEER_E_DATABASE_ACCESSDENIED     = 0x80630302L,
        /// <summary>The Database could not be initialized.</summary>
        PEER_E_DBINITIALIZATION_FAILED   = 0x80630303L,
        /// <summary>The record is too big.</summary>
        PEER_E_MAX_RECORD_SIZE_EXCEEDED  = 0x80630304L,
        /// <summary>The database already exists.</summary>
        PEER_E_DATABASE_ALREADY_PRESENT  = 0x80630305L,
        /// <summary>The database could not be found.</summary>
        PEER_E_DATABASE_NOT_PRESENT      = 0x80630306L,
        /// <summary>The identity could not be found.</summary>
        PEER_E_IDENTITY_NOT_FOUND        = 0x80630401L,
        /// <summary>The event handle could not be found.</summary>
        PEER_E_EVENT_HANDLE_NOT_FOUND    = 0x80630501L,
        /// <summary>Invalid search.</summary>
        PEER_E_INVALID_SEARCH            = 0x80630601L,
        /// <summary>The search atributes are invalid.</summary>
        PEER_E_INVALID_ATTRIBUTES        = 0x80630602L,
        /// <summary>The invitiation is not trusted.</summary>
        PEER_E_INVITATION_NOT_TRUSTED    = 0x80630701L,
        /// <summary>The certchain is too long.</summary>
        PEER_E_CHAIN_TOO_LONG            = 0x80630703L,
        /// <summary>The time period is invalid.</summary>
        PEER_E_INVALID_TIME_PERIOD       = 0x80630705L,
        /// <summary>A circular cert chain was detected.</summary>
        PEER_E_CIRCULAR_CHAIN_DETECTED   = 0x80630706L,
        /// <summary>The certstore is corrupted.</summary>
        PEER_E_CERT_STORE_CORRUPTED      = 0x80630801L,
        /// <summary>The specified PNRP cloud deos not exist.</summary>
        PEER_E_NO_CLOUD                  = 0x80631001L,
        /// <summary>The cloud name is ambiguous.</summary>
        PEER_E_CLOUD_NAME_AMBIGUOUS      = 0x80631005L,
        /// <summary>The record is invlaid.</summary>
        PEER_E_INVALID_RECORD            = 0x80632010L,
        /// <summary>Not authorized.</summary>
        PEER_E_NOT_AUTHORIZED            = 0x80632020L,
        /// <summary>The password does not meet policy requirements.</summary>
        PEER_E_PASSWORD_DOES_NOT_MEET_POLICY = 0x80632021L,
        /// <summary>The record validation has been defered.</summary>
        PEER_E_DEFERRED_VALIDATION       = 0x80632030L,
        /// <summary>The group properies are invalid.</summary>
        PEER_E_INVALID_GROUP_PROPERTIES  = 0x80632040L,
        /// <summary>The peername is invalid.</summary>
        PEER_E_INVALID_PEER_NAME         = 0x80632050L,
        /// <summary>The classifier is invalid.</summary>
        PEER_E_INVALID_CLASSIFIER        = 0x80632060L,
        /// <summary>The friendly name is invalid.</summary>
        PEER_E_INVALID_FRIENDLY_NAME     = 0x80632070L,
        /// <summary>Invalid role property.</summary>
        PEER_E_INVALID_ROLE_PROPERTY     = 0x80632071L,
        /// <summary>Invalid classifer property.</summary>
        PEER_E_INVALID_CLASSIFIER_PROPERTY = 0x80632072L,
        /// <summary>Invlaid record expiration.</summary>
        PEER_E_INVALID_RECORD_EXPIRATION = 0x80632080L,
        /// <summary>Invlaid credential info.</summary>
        PEER_E_INVALID_CREDENTIAL_INFO   = 0x80632081L,
        /// <summary>Invalid credential.</summary>
        PEER_E_INVALID_CREDENTIAL        = 0x80632082L,
        /// <summary>Invalid record size.</summary>
        PEER_E_INVALID_RECORD_SIZE       = 0x80632083L,
        /// <summary>Unsupported version.</summary>
        PEER_E_UNSUPPORTED_VERSION       = 0x80632090L,
        /// <summary>The group is not ready.</summary>
        PEER_E_GROUP_NOT_READY           = 0x80632091L,
        /// <summary>The group is still in use.</summary>
        PEER_E_GROUP_IN_USE              = 0x80632092L,
        /// <summary>The group is invalid.</summary>
        PEER_E_INVALID_GROUP             = 0x80632093L,
        /// <summary>No members were found.</summary>
        PEER_E_NO_MEMBERS_FOUND          = 0x80632094L,
        /// <summary>There are no member connections.</summary>
        PEER_E_NO_MEMBER_CONNECTIONS     = 0x80632095L,
        /// <summary>Unable to listen.</summary>
        PEER_E_UNABLE_TO_LISTEN          = 0x80632096L,
        /// <summary>The identity does not exist.</summary>
        PEER_E_IDENTITY_DELETED          = 0x806320A0L,
        /// <summary>The service is not availible.</summary>
        PEER_E_SERVICE_NOT_AVAILABLE     = 0x806320A1L,
        /// <summary>THe contact could not be found.</summary>
        PEER_E_CONTACT_NOT_FOUND         = 0x80636001L,
        /// <summary>The graph data was created.</summary>
        PEER_S_GRAPH_DATA_CREATED        = 0x00630001L,
        /// <summary>There is not more event data.</summary>
        PEER_S_NO_EVENT_DATA             = 0x00630002L,
        /// <summary>The graph is already connect.</summary>
        PEER_S_ALREADY_CONNECTED         = 0x00632000L,
        /// <summary>The subscription already exists.</summary>
        PEER_S_SUBSCRIPTION_EXISTS       = 0x00636000L,
        /// <summary>No connectivity.</summary>
        PEER_S_NO_CONNECTIVITY           = 0x00630005L,
        /// <summary>Already a member.</summary>
        PEER_S_ALREADY_A_MEMBER          = 0x00630006L,
        /// <summary>The peername could not be converted to a DNS pnrp name.</summary>
        PEER_E_CANNOT_CONVERT_PEER_NAME  = 0x80634001L,
        /// <summary>Invalid peer host name.</summary>
        PEER_E_INVALID_PEER_HOST_NAME    = 0x80634002L,
        /// <summary>No more data could be found.</summary>
        PEER_E_NO_MORE                   = 0x80634003L,
        /// <summary>The existing peer name is already registered.</summary>
        PEER_E_PNRP_DUPLICATE_PEER_NAME  = 0x80634005L,
        /// <summary>The app invite request was cancelled by the user.</summary>
        PEER_E_INVITE_CANCELLED          = 0x80637000L,
        /// <summary>No response of the invite was received.</summary>
        PEER_E_INVITE_RESPONSE_NOT_AVAILABLE = 0x80637001L,
        /// <summary>User is not signed into serverless presence.</summary>
        PEER_E_NOT_SIGNED_IN             = 0x80637003L,
        /// <summary>The user declined the privacy policy prompt.</summary>
        PEER_E_PRIVACY_DECLINED          = 0x80637004L,
        /// <summary>A timeout occurred.</summary>
        PEER_E_TIMEOUT                   = 0x80637005L,
        /// <summary>The address is invalid.</summary>
        PEER_E_INVALID_ADDRESS           = 0x80637007L,
        /// <summary>A required firewall exception is disabled.</summary>
        PEER_E_FW_EXCEPTION_DISABLED     = 0x80637008L,
        /// <summary>The service is blocked by a firewall policy.</summary>
        PEER_E_FW_BLOCKED_BY_POLICY      = 0x80637009L,
        /// <summary>Firewall exceptions are disabled.</summary>
        PEER_E_FW_BLOCKED_BY_SHIELDS_UP  = 0x8063700AL,
        /// <summary>The user declined to enable the firewall exceptions.</summary>
        PEER_E_FW_DECLINED               = 0x8063700BL,
        /// <summary>The object could not be created.</summary>
        UI_E_CREATE_FAILED               = 0x802A0001L,
        /// <summary>Shutdown was already called on this object or the object that owns it.</summary>
        UI_E_SHUTDOWN_CALLED             = 0x802A0002L,
        /// <summary>This method cannot be called during this type of callback.</summary>
        UI_E_ILLEGAL_REENTRANCY          = 0x802A0003L,
        /// <summary>This object has been sealed, so this change is no longer allowed.</summary>
        UI_E_OBJECT_SEALED               = 0x802A0004L,
        /// <summary>The requested value was never set.</summary>
        UI_E_VALUE_NOT_SET               = 0x802A0005L,
        /// <summary>The requested value cannot be determined.</summary>
        UI_E_VALUE_NOT_DETERMINED        = 0x802A0006L,
        /// <summary>A callback returned an invalid output parameter.</summary>
        UI_E_INVALID_OUTPUT              = 0x802A0007L,
        /// <summary>A callback returned a success code other than S_OK or S_FALSE.</summary>
        UI_E_BOOLEAN_EXPECTED            = 0x802A0008L,
        /// <summary>A parameter that should be owned by this object is owned by a different object.</summary>
        UI_E_DIFFERENT_OWNER             = 0x802A0009L,
        /// <summary>More than one item matched the search criteria.</summary>
        UI_E_AMBIGUOUS_MATCH             = 0x802A000AL,
        /// <summary>A floating-point overflow occurred.</summary>
        UI_E_FP_OVERFLOW                 = 0x802A000BL,
        /// <summary>This method can only be called from the thread that created the object.</summary>
        UI_E_WRONG_THREAD                = 0x802A000CL,
        /// <summary>The storyboard is currently in the schedule.</summary>
        UI_E_STORYBOARD_ACTIVE           = 0x802A0101L,
        /// <summary>The storyboard is not playing.</summary>
        UI_E_STORYBOARD_NOT_PLAYING      = 0x802A0102L,
        /// <summary>The start keyframe might occur after the end keyframe.</summary>
        UI_E_START_KEYFRAME_AFTER_END    = 0x802A0103L,
        /// <summary>It might not be possible to determine the end keyframe time when the start keyframe is reached.</summary>
        UI_E_END_KEYFRAME_NOT_DETERMINED = 0x802A0104L,
        /// <summary>Two repeated portions of a storyboard might overlap.</summary>
        UI_E_LOOPS_OVERLAP               = 0x802A0105L,
        /// <summary>The transition has already been added to a storyboard.</summary>
        UI_E_TRANSITION_ALREADY_USED     = 0x802A0106L,
        /// <summary>The transition has not been added to a storyboard.</summary>
        UI_E_TRANSITION_NOT_IN_STORYBOARD = 0x802A0107L,
        /// <summary>The transition might eclipse the beginning of another transition in the storyboard.</summary>
        UI_E_TRANSITION_ECLIPSED         = 0x802A0108L,
        /// <summary>The given time is earlier than the time passed to the last update.</summary>
        UI_E_TIME_BEFORE_LAST_UPDATE     = 0x802A0109L,
        /// <summary>This client is already connected to a timer.</summary>
        UI_E_TIMER_CLIENT_ALREADY_CONNECTED = 0x802A010AL,
        /// <summary>The passed dimension is invalid or does not match the object's dimension.</summary>
        UI_E_INVALID_DIMENSION           = 0x802A010BL,
        /// <summary>The added primitive begins at or beyond the duration of the interpolator.</summary>
        UI_E_PRIMITIVE_OUT_OF_BOUNDS     = 0x802A010CL,
        /// <summary>The operation cannot be completed because the window is being closed.</summary>
        UI_E_WINDOW_CLOSED               = 0x802A0201L,
        /// <summary>The attribute handle given was not valid on this server.</summary>
        E_BLUETOOTH_ATT_INVALID_HANDLE   = 0x80650001L,
        /// <summary>The attribute cannot be read.</summary>
        E_BLUETOOTH_ATT_READ_NOT_PERMITTED = 0x80650002L,
        /// <summary>The attribute cannot be written.</summary>
        E_BLUETOOTH_ATT_WRITE_NOT_PERMITTED = 0x80650003L,
        /// <summary>The attribute PDU was invalid.</summary>
        E_BLUETOOTH_ATT_INVALID_PDU      = 0x80650004L,
        /// <summary>The attribute requires authentication before it can be read or written.</summary>
        E_BLUETOOTH_ATT_INSUFFICIENT_AUTHENTICATION = 0x80650005L,
        /// <summary>Attribute server does not support the request received from the client.</summary>
        E_BLUETOOTH_ATT_REQUEST_NOT_SUPPORTED = 0x80650006L,
        /// <summary>Offset specified was past the end of the attribute.</summary>
        E_BLUETOOTH_ATT_INVALID_OFFSET   = 0x80650007L,
        /// <summary>The attribute requires authorization before it can be read or written.</summary>
        E_BLUETOOTH_ATT_INSUFFICIENT_AUTHORIZATION = 0x80650008L,
        /// <summary>Too many prepare writes have been queued.</summary>
        E_BLUETOOTH_ATT_PREPARE_QUEUE_FULL = 0x80650009L,
        /// <summary>No attribute found within the given attribute handle range.</summary>
        E_BLUETOOTH_ATT_ATTRIBUTE_NOT_FOUND = 0x8065000AL,
        /// <summary>The attribute cannot be read or written using the Read Blob Request.</summary>
        E_BLUETOOTH_ATT_ATTRIBUTE_NOT_LONG = 0x8065000BL,
        /// <summary>The Encryption Key Size used for encrypting this link is insufficient.</summary>
        E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE = 0x8065000CL,
        /// <summary>The attribute value length is invalid for the operation.</summary>
        E_BLUETOOTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH = 0x8065000DL,
        /// <summary>The attribute request that was requested has encountered an error that was unlikely, and therefore could not be completed as requested.</summary>
        E_BLUETOOTH_ATT_UNLIKELY         = 0x8065000EL,
        /// <summary>The attribute requires encryption before it can be read or written.</summary>
        E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION = 0x8065000FL,
        /// <summary>The attribute type is not a supported grouping attribute as defined by a higher layer specification.</summary>
        E_BLUETOOTH_ATT_UNSUPPORTED_GROUP_TYPE = 0x80650010L,
        /// <summary>Insufficient Resources to complete the request.</summary>
        E_BLUETOOTH_ATT_INSUFFICIENT_RESOURCES = 0x80650011L,
        /// <summary>An error that lies in the reserved range has been received.</summary>
        E_BLUETOOTH_ATT_UNKNOWN_ERROR    = 0x80651000L,
        /// <summary>PortCls could not find an audio engine node exposed by a miniport driver claiming support for IMiniportAudioEngineNode.</summary>
        E_AUDIO_ENGINE_NODE_NOT_FOUND    = 0x80660001L,
        /// <summary>HD Audio widget encountered an unexpected empty connection list.</summary>
        E_HDAUDIO_EMPTY_CONNECTION_LIST  = 0x80660002L,
        /// <summary>HD Audio widget does not support the connection list parameter.</summary>
        E_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED = 0x80660003L,
        /// <summary>No HD Audio subdevices were successfully created.</summary>
        E_HDAUDIO_NO_LOGICAL_DEVICES_CREATED = 0x80660004L,
        /// <summary>An unexpected NULL pointer was encountered in a linked list.</summary>
        E_HDAUDIO_NULL_LINKED_LIST_ENTRY = 0x80660005L,
        /// <summary>Optimistic locking failure. Data cannot be updated if it has changed since it was read.</summary>
        STATEREPOSITORY_E_CONCURRENCY_LOCKING_FAILURE = 0x80670001L,
        /// <summary>A prepared statement has been stepped at least once but not run to completion or reset. This may result in busy waits.</summary>
        STATEREPOSITORY_E_STATEMENT_INPROGRESS = 0x80670002L,
        /// <summary>The StateRepository configuration is not valid.</summary>
        STATEREPOSITORY_E_CONFIGURATION_INVALID = 0x80670003L,
        /// <summary>The StateRepository schema version is not known.</summary>
        STATEREPOSITORY_E_UNKNOWN_SCHEMA_VERSION = 0x80670004L,
        /// <summary>A StateRepository dictionary is not valid.</summary>
        STATEREPOSITORY_ERROR_DICTIONARY_CORRUPTED = 0x80670005L,
        /// <summary>The request failed because the StateRepository is actively blocking requests.</summary>
        STATEREPOSITORY_E_BLOCKED        = 0x80670006L,
        /// <summary>The database file is locked. The request will be retried.</summary>
        STATEREPOSITORY_E_BUSY_RETRY     = 0x80670007L,
        /// <summary>The database file is locked because another process is busy recovering the database. The request will be retried.</summary>
        STATEREPOSITORY_E_BUSY_RECOVERY_RETRY = 0x80670008L,
        /// <summary>A table in the database is locked. The request will be retried.</summary>
        STATEREPOSITORY_E_LOCKED_RETRY   = 0x80670009L,
        /// <summary>The shared cache for the database is locked by another connection. The request will be retried.</summary>
        STATEREPOSITORY_E_LOCKED_SHAREDCACHE_RETRY = 0x8067000AL,
        /// <summary>A transaction is required to perform the request operation.</summary>
        STATEREPOSITORY_E_TRANSACTION_REQUIRED = 0x8067000BL,
        /// <summary>The storage pool was deleted by the driver. The object cache should be updated.</summary>
        ERROR_SPACES_POOL_WAS_DELETED    = 0x00E70001L,
        /// <summary>The specified fault domain type or combination of minimum / maximum fault domain type is not valid.</summary>
        ERROR_SPACES_FAULT_DOMAIN_TYPE_INVALID = 0x80E70001L,
        /// <summary>A Storage Spaces internal error occurred.</summary>
        ERROR_SPACES_INTERNAL_ERROR      = 0x80E70002L,
        /// <summary>The specified resiliency type is not valid.</summary>
        ERROR_SPACES_RESILIENCY_TYPE_INVALID = 0x80E70003L,
        /// <summary>The physical disk's sector size is not supported by the storage pool.</summary>
        ERROR_SPACES_DRIVE_SECTOR_SIZE_INVALID = 0x80E70004L,
        /// <summary>The requested redundancy is outside of the supported range of values.</summary>
        ERROR_SPACES_DRIVE_REDUNDANCY_INVALID = 0x80E70006L,
        /// <summary>The number of data copies requested is outside of the supported range of values.</summary>
        ERROR_SPACES_NUMBER_OF_DATA_COPIES_INVALID = 0x80E70007L,
        /// <summary>The value for ParityLayout is outside of the supported range of values.</summary>
        ERROR_SPACES_PARITY_LAYOUT_INVALID = 0x80E70008L,
        /// <summary>The value for interleave length is outside of the supported range of values or is not a power of 2.</summary>
        ERROR_SPACES_INTERLEAVE_LENGTH_INVALID = 0x80E70009L,
        /// <summary>The number of columns specified is outside of the supported range of values.</summary>
        ERROR_SPACES_NUMBER_OF_COLUMNS_INVALID = 0x80E7000AL,
        /// <summary>There were not enough physical disks to complete the requested operation.</summary>
        ERROR_SPACES_NOT_ENOUGH_DRIVES   = 0x80E7000BL,
        /// <summary>Extended error information is available.</summary>
        ERROR_SPACES_EXTENDED_ERROR      = 0x80E7000CL,
        /// <summary>The specified provisioning type is not valid.</summary>
        ERROR_SPACES_PROVISIONING_TYPE_INVALID = 0x80E7000DL,
        /// <summary>The allocation size is outside of the supported range of values.</summary>
        ERROR_SPACES_ALLOCATION_SIZE_INVALID = 0x80E7000EL,
        /// <summary>Enclosure awareness is not supported for this virtual disk.</summary>
        ERROR_SPACES_ENCLOSURE_AWARE_INVALID = 0x80E7000FL,
        /// <summary>The write cache size is outside of the supported range of values.</summary>
        ERROR_SPACES_WRITE_CACHE_SIZE_INVALID = 0x80E70010L,
        /// <summary>The value for number of groups is outside of the supported range of values.</summary>
        ERROR_SPACES_NUMBER_OF_GROUPS_INVALID = 0x80E70011L,
        /// <summary>The OperationalState of the physical disk is invalid for this operation.</summary>
        ERROR_SPACES_DRIVE_OPERATIONAL_STATE_INVALID = 0x80E70012L,
        /// <summary>The bootfile is too small to support persistent snapshots.</summary>
        ERROR_VOLSNAP_BOOTFILE_NOT_VALID = 0x80820001L,
        /// <summary>Activation of persistent snapshots on this volume took longer than was allowed.</summary>
        ERROR_VOLSNAP_ACTIVATION_TIMEOUT = 0x80820002L,
        /// <summary>The specified volume does not support storage tiers.</summary>
        ERROR_TIERING_NOT_SUPPORTED_ON_VOLUME = 0x80830001L,
        /// <summary>The Storage Tiers Management service detected that the specified volume is in the process of being dismounted.</summary>
        ERROR_TIERING_VOLUME_DISMOUNT_IN_PROGRESS = 0x80830002L,
        /// <summary>The specified storage tier could not be found on the volume. Confirm that the storage tier name is valid.</summary>
        ERROR_TIERING_STORAGE_TIER_NOT_FOUND = 0x80830003L,
        /// <summary>The file identifier specified is not valid on the volume.</summary>
        ERROR_TIERING_INVALID_FILE_ID    = 0x80830004L,
        /// <summary>Storage tier operations must be called on the clustering node that owns the metadata volume.</summary>
        ERROR_TIERING_WRONG_CLUSTER_NODE = 0x80830005L,
        /// <summary>The Storage Tiers Management service is already optimizing the storage tiers on the specified volume.</summary>
        ERROR_TIERING_ALREADY_PROCESSING = 0x80830006L,
        /// <summary>The requested object type cannot be assigned to a storage tier.</summary>
        ERROR_TIERING_CANNOT_PIN_OBJECT  = 0x80830007L,
        /// <summary>The command was not recognized by the security core</summary>
        ERROR_SECCORE_INVALID_COMMAND    = 0xC0E80000L,
        /// <summary>No applicable app licenses found.</summary>
        ERROR_NO_APPLICABLE_APP_LICENSES_FOUND = 0xC0EA0001L,
        /// <summary>CLiP license not found.</summary>
        ERROR_CLIP_LICENSE_NOT_FOUND     = 0xC0EA0002L,
        /// <summary>CLiP device license not found.</summary>
        ERROR_CLIP_DEVICE_LICENSE_MISSING = 0xC0EA0003L,
        /// <summary>CLiP license has an invalid signature.</summary>
        ERROR_CLIP_LICENSE_INVALID_SIGNATURE = 0xC0EA0004L,
        /// <summary>CLiP keyholder license is invalid or missing.</summary>
        ERROR_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID = 0xC0EA0005L,
        /// <summary>CLiP license has expired.</summary>
        ERROR_CLIP_LICENSE_EXPIRED       = 0xC0EA0006L,
        /// <summary>CLiP license is signed by an unknown source.</summary>
        ERROR_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE = 0xC0EA0007L,
        /// <summary>CLiP license is not signed.</summary>
        ERROR_CLIP_LICENSE_NOT_SIGNED    = 0xC0EA0008L,
        /// <summary>CLiP license hardware ID is out of tolerance.</summary>
        ERROR_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE = 0xC0EA0009L,
        /// <summary>CLiP license device ID does not match the device ID in the bound device license.</summary>
        ERROR_CLIP_LICENSE_DEVICE_ID_MISMATCH = 0xC0EA000AL,
        /// <summary>The Present operation was invisible to the user.</summary>
        DXGI_STATUS_OCCLUDED             = 0x087A0001L,
        /// <summary>The Present operation was partially invisible to the user.</summary>
        DXGI_STATUS_CLIPPED              = 0x087A0002L,
        /// <summary>The driver is requesting that the DXGI runtime not use shared resources to communicate with the Desktop Window Manager.</summary>
        DXGI_STATUS_NO_REDIRECTION       = 0x087A0004L,
        /// <summary>The Present operation was not visible because the Windows session has switched to another desktop (for example, ctrl-alt-del).</summary>
        DXGI_STATUS_NO_DESKTOP_ACCESS    = 0x087A0005L,
        /// <summary>The Present operation was not visible because the target monitor was being used for some other purpose.</summary>
        DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = 0x087A0006L,
        /// <summary>The Present operation was not visible because the display mode changed. DXGI will have re-attempted the presentation.</summary>
        DXGI_STATUS_MODE_CHANGED         = 0x087A0007L,
        /// <summary>The Present operation was not visible because another Direct3D device was attempting to take fullscreen mode at the time.</summary>
        DXGI_STATUS_MODE_CHANGE_IN_PROGRESS = 0x087A0008L,
        /// <summary>The application made a call that is invalid. Either the parameters of the call or the state of some object was incorrect. Enable the D3D debug layer in order to see details via debug messages.</summary>
        DXGI_ERROR_INVALID_CALL          = 0x887A0001L,
        /// <summary>The object was not found. If calling IDXGIFactory::EnumAdaptes, there is no adapter with the specified ordinal.</summary>
        DXGI_ERROR_NOT_FOUND             = 0x887A0002L,
        /// <summary>The caller did not supply a sufficiently large buffer.</summary>
        DXGI_ERROR_MORE_DATA             = 0x887A0003L,
        /// <summary>The specified device interface or feature level is not supported on this system.</summary>
        DXGI_ERROR_UNSUPPORTED           = 0x887A0004L,
        /// <summary>The GPU device instance has been suspended. Use GetDeviceRemovedReason to determine the appropriate action.</summary>
        DXGI_ERROR_DEVICE_REMOVED        = 0x887A0005L,
        /// <summary>The GPU will not respond to more commands, most likely because of an invalid command passed by the calling application.</summary>
        DXGI_ERROR_DEVICE_HUNG           = 0x887A0006L,
        /// <summary>The GPU will not respond to more commands, most likely because some other application submitted invalid commands. The calling application should re-create the device and continue.</summary>
        DXGI_ERROR_DEVICE_RESET          = 0x887A0007L,
        /// <summary>The GPU was busy at the moment when the call was made, and the call was neither executed nor scheduled.</summary>
        DXGI_ERROR_WAS_STILL_DRAWING     = 0x887A000AL,
        /// <summary>An event (such as power cycle) interrupted the gathering of presentation statistics. Any previous statistics should be considered invalid.</summary>
        DXGI_ERROR_FRAME_STATISTICS_DISJOINT = 0x887A000BL,
        /// <summary>Fullscreen mode could not be achieved because the specified output was already in use.</summary>
        DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = 0x887A000CL,
        /// <summary>An internal issue prevented the driver from carrying out the specified operation. The driver's state is probably suspect, and the application should not continue.</summary>
        DXGI_ERROR_DRIVER_INTERNAL_ERROR = 0x887A0020L,
        /// <summary>A global counter resource was in use, and the specified counter cannot be used by this Direct3D device at this time.</summary>
        DXGI_ERROR_NONEXCLUSIVE          = 0x887A0021L,
        /// <summary>A resource is not available at the time of the call, but may become available later.</summary>
        DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = 0x887A0022L,
        /// <summary>The application's remote device has been removed due to session disconnect or network disconnect. The application should call IDXGIFactory1::IsCurrent to find out when the remote device becomes available again.</summary>
        DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = 0x887A0023L,
        /// <summary>The device has been removed during a remote session because the remote computer ran out of memory.</summary>
        DXGI_ERROR_REMOTE_OUTOFMEMORY    = 0x887A0024L,
        /// <summary>The keyed mutex was abandoned.</summary>
        DXGI_ERROR_ACCESS_LOST           = 0x887A0026L,
        /// <summary>The timeout value has elapsed and the resource is not yet available.</summary>
        DXGI_ERROR_WAIT_TIMEOUT          = 0x887A0027L,
        /// <summary>The output duplication has been turned off because the Windows session ended or was disconnected. This happens when a remote user disconnects, or when "switch user" is used locally.</summary>
        DXGI_ERROR_SESSION_DISCONNECTED  = 0x887A0028L,
        /// <summary>The DXGI outuput (monitor) to which the swapchain content was restricted, has been disconnected or changed.</summary>
        DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = 0x887A0029L,
        /// <summary>DXGI is unable to provide content protection on the swapchain. This is typically caused by an older driver, or by the application using a swapchain that is incompatible with content protection.</summary>
        DXGI_ERROR_CANNOT_PROTECT_CONTENT = 0x887A002AL,
        /// <summary>The application is trying to use a resource to which it does not have the required access privileges. This is most commonly caused by writing to a shared resource with read-only access.</summary>
        DXGI_ERROR_ACCESS_DENIED         = 0x887A002BL,
        /// <summary>The application is trying to create a shared handle using a name that is already associated with some other resource.</summary>
        DXGI_ERROR_NAME_ALREADY_EXISTS   = 0x887A002CL,
        /// <summary>The application requested an operation that depends on an SDK component that is missing or mismatched.</summary>
        DXGI_ERROR_SDK_COMPONENT_MISSING = 0x887A002DL,
        /// <summary>The DXGI objects that the application has created are no longer current & need to be recreated for this operation to be performed.</summary>
        DXGI_ERROR_NOT_CURRENT           = 0x887A002EL,
        /// <summary>Insufficient HW protected memory exits for proper function.</summary>
        DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = 0x887A0030L,
        /// <summary>The swapchain has become unoccluded.</summary>
        DXGI_STATUS_UNOCCLUDED           = 0x087A0009L,
        /// <summary>The adapter did not have access to the required resources to complete the Desktop Duplication Present() call, the Present() call needs to be made again</summary>
        DXGI_STATUS_DDA_WAS_STILL_DRAWING = 0x087A000AL,
        /// <summary>An on-going mode change prevented completion of the call. The call may succeed if attempted later.</summary>
        DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = 0x887A0025L,
        /// <summary>The present succeeded but the caller should present again on the next V-sync, even if there are no changes to the content.</summary>
        DXGI_STATUS_PRESENT_REQUIRED     = 0x087A002FL,
        /// <summary>The GPU was busy when the operation was requested.</summary>
        DXGI_DDI_ERR_WASSTILLDRAWING     = 0x887B0001L,
        /// <summary>The driver has rejected the creation of this resource.</summary>
        DXGI_DDI_ERR_UNSUPPORTED         = 0x887B0002L,
        /// <summary>The GPU counter was in use by another process or d3d device when application requested access to it.</summary>
        DXGI_DDI_ERR_NONEXCLUSIVE        = 0x887B0003L,
        /// <summary>The application has exceeded the maximum number of unique state objects per Direct3D device. The limit is 4096 for feature levels up to 11.1.</summary>
        D3D10_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = 0x88790001L,
        /// <summary>The specified file was not found.</summary>
        D3D10_ERROR_FILE_NOT_FOUND       = 0x88790002L,
        /// <summary>The application has exceeded the maximum number of unique state objects per Direct3D device. The limit is 4096 for feature levels up to 11.1.</summary>
        D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = 0x887C0001L,
        /// <summary>The specified file was not found.</summary>
        D3D11_ERROR_FILE_NOT_FOUND       = 0x887C0002L,
        /// <summary>The application has exceeded the maximum number of unique view objects per Direct3D device. The limit is 2^20 for feature levels up to 11.1.</summary>
        D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS = 0x887C0003L,
        /// <summary>The application's first call per command list to Map on a deferred context did not use D3D11_MAP_WRITE_DISCARD.</summary>
        D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD = 0x887C0004L,
        /// <summary>The blob provided does not match the adapter that the device was created on.</summary>
        D3D12_ERROR_ADAPTER_NOT_FOUND    = 0x887E0001L,
        /// <summary>The blob provided was created for a different version of the driver, and must be re-created.</summary>
        D3D12_ERROR_DRIVER_VERSION_MISMATCH = 0x887E0002L,
        /// <summary>The object was not in the correct state to process the method.</summary>
        D2DERR_WRONG_STATE               = 0x88990001L,
        /// <summary>The object has not yet been initialized.</summary>
        D2DERR_NOT_INITIALIZED           = 0x88990002L,
        /// <summary>The requested operation is not supported.</summary>
        D2DERR_UNSUPPORTED_OPERATION     = 0x88990003L,
        /// <summary>The geometry scanner failed to process the data.</summary>
        D2DERR_SCANNER_FAILED            = 0x88990004L,
        /// <summary>Direct2D could not access the screen.</summary>
        D2DERR_SCREEN_ACCESS_DENIED      = 0x88990005L,
        /// <summary>A valid display state could not be determined.</summary>
        D2DERR_DISPLAY_STATE_INVALID     = 0x88990006L,
        /// <summary>The supplied vector is zero.</summary>
        D2DERR_ZERO_VECTOR               = 0x88990007L,
        /// <summary>An internal error (Direct2D bug) occurred. On checked builds, we would assert. The application should close this instance of Direct2D and should consider restarting its process.</summary>
        D2DERR_INTERNAL_ERROR            = 0x88990008L,
        /// <summary>The display format Direct2D needs to render is not supported by the hardware device.</summary>
        D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED = 0x88990009L,
        /// <summary>A call to this method is invalid.</summary>
        D2DERR_INVALID_CALL              = 0x8899000AL,
        /// <summary>No hardware rendering device is available for this operation.</summary>
        D2DERR_NO_HARDWARE_DEVICE        = 0x8899000BL,
        /// <summary>There has been a presentation error that may be recoverable. The caller needs to recreate, rerender the entire frame, and reattempt present.</summary>
        D2DERR_RECREATE_TARGET           = 0x8899000CL,
        /// <summary>Shader construction failed because it was too complex.</summary>
        D2DERR_TOO_MANY_SHADER_ELEMENTS  = 0x8899000DL,
        /// <summary>Shader compilation failed.</summary>
        D2DERR_SHADER_COMPILE_FAILED     = 0x8899000EL,
        /// <summary>Requested DirectX surface size exceeded maximum texture size.</summary>
        D2DERR_MAX_TEXTURE_SIZE_EXCEEDED = 0x8899000FL,
        /// <summary>The requested Direct2D version is not supported.</summary>
        D2DERR_UNSUPPORTED_VERSION       = 0x88990010L,
        /// <summary>Invalid number.</summary>
        D2DERR_BAD_NUMBER                = 0x88990011L,
        /// <summary>Objects used together must be created from the same factory instance.</summary>
        D2DERR_WRONG_FACTORY             = 0x88990012L,
        /// <summary>A layer resource can only be in use once at any point in time.</summary>
        D2DERR_LAYER_ALREADY_IN_USE      = 0x88990013L,
        /// <summary>The pop call did not match the corresponding push call.</summary>
        D2DERR_POP_CALL_DID_NOT_MATCH_PUSH = 0x88990014L,
        /// <summary>The resource was realized on the wrong render target.</summary>
        D2DERR_WRONG_RESOURCE_DOMAIN     = 0x88990015L,
        /// <summary>The push and pop calls were unbalanced.</summary>
        D2DERR_PUSH_POP_UNBALANCED       = 0x88990016L,
        /// <summary>Attempt to copy from a render target while a layer or clip rect is applied.</summary>
        D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT = 0x88990017L,
        /// <summary>The brush types are incompatible for the call.</summary>
        D2DERR_INCOMPATIBLE_BRUSH_TYPES  = 0x88990018L,
        /// <summary>An unknown win32 failure occurred.</summary>
        D2DERR_WIN32_ERROR               = 0x88990019L,
        /// <summary>The render target is not compatible with GDI.</summary>
        D2DERR_TARGET_NOT_GDI_COMPATIBLE = 0x8899001AL,
        /// <summary>A text client drawing effect object is of the wrong type.</summary>
        D2DERR_TEXT_EFFECT_IS_WRONG_TYPE = 0x8899001BL,
        /// <summary>The application is holding a reference to the IDWriteTextRenderer interface after the corresponding DrawText or DrawTextLayout call has returned. The IDWriteTextRenderer instance will be invalid.</summary>
        D2DERR_TEXT_RENDERER_NOT_RELEASED = 0x8899001CL,
        /// <summary>The requested size is larger than the guaranteed supported texture size at the Direct3D device's current feature level.</summary>
        D2DERR_EXCEEDS_MAX_BITMAP_SIZE   = 0x8899001DL,
        /// <summary>There was a configuration error in the graph.</summary>
        D2DERR_INVALID_GRAPH_CONFIGURATION = 0x8899001EL,
        /// <summary>There was a internal configuration error in the graph.</summary>
        D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION = 0x8899001FL,
        /// <summary>There was a cycle in the graph.</summary>
        D2DERR_CYCLIC_GRAPH              = 0x88990020L,
        /// <summary>Cannot draw with a bitmap that has the D2D1_BITMAP_OPTIONS_CANNOT_DRAW option.</summary>
        D2DERR_BITMAP_CANNOT_DRAW        = 0x88990021L,
        /// <summary>The operation cannot complete while there are outstanding references to the target bitmap.</summary>
        D2DERR_OUTSTANDING_BITMAP_REFERENCES = 0x88990022L,
        /// <summary>The operation failed because the original target is not currently bound as a target.</summary>
        D2DERR_ORIGINAL_TARGET_NOT_BOUND = 0x88990023L,
        /// <summary>Cannot set the image as a target because it is either an effect or is a bitmap that does not have the D2D1_BITMAP_OPTIONS_TARGET flag set.</summary>
        D2DERR_INVALID_TARGET            = 0x88990024L,
        /// <summary>Cannot draw with a bitmap that is currently bound as the target bitmap.</summary>
        D2DERR_BITMAP_BOUND_AS_TARGET    = 0x88990025L,
        /// <summary>D3D Device does not have sufficient capabilities to perform the requested action.</summary>
        D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES = 0x88990026L,
        /// <summary>The graph could not be rendered with the context's current tiling settings.</summary>
        D2DERR_INTERMEDIATE_TOO_LARGE    = 0x88990027L,
        /// <summary>The CLSID provided to Unregister did not correspond to a registered effect.</summary>
        D2DERR_EFFECT_IS_NOT_REGISTERED  = 0x88990028L,
        /// <summary>The specified property does not exist.</summary>
        D2DERR_INVALID_PROPERTY          = 0x88990029L,
        /// <summary>The specified sub-property does not exist.</summary>
        D2DERR_NO_SUBPROPERTIES          = 0x8899002AL,
        /// <summary>AddPage or Close called after print job is already closed.</summary>
        D2DERR_PRINT_JOB_CLOSED          = 0x8899002BL,
        /// <summary>Error during print control creation. Indicates that none of the package target types (representing printer formats) are supported by Direct2D print control.</summary>
        D2DERR_PRINT_FORMAT_NOT_SUPPORTED = 0x8899002CL,
        /// <summary>An effect attempted to use a transform with too many inputs.</summary>
        D2DERR_TOO_MANY_TRANSFORM_INPUTS = 0x8899002DL,
        /// <summary>An error was encountered while decoding or parsing the requested glyph image.</summary>
        D2DERR_INVALID_GLYPH_IMAGE       = 0x8899002EL,
        /// <summary>Indicates an error in an input file such as a font file.</summary>
        DWRITE_E_FILEFORMAT              = 0x88985000L,
        /// <summary>Indicates an error originating in DirectWrite code, which is not expected to occur but is safe to recover from.</summary>
        DWRITE_E_UNEXPECTED              = 0x88985001L,
        /// <summary>Indicates the specified font does not exist.</summary>
        DWRITE_E_NOFONT                  = 0x88985002L,
        /// <summary>A font file could not be opened because the file, directory, network location, drive, or other storage location does not exist or is unavailable.</summary>
        DWRITE_E_FILENOTFOUND            = 0x88985003L,
        /// <summary>A font file exists but could not be opened due to access denied, sharing violation, or similar error.</summary>
        DWRITE_E_FILEACCESS              = 0x88985004L,
        /// <summary>A font collection is obsolete due to changes in the system.</summary>
        DWRITE_E_FONTCOLLECTIONOBSOLETE  = 0x88985005L,
        /// <summary>The given interface is already registered.</summary>
        DWRITE_E_ALREADYREGISTERED       = 0x88985006L,
        /// <summary>The font cache contains invalid data.</summary>
        DWRITE_E_CACHEFORMAT             = 0x88985007L,
        /// <summary>A font cache file corresponds to a different version of DirectWrite.</summary>
        DWRITE_E_CACHEVERSION            = 0x88985008L,
        /// <summary>The operation is not supported for this type of font.</summary>
        DWRITE_E_UNSUPPORTEDOPERATION    = 0x88985009L,
        /// <summary>The version of the text renderer interface is not compatible.</summary>
        DWRITE_E_TEXTRENDERERINCOMPATIBLE = 0x8898500AL,
        /// <summary>The flow direction conflicts with the reading direction. They must be perpendicular to each other.</summary>
        DWRITE_E_FLOWDIRECTIONCONFLICTS  = 0x8898500BL,
        /// <summary>The font or glyph run does not contain any colored glyphs.</summary>
        DWRITE_E_NOCOLOR                 = 0x8898500CL,
        /// <summary>The codec is in the wrong state.</summary>
        WINCODEC_ERR_WRONGSTATE          = 0x88982F04L,
        /// <summary>The value is out of range.</summary>
        WINCODEC_ERR_VALUEOUTOFRANGE     = 0x88982F05L,
        /// <summary>The image format is unknown.</summary>
        WINCODEC_ERR_UNKNOWNIMAGEFORMAT  = 0x88982F07L,
        /// <summary>The SDK version is unsupported.</summary>
        WINCODEC_ERR_UNSUPPORTEDVERSION  = 0x88982F0BL,
        /// <summary>The component is not initialized.</summary>
        WINCODEC_ERR_NOTINITIALIZED      = 0x88982F0CL,
        /// <summary>There is already an outstanding read or write lock.</summary>
        WINCODEC_ERR_ALREADYLOCKED       = 0x88982F0DL,
        /// <summary>The specified bitmap property cannot be found.</summary>
        WINCODEC_ERR_PROPERTYNOTFOUND    = 0x88982F40L,
        /// <summary>The bitmap codec does not support the bitmap property.</summary>
        WINCODEC_ERR_PROPERTYNOTSUPPORTED = 0x88982F41L,
        /// <summary>The bitmap property size is invalid.</summary>
        WINCODEC_ERR_PROPERTYSIZE        = 0x88982F42L,
        /// <summary>An unknown error has occurred.</summary>
        WINCODEC_ERR_CODECPRESENT        = 0x88982F43L,
        /// <summary>The bitmap codec does not support a thumbnail.</summary>
        WINCODEC_ERR_CODECNOTHUMBNAIL    = 0x88982F44L,
        /// <summary>The bitmap palette is unavailable.</summary>
        WINCODEC_ERR_PALETTEUNAVAILABLE  = 0x88982F45L,
        /// <summary>Too many scanlines were requested.</summary>
        WINCODEC_ERR_CODECTOOMANYSCANLINES = 0x88982F46L,
        /// <summary>An internal error occurred.</summary>
        WINCODEC_ERR_INTERNALERROR       = 0x88982F48L,
        /// <summary>The bitmap bounds do not match the bitmap dimensions.</summary>
        WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = 0x88982F49L,
        /// <summary>The component cannot be found.</summary>
        WINCODEC_ERR_COMPONENTNOTFOUND   = 0x88982F50L,
        /// <summary>The bitmap size is outside the valid range.</summary>
        WINCODEC_ERR_IMAGESIZEOUTOFRANGE = 0x88982F51L,
        /// <summary>There is too much metadata to be written to the bitmap.</summary>
        WINCODEC_ERR_TOOMUCHMETADATA     = 0x88982F52L,
        /// <summary>The image is unrecognized.</summary>
        WINCODEC_ERR_BADIMAGE            = 0x88982F60L,
        /// <summary>The image header is unrecognized.</summary>
        WINCODEC_ERR_BADHEADER           = 0x88982F61L,
        /// <summary>The bitmap frame is missing.</summary>
        WINCODEC_ERR_FRAMEMISSING        = 0x88982F62L,
        /// <summary>The image metadata header is unrecognized.</summary>
        WINCODEC_ERR_BADMETADATAHEADER   = 0x88982F63L,
        /// <summary>The stream data is unrecognized.</summary>
        WINCODEC_ERR_BADSTREAMDATA       = 0x88982F70L,
        /// <summary>Failed to write to the stream.</summary>
        WINCODEC_ERR_STREAMWRITE         = 0x88982F71L,
        /// <summary>Failed to read from the stream.</summary>
        WINCODEC_ERR_STREAMREAD          = 0x88982F72L,
        /// <summary>The stream is not available.</summary>
        WINCODEC_ERR_STREAMNOTAVAILABLE  = 0x88982F73L,
        /// <summary>The bitmap pixel format is unsupported.</summary>
        WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = 0x88982F80L,
        /// <summary>The operation is unsupported.</summary>
        WINCODEC_ERR_UNSUPPORTEDOPERATION = 0x88982F81L,
        /// <summary>The component registration is invalid.</summary>
        WINCODEC_ERR_INVALIDREGISTRATION = 0x88982F8AL,
        /// <summary>The component initialization has failed.</summary>
        WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = 0x88982F8BL,
        /// <summary>The buffer allocated is insufficient.</summary>
        WINCODEC_ERR_INSUFFICIENTBUFFER  = 0x88982F8CL,
        /// <summary>Duplicate metadata is present.</summary>
        WINCODEC_ERR_DUPLICATEMETADATAPRESENT = 0x88982F8DL,
        /// <summary>The bitmap property type is unexpected.</summary>
        WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = 0x88982F8EL,
        /// <summary>The size is unexpected.</summary>
        WINCODEC_ERR_UNEXPECTEDSIZE      = 0x88982F8FL,
        /// <summary>The property query is invalid.</summary>
        WINCODEC_ERR_INVALIDQUERYREQUEST = 0x88982F90L,
        /// <summary>The metadata type is unexpected.</summary>
        WINCODEC_ERR_UNEXPECTEDMETADATATYPE = 0x88982F91L,
        /// <summary>The specified bitmap property is only valid at root level.</summary>
        WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = 0x88982F92L,
        /// <summary>The query string contains an invalid character.</summary>
        WINCODEC_ERR_INVALIDQUERYCHARACTER = 0x88982F93L,
        /// <summary>Windows Codecs received an error from the Win32 system.</summary>
        WINCODEC_ERR_WIN32ERROR          = 0x88982F94L,
        /// <summary>The requested level of detail is not present.</summary>
        WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = 0x88982F95L,
        /// <summary>The scan index is invalid.</summary>
        WINCODEC_ERR_INVALIDJPEGSCANINDEX = 0x88982F96L,
        /// <summary>MILERR_OBJECTBUSY</summary>
        MILERR_OBJECTBUSY                = 0x88980001L,
        /// <summary>MILERR_INSUFFICIENTBUFFER</summary>
        MILERR_INSUFFICIENTBUFFER        = 0x88980002L,
        /// <summary>MILERR_WIN32ERROR</summary>
        MILERR_WIN32ERROR                = 0x88980003L,
        /// <summary>MILERR_SCANNER_FAILED</summary>
        MILERR_SCANNER_FAILED            = 0x88980004L,
        /// <summary>MILERR_SCREENACCESSDENIED</summary>
        MILERR_SCREENACCESSDENIED        = 0x88980005L,
        /// <summary>MILERR_DISPLAYSTATEINVALID</summary>
        MILERR_DISPLAYSTATEINVALID       = 0x88980006L,
        /// <summary>MILERR_NONINVERTIBLEMATRIX</summary>
        MILERR_NONINVERTIBLEMATRIX       = 0x88980007L,
        /// <summary>MILERR_ZEROVECTOR</summary>
        MILERR_ZEROVECTOR                = 0x88980008L,
        /// <summary>MILERR_TERMINATED</summary>
        MILERR_TERMINATED                = 0x88980009L,
        /// <summary>MILERR_BADNUMBER</summary>
        MILERR_BADNUMBER                 = 0x8898000AL,
        /// <summary>An internal error (MIL bug) occurred. On checked builds, an assert would be raised.</summary>
        MILERR_INTERNALERROR             = 0x88980080L,
        /// <summary>The display format we need to render is not supported by the hardware device.</summary>
        MILERR_DISPLAYFORMATNOTSUPPORTED = 0x88980084L,
        /// <summary>A call to this method is invalid.</summary>
        MILERR_INVALIDCALL               = 0x88980085L,
        /// <summary>Lock attempted on an already locked object.</summary>
        MILERR_ALREADYLOCKED             = 0x88980086L,
        /// <summary>Unlock attempted on an unlocked object.</summary>
        MILERR_NOTLOCKED                 = 0x88980087L,
        /// <summary>No algorithm avaliable to render text with this device</summary>
        MILERR_DEVICECANNOTRENDERTEXT    = 0x88980088L,
        /// <summary>Some glyph bitmaps, required for glyph run rendering, are not contained in glyph cache.</summary>
        MILERR_GLYPHBITMAPMISSED         = 0x88980089L,
        /// <summary>Some glyph bitmaps in glyph cache are unexpectedly big.</summary>
        MILERR_MALFORMEDGLYPHCACHE       = 0x8898008AL,
        /// <summary>Marker error for known Win32 errors that are currently being ignored by the compositor. This is to avoid returning S_OK when an error has occurred, but still unwind the stack in the correct location.</summary>
        MILERR_GENERIC_IGNORE            = 0x8898008BL,
        /// <summary>Guideline coordinates are not sorted properly or contain NaNs.</summary>
        MILERR_MALFORMED_GUIDELINE_DATA  = 0x8898008CL,
        /// <summary>No HW rendering device is available for this operation.</summary>
        MILERR_NO_HARDWARE_DEVICE        = 0x8898008DL,
        /// <summary>There has been a presentation error that may be recoverable. The caller needs to recreate, rerender the entire frame, and reattempt present. There are two known case for this: 1) D3D Driver Internal error 2) D3D E_FAIL 2a) Unknown root cause b) When resizing too quickly for DWM and D3D stay in sync</summary>
        MILERR_NEED_RECREATE_AND_PRESENT = 0x8898008EL,
        /// <summary>The object has already been initialized.</summary>
        MILERR_ALREADY_INITIALIZED       = 0x8898008FL,
        /// <summary>The size of the object does not match the expected size.</summary>
        MILERR_MISMATCHED_SIZE           = 0x88980090L,
        /// <summary>No Redirection surface available.</summary>
        MILERR_NO_REDIRECTION_SURFACE_AVAILABLE = 0x88980091L,
        /// <summary>Remoting of this content is not supported.</summary>
        MILERR_REMOTING_NOT_SUPPORTED    = 0x88980092L,
        /// <summary>Queued Presents are not supported.</summary>
        MILERR_QUEUED_PRESENT_NOT_SUPPORTED = 0x88980093L,
        /// <summary>Queued Presents are not being used.</summary>
        MILERR_NOT_QUEUING_PRESENTS      = 0x88980094L,
        /// <summary>No redirection surface was available. Caller should retry the call.</summary>
        MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER = 0x88980095L,
        /// <summary>Shader construction failed because it was too complex.</summary>
        MILERR_TOOMANYSHADERELEMNTS      = 0x88980096L,
        /// <summary>MROW attempt to get a read lock failed.</summary>
        MILERR_MROW_READLOCK_FAILED      = 0x88980097L,
        /// <summary>MROW attempt to update the data failed because another update was outstanding.</summary>
        MILERR_MROW_UPDATE_FAILED        = 0x88980098L,
        /// <summary>Shader compilation failed.</summary>
        MILERR_SHADER_COMPILE_FAILED     = 0x88980099L,
        /// <summary>Requested DX redirection surface size exceeded maximum texture size.</summary>
        MILERR_MAX_TEXTURE_SIZE_EXCEEDED = 0x8898009AL,
        /// <summary>QueryPerformanceCounter returned a time in the past.</summary>
        MILERR_QPC_TIME_WENT_BACKWARD    = 0x8898009BL,
        /// <summary>Primary Display device returned an invalid refresh rate.</summary>
        MILERR_DXGI_ENUMERATION_OUT_OF_SYNC = 0x8898009DL,
        /// <summary>DWM can not find the adapter specified by the LUID.</summary>
        MILERR_ADAPTER_NOT_FOUND         = 0x8898009EL,
        /// <summary>The requested bitmap color space is not supported.</summary>
        MILERR_COLORSPACE_NOT_SUPPORTED  = 0x8898009FL,
        /// <summary>The requested bitmap pre-filtering state is not supported.</summary>
        MILERR_PREFILTER_NOT_SUPPORTED   = 0x889800A0L,
        /// <summary>Access is denied to the requested bitmap for the specified display id.</summary>
        MILERR_DISPLAYID_ACCESS_DENIED   = 0x889800A1L,
        /// <summary>UCEERR_INVALIDPACKETHEADER</summary>
        UCEERR_INVALIDPACKETHEADER       = 0x88980400L,
        /// <summary>UCEERR_UNKNOWNPACKET</summary>
        UCEERR_UNKNOWNPACKET             = 0x88980401L,
        /// <summary>UCEERR_ILLEGALPACKET</summary>
        UCEERR_ILLEGALPACKET             = 0x88980402L,
        /// <summary>UCEERR_MALFORMEDPACKET</summary>
        UCEERR_MALFORMEDPACKET           = 0x88980403L,
        /// <summary>UCEERR_ILLEGALHANDLE</summary>
        UCEERR_ILLEGALHANDLE             = 0x88980404L,
        /// <summary>UCEERR_HANDLELOOKUPFAILED</summary>
        UCEERR_HANDLELOOKUPFAILED        = 0x88980405L,
        /// <summary>UCEERR_RENDERTHREADFAILURE</summary>
        UCEERR_RENDERTHREADFAILURE       = 0x88980406L,
        /// <summary>UCEERR_CTXSTACKFRSTTARGETNULL</summary>
        UCEERR_CTXSTACKFRSTTARGETNULL    = 0x88980407L,
        /// <summary>UCEERR_CONNECTIONIDLOOKUPFAILED</summary>
        UCEERR_CONNECTIONIDLOOKUPFAILED  = 0x88980408L,
        /// <summary>UCEERR_BLOCKSFULL</summary>
        UCEERR_BLOCKSFULL                = 0x88980409L,
        /// <summary>UCEERR_MEMORYFAILURE</summary>
        UCEERR_MEMORYFAILURE             = 0x8898040AL,
        /// <summary>UCEERR_PACKETRECORDOUTOFRANGE</summary>
        UCEERR_PACKETRECORDOUTOFRANGE    = 0x8898040BL,
        /// <summary>UCEERR_ILLEGALRECORDTYPE</summary>
        UCEERR_ILLEGALRECORDTYPE         = 0x8898040CL,
        /// <summary>UCEERR_OUTOFHANDLES</summary>
        UCEERR_OUTOFHANDLES              = 0x8898040DL,
        /// <summary>UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED</summary>
        UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED = 0x8898040EL,
        /// <summary>UCEERR_NO_MULTIPLE_WORKER_THREADS</summary>
        UCEERR_NO_MULTIPLE_WORKER_THREADS = 0x8898040FL,
        /// <summary>UCEERR_REMOTINGNOTSUPPORTED</summary>
        UCEERR_REMOTINGNOTSUPPORTED      = 0x88980410L,
        /// <summary>UCEERR_MISSINGENDCOMMAND</summary>
        UCEERR_MISSINGENDCOMMAND         = 0x88980411L,
        /// <summary>UCEERR_MISSINGBEGINCOMMAND</summary>
        UCEERR_MISSINGBEGINCOMMAND       = 0x88980412L,
        /// <summary>UCEERR_CHANNELSYNCTIMEDOUT</summary>
        UCEERR_CHANNELSYNCTIMEDOUT       = 0x88980413L,
        /// <summary>UCEERR_CHANNELSYNCABANDONED</summary>
        UCEERR_CHANNELSYNCABANDONED      = 0x88980414L,
        /// <summary>UCEERR_UNSUPPORTEDTRANSPORTVERSION</summary>
        UCEERR_UNSUPPORTEDTRANSPORTVERSION = 0x88980415L,
        /// <summary>UCEERR_TRANSPORTUNAVAILABLE</summary>
        UCEERR_TRANSPORTUNAVAILABLE      = 0x88980416L,
        /// <summary>UCEERR_FEEDBACK_UNSUPPORTED</summary>
        UCEERR_FEEDBACK_UNSUPPORTED      = 0x88980417L,
        /// <summary>UCEERR_COMMANDTRANSPORTDENIED</summary>
        UCEERR_COMMANDTRANSPORTDENIED    = 0x88980418L,
        /// <summary>UCEERR_GRAPHICSSTREAMUNAVAILABLE</summary>
        UCEERR_GRAPHICSSTREAMUNAVAILABLE = 0x88980419L,
        /// <summary>UCEERR_GRAPHICSSTREAMALREADYOPEN</summary>
        UCEERR_GRAPHICSSTREAMALREADYOPEN = 0x88980420L,
        /// <summary>UCEERR_TRANSPORTDISCONNECTED</summary>
        UCEERR_TRANSPORTDISCONNECTED     = 0x88980421L,
        /// <summary>UCEERR_TRANSPORTOVERLOADED</summary>
        UCEERR_TRANSPORTOVERLOADED       = 0x88980422L,
        /// <summary>UCEERR_PARTITION_ZOMBIED</summary>
        UCEERR_PARTITION_ZOMBIED         = 0x88980423L,
        /// <summary>MILAVERR_NOCLOCK</summary>
        MILAVERR_NOCLOCK                 = 0x88980500L,
        /// <summary>MILAVERR_NOMEDIATYPE</summary>
        MILAVERR_NOMEDIATYPE             = 0x88980501L,
        /// <summary>MILAVERR_NOVIDEOMIXER</summary>
        MILAVERR_NOVIDEOMIXER            = 0x88980502L,
        /// <summary>MILAVERR_NOVIDEOPRESENTER</summary>
        MILAVERR_NOVIDEOPRESENTER        = 0x88980503L,
        /// <summary>MILAVERR_NOREADYFRAMES</summary>
        MILAVERR_NOREADYFRAMES           = 0x88980504L,
        /// <summary>MILAVERR_MODULENOTLOADED</summary>
        MILAVERR_MODULENOTLOADED         = 0x88980505L,
        /// <summary>MILAVERR_WMPFACTORYNOTREGISTERED</summary>
        MILAVERR_WMPFACTORYNOTREGISTERED = 0x88980506L,
        /// <summary>MILAVERR_INVALIDWMPVERSION</summary>
        MILAVERR_INVALIDWMPVERSION       = 0x88980507L,
        /// <summary>MILAVERR_INSUFFICIENTVIDEORESOURCES</summary>
        MILAVERR_INSUFFICIENTVIDEORESOURCES = 0x88980508L,
        /// <summary>MILAVERR_VIDEOACCELERATIONNOTAVAILABLE</summary>
        MILAVERR_VIDEOACCELERATIONNOTAVAILABLE = 0x88980509L,
        /// <summary>MILAVERR_REQUESTEDTEXTURETOOBIG</summary>
        MILAVERR_REQUESTEDTEXTURETOOBIG  = 0x8898050AL,
        /// <summary>MILAVERR_SEEKFAILED</summary>
        MILAVERR_SEEKFAILED              = 0x8898050BL,
        /// <summary>MILAVERR_UNEXPECTEDWMPFAILURE</summary>
        MILAVERR_UNEXPECTEDWMPFAILURE    = 0x8898050CL,
        /// <summary>MILAVERR_MEDIAPLAYERCLOSED</summary>
        MILAVERR_MEDIAPLAYERCLOSED       = 0x8898050DL,
        /// <summary>MILAVERR_UNKNOWNHARDWAREERROR</summary>
        MILAVERR_UNKNOWNHARDWAREERROR    = 0x8898050EL,
        /// <summary>MILEFFECTSERR_UNKNOWNPROPERTY</summary>
        MILEFFECTSERR_UNKNOWNPROPERTY    = 0x8898060EL,
        /// <summary>MILEFFECTSERR_EFFECTNOTPARTOFGROUP</summary>
        MILEFFECTSERR_EFFECTNOTPARTOFGROUP = 0x8898060FL,
        /// <summary>MILEFFECTSERR_NOINPUTSOURCEATTACHED</summary>
        MILEFFECTSERR_NOINPUTSOURCEATTACHED = 0x88980610L,
        /// <summary>MILEFFECTSERR_CONNECTORNOTCONNECTED</summary>
        MILEFFECTSERR_CONNECTORNOTCONNECTED = 0x88980611L,
        /// <summary>MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT</summary>
        MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT = 0x88980612L,
        /// <summary>MILEFFECTSERR_RESERVED</summary>
        MILEFFECTSERR_RESERVED           = 0x88980613L,
        /// <summary>MILEFFECTSERR_CYCLEDETECTED</summary>
        MILEFFECTSERR_CYCLEDETECTED      = 0x88980614L,
        /// <summary>MILEFFECTSERR_EFFECTINMORETHANONEGRAPH</summary>
        MILEFFECTSERR_EFFECTINMORETHANONEGRAPH = 0x88980615L,
        /// <summary>MILEFFECTSERR_EFFECTALREADYINAGRAPH</summary>
        MILEFFECTSERR_EFFECTALREADYINAGRAPH = 0x88980616L,
        /// <summary>MILEFFECTSERR_EFFECTHASNOCHILDREN</summary>
        MILEFFECTSERR_EFFECTHASNOCHILDREN = 0x88980617L,
        /// <summary>MILEFFECTSERR_ALREADYATTACHEDTOLISTENER</summary>
        MILEFFECTSERR_ALREADYATTACHEDTOLISTENER = 0x88980618L,
        /// <summary>MILEFFECTSERR_NOTAFFINETRANSFORM</summary>
        MILEFFECTSERR_NOTAFFINETRANSFORM = 0x88980619L,
        /// <summary>MILEFFECTSERR_EMPTYBOUNDS</summary>
        MILEFFECTSERR_EMPTYBOUNDS        = 0x8898061AL,
        /// <summary>MILEFFECTSERR_OUTPUTSIZETOOLARGE</summary>
        MILEFFECTSERR_OUTPUTSIZETOOLARGE = 0x8898061BL,
        /// <summary>DWMERR_STATE_TRANSITION_FAILED</summary>
        DWMERR_STATE_TRANSITION_FAILED   = 0x88980700L,
        /// <summary>DWMERR_THEME_FAILED</summary>
        DWMERR_THEME_FAILED              = 0x88980701L,
        /// <summary>DWMERR_CATASTROPHIC_FAILURE</summary>
        DWMERR_CATASTROPHIC_FAILURE      = 0x88980702L,
        /// <summary>DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED</summary>
        DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED = 0x88980800L,
        /// <summary>DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED</summary>
        DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED = 0x88980801L,
        /// <summary>DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED</summary>
        DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED = 0x88980802L,
        /// <summary>Authentication target is invalid or not configured correctly.</summary>
        ONL_E_INVALID_AUTHENTICATION_TARGET = 0x80860001L,
        /// <summary>Your application cannot get the Online Id properties due to the Terms of Use accepted by the user.</summary>
        ONL_E_ACCESS_DENIED_BY_TOU       = 0x80860002L,
        /// <summary>The application requesting authentication tokens is either disabled or incorrectly configured.</summary>
        ONL_E_INVALID_APPLICATION        = 0x80860003L,
        /// <summary>Online Id password must be updated before signin.</summary>
        ONL_E_PASSWORD_UPDATE_REQUIRED   = 0x80860004L,
        /// <summary>Online Id account properties must be updated before signin.</summary>
        ONL_E_ACCOUNT_UPDATE_REQUIRED    = 0x80860005L,
        /// <summary>To help protect your Online Id account you must signin again.</summary>
        ONL_E_FORCESIGNIN                = 0x80860006L,
        /// <summary>Online Id account was locked because there have been too many attempts to sign in.</summary>
        ONL_E_ACCOUNT_LOCKED             = 0x80860007L,
        /// <summary>Online Id account requires parental consent before proceeding.</summary>
        ONL_E_PARENTAL_CONSENT_REQUIRED  = 0x80860008L,
        /// <summary>Online Id signin name is not yet verified. Email verification is required before signin.</summary>
        ONL_E_EMAIL_VERIFICATION_REQUIRED = 0x80860009L,
        /// <summary>We have noticed some unusual activity in your Online Id account. Your action is needed to make sure no one else is using your account.</summary>
        ONL_E_ACCOUNT_SUSPENDED_COMPROIMISE = 0x8086000AL,
        /// <summary>We detected some suspicious activity with your Online Id account. To help protect you, we've temporarily blocked your account.</summary>
        ONL_E_ACCOUNT_SUSPENDED_ABUSE    = 0x8086000BL,
        /// <summary>User interaction is required for authentication.</summary>
        ONL_E_ACTION_REQUIRED            = 0x8086000CL,
        /// <summary>User has reached the maximum device associations per user limit.</summary>
        ONL_CONNECTION_COUNT_LIMIT       = 0x8086000DL,
        /// <summary>Cannot sign out from the application since the user account is connected.</summary>
        ONL_E_CONNECTED_ACCOUNT_CAN_NOT_SIGNOUT = 0x8086000EL,
        /// <summary>User authentication is required for this operation.</summary>
        ONL_E_USER_AUTHENTICATION_REQUIRED = 0x8086000FL,
        /// <summary>We want to make sure this is you. User interaction is required for authentication.</summary>
        ONL_E_REQUEST_THROTTLED          = 0x80860010L,
        /// <summary>The maximum number of items for the access list has been reached. An item must be removed before another item is added.</summary>
        FA_E_MAX_PERSISTED_ITEMS_REACHED = 0x80270220L,
        /// <summary>Cannot access Homegroup. Homegroup may not be set up or may have encountered an error.</summary>
        FA_E_HOMEGROUP_NOT_AVAILABLE     = 0x80270222L,
        /// <summary>This app can't start because the screen resolution is below 1024x768. Choose a higher screen resolution and then try again.</summary>
        E_MONITOR_RESOLUTION_TOO_LOW     = 0x80270250L,
        /// <summary>This app can't be activated from an elevated context.</summary>
        E_ELEVATED_ACTIVATION_NOT_SUPPORTED = 0x80270251L,
        /// <summary>This app can't be activated when UAC is disabled.</summary>
        E_UAC_DISABLED                   = 0x80270252L,
        /// <summary>This app can't be activated by the Built-in Administrator.</summary>
        E_FULL_ADMIN_NOT_SUPPORTED       = 0x80270253L,
        /// <summary>This app does not support the contract specified or is not installed.</summary>
        E_APPLICATION_NOT_REGISTERED     = 0x80270254L,
        /// <summary>This app has mulitple extensions registered to support the specified contract. Activation by AppUserModelId is ambiguous.</summary>
        E_MULTIPLE_EXTENSIONS_FOR_APPLICATION = 0x80270255L,
        /// <summary>This app's package family has more than one package installed. This is not supported.</summary>
        E_MULTIPLE_PACKAGES_FOR_FAMILY   = 0x80270256L,
        /// <summary>The app manager is required to activate applications, but is not running.</summary>
        E_APPLICATION_MANAGER_NOT_RUNNING = 0x80270257L,
        /// <summary>The Store was launched instead of the specified app because the app's package was in an invalid state.</summary>
        S_STORE_LAUNCHED_FOR_REMEDIATION = 0x00270258L,
        /// <summary>This app failed to launch, but the error was handled with a dialog.</summary>
        S_APPLICATION_ACTIVATION_ERROR_HANDLED_BY_DIALOG = 0x00270259L,
        /// <summary>The app didn't start in the required time.</summary>
        E_APPLICATION_ACTIVATION_TIMED_OUT = 0x8027025AL,
        /// <summary>The app didn't start.</summary>
        E_APPLICATION_ACTIVATION_EXEC_FAILURE = 0x8027025BL,
        /// <summary>This app failed to launch because of an issue with its license. Please try again in a moment.</summary>
        E_APPLICATION_TEMPORARY_LICENSE_ERROR = 0x8027025CL,
        /// <summary>This app failed to launch because its trial license has expired.</summary>
        E_APPLICATION_TRIAL_LICENSE_EXPIRED = 0x8027025DL,
        /// <summary>Please choose a folder on a drive that's formatted with the NTFS file system.</summary>
        E_SKYDRIVE_ROOT_TARGET_FILE_SYSTEM_NOT_SUPPORTED = 0x80270260L,
        /// <summary>This location is already being used. Please choose a different location.</summary>
        E_SKYDRIVE_ROOT_TARGET_OVERLAP   = 0x80270261L,
        /// <summary>This location cannot be indexed. Please choose a different location.</summary>
        E_SKYDRIVE_ROOT_TARGET_CANNOT_INDEX = 0x80270262L,
        /// <summary>Sorry, the action couldn't be completed because the file hasn't finished uploading. Try again later.</summary>
        E_SKYDRIVE_FILE_NOT_UPLOADED     = 0x80270263L,
        /// <summary>Sorry, the action couldn't be completed.</summary>
        E_SKYDRIVE_UPDATE_AVAILABILITY_FAIL = 0x80270264L,
        /// <summary>This content can only be moved to a folder. To move the content to this drive, please choose or create a folder.</summary>
        E_SKYDRIVE_ROOT_TARGET_VOLUME_ROOT_NOT_SUPPORTED = 0x80270265L,
        /// <summary>The file size is larger than supported by the sync engine.</summary>
        E_SYNCENGINE_FILE_SIZE_OVER_LIMIT = 0x8802B001L,
        /// <summary>The file cannot be uploaded because it doesn't fit in the user's available service provided storage space.</summary>
        E_SYNCENGINE_FILE_SIZE_EXCEEDS_REMAINING_QUOTA = 0x8802B002L,
        /// <summary>The file name contains invalid characters.</summary>
        E_SYNCENGINE_UNSUPPORTED_FILE_NAME = 0x8802B003L,
        /// <summary>The maximum file count has been reached for this folder in the sync engine.</summary>
        E_SYNCENGINE_FOLDER_ITEM_COUNT_LIMIT_EXCEEDED = 0x8802B004L,
        /// <summary>The file sync has been delegated to another program and has run into an issue.</summary>
        E_SYNCENGINE_FILE_SYNC_PARTNER_ERROR = 0x8802B005L,
        /// <summary>Sync has been delayed due to a throttling request from the service.</summary>
        E_SYNCENGINE_SYNC_PAUSED_BY_SERVICE = 0x8802B006L,
        /// <summary>We can't seem to find that file. Please try again later.</summary>
        E_SYNCENGINE_FILE_IDENTIFIER_UNKNOWN = 0x8802C002L,
        /// <summary>The account you're signed in with doesn't have permission to open this file.</summary>
        E_SYNCENGINE_SERVICE_AUTHENTICATION_FAILED = 0x8802C003L,
        /// <summary>There was a problem connecting to the service. Please try again later.</summary>
        E_SYNCENGINE_UNKNOWN_SERVICE_ERROR = 0x8802C004L,
        /// <summary>Sorry, there was a problem downloading the file.</summary>
        E_SYNCENGINE_SERVICE_RETURNED_UNEXPECTED_SIZE = 0x8802C005L,
        /// <summary>We're having trouble downloading the file right now. Please try again later.</summary>
        E_SYNCENGINE_REQUEST_BLOCKED_BY_SERVICE = 0x8802C006L,
        /// <summary>We're having trouble downloading the file right now. Please try again later.</summary>
        E_SYNCENGINE_REQUEST_BLOCKED_DUE_TO_CLIENT_ERROR = 0x8802C007L,
        /// <summary>The sync engine does not have permissions to access a local folder under the sync root.</summary>
        E_SYNCENGINE_FOLDER_INACCESSIBLE = 0x8802D001L,
        /// <summary>The folder name contains invalid characters.</summary>
        E_SYNCENGINE_UNSUPPORTED_FOLDER_NAME = 0x8802D002L,
        /// <summary>The sync engine is not allowed to run in your current market.</summary>
        E_SYNCENGINE_UNSUPPORTED_MARKET  = 0x8802D003L,
        /// <summary>All files and folders can't be uploaded because a path of a file or folder is too long.</summary>
        E_SYNCENGINE_PATH_LENGTH_LIMIT_EXCEEDED = 0x8802D004L,
        /// <summary>All file and folders cannot be synchronized because a path of a file or folder would exceed the local path limit.</summary>
        E_SYNCENGINE_REMOTE_PATH_LENGTH_LIMIT_EXCEEDED = 0x8802D005L,
        /// <summary>Updates are needed in order to use the sync engine.</summary>
        E_SYNCENGINE_CLIENT_UPDATE_NEEDED = 0x8802D006L,
        /// <summary>The sync engine needs to authenticate with a proxy server.</summary>
        E_SYNCENGINE_PROXY_AUTHENTICATION_REQUIRED = 0x8802D007L,
        /// <summary>There was a problem setting up the storage services for the account.</summary>
        E_SYNCENGINE_STORAGE_SERVICE_PROVISIONING_FAILED = 0x8802D008L,
        /// <summary>Files can't be uploaded because there's an unsupported reparse point.</summary>
        E_SYNCENGINE_UNSUPPORTED_REPARSE_POINT = 0x8802D009L,
        /// <summary>The service has blocked your account from accessing the storage service.</summary>
        E_SYNCENGINE_STORAGE_SERVICE_BLOCKED = 0x8802D00AL,
        /// <summary>The action can't be performed right now because this folder is being moved. Please try again later.</summary>
        E_SYNCENGINE_FOLDER_IN_REDIRECTION = 0x8802D00BL,
        /// <summary>Windows cannot evaluate this EAS policy since this is not managed by the operating system.</summary>
        EAS_E_POLICY_NOT_MANAGED_BY_OS   = 0x80550001L,
        /// <summary>The system can be made compliant to this EAS policy if certain actions are performed by the user.</summary>
        EAS_E_POLICY_COMPLIANT_WITH_ACTIONS = 0x80550002L,
        /// <summary>The EAS policy being evaluated cannot be enforced by the system.</summary>
        EAS_E_REQUESTED_POLICY_NOT_ENFORCEABLE = 0x80550003L,
        /// <summary>EAS password policies for the user cannot be evaluated as the user has a blank password.</summary>
        EAS_E_CURRENT_USER_HAS_BLANK_PASSWORD = 0x80550004L,
        /// <summary>EAS password expiration policy cannot be satisfied as the password expiration interval is less than the minimum password interval of the system.</summary>
        EAS_E_REQUESTED_POLICY_PASSWORD_EXPIRATION_INCOMPATIBLE = 0x80550005L,
        /// <summary>The user is not allowed to change her password.</summary>
        EAS_E_USER_CANNOT_CHANGE_PASSWORD = 0x80550006L,
        /// <summary>EAS password policies cannot be evaluated as one or more admins have blank passwords.</summary>
        EAS_E_ADMINS_HAVE_BLANK_PASSWORD = 0x80550007L,
        /// <summary>One or more admins are not allowed to change their password.</summary>
        EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD = 0x80550008L,
        /// <summary>There are other standard users present who are not allowed to change their password.</summary>
        EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD = 0x80550009L,
        /// <summary>The EAS password policy cannot be enforced by the connected account provider of at least one administrator.</summary>
        EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CONNECTED_ADMINS = 0x8055000AL,
        /// <summary>There is at least one administrator whose connected account password needs to be changed for EAS password policy compliance.</summary>
        EAS_E_CONNECTED_ADMINS_NEED_TO_CHANGE_PASSWORD = 0x8055000BL,
        /// <summary>The EAS password policy cannot be enforced by the connected account provider of the current user.</summary>
        EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CURRENT_CONNECTED_USER = 0x8055000CL,
        /// <summary>The connected account password of the current user needs to be changed for EAS password policy compliance.</summary>
        EAS_E_CURRENT_CONNECTED_USER_NEED_TO_CHANGE_PASSWORD = 0x8055000DL,
        /// <summary>Unsupported format.</summary>
        WEB_E_UNSUPPORTED_FORMAT         = 0x83750001L,
        /// <summary>Invalid XML.</summary>
        WEB_E_INVALID_XML                = 0x83750002L,
        /// <summary>Missing required element.</summary>
        WEB_E_MISSING_REQUIRED_ELEMENT   = 0x83750003L,
        /// <summary>Missing required attribute.</summary>
        WEB_E_MISSING_REQUIRED_ATTRIBUTE = 0x83750004L,
        /// <summary>Unexpected content.</summary>
        WEB_E_UNEXPECTED_CONTENT         = 0x83750005L,
        /// <summary>Resource too large.</summary>
        WEB_E_RESOURCE_TOO_LARGE         = 0x83750006L,
        /// <summary>Invalid JSON string.</summary>
        WEB_E_INVALID_JSON_STRING        = 0x83750007L,
        /// <summary>Invalid JSON number.</summary>
        WEB_E_INVALID_JSON_NUMBER        = 0x83750008L,
        /// <summary>JSON value not found.</summary>
        WEB_E_JSON_VALUE_NOT_FOUND       = 0x83750009L,
        /// <summary>Unexpected HTTP status code.</summary>
        HTTP_E_STATUS_UNEXPECTED         = 0x80190001L,
        /// <summary>Unexpected redirection status code (3xx).</summary>
        HTTP_E_STATUS_UNEXPECTED_REDIRECTION = 0x80190003L,
        /// <summary>Unexpected client error status code (4xx).</summary>
        HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR = 0x80190004L,
        /// <summary>Unexpected server error status code (5xx).</summary>
        HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR = 0x80190005L,
        /// <summary>Multiple choices (300).</summary>
        HTTP_E_STATUS_AMBIGUOUS          = 0x8019012CL,
        /// <summary>Moved permanently (301).</summary>
        HTTP_E_STATUS_MOVED              = 0x8019012DL,
        /// <summary>Found (302).</summary>
        HTTP_E_STATUS_REDIRECT           = 0x8019012EL,
        /// <summary>See Other (303).</summary>
        HTTP_E_STATUS_REDIRECT_METHOD    = 0x8019012FL,
        /// <summary>Not modified (304).</summary>
        HTTP_E_STATUS_NOT_MODIFIED       = 0x80190130L,
        /// <summary>Use proxy (305).</summary>
        HTTP_E_STATUS_USE_PROXY          = 0x80190131L,
        /// <summary>Temporary redirect (307).</summary>
        HTTP_E_STATUS_REDIRECT_KEEP_VERB = 0x80190133L,
        /// <summary>Bad request (400).</summary>
        HTTP_E_STATUS_BAD_REQUEST        = 0x80190190L,
        /// <summary>Unauthorized (401).</summary>
        HTTP_E_STATUS_DENIED             = 0x80190191L,
        /// <summary>Payment required (402).</summary>
        HTTP_E_STATUS_PAYMENT_REQ        = 0x80190192L,
        /// <summary>Forbidden (403).</summary>
        HTTP_E_STATUS_FORBIDDEN          = 0x80190193L,
        /// <summary>Not found (404).</summary>
        HTTP_E_STATUS_NOT_FOUND          = 0x80190194L,
        /// <summary>Method not allowed (405).</summary>
        HTTP_E_STATUS_BAD_METHOD         = 0x80190195L,
        /// <summary>Not acceptable (406).</summary>
        HTTP_E_STATUS_NONE_ACCEPTABLE    = 0x80190196L,
        /// <summary>Proxy authentication required (407).</summary>
        HTTP_E_STATUS_PROXY_AUTH_REQ     = 0x80190197L,
        /// <summary>Request timeout (408).</summary>
        HTTP_E_STATUS_REQUEST_TIMEOUT    = 0x80190198L,
        /// <summary>Conflict (409).</summary>
        HTTP_E_STATUS_CONFLICT           = 0x80190199L,
        /// <summary>Gone (410).</summary>
        HTTP_E_STATUS_GONE               = 0x8019019AL,
        /// <summary>Length required (411).</summary>
        HTTP_E_STATUS_LENGTH_REQUIRED    = 0x8019019BL,
        /// <summary>Precondition failed (412).</summary>
        HTTP_E_STATUS_PRECOND_FAILED     = 0x8019019CL,
        /// <summary>Request entity too large (413).</summary>
        HTTP_E_STATUS_REQUEST_TOO_LARGE  = 0x8019019DL,
        /// <summary>Request-URI too long (414).</summary>
        HTTP_E_STATUS_URI_TOO_LONG       = 0x8019019EL,
        /// <summary>Unsupported media type (415).</summary>
        HTTP_E_STATUS_UNSUPPORTED_MEDIA  = 0x8019019FL,
        /// <summary>Requested range not satisfiable (416).</summary>
        HTTP_E_STATUS_RANGE_NOT_SATISFIABLE = 0x801901A0L,
        /// <summary>Expectation failed (417).</summary>
        HTTP_E_STATUS_EXPECTATION_FAILED = 0x801901A1L,
        /// <summary>Internal server error (500).</summary>
        HTTP_E_STATUS_SERVER_ERROR       = 0x801901F4L,
        /// <summary>Not implemented (501).</summary>
        HTTP_E_STATUS_NOT_SUPPORTED      = 0x801901F5L,
        /// <summary>Bad gateway (502).</summary>
        HTTP_E_STATUS_BAD_GATEWAY        = 0x801901F6L,
        /// <summary>Service unavailable (503).</summary>
        HTTP_E_STATUS_SERVICE_UNAVAIL    = 0x801901F7L,
        /// <summary>Gateway timeout (504).</summary>
        HTTP_E_STATUS_GATEWAY_TIMEOUT    = 0x801901F8L,
        /// <summary>Version not supported (505).</summary>
        HTTP_E_STATUS_VERSION_NOT_SUP    = 0x801901F9L,
        /// <summary>Invalid operation performed by the protocol.</summary>
        E_INVALID_PROTOCOL_OPERATION     = 0x83760001L,
        /// <summary>Invalid data format for the specific protocol operation.</summary>
        E_INVALID_PROTOCOL_FORMAT        = 0x83760002L,
        /// <summary>Protocol extensions are not supported.</summary>
        E_PROTOCOL_EXTENSIONS_NOT_SUPPORTED = 0x83760003L,
        /// <summary>Subrotocol is not supported.</summary>
        E_SUBPROTOCOL_NOT_SUPPORTED      = 0x83760004L,
        /// <summary>Incorrect protocol version.</summary>
        E_PROTOCOL_VERSION_NOT_SUPPORTED = 0x83760005L,
        /// <summary>Input data cannot be processed in the non-chronological order.</summary>
        INPUT_E_OUT_OF_ORDER             = 0x80400000L,
        /// <summary>Requested operation cannot be performed inside the callback or event handler.</summary>
        INPUT_E_REENTRANCY               = 0x80400001L,
        /// <summary>Input cannot be processed because there is ongoing interaction with another pointer type.</summary>
        INPUT_E_MULTIMODAL               = 0x80400002L,
        /// <summary>One or more fields in the input packet are invalid.</summary>
        INPUT_E_PACKET                   = 0x80400003L,
        /// <summary>Packets in the frame are inconsistent. Either pointer ids are not unique or there is a discrepancy in timestamps, frame ids, pointer types or source devices.</summary>
        INPUT_E_FRAME                    = 0x80400004L,
        /// <summary>The history of frames is inconsistent. Pointer ids, types, source devices don't match, or frame ids are not unique, or timestamps are out of order.</summary>
        INPUT_E_HISTORY                  = 0x80400005L,
        /// <summary>Failed to retrieve information about the input device.</summary>
        INPUT_E_DEVICE_INFO              = 0x80400006L,
        /// <summary>Coordinate system transformation failed to transform the data.</summary>
        INPUT_E_TRANSFORM                = 0x80400007L,
        /// <summary>The property is not supported or not reported correctly by the input device.</summary>
        INPUT_E_DEVICE_PROPERTY          = 0x80400008L,
        /// <summary>The URL is invalid.</summary>
        INET_E_INVALID_URL               = 0x800C0002L,
        /// <summary>No Internet session has been established.</summary>
        INET_E_NO_SESSION                = 0x800C0003L,
        /// <summary>Unable to connect to the target server.</summary>
        INET_E_CANNOT_CONNECT            = 0x800C0004L,
        /// <summary>The system cannot locate the resource specified.</summary>
        INET_E_RESOURCE_NOT_FOUND        = 0x800C0005L,
        /// <summary>The system cannot locate the object specified.</summary>
        INET_E_OBJECT_NOT_FOUND          = 0x800C0006L,
        /// <summary>No data is available for the requested resource.</summary>
        INET_E_DATA_NOT_AVAILABLE        = 0x800C0007L,
        /// <summary>The download of the specified resource has failed.</summary>
        INET_E_DOWNLOAD_FAILURE          = 0x800C0008L,
        /// <summary>Authentication is required to access this resource.</summary>
        INET_E_AUTHENTICATION_REQUIRED   = 0x800C0009L,
        /// <summary>The server could not recognize the provided mime type.</summary>
        INET_E_NO_VALID_MEDIA            = 0x800C000AL,
        /// <summary>The operation was timed out.</summary>
        INET_E_CONNECTION_TIMEOUT        = 0x800C000BL,
        /// <summary>The server did not understand the request, or the request was invalid.</summary>
        INET_E_INVALID_REQUEST           = 0x800C000CL,
        /// <summary>The specified protocol is unknown.</summary>
        INET_E_UNKNOWN_PROTOCOL          = 0x800C000DL,
        /// <summary>A security problem occurred.</summary>
        INET_E_SECURITY_PROBLEM          = 0x800C000EL,
        /// <summary>The system could not load the persisted data.</summary>
        INET_E_CANNOT_LOAD_DATA          = 0x800C000FL,
        /// <summary>Unable to instantiate the object.</summary>
        INET_E_CANNOT_INSTANTIATE_OBJECT = 0x800C0010L,
        /// <summary>Security certificate required to access this resource is invalid.</summary>
        INET_E_INVALID_CERTIFICATE       = 0x800C0019L,
        /// <summary>A redirection problem occurred.</summary>
        INET_E_REDIRECT_FAILED           = 0x800C0014L,
        /// <summary>The requested resource is a directory, not a file.</summary>
        INET_E_REDIRECT_TO_DIR           = 0x800C0015L,
        /// <summary>Could not create new process from ARM architecture device.</summary>
        ERROR_DBG_CREATE_PROCESS_FAILURE_LOCKDOWN = 0x80B00001L,
        /// <summary>Could not attach to the application process from ARM architecture device.</summary>
        ERROR_DBG_ATTACH_PROCESS_FAILURE_LOCKDOWN = 0x80B00002L,
        /// <summary>Could not connect to dbgsrv server from ARM architecture device.</summary>
        ERROR_DBG_CONNECT_SERVER_FAILURE_LOCKDOWN = 0x80B00003L,
        /// <summary>Could not start dbgsrv server from ARM architecture device.</summary>
        ERROR_DBG_START_SERVER_FAILURE_LOCKDOWN = 0x80B00004L,
        /// <summary>The operation was preempted by a higher priority operation. It must be resumed later.</summary>
        ERROR_IO_PREEMPTED               = 0x89010001L,
        /// <summary>Function could not execute because it was deleted or garbage collected.</summary>
        JSCRIPT_E_CANTEXECUTE            = 0x89020001L,
        /// <summary>One or more fixed volumes are not provisioned with the 3rd party encryption providers to support device encryption. Enable encryption with the 3rd party provider to comply with policy.</summary>
        WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES = 0x88010001L,
        /// <summary>This computer is not fully encrypted. There are fixed volumes present which are not supported for encryption.</summary>
        WEP_E_FIXED_DATA_NOT_SUPPORTED   = 0x88010002L,
        /// <summary>This computer does not meet the hardware requirements to support device encryption with the installed 3rd party provider.</summary>
        WEP_E_HARDWARE_NOT_COMPLIANT     = 0x88010003L,
        /// <summary>This computer cannot support device encryption because the requisites for the device lock feature are not configured.</summary>
        WEP_E_LOCK_NOT_CONFIGURED        = 0x88010004L,
        /// <summary>Protection is enabled on this volume but is not in the active state.</summary>
        WEP_E_PROTECTION_SUSPENDED       = 0x88010005L,
        /// <summary>The 3rd party provider has been installed, but cannot activate encryption beacuse a license has not been activated.</summary>
        WEP_E_NO_LICENSE                 = 0x88010006L,
        /// <summary>The operating system drive is not protected by 3rd party drive encryption.</summary>
        WEP_E_OS_NOT_PROTECTED           = 0x88010007L,
        /// <summary>Unexpected failure was encountered while calling into the 3rd Party drive encryption plugin.</summary>
        WEP_E_UNEXPECTED_FAIL            = 0x88010008L,
        /// <summary>The input buffer size for the lockout metadata used by the 3rd party drive encryption is too large.</summary>
        WEP_E_BUFFER_TOO_LARGE           = 0x88010009L,
        /// <summary>The proper error code with sense data was stored on server side.</summary>
        ERROR_SVHDX_ERROR_STORED         = 0xC05C0000L,
        /// <summary>The requested error data is not available on the server.</summary>
        ERROR_SVHDX_ERROR_NOT_AVAILABLE  = 0xC05CFF00L,
        /// <summary>Unit Attention data is available for the initiator to query.</summary>
        ERROR_SVHDX_UNIT_ATTENTION_AVAILABLE = 0xC05CFF01L,
        /// <summary>The data capacity of the device has changed, resulting in a Unit Attention condition.</summary>
        ERROR_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED = 0xC05CFF02L,
        /// <summary>A previous operation resulted in this initiator's reservations being preempted, resulting in a Unit Attention condition.</summary>
        ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED = 0xC05CFF03L,
        /// <summary>A previous operation resulted in this initiator's reservations being released, resulting in a Unit Attention condition.</summary>
        ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED = 0xC05CFF04L,
        /// <summary>A previous operation resulted in this initiator's registrations being preempted, resulting in a Unit Attention condition.</summary>
        ERROR_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED = 0xC05CFF05L,
        /// <summary>The data storage format of the device has changed, resulting in a Unit Attention condition.</summary>
        ERROR_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED = 0xC05CFF06L,
        /// <summary>The current initiator is not allowed to perform the SCSI command because of a reservation conflict.</summary>
        ERROR_SVHDX_RESERVATION_CONFLICT = 0xC05CFF07L,
        /// <summary>Multiple virtual machines sharing a virtual hard disk is supported only on Fixed or Dynamic VHDX format virtual hard disks.</summary>
        ERROR_SVHDX_WRONG_FILE_TYPE      = 0xC05CFF08L,
        /// <summary>The server version does not match the requested version.</summary>
        ERROR_SVHDX_VERSION_MISMATCH     = 0xC05CFF09L,
        /// <summary>The requested operation cannot be performed on the virtual disk as it is currently used in shared mode.</summary>
        ERROR_VHD_SHARED                 = 0xC05CFF0AL,
        /// <summary>Invalid Shared VHDX open due to lack of initiator ID. Check for related Continuous Availability failures.</summary>
        ERROR_SVHDX_NO_INITIATOR         = 0xC05CFF0BL,
        /// <summary>The requested operation failed due to a missing backing storage file.</summary>
        ERROR_VHDSET_BACKING_STORAGE_NOT_FOUND = 0xC05CFF0CL,
        /// <summary>Failed to negotiate a preauthentication integrity hash function.</summary>
        ERROR_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP = 0xC05D0000L,
        /// <summary>The current cluster functional level does not support this SMB dialect.</summary>
        ERROR_SMB_BAD_CLUSTER_DIALECT    = 0xC05D0001L,
        /// <summary>No more Internet handles can be allocated</summary>
        WININET_E_OUT_OF_HANDLES         = 0x80072EE1L,
        /// <summary>The operation timed out</summary>
        WININET_E_TIMEOUT                = 0x80072EE2L,
        /// <summary>The server returned extended information</summary>
        WININET_E_EXTENDED_ERROR         = 0x80072EE3L,
        /// <summary>An internal error occurred in the Microsoft Internet extensions</summary>
        WININET_E_INTERNAL_ERROR         = 0x80072EE4L,
        /// <summary>The URL is invalid</summary>
        WININET_E_INVALID_URL            = 0x80072EE5L,
        /// <summary>The URL does not use a recognized protocol</summary>
        WININET_E_UNRECOGNIZED_SCHEME    = 0x80072EE6L,
        /// <summary>The server name or address could not be resolved</summary>
        WININET_E_NAME_NOT_RESOLVED      = 0x80072EE7L,
        /// <summary>A protocol with the required capabilities was not found</summary>
        WININET_E_PROTOCOL_NOT_FOUND     = 0x80072EE8L,
        /// <summary>The option is invalid</summary>
        WININET_E_INVALID_OPTION         = 0x80072EE9L,
        /// <summary>The length is incorrect for the option type</summary>
        WININET_E_BAD_OPTION_LENGTH      = 0x80072EEAL,
        /// <summary>The option value cannot be set</summary>
        WININET_E_OPTION_NOT_SETTABLE    = 0x80072EEBL,
        /// <summary>Microsoft Internet Extension support has been shut down</summary>
        WININET_E_SHUTDOWN               = 0x80072EECL,
        /// <summary>The user name was not allowed</summary>
        WININET_E_INCORRECT_USER_NAME    = 0x80072EEDL,
        /// <summary>The password was not allowed</summary>
        WININET_E_INCORRECT_PASSWORD     = 0x80072EEEL,
        /// <summary>The login request was denied</summary>
        WININET_E_LOGIN_FAILURE          = 0x80072EEFL,
        /// <summary>The requested operation is invalid</summary>
        WININET_E_INVALID_OPERATION      = 0x80072EF0L,
        /// <summary>The operation has been canceled</summary>
        WININET_E_OPERATION_CANCELLED    = 0x80072EF1L,
        /// <summary>The supplied handle is the wrong type for the requested operation</summary>
        WININET_E_INCORRECT_HANDLE_TYPE  = 0x80072EF2L,
        /// <summary>The handle is in the wrong state for the requested operation</summary>
        WININET_E_INCORRECT_HANDLE_STATE = 0x80072EF3L,
        /// <summary>The request cannot be made on a Proxy session</summary>
        WININET_E_NOT_PROXY_REQUEST      = 0x80072EF4L,
        /// <summary>The registry value could not be found</summary>
        WININET_E_REGISTRY_VALUE_NOT_FOUND = 0x80072EF5L,
        /// <summary>The registry parameter is incorrect</summary>
        WININET_E_BAD_REGISTRY_PARAMETER = 0x80072EF6L,
        /// <summary>Direct Internet access is not available</summary>
        WININET_E_NO_DIRECT_ACCESS       = 0x80072EF7L,
        /// <summary>No context value was supplied</summary>
        WININET_E_NO_CONTEXT             = 0x80072EF8L,
        /// <summary>No status callback was supplied</summary>
        WININET_E_NO_CALLBACK            = 0x80072EF9L,
        /// <summary>There are outstanding requests</summary>
        WININET_E_REQUEST_PENDING        = 0x80072EFAL,
        /// <summary>The information format is incorrect</summary>
        WININET_E_INCORRECT_FORMAT       = 0x80072EFBL,
        /// <summary>The requested item could not be found</summary>
        WININET_E_ITEM_NOT_FOUND         = 0x80072EFCL,
        /// <summary>A connection with the server could not be established</summary>
        WININET_E_CANNOT_CONNECT         = 0x80072EFDL,
        /// <summary>The connection with the server was terminated abnormally</summary>
        WININET_E_CONNECTION_ABORTED     = 0x80072EFEL,
        /// <summary>The connection with the server was reset</summary>
        WININET_E_CONNECTION_RESET       = 0x80072EFFL,
        /// <summary>The action must be retried</summary>
        WININET_E_FORCE_RETRY            = 0x80072F00L,
        /// <summary>The proxy request is invalid</summary>
        WININET_E_INVALID_PROXY_REQUEST  = 0x80072F01L,
        /// <summary>User interaction is required to complete the operation</summary>
        WININET_E_NEED_UI                = 0x80072F02L,
        /// <summary>The handle already exists</summary>
        WININET_E_HANDLE_EXISTS          = 0x80072F04L,
        /// <summary>The date in the certificate is invalid or has expired</summary>
        WININET_E_SEC_CERT_DATE_INVALID  = 0x80072F05L,
        /// <summary>The host name in the certificate is invalid or does not match</summary>
        WININET_E_SEC_CERT_CN_INVALID    = 0x80072F06L,
        /// <summary>A redirect request will change a non-secure to a secure connection</summary>
        WININET_E_HTTP_TO_HTTPS_ON_REDIR = 0x80072F07L,
        /// <summary>A redirect request will change a secure to a non-secure connection</summary>
        WININET_E_HTTPS_TO_HTTP_ON_REDIR = 0x80072F08L,
        /// <summary>Mixed secure and non-secure connections</summary>
        WININET_E_MIXED_SECURITY         = 0x80072F09L,
        /// <summary>Changing to non-secure post</summary>
        WININET_E_CHG_POST_IS_NON_SECURE = 0x80072F0AL,
        /// <summary>Data is being posted on a non-secure connection</summary>
        WININET_E_POST_IS_NON_SECURE     = 0x80072F0BL,
        /// <summary>A certificate is required to complete client authentication</summary>
        WININET_E_CLIENT_AUTH_CERT_NEEDED = 0x80072F0CL,
        /// <summary>The certificate authority is invalid or incorrect</summary>
        WININET_E_INVALID_CA             = 0x80072F0DL,
        /// <summary>Client authentication has not been correctly installed</summary>
        WININET_E_CLIENT_AUTH_NOT_SETUP  = 0x80072F0EL,
        /// <summary>An error has occurred in a Wininet asynchronous thread. You may need to restart</summary>
        WININET_E_ASYNC_THREAD_FAILED    = 0x80072F0FL,
        /// <summary>The protocol scheme has changed during a redirect operaiton</summary>
        WININET_E_REDIRECT_SCHEME_CHANGE = 0x80072F10L,
        /// <summary>There are operations awaiting retry</summary>
        WININET_E_DIALOG_PENDING         = 0x80072F11L,
        /// <summary>The operation must be retried</summary>
        WININET_E_RETRY_DIALOG           = 0x80072F12L,
        /// <summary>There are no new cache containers</summary>
        WININET_E_NO_NEW_CONTAINERS      = 0x80072F13L,
        /// <summary>A security zone check indicates the operation must be retried</summary>
        WININET_E_HTTPS_HTTP_SUBMIT_REDIR = 0x80072F14L,
        /// <summary>The SSL certificate contains errors.</summary>
        WININET_E_SEC_CERT_ERRORS        = 0x80072F17L,
        /// <summary>It was not possible to connect to the revocation server or a definitive response could not be obtained.</summary>
        WININET_E_SEC_CERT_REV_FAILED    = 0x80072F19L,
        /// <summary>The requested header was not found</summary>
        WININET_E_HEADER_NOT_FOUND       = 0x80072F76L,
        /// <summary>The server does not support the requested protocol level</summary>
        WININET_E_DOWNLEVEL_SERVER       = 0x80072F77L,
        /// <summary>The server returned an invalid or unrecognized response</summary>
        WININET_E_INVALID_SERVER_RESPONSE = 0x80072F78L,
        /// <summary>The supplied HTTP header is invalid</summary>
        WININET_E_INVALID_HEADER         = 0x80072F79L,
        /// <summary>The request for a HTTP header is invalid</summary>
        WININET_E_INVALID_QUERY_REQUEST  = 0x80072F7AL,
        /// <summary>The HTTP header already exists</summary>
        WININET_E_HEADER_ALREADY_EXISTS  = 0x80072F7BL,
        /// <summary>The HTTP redirect request failed</summary>
        WININET_E_REDIRECT_FAILED        = 0x80072F7CL,
        /// <summary>An error occurred in the secure channel support</summary>
        WININET_E_SECURITY_CHANNEL_ERROR = 0x80072F7DL,
        /// <summary>The file could not be written to the cache</summary>
        WININET_E_UNABLE_TO_CACHE_FILE   = 0x80072F7EL,
        /// <summary>The TCP/IP protocol is not installed properly</summary>
        WININET_E_TCPIP_NOT_INSTALLED    = 0x80072F7FL,
        /// <summary>The computer is disconnected from the network</summary>
        WININET_E_DISCONNECTED           = 0x80072F83L,
        /// <summary>The server is unreachable</summary>
        WININET_E_SERVER_UNREACHABLE     = 0x80072F84L,
        /// <summary>The proxy server is unreachable</summary>
        WININET_E_PROXY_SERVER_UNREACHABLE = 0x80072F85L,
        /// <summary>The proxy auto-configuration script is in error</summary>
        WININET_E_BAD_AUTO_PROXY_SCRIPT  = 0x80072F86L,
        /// <summary>Could not download the proxy auto-configuration script file</summary>
        WININET_E_UNABLE_TO_DOWNLOAD_SCRIPT = 0x80072F87L,
        /// <summary>The supplied certificate is invalid</summary>
        WININET_E_SEC_INVALID_CERT       = 0x80072F89L,
        /// <summary>The supplied certificate has been revoked</summary>
        WININET_E_SEC_CERT_REVOKED       = 0x80072F8AL,
        /// <summary>The Dialup failed because file sharing was turned on and a failure was requested if security check was needed</summary>
        WININET_E_FAILED_DUETOSECURITYCHECK = 0x80072F8BL,
        /// <summary>Initialization of the WinINet API has not occurred</summary>
        WININET_E_NOT_INITIALIZED        = 0x80072F8CL,
        /// <summary>Login failed and the client should display the entity body to the user</summary>
        WININET_E_LOGIN_FAILURE_DISPLAY_ENTITY_BODY = 0x80072F8EL,
        /// <summary>Content decoding has failed</summary>
        WININET_E_DECODING_FAILED        = 0x80072F8FL,
        /// <summary>The HTTP request was not redirected</summary>
        WININET_E_NOT_REDIRECTED         = 0x80072F80L,
        /// <summary>A cookie from the server must be confirmed by the user</summary>
        WININET_E_COOKIE_NEEDS_CONFIRMATION = 0x80072F81L,
        /// <summary>A cookie from the server has been declined acceptance</summary>
        WININET_E_COOKIE_DECLINED        = 0x80072F82L,
        /// <summary>The HTTP redirect request must be confirmed by the user</summary>
        WININET_E_REDIRECT_NEEDS_CONFIRMATION = 0x80072F88L,
        /// <summary>SQL error or missing database</summary>
        SQLITE_E_ERROR                   = 0x87AF0001L,
        /// <summary>Internal logic error in SQLite</summary>
        SQLITE_E_INTERNAL                = 0x87AF0002L,
        /// <summary>Access permission denied</summary>
        SQLITE_E_PERM                    = 0x87AF0003L,
        /// <summary>Callback routine requested an abort</summary>
        SQLITE_E_ABORT                   = 0x87AF0004L,
        /// <summary>The database file is locked</summary>
        SQLITE_E_BUSY                    = 0x87AF0005L,
        /// <summary>A table in the database is locked</summary>
        SQLITE_E_LOCKED                  = 0x87AF0006L,
        /// <summary>A malloc() failed</summary>
        SQLITE_E_NOMEM                   = 0x87AF0007L,
        /// <summary>Attempt to write a readonly database</summary>
        SQLITE_E_READONLY                = 0x87AF0008L,
        /// <summary>Operation terminated by sqlite3_interrupt()</summary>
        SQLITE_E_INTERRUPT               = 0x87AF0009L,
        /// <summary>Some kind of disk I/O error occurred</summary>
        SQLITE_E_IOERR                   = 0x87AF000AL,
        /// <summary>The database disk image is malformed</summary>
        SQLITE_E_CORRUPT                 = 0x87AF000BL,
        /// <summary>Unknown opcode in sqlite3_file_control()</summary>
        SQLITE_E_NOTFOUND                = 0x87AF000CL,
        /// <summary>Insertion failed because database is full</summary>
        SQLITE_E_FULL                    = 0x87AF000DL,
        /// <summary>Unable to open the database file</summary>
        SQLITE_E_CANTOPEN                = 0x87AF000EL,
        /// <summary>Database lock protocol error</summary>
        SQLITE_E_PROTOCOL                = 0x87AF000FL,
        /// <summary>Database is empty</summary>
        SQLITE_E_EMPTY                   = 0x87AF0010L,
        /// <summary>The database schema changed</summary>
        SQLITE_E_SCHEMA                  = 0x87AF0011L,
        /// <summary>String or BLOB exceeds size limit</summary>
        SQLITE_E_TOOBIG                  = 0x87AF0012L,
        /// <summary>Abort due to constraint violation</summary>
        SQLITE_E_CONSTRAINT              = 0x87AF0013L,
        /// <summary>Data type mismatch</summary>
        SQLITE_E_MISMATCH                = 0x87AF0014L,
        /// <summary>Library used incorrectly</summary>
        SQLITE_E_MISUSE                  = 0x87AF0015L,
        /// <summary>Uses OS features not supported on host</summary>
        SQLITE_E_NOLFS                   = 0x87AF0016L,
        /// <summary>Authorization denied</summary>
        SQLITE_E_AUTH                    = 0x87AF0017L,
        /// <summary>Auxiliary database format error</summary>
        SQLITE_E_FORMAT                  = 0x87AF0018L,
        /// <summary>2nd parameter to sqlite3_bind out of range</summary>
        SQLITE_E_RANGE                   = 0x87AF0019L,
        /// <summary>File opened that is not a database file</summary>
        SQLITE_E_NOTADB                  = 0x87AF001AL,
        /// <summary>Notifications from sqlite3_log()</summary>
        SQLITE_E_NOTICE                  = 0x87AF001BL,
        /// <summary>Warnings from sqlite3_log()</summary>
        SQLITE_E_WARNING                 = 0x87AF001CL,
        /// <summary>sqlite3_step() has another row ready</summary>
        SQLITE_E_ROW                     = 0x87AF0064L,
        /// <summary>sqlite3_step() has finished executing</summary>
        SQLITE_E_DONE                    = 0x87AF0065L,
        /// <summary>SQLITE_IOERR_READ</summary>
        SQLITE_E_IOERR_READ              = 0x87AF010AL,
        /// <summary>SQLITE_IOERR_SHORT_READ</summary>
        SQLITE_E_IOERR_SHORT_READ        = 0x87AF020AL,
        /// <summary>SQLITE_IOERR_WRITE</summary>
        SQLITE_E_IOERR_WRITE             = 0x87AF030AL,
        /// <summary>SQLITE_IOERR_FSYNC</summary>
        SQLITE_E_IOERR_FSYNC             = 0x87AF040AL,
        /// <summary>SQLITE_IOERR_DIR_FSYNC</summary>
        SQLITE_E_IOERR_DIR_FSYNC         = 0x87AF050AL,
        /// <summary>SQLITE_IOERR_TRUNCATE</summary>
        SQLITE_E_IOERR_TRUNCATE          = 0x87AF060AL,
        /// <summary>SQLITE_IOERR_FSTAT</summary>
        SQLITE_E_IOERR_FSTAT             = 0x87AF070AL,
        /// <summary>SQLITE_IOERR_UNLOCK</summary>
        SQLITE_E_IOERR_UNLOCK            = 0x87AF080AL,
        /// <summary>SQLITE_IOERR_RDLOCK</summary>
        SQLITE_E_IOERR_RDLOCK            = 0x87AF090AL,
        /// <summary>SQLITE_IOERR_DELETE</summary>
        SQLITE_E_IOERR_DELETE            = 0x87AF0A0AL,
        /// <summary>SQLITE_IOERR_BLOCKED</summary>
        SQLITE_E_IOERR_BLOCKED           = 0x87AF0B0AL,
        /// <summary>SQLITE_IOERR_NOMEM</summary>
        SQLITE_E_IOERR_NOMEM             = 0x87AF0C0AL,
        /// <summary>SQLITE_IOERR_ACCESS</summary>
        SQLITE_E_IOERR_ACCESS            = 0x87AF0D0AL,
        /// <summary>SQLITE_IOERR_CHECKRESERVEDLOCK</summary>
        SQLITE_E_IOERR_CHECKRESERVEDLOCK = 0x87AF0E0AL,
        /// <summary>SQLITE_IOERR_LOCK</summary>
        SQLITE_E_IOERR_LOCK              = 0x87AF0F0AL,
        /// <summary>SQLITE_IOERR_CLOSE</summary>
        SQLITE_E_IOERR_CLOSE             = 0x87AF100AL,
        /// <summary>SQLITE_IOERR_DIR_CLOSE</summary>
        SQLITE_E_IOERR_DIR_CLOSE         = 0x87AF110AL,
        /// <summary>SQLITE_IOERR_SHMOPEN</summary>
        SQLITE_E_IOERR_SHMOPEN           = 0x87AF120AL,
        /// <summary>SQLITE_IOERR_SHMSIZE</summary>
        SQLITE_E_IOERR_SHMSIZE           = 0x87AF130AL,
        /// <summary>SQLITE_IOERR_SHMLOCK</summary>
        SQLITE_E_IOERR_SHMLOCK           = 0x87AF140AL,
        /// <summary>SQLITE_IOERR_SHMMAP</summary>
        SQLITE_E_IOERR_SHMMAP            = 0x87AF150AL,
        /// <summary>SQLITE_IOERR_SEEK</summary>
        SQLITE_E_IOERR_SEEK              = 0x87AF160AL,
        /// <summary>SQLITE_IOERR_DELETE_NOENT</summary>
        SQLITE_E_IOERR_DELETE_NOENT      = 0x87AF170AL,
        /// <summary>SQLITE_IOERR_MMAP</summary>
        SQLITE_E_IOERR_MMAP              = 0x87AF180AL,
        /// <summary>SQLITE_IOERR_GETTEMPPATH</summary>
        SQLITE_E_IOERR_GETTEMPPATH       = 0x87AF190AL,
        /// <summary>SQLITE_IOERR_CONVPATH</summary>
        SQLITE_E_IOERR_CONVPATH          = 0x87AF1A0AL,
        /// <summary>SQLITE_IOERR_VNODE</summary>
        SQLITE_E_IOERR_VNODE             = 0x87AF1A02L,
        /// <summary>SQLITE_IOERR_AUTH</summary>
        SQLITE_E_IOERR_AUTH              = 0x87AF1A03L,
        /// <summary>SQLITE_LOCKED_SHAREDCACHE</summary>
        SQLITE_E_LOCKED_SHAREDCACHE      = 0x87AF0106L,
        /// <summary>SQLITE_BUSY_RECOVERY</summary>
        SQLITE_E_BUSY_RECOVERY           = 0x87AF0105L,
        /// <summary>SQLITE_BUSY_SNAPSHOT</summary>
        SQLITE_E_BUSY_SNAPSHOT           = 0x87AF0205L,
        /// <summary>SQLITE_CANTOPEN_NOTEMPDIR</summary>
        SQLITE_E_CANTOPEN_NOTEMPDIR      = 0x87AF010EL,
        /// <summary>SQLITE_CANTOPEN_ISDIR</summary>
        SQLITE_E_CANTOPEN_ISDIR          = 0x87AF020EL,
        /// <summary>SQLITE_CANTOPEN_FULLPATH</summary>
        SQLITE_E_CANTOPEN_FULLPATH       = 0x87AF030EL,
        /// <summary>SQLITE_CANTOPEN_CONVPATH</summary>
        SQLITE_E_CANTOPEN_CONVPATH       = 0x87AF040EL,
        /// <summary>SQLITE_CORRUPT_VTAB</summary>
        SQLITE_E_CORRUPT_VTAB            = 0x87AF010BL,
        /// <summary>SQLITE_READONLY_RECOVERY</summary>
        SQLITE_E_READONLY_RECOVERY       = 0x87AF0108L,
        /// <summary>SQLITE_READONLY_CANTLOCK</summary>
        SQLITE_E_READONLY_CANTLOCK       = 0x87AF0208L,
        /// <summary>SQLITE_READONLY_ROLLBACK</summary>
        SQLITE_E_READONLY_ROLLBACK       = 0x87AF0308L,
        /// <summary>SQLITE_READONLY_DBMOVED</summary>
        SQLITE_E_READONLY_DBMOVED        = 0x87AF0408L,
        /// <summary>SQLITE_ABORT_ROLLBACK</summary>
        SQLITE_E_ABORT_ROLLBACK          = 0x87AF0204L,
        /// <summary>SQLITE_CONSTRAINT_CHECK</summary>
        SQLITE_E_CONSTRAINT_CHECK        = 0x87AF0113L,
        /// <summary>SQLITE_CONSTRAINT_COMMITHOOK</summary>
        SQLITE_E_CONSTRAINT_COMMITHOOK   = 0x87AF0213L,
        /// <summary>SQLITE_CONSTRAINT_FOREIGNKEY</summary>
        SQLITE_E_CONSTRAINT_FOREIGNKEY   = 0x87AF0313L,
        /// <summary>SQLITE_CONSTRAINT_FUNCTION</summary>
        SQLITE_E_CONSTRAINT_FUNCTION     = 0x87AF0413L,
        /// <summary>SQLITE_CONSTRAINT_NOTNULL</summary>
        SQLITE_E_CONSTRAINT_NOTNULL      = 0x87AF0513L,
        /// <summary>SQLITE_CONSTRAINT_PRIMARYKEY</summary>
        SQLITE_E_CONSTRAINT_PRIMARYKEY   = 0x87AF0613L,
        /// <summary>SQLITE_CONSTRAINT_TRIGGER</summary>
        SQLITE_E_CONSTRAINT_TRIGGER      = 0x87AF0713L,
        /// <summary>SQLITE_CONSTRAINT_UNIQUE</summary>
        SQLITE_E_CONSTRAINT_UNIQUE       = 0x87AF0813L,
        /// <summary>SQLITE_CONSTRAINT_VTAB</summary>
        SQLITE_E_CONSTRAINT_VTAB         = 0x87AF0913L,
        /// <summary>SQLITE_CONSTRAINT_ROWID</summary>
        SQLITE_E_CONSTRAINT_ROWID        = 0x87AF0A13L,
        /// <summary>SQLITE_NOTICE_RECOVER_WAL</summary>
        SQLITE_E_NOTICE_RECOVER_WAL      = 0x87AF011BL,
        /// <summary>SQLITE_NOTICE_RECOVER_ROLLBACK</summary>
        SQLITE_E_NOTICE_RECOVER_ROLLBACK = 0x87AF021BL,
        /// <summary>SQLITE_WARNING_AUTOINDEX</summary>
        SQLITE_E_WARNING_AUTOINDEX       = 0x87AF011CL,
        /// <summary>Toggle (alternative) trace started</summary>
        UTC_E_TOGGLE_TRACE_STARTED       = 0x87C51001L,
        /// <summary>Cannot pre-empt running trace: The current trace has a higher priority</summary>
        UTC_E_ALTERNATIVE_TRACE_CANNOT_PREEMPT = 0x87C51002L,
        /// <summary>The always-on-trace is not running</summary>
        UTC_E_AOT_NOT_RUNNING            = 0x87C51003L,
        /// <summary>RunScriptAction contains an invalid script type</summary>
        UTC_E_SCRIPT_TYPE_INVALID        = 0x87C51004L,
        /// <summary>Requested scenario definition cannot be found</summary>
        UTC_E_SCENARIODEF_NOT_FOUND      = 0x87C51005L,
        /// <summary>Requested trace profile cannot be found</summary>
        UTC_E_TRACEPROFILE_NOT_FOUND     = 0x87C51006L,
        /// <summary>Trigger forwarder is already enabled</summary>
        UTC_E_FORWARDER_ALREADY_ENABLED  = 0x87C51007L,
        /// <summary>Trigger forwarder is already disabled</summary>
        UTC_E_FORWARDER_ALREADY_DISABLED = 0x87C51008L,
        /// <summary>Cannot parse EventLog XML: The entry is malformed</summary>
        UTC_E_EVENTLOG_ENTRY_MALFORMED   = 0x87C51009L,
        /// <summary><diagrules> node contains a schemaversion which is not compatible with this client</summary>
        UTC_E_DIAGRULES_SCHEMAVERSION_MISMATCH = 0x87C5100AL,
        /// <summary>RunScriptAction was forced to terminate a script</summary>
        UTC_E_SCRIPT_TERMINATED          = 0x87C5100BL,
        /// <summary>ToggleTraceWithCustomFilterAction contains an invalid custom filter</summary>
        UTC_E_INVALID_CUSTOM_FILTER      = 0x87C5100CL,
        /// <summary>The trace is not running</summary>
        UTC_E_TRACE_NOT_RUNNING          = 0x87C5100DL,
        /// <summary>A scenario failed to escalate: This scenario has escalated too recently</summary>
        UTC_E_REESCALATED_TOO_QUICKLY    = 0x87C5100EL,
        /// <summary>A scenario failed to escalate: This scenario is already running an escalation</summary>
        UTC_E_ESCALATION_ALREADY_RUNNING = 0x87C5100FL,
        /// <summary>Cannot start tracing: PerfTrack component is already tracing</summary>
        UTC_E_PERFTRACK_ALREADY_TRACING  = 0x87C51010L,
        /// <summary>A scenario failed to escalate: This scenario has reached max escalations for this escalation type</summary>
        UTC_E_REACHED_MAX_ESCALATIONS    = 0x87C51011L,
        /// <summary>Cannot update forwarder: The forwarder passed to the function is of a different type</summary>
        UTC_E_FORWARDER_PRODUCER_MISMATCH = 0x87C51012L,
        /// <summary>RunScriptAction failed intentionally to force this escalation to terminate</summary>
        UTC_E_INTENTIONAL_SCRIPT_FAILURE = 0x87C51013L,
        /// <summary>Failed to initialize SQM logger</summary>
        UTC_E_SQM_INIT_FAILED            = 0x87C51014L,
        /// <summary>Failed to initialize WER logger: This system does not support WER for UTC</summary>
        UTC_E_NO_WER_LOGGER_SUPPORTED    = 0x87C51015L,
        /// <summary>The TraceManager has attempted to take a tracing action without initializing tracers</summary>
        UTC_E_TRACERS_DONT_EXIST         = 0x87C51016L,
        /// <summary>WinRT initialization failed</summary>
        UTC_E_WINRT_INIT_FAILED          = 0x87C51017L,
        /// <summary><scenario> node contains a schemaversion that is not compatible with this client</summary>
        UTC_E_SCENARIODEF_SCHEMAVERSION_MISMATCH = 0x87C51018L,
        /// <summary>Scenario contains an invalid filter that can never be satisfied</summary>
        UTC_E_INVALID_FILTER             = 0x87C51019L,
        /// <summary>RunExeWithArgsAction was forced to terminate a running executable</summary>
        UTC_E_EXE_TERMINATED             = 0x87C5101AL,
        /// <summary>Escalation for scenario failed due to insufficient permissions</summary>
        UTC_E_ESCALATION_NOT_AUTHORIZED  = 0x87C5101BL,
        /// <summary>Setup for scenario failed due to insufficient permissions</summary>
        UTC_E_SETUP_NOT_AUTHORIZED       = 0x87C5101CL,
        /// <summary>A process launched by UTC failed with a non-zero exit code.</summary>
        UTC_E_CHILD_PROCESS_FAILED       = 0x87C5101DL,
        /// <summary>A RunExeWithArgs action contains an unauthorized command line.</summary>
        UTC_E_COMMAND_LINE_NOT_AUTHORIZED = 0x87C5101EL,
        /// <summary>UTC cannot load Scenario Editor XML. Convert the scenario file to a DiagTrack XML using the editor.</summary>
        UTC_E_CANNOT_LOAD_SCENARIO_EDITOR_XML = 0x87C5101FL,
        /// <summary>Escalation for scenario has timed out</summary>
        UTC_E_ESCALATION_TIMED_OUT       = 0x87C51020L,
        /// <summary>Setup for scenario has timed out</summary>
        UTC_E_SETUP_TIMED_OUT            = 0x87C51021L,
        /// <summary>The given trigger does not match the expected trigger type</summary>
        UTC_E_TRIGGER_MISMATCH           = 0x87C51022L,
        /// <summary>Requested trigger cannot be found</summary>
        UTC_E_TRIGGER_NOT_FOUND          = 0x87C51023L,
        /// <summary>SIF is not supported on the machine</summary>
        UTC_E_SIF_NOT_SUPPORTED          = 0x87C51024L,
        /// <summary>The delay action was terminated</summary>
        UTC_E_DELAY_TERMINATED           = 0x87C51025L,
        /// <summary>The device ticket was not obtained</summary>
        UTC_E_DEVICE_TICKET_ERROR        = 0x87C51026L,
        /// <summary>The trace profile needs more memory than is available for tracing</summary>
        UTC_E_TRACE_BUFFER_LIMIT_EXCEEDED = 0x87C51027L,
        /// <summary>The API was not completed successfully so the result is unavailable</summary>
        UTC_E_API_RESULT_UNAVAILABLE     = 0x87C51028L,
        /// <summary>The requested API encountered a timeout in the API manager</summary>
        UTC_E_RPC_TIMEOUT                = 0x87C51029L,
        /// <summary>The synchronous API encountered a wait failure</summary>
        UTC_E_RPC_WAIT_FAILED            = 0x87C5102AL,
        /// <summary>The UTC API is busy with another request</summary>
        UTC_E_API_BUSY                   = 0x87C5102BL,
        /// <summary>The running trace profile does not have a sufficient runtime to fulfill the escalation request</summary>
        UTC_E_TRACE_MIN_DURATION_REQUIREMENT_NOT_MET = 0x87C5102CL,
        /// <summary>The trace profile could not be started because it requires exclusivity and another higher priority trace is already running</summary>
        UTC_E_EXCLUSIVITY_NOT_AVAILABLE  = 0x87C5102DL,
        /// <summary>The file path is not approved for the GetFile escalation action</summary>
        UTC_E_GETFILE_FILE_PATH_NOT_APPROVED = 0x87C5102EL,
        /// <summary>The escalation working directory for the requested escalation could not be created because it already exists</summary>
        UTC_E_ESCALATION_DIRECTORY_ALREADY_EXISTS = 0x87C5102FL,
    }
}
