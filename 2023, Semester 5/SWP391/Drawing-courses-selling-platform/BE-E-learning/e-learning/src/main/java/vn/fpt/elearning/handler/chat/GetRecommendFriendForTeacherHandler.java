//package vn.hcmute.elearning.handler.chat;
//
//import lombok.RequiredArgsConstructor;
//import org.springframework.data.domain.Page;
//import org.springframework.stereotype.Component;
//import core.vn.fpt.elearning.PageResponseData;
//import core.vn.fpt.elearning.RequestHandler;
//import request.chat.dtos.vn.fpt.elearning.GetRecommendFriendFoTeacherRequest;
//import entity.vn.fpt.elearning.User;
//import mapper.vn.fpt.elearning.IUserMapper;
//import chat.model.vn.fpt.elearning.UserInfoChat;
//import interfaces.service.vn.fpt.elearning.IUserService;
//
//@Component
//@RequiredArgsConstructor
//public class GetRecommendFriendForTeacherHandler extends RequestHandler<GetRecommendFriendFoTeacherRequest, PageResponseData<UserInfoChat>> {
//    private final IUserService iUserService;
//    private final IUserMapper iUserMapper;
//
//    @Override
//    public PageResponseData<UserInfoChat> handle(GetRecommendFriendFoTeacherRequest request) {
//        Page<User> page = iUserService.getRecommendFiend(request.getUserId(), request.getPageable(), true);
//        return new PageResponseData<>(iUserMapper.toListUserInfoChat(page.getContent()), page);
//    }
//}
