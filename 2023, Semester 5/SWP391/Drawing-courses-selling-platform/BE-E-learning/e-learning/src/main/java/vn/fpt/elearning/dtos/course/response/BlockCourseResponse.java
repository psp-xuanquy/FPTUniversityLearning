package vn.fpt.elearning.dtos.course.response;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import vn.fpt.elearning.core.BaseResponseData;
import vn.fpt.elearning.model.course.CourseDto;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class BlockCourseResponse extends BaseResponseData {
    private CourseDto course;
}
