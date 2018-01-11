use dlcdi_chat;

INSERT INTO [dbo].[groups]
	([group_name] ,[group_level])
VALUES
	('guest', 1), -- group_id = 1
	('user', 3), -- group_id = 2
	('moderator', 7), -- group_id = 3
	('admin', 9), -- group_id = 4
	('system', 99); -- group_id = 5

INSERT INTO users
([login], [gender], [email], [passwd], [registered], [birthday], [group_id])
VALUES
('system', 'M', 'system@local', 'ABCDEF0123456ABCDEF0123456', '2018-01-01 00:00:00', '1970-01-01 00:00:00', '5');