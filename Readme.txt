补丁说明：

  一、注意事项：
    1.本补丁仅适用于近乎_V4.1.0.1_免费安装版、近乎_V4.1.0.1_免费源码版、近乎_V4.1.0.1_专业版、近乎_V4.1.0.1_标准版；
    2.安装补丁时注意对补丁包内涉及到的文件和数据库进行备份，以免安装补丁时覆盖用户自己修改过的文件。

  二、操作步骤：
    1.近乎_V4.1.0.1_免费安装版用户：
        1)用补丁的web文件夹内的文件覆盖网站程序web文件夹下的文件；
          （注意如果 自己做过修改 注意合并，升级前一定要做好备份）
	2)执行SqlScripts文件夹下面的脚本
        3)重启IIS 。
    2.近乎_V4.1.0.1_免费源码版、近乎_V4.1.0.1_专业版、近乎_V4.1.0.1_标准版用户：
        1)用补丁的所有文件覆盖您解决方案中的文件；
          （注意如果 自己做过修改 注意合并，升级前一定要做好备份
	2)执行SqlScripts文件夹下面的脚本
        3)重新编译解决方案。

  三、附录-->功能变更：
	#8942：支持第三方QQ帐号注册，登陆
	#8953：用户社区，人人网帐号登录报错
	#8952：有些位置，输入<add key="IISVersion" value="7" />,提交报错
	#8084：评论回帖时，输入类似<add key="IISVersion" value="7" />的内容，提交显示处理中然后就没有任何反应了，实际是没有提交上的
	#8994：后台-运营-群发消息，发送邮件时，按角色选择“超级管理员”，但不只给管理员发了邮件
	#8904：通过咱们微博同步到新浪微博后，取得微博图片太小，几乎看不清晰。	
	#8943：日志，发布日志时，有的内容会报错“将截断字符串或二进制数据。语句已终止。”
	#8931：关注用户，未分组列表，将一个用户设置了分组后消失，但是刷新页面后又显示了（有缓存）
	#8950：上传头像，IE11下【上传】按钮单击没反应，必须双击
	#8954：用户社区，出现重复的群组动态
	#8955：群组-微博详细页，评论没有显示，点击【评论】链接也没有反应
	#8951：HTML编辑器，插入图片时，插入的换行位置不对
	#8906：可能感兴趣的人，已经关注的人也出现在了可能感兴趣的人里面
	#8882：我关注的人也关注了他页面,即使没有更多,也还显示[更多信息]条
	#7577：后台群发消息，发邮件时1）300字的限制，字数还少了；2）可以使用HTML编辑器编辑邮件内容；3）没有通过邮箱验证的用户，不要发给他邮件
	#8928：贴吧，第N页，帖子详细页面，返回键，都是返回贴吧的第一页
	#8929：头像，修改头像时，上传了图片后，点击【取消】按钮，原来的头像也不显示了
	#8948：用户社区上，点击他的日志报错
	#8047：HTML编辑器，IE11兼容性问题
	#8912：At朋友，当关注的人较多时，有些用户在At用户时搜索不出来	
	#8938：匿名用户点击我要评论按钮，建议给匿名用户一个提示，或者弹出登录框，现在点击我要评论按钮，没有任何反应
	#8914：我的首页，“最近访客”应该显示9个，现在只显示了8个，实际数量是多于9个的
	#8936：用户空间-编辑个人资料，邮箱修改为非邮箱格式，上面的邮箱也提示“不合法的帐号邮箱”
	#8910：编辑帖吧管理员BUG
	#8923：日志，日志频道首页，页面title显示不正确
	#8934:资讯，栏目层级三级以上时，显示有问题
	#8933:群组，点击群组标签云中的标签报错
	#8941：群组，邀请用户加入群组时，如果没有互相关注，现在提示的是“XXX不能被邀请”，提示信息需要更明确些
	@不到一部分用户问题；
        羽毛球派下的动态收不到问题；