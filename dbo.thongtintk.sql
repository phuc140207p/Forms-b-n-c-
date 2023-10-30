CREATE TABLE [dbo].[thongtintk] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [Tên Đăng nhập] NVARCHAR (50) NULL,
    [Mật Khẩu]      NVARCHAR(50)    NULL,
    CONSTRAINT [PK_thongtintk] PRIMARY KEY CLUSTERED ([id] ASC)
);

